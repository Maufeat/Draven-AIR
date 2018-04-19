using Newtonsoft.Json;
using RtmpSharp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.loot.dto.PlayerLootDefinitionsDTO")]
    public class PlayerLootDefinitionsDTO
    {
        [JsonProperty("lootItemList")]
        [SerializedName("lootItemList")]
        public LootItemListClientDTO LootItemList { get; set; }
        [JsonProperty("recipeList")]
        [SerializedName("recipeList")]
        public RecipeListClientDTO RecipeList { get; set; }
        [JsonProperty("playerLoot")]
        [SerializedName("playerLoot")]
        public List<PlayerLootDTO> PlayerLoot { get; set; }
    }
}
