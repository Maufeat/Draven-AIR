namespace Draven.Structures.Leagues.Pojo
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.leagues.pojo.LeagueListDTO")]
    class LeagueListDTO
    {
        [JsonProperty("name")]
        [SerializedName("name")]
        public String Name { get; set; }
        [JsonProperty("entries")]
        [SerializedName("entries")]
        public List<LeagueItemDTO> Entries { get; set; }
        [JsonProperty("tier")]
        [SerializedName("tier")]
        public String Tier { get; set; }
        [JsonProperty("requestorsRank")]
        [SerializedName("requestorsRank")]
        public String RequestorsRank { get; set; }
        [JsonProperty("queue")]
        [SerializedName("queue")]
        public String Queue { get; set; }
        [JsonProperty("requestorsName")]
        [SerializedName("requestorsName")]
        public object RequestorsName { get; set; }
        [JsonProperty("maxLeagueSize")]
        [SerializedName("maxLeagueSize")]
        public Int32 MaxLeagueSize { get; set; }
        [JsonProperty("nextApexUpdate")]
        [SerializedName("nextApexUpdate")]
        public Int32 NextApexUpdate { get; set; }
    }
}
