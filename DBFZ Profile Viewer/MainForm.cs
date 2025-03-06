using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Memory;

namespace DBFZTrainer
{
    public partial class MainForm : Form
    {
        private Mem m = new Mem();
        private const string procName = "RED-Win64-Shipping";
        private long  profileAddress = 0x0;
        private const long basePointer = 0x1440E6FF8; //48 89 5C 24 08 48 89 74 24 10 57 48 83 EC ? 48 8D 99 F8 02 00 00
        private const long offset0 = 0x120;
        private const long offset1 = 0xC50;
        private const long playerNameOffset = 0x300;
        private const long steamIDOffset = 0x310;
        private readonly long[] playerStatsOffsets = new long[] {
            //RANKED      CASUAL        ARENA         RING
            0x330, 0x334, 0x354, 0x358, 0x364, 0x368, 0x36C, 0x370,
            //RING PARTY  FOLLOWERS Z UNION
            0x374, 0x378, 0xE88, 0xE98
        };
        private int[] stats = {
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0
        };
        private List<long> playersFound = new List<long>();
        private const int matchHistoryMaxCount = 10;
        private const long matchHistoryOffset = 0xC08;
        private const long matchMemSize = 0x40;
        private const long matchPlayerNameOffset = 0x0; //To make it easier to read and update
        private const long matchSteamIDOffset = 0x10;
        private readonly long[] matchCharactersOffsets = new long[] { 0x2E, 0x2F, 0x30, 0x31, 0x32, 0x33 };
        private const long matchResultOffset = 0x34;
        private long lastSteamID = 0x0;
        private string lastPlayerName = "";
        private bool procOpen = false;
        private int pID = 0;
        private PlayerInfo playerInfo;
        private PlayerInfoForm playerInfoForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!background_find_game_process.IsBusy) background_find_game_process.RunWorkerAsync();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void background_find_game_process_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                pID = m.GetProcIdFromName(procName);
                lbl_pid.Invoke((MethodInvoker)delegate
                {
                    lbl_pid.Text = pID.ToString();
                });
                if (pID > 0)
                {
                    procOpen = m.OpenProcess(pID);
                    lbl_status.Invoke((MethodInvoker)delegate
                    {
                        lbl_status.Text = "RUNNING";
                        lbl_status.ForeColor = Color.Green;
                    });
                }
                else
                {
                    profileAddress = 0x0;
                    lastPlayerName = "";
                    lastSteamID = 0;
                    playersFound.Clear();

                    for (int i = 0; i < stats.Length; i++)
                    {
                        stats[i] = 0;
                    }

                    lbl_status.Invoke((MethodInvoker)delegate
                    {
                        lbl_status.Text = "NOT RUNNING";
                        lbl_status.ForeColor = Color.Red;
                    });

                    btn_open_profile.Invoke((MethodInvoker)delegate
                    {
                        btn_open_profile.Enabled = false;
                    });

                    btn_info.Invoke((MethodInvoker)delegate
                    {
                        btn_info.Enabled = false;
                    });

                    txt_playername.Invoke((MethodInvoker)delegate
                    {
                        txt_playername.Text = "";
                    });

                    txt_steamid.Invoke((MethodInvoker)delegate
                    {
                        txt_steamid.Text = "";
                    });

                    if (playerInfoForm != null) Invoke((MethodInvoker)delegate
                    {
                        playerInfoForm.Close();
                    });
                }
                if (procOpen)
                {
                    if (profileAddress == 0x0)
                    {
                        long address = 0;
                        long layer0 = 0;
                        long layer1 = 0;
                        long testSteamID = 0;
                        //Find true profile address
                        //It keeps pointing to different addresses and to find the right one we need to try to parse it to a long and see if it is a *valid* steam id
                        try
                        {
                            layer0 = m.ReadLong(Convert.ToString(basePointer, 16));
                            layer1 = m.ReadLong(Convert.ToString(layer0 + offset0, 16));
                            address = m.ReadLong(Convert.ToString(layer1 + offset1, 16));
                            testSteamID = m.ReadLong(Convert.ToString(address + steamIDOffset, 16));
                        } catch
                        {
                            
                        }
                        if (testSteamID > 0x110000000000000 && testSteamID < 0x120000000000000) //Check if Steam ID is valid
                        {
                            profileAddress = address;
                            btn_open_profile.Invoke((MethodInvoker)delegate
                            {
                                btn_open_profile.Enabled = true;
                            });
                            btn_info.Invoke((MethodInvoker)delegate
                            {
                                btn_info.Enabled = true;
                            });
                        }
                    }
                    else
                    {
                        //Reliable memory access because the pointer keeps changing between addresses (related to UI)
                        lastPlayerName = m.ReadString(Convert.ToString(profileAddress + playerNameOffset, 16), "", 16);
                        lastSteamID = m.ReadLong(Convert.ToString(profileAddress + steamIDOffset, 16));

                        List<Match> matches = new List<Match>();
                        string playerName;
                        long steamID;
                        int redPoint, redMid, redAnchor, bluePoint, blueMid, blueAnchor, result;

                        for (int i = 0; i < matchHistoryMaxCount; i++)
                        {
                            //IDK WHY IT DOESN'T READ IT NORMALLY, MAYBE BECAUSE THE ID STARTS WITH 0x00 INSTEAD OF ENDING WITH IT
                            string steamIDText = m.ReadString(Convert.ToString(profileAddress + matchHistoryOffset + matchSteamIDOffset + 1 + (matchMemSize * i), 16), "", 15, false);
                            //If there are no players/matches this may return an invalid long
                            try
                            {
                                steamID = Convert.ToInt64(steamIDText, 16);
                            }
                            catch
                            {
                                steamID = 0;
                            }
                            if (steamID > 0x110000000000000 && steamID < 0x120000000000000)
                            {
                                playerName = m.ReadString(Convert.ToString(profileAddress + matchHistoryOffset + matchPlayerNameOffset + (matchMemSize * i), 16), "", 16);
                                redPoint = m.ReadByte(Convert.ToString(profileAddress + matchHistoryOffset + matchCharactersOffsets[0] + (matchMemSize * i), 16));
                                redMid = m.ReadByte(Convert.ToString(profileAddress + matchHistoryOffset + matchCharactersOffsets[1] + (matchMemSize * i), 16));
                                redAnchor = m.ReadByte(Convert.ToString(profileAddress + matchHistoryOffset + matchCharactersOffsets[2] + (matchMemSize * i), 16));
                                bluePoint = m.ReadByte(Convert.ToString(profileAddress + matchHistoryOffset + matchCharactersOffsets[3] + (matchMemSize * i), 16));
                                blueMid = m.ReadByte(Convert.ToString(profileAddress + matchHistoryOffset + matchCharactersOffsets[4] + (matchMemSize * i), 16));
                                blueAnchor = m.ReadByte(Convert.ToString(profileAddress + matchHistoryOffset + matchCharactersOffsets[5] + (matchMemSize * i), 16));
                                result = m.ReadByte(Convert.ToString(profileAddress + matchHistoryOffset + matchResultOffset + (matchMemSize * i), 16));
                                matches.Add(new Match(playerName, steamID, result, redPoint, redMid, redAnchor, bluePoint, blueMid, blueAnchor));
                            } else
                            {
                                i = matchHistoryMaxCount;
                            }
                        }

                        if (lastSteamID <= 0x110000000000000 || lastSteamID >= 0x120000000000000)
                        {
                            profileAddress = 0x0;
                        }
                        else
                        {
                            txt_steamid.Invoke((MethodInvoker)delegate
                            {
                                txt_steamid.Text = Convert.ToString(lastSteamID, 10);
                            });

                            txt_playername.Invoke((MethodInvoker)delegate
                            {
                                txt_playername.Text = lastPlayerName;
                            });
                            for (int i = 0; i < stats.Length && i < playerStatsOffsets.Length; i++) //12 STATS
                            {
                                stats[i] = m.ReadInt(Convert.ToString(profileAddress + playerStatsOffsets[i], 16));
                            }

                            PlayerStats playerStats = new PlayerStats(
                                stats[0], stats[1], stats[2], stats[3],
                                stats[4], stats[5], stats[6], stats[7],
                                stats[8], stats[9], stats[10], stats[11]
                            );

                            playerInfo = new PlayerInfo(lastPlayerName, lastSteamID, playerStats, matches);

                            if (playerInfoForm != null) playerInfoForm.UpdatePlayerInfo(playerInfo);
                        }
                    }
                }
            }
        }

        private void btn_open_profile_Click(object sender, EventArgs e)
        {
            if (lastSteamID > 0x110000000000000 && lastSteamID < 0x120000000000000)
            {
                Process.Start("http://steamcommunity.com/profiles/" + txt_steamid.Text);
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            if (lastSteamID > 0x110000000000000 && lastSteamID < 0x120000000000000)
            {
                playerInfoForm = new PlayerInfoForm(playerInfo, this);
                playerInfoForm.Show();
            }
        }

    }
}
