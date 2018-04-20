namespace Draven.Structures.Platform.Loot
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    using RtmpSharp.IO;

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
