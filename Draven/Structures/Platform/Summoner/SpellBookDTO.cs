namespace Draven.Structures.Platform.Summoner
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.spellbook.SpellBookDTO")]
    public class SpellBookDTO
    {
        [SerializedName("sortByPageId")]
        public object SortByPageId { get; set; }
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
        [SerializedName("dateString")]
        public String DateString { get; set; }
        [SerializedName("bookPages")]
        public ArrayCollection BookPages { get; set; }
    }
}
