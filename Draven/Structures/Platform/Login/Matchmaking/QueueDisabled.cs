namespace Draven.Structures.Platform.Login.Matchmaking
{
    using System;

    using Draven.Structures.Platform.Summoner;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.QueueDisabled")]
    public class QueueDisabled
    {
        [SerializedName("queueId")]
        public Double QueueId { get; set; }

        [SerializedName("message")]
        public string Message { get; set; }

        [SerializedName("summoner")]
        public Summoner Summoner { get; set; }
    }
}
