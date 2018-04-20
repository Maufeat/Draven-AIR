namespace Draven.Structures.Platform.Login.Matchmaking
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.SearchingForMatchNotification")]
    public class SearchingForMatchNotification
    {
        [SerializedName("ghostGameSummoners")]
        public ArrayCollection GhostGameSummoners { get; set; }

        [SerializedName("joinedQueues")]
        public ArrayCollection JoinedQueues { get; set; }

        [SerializedName("playerJoinFailures")]
        public ArrayCollection PlayerJoinFailures { get; set; }
    }
}
