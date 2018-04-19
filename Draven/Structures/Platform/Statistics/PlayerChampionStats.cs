using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    class PlayerChampionStats
    {
        [SerializedName("champion")]
        public Int32 Champion { get; set; }
        [SerializedName("owned")]
        public Boolean Owned { get; set; }
        [SerializedName("totalGamesPlayed")]
        public Int32 TotalGamesPlayed { get; set; }
        [SerializedName("wins")]
        public Int32 Wins { get; set; }
        [SerializedName("stats")]
        public ArrayCollection Stats { get; set; }
    }
}
