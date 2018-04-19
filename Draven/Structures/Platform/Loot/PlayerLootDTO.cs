using Newtonsoft.Json;
using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.loot.dto.PlayerLootDTO")]
    public class PlayerLootDTO
    {
        [JsonProperty("playerId")]
        [SerializedName("playerId")]
        public Double playerId { get; set; }
        [JsonProperty("lootName")]
        [SerializedName("lootName")]
        public String lootName { get; set; }
        [JsonProperty("count")]
        [SerializedName("count")]
        public Int32 count { get; set; }
        [JsonProperty("expiryTime")]
        [SerializedName("expiryTime")]
        public Double expiryTime { get; set; }
    }
}