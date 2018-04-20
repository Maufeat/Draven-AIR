namespace Draven.Structures.Platform.Matchmaking
{
    using System;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.QueueInfo")]
    class QueueInfo
    {
        [SerializedName("waitTime")]
        public Double WaitTime { get; set; }

        [SerializedName("queueId")]
        public Double QueueID { get; set; }

        [SerializedName("queueLength")]
        public Int32 QueueLength { get; set; }
    }
}
