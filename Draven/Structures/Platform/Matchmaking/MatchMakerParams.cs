namespace Draven.Structures.Platform.Matchmaking
{
    using System;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.MatchMakerParams")]
    class MatchMakerParams
    {
        [SerializedName("lastMaestroMessage")]
        public object LastMaestroMessage { get; set; }

        [SerializedName("teamId")]
        public object TeamId { get; set; }

        [SerializedName("languages")]
        public object Languages { get; set; }

        [SerializedName("botDifficulty")]
        public String BotDifficulty { get; set; }

        [SerializedName("team")]
        public object Team { get; set; }

        [SerializedName("queueIds")]
        public Int32[] QueueIds { get; set; }

        [SerializedName("invitationId")]
        public object InvitationId { get; set; }
    }
}
