using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFZTrainer
{
    public class Match
    {
        public string playerName { get; set; }
        public long steamID { get; set; }
        public int result { get; set; }
        public int redPoint { get; set; }
        public int redMid { get; set; }
        public int redAnchor { get; set; }
        public int bluePoint { get; set; }
        public int blueMid { get; set; }
        public int blueAnchor { get; set; }

        public Match(string playerName, long steamID, int result, int redPoint, int redMid, int redAnchor, int bluePoint, int blueMid, int blueAnchor)
        {
            this.playerName = playerName;
            this.steamID = steamID;
            this.result = result;
            this.redPoint = redPoint;
            this.redMid = redMid;
            this.redAnchor = redAnchor;
            this.bluePoint = bluePoint;
            this.blueMid = blueMid;
            this.blueAnchor = blueAnchor;
        }

        public override string ToString()
        {
            return playerName + " - " + steamID + " - " + (result == 0 ? "WIN" : "LOSS") + " - " + redPoint + " " + redMid + " " + redAnchor + " " + bluePoint + " " + blueMid + " " + blueAnchor;
        }
    }
}
