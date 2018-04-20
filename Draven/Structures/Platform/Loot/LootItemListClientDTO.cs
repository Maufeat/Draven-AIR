namespace Draven.Structures.Platform.Loot
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.loot.dto.LootItemListClientDTO")]
    public class LootItemListClientDTO
    {
        [JsonProperty("lootItems")]
        [SerializedName("lootItems")]
        public List<LootItemDTO> LootItems { get; set; }
        [JsonProperty("lastUpdate")]
        [SerializedName("lastUpdate")]
        public Double LastUpdate{ get; set; }
    }
}
