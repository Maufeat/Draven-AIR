using RtmpSharp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.loot.dto.LootItemClientDTO")]
    public class LootItemDTO
    {
        [SerializedName("lootName")]
        public String LootName { get; set; }
        [SerializedName("type")]
        public String Type{ get; set; }
        [SerializedName("tags")]
        public String Tags { get; set; }
        [SerializedName("displayCategories")]
        public List<string> DisplayCategories { get; set; }
        [SerializedName("rarity")]
        public String Rarity { get; set; }
        [SerializedName("value")]
        public Double Value { get; set; }
        [SerializedName("storeItemId")]
        public Double StoreItemId { get; set; }
        [SerializedName("upgradeLootName")]
        public String UpgradeLootName { get; set; }
        [SerializedName("expiryTime")]
        public Double ExpiryTime { get; set; }
        [SerializedName("rentalSeconds")]
        public Double RentalSeconds { get; set; }
        [SerializedName("rentalGames")]
        public Double RentalGames { get; set; }
        [SerializedName("lootLocalName")]
        public String LootLocalName { get; set; }
    }
}
