namespace Draven.Structures.Platform.Loot
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.loot.dto.LootItemClientDTO")]
    public class LootItemDTO
    {
        [JsonProperty("lootName")]
        [SerializedName("lootName")]
        public String LootName { get; set; }
        [JsonProperty("type")]
        [SerializedName("type")]
        public String Type{ get; set; }
        [JsonProperty("tags")]
        [SerializedName("tags")]
        public String Tags { get; set; }
        [JsonProperty("displayCategories")]
        [SerializedName("displayCategories")]
        public List<string> DisplayCategories { get; set; }
        [JsonProperty("rarity")]
        [SerializedName("rarity")]
        public String Rarity { get; set; }
        [JsonProperty("value")]
        [SerializedName("value")]
        public Double Value { get; set; }
        [JsonProperty("storeItemId")]
        [SerializedName("storeItemId")]
        public Double StoreItemId { get; set; }
        [JsonProperty("upgradeLootName")]
        [SerializedName("upgradeLootName")]
        public String UpgradeLootName { get; set; }
        [JsonProperty("expiryTime")]
        [SerializedName("expiryTime")]
        public Double ExpiryTime { get; set; }
        [JsonProperty("rentalSeconds")]
        [SerializedName("rentalSeconds")]
        public Double RentalSeconds { get; set; }
        [JsonProperty("rentalGames")]
        [SerializedName("rentalGames")]
        public Double RentalGames { get; set; }
        [JsonProperty("lootLocalName")]
        [SerializedName("lootLocalName")]
        public String LootLocalName { get; set; }
    }
}
