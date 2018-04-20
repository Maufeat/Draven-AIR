using Newtonsoft.Json;
using RtmpSharp.IO;
using System;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.championmastery.pojo.ChampionMasteryDTO")]
    public class ChampionMasteryDTO
    {
        [JsonProperty("playerId")]
        [SerializedName("playerId")]
        public Double Score { get; set; }

        [JsonProperty("championId")]
        [SerializedName("championId")]
        public Double ChampionId { get; set; }

        [JsonProperty("championLevel")]
        [SerializedName("championLevel")]
        public Double ChampionLevel { get; set; }

        [JsonProperty("championPoints")]
        [SerializedName("championPoints")]
        public Double ChampionPoints { get; set; }

        [JsonProperty("lastPlayTime")]
        [SerializedName("lastPlayTime")]
        public Double LastPlayTime { get; set; }

        [JsonProperty("championPointsSinceLastLevel")]
        [SerializedName("championPointsSinceLastLevel")]
        public Double ChampionPointsSinceLastLevel { get; set; }

        [JsonProperty("championPointsUntilNextLevel")]
        [SerializedName("championPointsUntilNextLevel")]
        public Double ChampionPointsUntilNextLevel { get; set; }

        [JsonProperty("chestGranted")]
        [SerializedName("chestGranted")]
        public Boolean ChestGranted { get; set; }

        [JsonProperty("playerOrTeamId")]
        [SerializedName("highestGrade")]
        public String HighestGrade { get; set; }
    }
}
