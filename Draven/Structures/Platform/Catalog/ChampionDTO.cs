namespace Draven.Structures.Platform.Catalog
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.catalog.champion.ChampionDTO")]
    public class ChampionDTO
    {
        [SerializedName("chromas")]
        public object Chromas { get; set; }
        [SerializedName("ownedByYourTeam")]
        public Boolean OwnedByYourTeam { get; set; }
        [SerializedName("ownedByEnemyTeam")]
        public Boolean OwnedByEnemyTeam { get; set; }
        [SerializedName("championId")]
        public Int32 ChampionID { get; set; }
        [SerializedName("displayName")]
        public String DisplayName{ get; set; }
        [SerializedName("description")]
        public String Description { get; set; }
        [SerializedName("active")]
        public Boolean Active { get; set; }
        [SerializedName("botEnabled")]
        public Boolean BotEnabled { get; set; }
        [SerializedName("freeToPlay")]
        public Boolean FreeToPlay { get; set; }
        [SerializedName("owned")]
        public Boolean Owned { get; set; }
        [SerializedName("freeToPlayReward")]
        public Boolean FreeToPlayReward { get; set; }
        [SerializedName("defaultSkin")]
        public object DefaultSkin { get; set; }
        [SerializedName("banned")]
        public Boolean Banned { get; set; }
        [SerializedName("championData")]
        public object ChampionData { get; set; }
        [SerializedName("championSkins")]
        public ArrayCollection ChampionSkins { get; set; }
        
        /*
        [SerializedName("rankedPlayEnabled")]
        public Boolean RankedPlayEnabled { get; set; }
        [SerializedName("purchased")]
        public Double PurchaseDateTime { get; set; }
        */
    }
}
