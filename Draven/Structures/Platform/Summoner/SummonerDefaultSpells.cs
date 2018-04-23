namespace Draven.Structures.Platform.Summoner
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.SummonerDefaultSpells")]
    public class SummonerDefaultSpells
    {
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
        [SerializedName("spellDefault1")]
        public ArrayCollection SpellDefault1 { get; set; }
        [SerializedName("spellDefault2")]
        public ArrayCollection SpellDefault2 { get; set; }
    }
}
