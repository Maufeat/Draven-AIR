namespace Draven.Structures.Platform.Summoner
{
    using System;

    using RtmpSharp.IO;

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
