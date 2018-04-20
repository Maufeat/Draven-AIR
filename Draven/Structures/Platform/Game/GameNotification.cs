namespace Draven.Structures.Platform.Game
{
    using System;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.game.message.GameNotification")]
    public class GameNotification
    {
        [SerializedName("messageCode")]
        public string MessageCode { get; set; }
        [SerializedName("messageArgument")]
        public object MessageArgument { get; set; }
        [SerializedName("type")]
        public string Type { get; set; }
    }
}
