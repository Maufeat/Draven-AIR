namespace Draven.Structures.Platform.Summoner
{
    using System;

    using RtmpSharp.IO;

    public class BaseSummoner
    {
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
        [SerializedName("acctId")]
        public Double AcctId { get; set; }
        [SerializedName("name")]
        public String Name { get; set; }
        [SerializedName("internalName")]
        public String InternalName { get; set; }
        [SerializedName("profileIconId")]
        public Int32 ProfileIconId { get; set; }
    }
}
