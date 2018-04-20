namespace Draven.Structures.Platform.Login.Matchmaking
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.MatchingThrottleConfig")]
    public class MatchingThrottleConfig
    {
        [SerializedName("limit")]
        public Double Limit { get; set; }

        [SerializedName("matchingThrottleProperties")]
        public ArrayCollection MatchingThrottleProperties { get; set; }

        [SerializedName("cacheName")]
        public String CacheName { get; set; }
    }
}
