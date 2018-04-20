namespace Draven.Structures.Platform.Loot
{
    using System;

    using Newtonsoft.Json;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.loot.dto.RecipeOutputDTO")]
    public class RecipeOutputDTO
    {
        [JsonProperty("lootName")]
        [SerializedName("lootName")]
        public String LootName{ get; set; }
        [JsonProperty("quantityExpression")]
        [SerializedName("quantityExpression")]
        public String QuantityExpression { get; set; }
    }
}
