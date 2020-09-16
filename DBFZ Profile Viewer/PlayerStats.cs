using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFZTrainer
{
    public class PlayerStats
    {
        public int rankedMatches { get; set; }
        public int rankedWins { get; set; }
        public int casualMatches { get; set; }
        public int casualWins { get; set; }
        public int arenaMatches { get; set; }
        public int arenaWins { get; set; }
        public int ringMatches { get; set; }
        public int ringWins { get; set; }
        public int ringPartyMatches { get; set; }
        public int ringPartyWins { get; set; }
        public int followers { get; set; }
        public int zUnion { get; set; }

        public PlayerStats(
            int rankedMatches, int rankedWins, int casualMatches, int casualWins,
            int arenaMatches, int arenaWins, int ringMatches, int ringWins,
            int ringPartyMatches, int ringPartyWins, int followers, int zUnion
        )
        {
            this.rankedMatches = rankedMatches;
            this.rankedWins = rankedWins;
            this.casualMatches = casualMatches;
            this.casualWins = casualWins;
            this.arenaMatches = arenaMatches;
            this.arenaWins = arenaWins;
            this.ringMatches = ringMatches;
            this.ringWins = ringWins;
            this.ringPartyMatches = ringPartyMatches;
            this.ringPartyWins = ringPartyWins;
            this.followers = followers;
            this.zUnion = zUnion;
        }
    }
}
