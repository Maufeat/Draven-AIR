namespace Draven.Structures.Platform.Summoner
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.SummonerCatalog")]
    public class SummonerCatalog
    {
        [SerializedName("talentTree")]
        public ArrayCollection TalentTree { get; set; }
        [SerializedName("spellBookConfig")]
        public ArrayCollection SpellBookConfig { get; set; }
    }
}
