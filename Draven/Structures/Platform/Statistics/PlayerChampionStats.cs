namespace Draven.Structures.Platform.Statistics
{
    using System;
    using Draven.Structures.Platform.Catalog;
    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    class PlayerChampionStats
    {
        [SerializedName("champion")]
        public ChampionDTO Champion { get; set; }
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
