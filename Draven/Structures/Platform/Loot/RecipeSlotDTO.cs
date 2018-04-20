namespace Draven.Structures.Platform.Loot
{
    using System;

    using Newtonsoft.Json;

    using RtmpSharp.IO;

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
