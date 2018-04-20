namespace Draven.Structures.Leagues.Client.DTO
{
    using System;
    using System.Collections.Generic;

    using Draven.Structures.Leagues.Pojo;

    using Newtonsoft.Json;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.leagues.client.dto.SummonerLeaguesDTO")]
    class SummonerLeaguesDTO
    {
        [JsonProperty("summonerLeagues")]
        [SerializedName("summonerLeagues")]
        public List<LeagueListDTO> SummonerLeagues { get; set; }
    }
}
