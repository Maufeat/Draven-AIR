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
    [SerializedName("com.riotgames.loot.dto.QueryResultDTO")]
    public class QueryResultDTO
    {
        [JsonProperty("queryToLootNames")]
        [SerializedName("queryToLootNames")]
        public object QueryToLootNames{ get; set; }
        [JsonProperty("lastUpdate")]
        [SerializedName("lastUpdate")]
        public Double LastUpdate { get; set; }
    }
}
