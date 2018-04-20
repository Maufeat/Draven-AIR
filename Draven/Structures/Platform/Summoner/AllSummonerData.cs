namespace Draven.Structures.Platform.Summoner
{
    using System;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.AllSummonerData")]
    public class AllSummonerData
    {
        [SerializedName("summoner")]
        public Summoner Summoner { get; set; }
        [SerializedName("summonerLevelAndPoints")]
        public SummonerLevelAndPoints SummonerLevelAndPoints { get; set; }
        [SerializedName("summonerTalentsAndPoints")]
        public SummonerTalentsAndPoints SummonerTalentsAndPoints { get; set; }
        [SerializedName("summonerDefaultSpells")]
        public SummonerDefaultSpells SummonerDefaultSpells { get; set; }
        [SerializedName("summonerLevel")]
        public SummonerLevel SummonerLevel { get; set; }
        [SerializedName("spellBook")]
        public SpellBookDTO SpellBook { get; set; }
    }
}
