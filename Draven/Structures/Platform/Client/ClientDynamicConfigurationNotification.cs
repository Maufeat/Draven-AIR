using RtmpSharp.IO;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.client.dynamic.configuration.ClientDynamicConfigurationNotification")]
    public class ClientDynamicConfigurationNotification
    {
        [SerializedName("configs")]
        public Dictionary<string, object> Config { get; set; }

        [SerializedName("delta")]
        public Boolean Delta { get; set; }
    }
}
