namespace Draven.Structures.Platform.Client
{
    using System;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.client.dynamic.configuration.ClientDynamicConfigurationNotification")]
    public class ClientDynamicConfigurationNotification
    {
        [SerializedName("delta")]
        public Boolean Delta { get; set; }

        [SerializedName("configs")]
        public String Config { get; set; }
    }
}
