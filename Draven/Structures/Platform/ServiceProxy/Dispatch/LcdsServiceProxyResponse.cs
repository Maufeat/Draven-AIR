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

        [SerializedName("methodName")]
        public String MethodName { get; set; }

        [SerializedName("serviceName")]
        public String ServiceName { get; set; }

        [SerializedName("compressedPayload")]
        public Boolean CompressedPayload { get; set; }

        [SerializedName("decompressedPayload")]
        public dynamic DecompressedPayload { get; set; }

    }
}
