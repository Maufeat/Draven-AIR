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
    [SerializedName("com.riotgames.loot.dto.RecipeSlotClientDTO")]
    public class RecipeSlotDTO
    {
        [JsonProperty("slotNumber")]
        [SerializedName("slotNumber")]
        public Int32 SlotNumber { get; set; }
        [JsonProperty("query")]
        [SerializedName("query")]
        public String Query { get; set; }
        [JsonProperty("quantityExpression")]
        [SerializedName("quantityExpression")]
        public String QuantityExpression { get; set; }
    }
}
