namespace Draven.Structures.Platform.Messaging
{
    using System;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.messaging.StoreAccountBalanceNotification")]
    class StoreAccountBalanceNotification
    {
        [SerializedName("rp")]
        public Double RP { get; set; }

        [SerializedName("ip")]
        public Double IP { get; set; }
    }
}
