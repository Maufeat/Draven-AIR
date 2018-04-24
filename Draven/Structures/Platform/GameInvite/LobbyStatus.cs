namespace Draven.Structures.Platform.GameInvite
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.gameinvite.contract.LobbyStatus")]
    public class LobbyStatus : InvitationMetadata
    {
        [SerializedName("owner")]
        public InvitationPlayer Owner { get; set; }
        [SerializedName("invitees")]
        public ArrayCollection Invitees { get; set; }
        [SerializedName("members")]
        public ArrayCollection Members{ get; set; }
        [SerializedName("chatKey")]
        public string ChatKey { get; set; }
        [SerializedName("invitationId")]
        public string InvitationId { get; set; }
    }
}
