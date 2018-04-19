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
        [SerializedName("lootItemList")]
        public LootItemListClientDTO LootItemList { get; set; }
        [SerializedName("recipeList")]
        public RecipeListClientDTO RecipeList { get; set; }
        [SerializedName("playerLoot")]
        public List<PlayerLootDTO> PlayerLoot { get; set; }
    }
}
