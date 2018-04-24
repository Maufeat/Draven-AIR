namespace Draven.Structures.Platform.GameInvite
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.gameinvite.contract.Player")]
    public class InvitationPlayer
    {
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
        [SerializedName("summonerName")]
        public String SummonerName { get; set; }
    }

    [SerializedName("com.riotgames.platform.gameinvite.contract.Invitee")]
    public class Invitee : InvitationPlayer
    {
        [SerializedName("inviteeState")]
        public String InviteeState { get; set; }
    }

    [SerializedName("com.riotgames.platform.gameinvite.contract.Member")]
    public class Member : InvitationPlayer
    {
        [SerializedName("hasDelegatedInvitePower")]
        public Boolean HasDelegatedInvitePower { get; set; }
    }
}
