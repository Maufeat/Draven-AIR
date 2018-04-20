namespace Draven.Structures.Platform.Login
{
    using System;

    using Draven.Structures.Platform.Account;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.login.Session")]
    public class Session
    {
        [SerializedName("token")]
        public String Token { get; set; }

        [SerializedName("password")]
        public String Password { get; set; }

        [SerializedName("accountSummary")]
        public AccountSummary Summary { get; set; }
    }
}
