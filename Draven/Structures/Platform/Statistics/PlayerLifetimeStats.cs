namespace Draven.Structures.Platform.Statistics
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.PlayerLifetimeStats")]
    class PlayerLifetimeStats
    {
        [SerializedName("userId")]
        public Int64 UserId { get; set; }
        [SerializedName("gameStatistics")]
        public ArrayCollection GameStatistics { get; set; }
        [SerializedName("playerStatSummaries")]
        public PlayerStatSummaries PlayerStatSummaries { get; set; }
        [SerializedName("previousFirstWinOfDay")]
        public DateTime PreviousFirstWinOfDay { get; set; }
        [SerializedName("playerStats")]
        public PlayerStats PlayerStats { get; set; }
    }
}
