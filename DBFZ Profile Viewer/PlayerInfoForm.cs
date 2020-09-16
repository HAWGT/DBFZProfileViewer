using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFZTrainer
{
    public partial class PlayerInfoForm : Form
    {
        static bool formOpen = false;

        private PlayerInfo playerInfo = new PlayerInfo("", 0, new PlayerStats(
            0, 0, 0, 0,
            0, 0, 0, 0,
            0, 0, 0, 0
        ), new List<Match>());
        public MainForm mainForm;

        public PlayerInfoForm(PlayerInfo playerInfo, MainForm mainForm)
        {
            InitializeComponent();
            UpdatePlayerInfo(playerInfo);
            this.mainForm = mainForm;
        }

        private void PlayerInfoForm_Load(object sender, EventArgs e)
        {
            if (!formOpen)
            {
                formOpen = true;
            }
            else
            {
                Dispose();
            }
        }

        private void PlayerInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formOpen) formOpen = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdatePlayerInfo(PlayerInfo playerInfo)
        {
            if (this.playerInfo.steamID == playerInfo.steamID) return;
            if (IsHandleCreated)
            {
                this.playerInfo = playerInfo;
                try
                {
                    Invoke((MethodInvoker)delegate
                    {
                        Text = "Player Info for " + playerInfo.playerName;
                    });
                    if (rct_playerinfo != null) rct_playerinfo.Invoke((MethodInvoker)delegate
                    {
                        rct_playerinfo.Text = "Name: " + playerInfo.playerName + "\t" + "SteamID: " + playerInfo.steamID.ToString() + "\n"
                        + "Followers: " + playerInfo.playerStats.followers.ToString() + "\t" + "Z Union: " + playerInfo.playerStats.zUnion.ToString() + "\n"
                        + "Ranked Matches: " + playerInfo.playerStats.rankedMatches.ToString() + "\t" + "Ranked Wins: " + playerInfo.playerStats.rankedWins.ToString() + "\n"
                        + "Casual Matches: " + playerInfo.playerStats.casualMatches.ToString() + "\t" + "Casual Wins: " + playerInfo.playerStats.casualWins.ToString() + "\n"
                        + "Arena Matches: " + playerInfo.playerStats.arenaMatches.ToString() + "\t" + "Arena Wins: " + playerInfo.playerStats.arenaWins.ToString() + "\n"
                        + "Ring Matches: " + playerInfo.playerStats.ringMatches.ToString() + "\t" + "Ring Wins: " + playerInfo.playerStats.ringWins.ToString() + "\n"
                        + "Ring Party Matches: " + playerInfo.playerStats.ringPartyMatches.ToString() + "\t" + "Ring Party Wins: " + playerInfo.playerStats.ringPartyWins.ToString() + "\n";
                    });
                    //Match 0
                    if (btn_visit0 != null) btn_visit0.Invoke((MethodInvoker)delegate
                    {
                        btn_visit0.Visible = false;
                        btn_visit0.Enabled = false;
                    });
                    if (txt_match0 != null) txt_match0.Invoke((MethodInvoker)delegate
                    {
                        txt_match0.Visible = false;
                        txt_match0.Text = "";
                    });
                    if (playerInfo.matches.Count > 0)
                    {
                        if (btn_visit0 != null) btn_visit0.Invoke((MethodInvoker)delegate
                        {
                            if (btn_visit0 != null) btn_visit0.Visible = (playerInfo.matches.Count > 0);
                            if (btn_visit0 != null) btn_visit0.Enabled = (playerInfo.matches.Count > 0);
                        });
                        if (txt_match0 != null) txt_match0.Invoke((MethodInvoker)delegate
                        {
                            if (txt_match0 != null) txt_match0.Visible = (playerInfo.matches.Count > 0);
                            if (txt_match0 != null) txt_match0.Text = playerInfo.matches[0].ToString();
                        });
                    }
                    //Match 1
                    if (btn_visit1 != null) btn_visit1.Invoke((MethodInvoker)delegate
                    {
                        btn_visit1.Visible = false;
                        btn_visit1.Enabled = false;
                    });
                    if (txt_match1 != null) txt_match1.Invoke((MethodInvoker)delegate
                    {
                        txt_match1.Visible = false;
                        txt_match1.Text = "";
                    });
                    if (playerInfo.matches.Count > 1)
                    {
                        if (btn_visit1 != null) btn_visit1.Invoke((MethodInvoker)delegate
                        {
                            if (btn_visit1 != null) btn_visit1.Visible = (playerInfo.matches.Count > 1);
                            if (btn_visit1 != null) btn_visit1.Enabled = (playerInfo.matches.Count > 1);
                        });
                        if (txt_match1 != null) txt_match1.Invoke((MethodInvoker)delegate
                        {
                            if (txt_match1 != null) txt_match1.Visible = (playerInfo.matches.Count > 1);
                            if (txt_match1 != null) txt_match1.Text = playerInfo.matches[1].ToString();
                        });
                    }
                    //Match 2
                    if (btn_visit2 != null) btn_visit2.Invoke((MethodInvoker)delegate
                    {
                        btn_visit2.Visible = false;
                        btn_visit2.Enabled = false;
                    });
                    if (txt_match2 != null) txt_match2.Invoke((MethodInvoker)delegate
                    {
                        txt_match2.Visible = false;
                        txt_match2.Text = "";
                    });
                    if (playerInfo.matches.Count > 2)
                    {
                        if (btn_visit2 != null) btn_visit2.Invoke((MethodInvoker)delegate
                        {
                            if (btn_visit2 != null) btn_visit2.Visible = (playerInfo.matches.Count > 2);
                            if (btn_visit2 != null) btn_visit2.Enabled = (playerInfo.matches.Count > 2);
                        });
                        if (txt_match2 != null) txt_match2.Invoke((MethodInvoker)delegate
                        {
                            if (txt_match2 != null) txt_match2.Visible = (playerInfo.matches.Count > 2);
                            if (txt_match2 != null) txt_match2.Text = playerInfo.matches[2].ToString();
                        });
                    }
                    //Match 3
                    if (btn_visit3 != null) btn_visit3.Invoke((MethodInvoker)delegate
                    {
                        btn_visit3.Visible = false;
                        btn_visit3.Enabled = false;
                    });
                    if (txt_match3 != null) txt_match3.Invoke((MethodInvoker)delegate
                    {
                        txt_match3.Visible = false;
                        txt_match3.Text = "";
                    });
                    if (playerInfo.matches.Count > 3)
                    {
                        if (btn_visit3 != null) btn_visit3.Invoke((MethodInvoker)delegate
                        {
                            if (btn_visit3 != null) btn_visit3.Visible = (playerInfo.matches.Count > 3);
                            if (btn_visit3 != null) btn_visit3.Enabled = (playerInfo.matches.Count > 3);
                        });
                        if (txt_match3 != null) txt_match3.Invoke((MethodInvoker)delegate
                        {
                            if (txt_match3 != null) txt_match3.Visible = (playerInfo.matches.Count > 3);
                            if (txt_match3 != null) txt_match3.Text = playerInfo.matches[3].ToString();
                        });
                    }
                    //Match 4
                    if (btn_visit4 != null) btn_visit4.Invoke((MethodInvoker)delegate
                    {
                        btn_visit4.Visible = false;
                        btn_visit4.Enabled = false;
                    });
                    if (txt_match4 != null) txt_match4.Invoke((MethodInvoker)delegate
                    {
                        txt_match4.Visible = false;
                        txt_match4.Text = "";
                    });
                    if (playerInfo.matches.Count > 4)
                    {
                        if (btn_visit4 != null) btn_visit4.Invoke((MethodInvoker)delegate
                        {
                            if (btn_visit4 != null) btn_visit4.Visible = (playerInfo.matches.Count > 4);
                            if (btn_visit4 != null) btn_visit4.Enabled = (playerInfo.matches.Count > 4);
                        });
                        if (txt_match4 != null) txt_match4.Invoke((MethodInvoker)delegate
                        {
                            if (txt_match4 != null) txt_match4.Visible = (playerInfo.matches.Count > 4);
                            if (txt_match4 != null) txt_match4.Text = playerInfo.matches[4].ToString();
                        });
                    }
                    //Match 5
                    if (btn_visit5 != null) btn_visit5.Invoke((MethodInvoker)delegate
                    {
                        btn_visit5.Visible = false;
                        btn_visit5.Enabled = false;
                    });
                    if (txt_match5 != null) txt_match5.Invoke((MethodInvoker)delegate
                    {
                        txt_match5.Visible = false;
                        txt_match5.Text = "";
                    });
                    if (playerInfo.matches.Count > 5)
                    {
                        if (btn_visit5 != null) btn_visit5.Invoke((MethodInvoker)delegate
                        {
                            if (btn_visit5 != null) btn_visit5.Visible = (playerInfo.matches.Count > 5);
                            if (btn_visit5 != null) btn_visit5.Enabled = (playerInfo.matches.Count > 5);
                        });
                        if (txt_match5 != null) txt_match5.Invoke((MethodInvoker)delegate
                        {
                            if (txt_match5 != null) txt_match5.Visible = (playerInfo.matches.Count > 5);
                            if (txt_match5 != null) txt_match5.Text = playerInfo.matches[5].ToString();
                        });
                    }
                    //Match 6
                    if (btn_visit6 != null) btn_visit6.Invoke((MethodInvoker)delegate
                    {
                        btn_visit6.Visible = false;
                        btn_visit6.Enabled = false;
                    });
                    if (txt_match6 != null) txt_match6.Invoke((MethodInvoker)delegate
                    {
                        txt_match6.Visible = false;
                        txt_match6.Text = "";
                    });
                    if (playerInfo.matches.Count > 6)
                    {
                        if (btn_visit6 != null) btn_visit6.Invoke((MethodInvoker)delegate
                        {
                            if (btn_visit6 != null) btn_visit6.Visible = (playerInfo.matches.Count > 6);
                            if (btn_visit6 != null) btn_visit6.Enabled = (playerInfo.matches.Count > 6);
                        });
                        if (txt_match6 != null) txt_match6.Invoke((MethodInvoker)delegate
                        {
                            if (txt_match6 != null) txt_match6.Visible = (playerInfo.matches.Count > 6);
                            if (txt_match6 != null) txt_match6.Text = playerInfo.matches[6].ToString();
                        });
                    }
                    //Match 7
                    if (btn_visit7 != null) btn_visit7.Invoke((MethodInvoker)delegate
                    {
                        btn_visit7.Visible = false;
                        btn_visit7.Enabled = false;
                    });
                    if (txt_match7 != null) txt_match7.Invoke((MethodInvoker)delegate
                    {
                        txt_match7.Visible = false;
                        txt_match7.Text = "";
                    });
                    if (playerInfo.matches.Count > 7)
                    {
                        if (btn_visit7 != null) btn_visit7.Invoke((MethodInvoker)delegate
                        {
                            if (btn_visit7 != null) btn_visit7.Visible = (playerInfo.matches.Count > 7);
                            if (btn_visit7 != null) btn_visit7.Enabled = (playerInfo.matches.Count > 7);
                        });
                        if (txt_match7 != null) txt_match7.Invoke((MethodInvoker)delegate
                        {
                            if (txt_match7 != null) txt_match7.Visible = (playerInfo.matches.Count > 7);
                            if (txt_match7 != null) txt_match7.Text = playerInfo.matches[7].ToString();
                        });
                    }
                    //Match 8
                    if (btn_visit8 != null) btn_visit8.Invoke((MethodInvoker)delegate
                    {
                        btn_visit8.Visible = false;
                        btn_visit8.Enabled = false;
                    });
                    if (txt_match8 != null) txt_match8.Invoke((MethodInvoker)delegate
                    {
                        txt_match8.Visible = false;
                        txt_match8.Text = "";
                    });
                    if (playerInfo.matches.Count > 8)
                    {
                        if (btn_visit8 != null) btn_visit8.Invoke((MethodInvoker)delegate
                        {
                            if (btn_visit8 != null) btn_visit8.Visible = (playerInfo.matches.Count > 8);
                            if (btn_visit8 != null) btn_visit8.Enabled = (playerInfo.matches.Count > 8);
                        });
                        if (txt_match8 != null) txt_match8.Invoke((MethodInvoker)delegate
                        {
                            if (txt_match8 != null) txt_match8.Visible = (playerInfo.matches.Count > 8);
                            if (txt_match8 != null) txt_match8.Text = playerInfo.matches[8].ToString();
                        });
                    }
                    //Match 9
                    if (btn_visit9 != null) btn_visit9.Invoke((MethodInvoker)delegate
                    {
                        btn_visit9.Visible = false;
                        btn_visit9.Enabled = false;
                    });
                    if (txt_match9 != null) txt_match9.Invoke((MethodInvoker)delegate
                    {
                        txt_match9.Visible = false;
                        txt_match9.Text = "";
                    });
                    if (playerInfo.matches.Count > 9)
                    {
                        if (btn_visit9 != null) btn_visit9.Invoke((MethodInvoker)delegate
                        {
                            if (btn_visit9 != null) btn_visit9.Visible = (playerInfo.matches.Count > 9);
                            if (btn_visit9 != null) btn_visit9.Enabled = (playerInfo.matches.Count > 9);
                        });
                        if (txt_match9 != null) txt_match9.Invoke((MethodInvoker)delegate
                        {
                            if (txt_match9 != null) txt_match9.Visible = (playerInfo.matches.Count > 9);
                            if (txt_match9 != null) txt_match9.Text = playerInfo.matches[9].ToString();
                        });
                    }
                } catch
                {

                }
            }
        }

        private void btn_visit0_Click(object sender, EventArgs e)
        {
            if (playerInfo == null) return;
            if(playerInfo.matches.Count > 0)
            {
                Process.Start("http://steamcommunity.com/profiles/" + playerInfo.matches[0].steamID.ToString());
            }
        }

        private void btn_visit1_Click(object sender, EventArgs e)
        {
            if (playerInfo == null) return;
            if (playerInfo.matches.Count > 1)
            {
                Process.Start("http://steamcommunity.com/profiles/" + playerInfo.matches[1].steamID.ToString());
            }
        }

        private void btn_visit2_Click(object sender, EventArgs e)
        {
            if (playerInfo == null) return;
            if (playerInfo.matches.Count > 2)
            {
                Process.Start("http://steamcommunity.com/profiles/" + playerInfo.matches[2].steamID.ToString());
            }
        }

        private void btn_visit3_Click(object sender, EventArgs e)
        {
            if (playerInfo == null) return;
            if (playerInfo.matches.Count > 3)
            {
                Process.Start("http://steamcommunity.com/profiles/" + playerInfo.matches[3].steamID.ToString());
            }
        }

        private void btn_visit4_Click(object sender, EventArgs e)
        {
            if (playerInfo == null) return;
            if (playerInfo.matches.Count > 4)
            {
                Process.Start("http://steamcommunity.com/profiles/" + playerInfo.matches[4].steamID.ToString());
            }
        }

        private void btn_visit5_Click(object sender, EventArgs e)
        {
            if (playerInfo == null) return;
            if (playerInfo.matches.Count > 5)
            {
                Process.Start("http://steamcommunity.com/profiles/" + playerInfo.matches[5].steamID.ToString());
            }
        }

        private void btn_visit6_Click(object sender, EventArgs e)
        {
            if (playerInfo == null) return;
            if (playerInfo.matches.Count > 6)
            {
                Process.Start("http://steamcommunity.com/profiles/" + playerInfo.matches[6].steamID.ToString());
            }
        }

        private void btn_visit7_Click(object sender, EventArgs e)
        {
            if (playerInfo == null) return;
            if (playerInfo.matches.Count > 7)
            {
                Process.Start("http://steamcommunity.com/profiles/" + playerInfo.matches[7].steamID.ToString());
            }
        }

        private void btn_visit8_Click(object sender, EventArgs e)
        {
            if (playerInfo == null) return;
            if (playerInfo.matches.Count > 8)
            {
                Process.Start("http://steamcommunity.com/profiles/" + playerInfo.matches[8].steamID.ToString());
            }
        }

        private void btn_visit9_Click(object sender, EventArgs e)
        {
            if (playerInfo == null) return;
            if (playerInfo.matches.Count > 9)
            {
                Process.Start("http://steamcommunity.com/profiles/" + playerInfo.matches[9].steamID.ToString());
            }
        }
    }
}
