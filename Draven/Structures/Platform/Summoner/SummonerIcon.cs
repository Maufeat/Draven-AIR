using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.icon.SummonerIcon")]
    class SummonerIcon
    {
        [SerializedName("icon")]
        public object Icon { get; set; }
        [SerializedName("purchaseDate")]
        public String PurchaseDate { get; set; }
        [SerializedName("iconId")]
        public Double IconId { get; set; }
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
    }
}
