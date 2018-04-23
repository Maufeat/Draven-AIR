namespace Draven.Structures.Platform.Statistics
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.PlayerStats")]
    class PlayerStats
    {
        [SerializedName("promoGamesPlayed")]
        public Int32 PromoGamesPlayed { get; set; }
        [SerializedName("promoGamesPlayedLastUpdated")]
        public object PromoGamesPlayedLastUpdate { get; set; }
    }
}
