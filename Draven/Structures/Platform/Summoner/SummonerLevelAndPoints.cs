﻿using RtmpSharp.IO;
using System;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.SummonerLevelAndPoints")]
    public class SummonerLevelAndPoints
    {
        [SerializedName("sumId")]
        public Double SummonerId { get; set; }
        [SerializedName("summonerLevel")]
        public Double SummonerLevel { get; set; }
        [SerializedName("expPoints")]
        public Double ExpPoints { get; set; }
        [SerializedName("infPoints")]
        public Double InfPoints { get; set; }
    }
}
