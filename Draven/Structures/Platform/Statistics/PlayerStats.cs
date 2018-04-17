using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.PlayerStats")]
    class PlayerStats
    {
        [SerializedName("timeTrackedStats")]
        public ArrayCollection TimeTrackedStats { get; set; }
        [SerializedName("promoGamesPlayed")]
        public Int32 PromoGamesPlayed { get; set; }
        [SerializedName("promoGamesPlayedLastUpdate")]
        public object PromoGamesPlayedLastUpdate { get; set; }
        [SerializedName("lifetimeGamesPlayed")]
        public object LifetimeGamesPlayed { get; set; }
    }
}
