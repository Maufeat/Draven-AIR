using RtmpSharp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.serviceproxy.dispatch.LcdsServiceProxyResponse")]
    class LcdsServiceProxyResponse
    {
        [SerializedName("payload")]
        public dynamic Payload { get; set; }

        [SerializedName("status")]
        public String Status { get; set; }

        [SerializedName("messageId")]
        public String MessageId { get; set; }

        [SerializedName("MethodName")]
        public String MethodName { get; set; }

        [SerializedName("ServiceName")]
        public String ServiceName { get; set; }

    }
}
