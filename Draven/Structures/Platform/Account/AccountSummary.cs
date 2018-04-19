using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.account.AccountSummary")]
    public class AccountSummary
    {
        [SerializedName("accountId")]
        public Double AccountId { get; set; }
        [SerializedName("username")]
        public String Username { get; set; }
        [SerializedName("summonerName")]
        public String SummonerName { get; set; }
        [SerializedName("summonerInternalName")]
        public String InternalName { get; set; }
        [SerializedName("admin")]
        public Boolean IsAdministrator { get; set; }
        [SerializedName("hasBetaAccess")]
        public Boolean HasBetaAccess { get; set; }
        [SerializedName("partnerMode")]
        public Boolean PartnerMode { get; set; }
        [SerializedName("groupCount")]
        public Int32 GroupCount { get; set; }
        [SerializedName("needsPasswordReset")]
        public Boolean NeedsPasswordReset { get; set; }
        [SerializedName("items")]
        public ArrayCollection Items{ get; set; }
    }
}
