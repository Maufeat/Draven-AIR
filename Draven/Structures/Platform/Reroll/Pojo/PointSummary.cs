using RtmpSharp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.reroll.pojo.PointSummary")]
    class PointSummary
    {
        [SerializedName("pointsToNextRoll")]
        public Int32 PointsToNextRoll { get; set; }

        [SerializedName("maxRolls")]
        public Int32 MaxRolls { get; set; }

        [SerializedName("numberOfRolls")]
        public Int32 NumberOfRolls { get; set; }

        [SerializedName("pointsCostToRoll")]
        public Int32 PointsCostToRoll { get; set; }

        [SerializedName("currentPoints")]
        public Int32 CurrentPoints { get; set; }
    }
}
