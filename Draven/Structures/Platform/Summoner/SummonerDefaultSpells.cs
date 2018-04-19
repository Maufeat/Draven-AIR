﻿using RtmpSharp.IO;
using System;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.SummonerDefaultSpells")]
    public class SummonerDefaultSpells
    {
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
        [SerializedName("spellDefault1")]
        public object SummonerDefaultSpellsJson { get; set; }
        [SerializedName("spellDefault2")]
        public object SummonerDefaultSpellMap { get; set; }
    }
}
