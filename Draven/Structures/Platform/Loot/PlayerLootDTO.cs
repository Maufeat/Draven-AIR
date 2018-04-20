namespace Draven.Structures.Platform.Loot
{
    using System;

    using Newtonsoft.Json;

    using RtmpSharp.IO;

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