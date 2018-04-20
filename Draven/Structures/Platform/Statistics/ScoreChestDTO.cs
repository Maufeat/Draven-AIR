using Newtonsoft.Json;
using RtmpSharp.IO;
using System;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.championmastery.pojo.ScoreChestDTO")]
    public class ScoreChestDTO
    {
        [JsonProperty("score")]
        [SerializedName("score")]
        public Double Score { get; set; }

        [JsonProperty("earnableChests")]
        [SerializedName("earnableChests")]
        public Double EarnableChests { get; set; }

        [JsonProperty("maximumChests")]
        [SerializedName("maximumChests")]
        public Double MaximumChests { get; set; }

        [JsonProperty("nextChestRechargeTime")]
        [SerializedName("nextChestRechargeTime")]
        public Double NextChestRechargeTime { get; set; }
    }
}
