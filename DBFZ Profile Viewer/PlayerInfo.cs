using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFZTrainer
{
    public class PlayerInfo
    {
        public string playerName { get; set; }
        public long steamID { get; set; }

        public PlayerStats playerStats { get; set; }

        public List<Match> matches { get; set; }

        public PlayerInfo(string playerName, long steamID, PlayerStats playerStats, List<Match> matches)
        {
            this.playerName = playerName;
            this.steamID = steamID;
            this.playerStats = playerStats;
            this.matches = matches;
        }

    }
}
