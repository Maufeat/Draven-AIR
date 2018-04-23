namespace Draven.Structures.Platform.Loot
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.loot.dto.QueryResultDTO")]
    public class QueryResultDTO
    {
        [JsonProperty("queryToLootNames")]
        [SerializedName("queryToLootNames")]
        public Dictionary<string, List<string>> QueryToLootNames { get; set; }
        [JsonProperty("lastUpdate")]
        [SerializedName("lastUpdate")]
        public Double LastUpdate { get; set; }
    }
}
