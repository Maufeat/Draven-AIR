namespace Draven.Structures.Platform.Summoner
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.TalentGroup")]
    public class TalentGroup
    {
        [SerializedName("index")]
        public Int32 Index { get; set; }
        [SerializedName("talentRows")]
        public ArrayCollection TalentRows { get; set; }
        [SerializedName("name")]
        public String Name { get; set; }
        [SerializedName("tltGroupId")]
        public Int32 TltGroupId { get; set; }
        [SerializedName("version")]
        public Int32 Version { get; set; }
    }
}
