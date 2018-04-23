namespace Draven.Structures.Platform.Summoner
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.masterybook.MasteryBookPageDTO")]
    public class MasteryBookPageDTO
    {
        [SerializedName("current")]
        public Boolean Current { get; set; }
        [SerializedName("createDate")]
        public DateTime CreateDate { get; set; }
        [SerializedName("name")]
        public String Name { get; set; }
        [SerializedName("pageId")]
        public Int32 PageId { get; set; }
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
        [SerializedName("entries")]
        public ArrayCollection Entries { get; set; }
    }
}
