﻿using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
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
