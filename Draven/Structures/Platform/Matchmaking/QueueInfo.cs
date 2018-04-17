using RtmpSharp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
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
