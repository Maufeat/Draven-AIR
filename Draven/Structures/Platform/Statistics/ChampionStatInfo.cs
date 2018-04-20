namespace Draven.Structures.Platform.Statistics
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.ChampionStatInfo")]
    class ChampionStatInfo
    {
        [SerializedName("championId")]
        public Int32 ChampionId { get; set; }
        [SerializedName("stats")]
        public ArrayCollection Stats { get; set; }
        [SerializedName("totalGammesPlayed")]
        public Int32 TotalGammesPlayed { get; set; }
    }
}
