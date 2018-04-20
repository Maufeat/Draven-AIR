namespace Draven.Structures.Platform.ServiceProxy.Dispatch
{
    using System;

    using RtmpSharp.IO;

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
