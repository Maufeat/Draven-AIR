namespace Draven.Structures.Platform.Loot
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.loot.dto.RecipeListClientDTO")]
    public class RecipeListClientDTO
    {
        [JsonProperty("recipes")]
        [SerializedName("recipes")]
        public List<RecipeClientDTO> Recipes{ get; set; }
        [JsonProperty("lastUpdate")]
        [SerializedName("lastUpdate")]
        public Double LastUpdate{ get; set; }
    }
}
