using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.icon.SummonerIconInventoryDTO")]
    public class SummonerIconInventoryDTO
    {
        [SerializedName("summonerIcons")]
        public ArrayCollection SummonerIcons { get; set; }
        [SerializedName("dateString")]
        public String DateString { get; set; }
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
        [SerializedName("summonerIconJson ")]
        public object SummonerIconJson { get; set; }

    }
}
