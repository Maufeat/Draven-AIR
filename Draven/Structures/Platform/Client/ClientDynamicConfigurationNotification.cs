using RtmpSharp.IO;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
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
