namespace Draven.Structures.Platform.Loot
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.loot.dto.RecipeClientDTO")]
    public class RecipeClientDTO
    {
        [JsonProperty("recipeName")]
        [SerializedName("recipeName")]
        public String RecipeName { get; set; }
        [JsonProperty("type")]
        [SerializedName("type")]
        public String Type { get; set; }
        [JsonProperty("displayCategories")]
        [SerializedName("displayCategories")]
        public List<string> DisplayCategories { get; set; }
        [JsonProperty("slots")]
        [SerializedName("slots")]
        public List<RecipeSlotDTO> Slots { get; set; }
        [JsonProperty("outputs")]
        [SerializedName("outputs")]
        public List<RecipeOutputDTO> Outputs { get; set; }
    }
}
