namespace Draven.Structures.Platform.Leagues
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.leagues.client.dto.SummonerLeagueItemsDTO")]
    public class SummonerLeagueItemsDTO
    {
        [SerializedName("summonerLeagues")]
        public ArrayCollection summonerLeagues { get; set; }
    }
}
