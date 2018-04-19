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
