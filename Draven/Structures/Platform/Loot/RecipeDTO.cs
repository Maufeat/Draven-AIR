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
