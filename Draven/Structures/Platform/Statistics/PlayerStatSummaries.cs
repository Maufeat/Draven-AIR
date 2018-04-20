namespace Draven.Structures.Platform.Statistics
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.PlayerStatSummaries")]
    public class PlayerStatSummaries
    {
        [SerializedName("playerStatSummarySet")]
        public ArrayCollection SummaryList { get; set; }
        [SerializedName("userId")]
        public Int32 UserID { get; set; }
    }
}
