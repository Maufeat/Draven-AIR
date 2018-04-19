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
    [SerializedName("com.riotgames.leagues.pojo.LeagueItemDTO")]
    class LeagueItemDTO
    {
        [JsonProperty("playerOrTeamId")]
        [SerializedName("playerOrTeamId")]
        public String PlayerOrTeamId { get; set; }
        [JsonProperty("playerOrTeamName")]
        [SerializedName("playerOrTeamName")]
        public String PlayerOrteamName { get; set; }
        [JsonProperty("leagueName")]
        [SerializedName("leagueName")]
        public String LeagueName { get; set; }
        [JsonProperty("queueType")]
        [SerializedName("queueType")]
        public String QueueType { get; set; }
        [JsonProperty("tier")]
        [SerializedName("tier")]
        public String Tier { get; set; }
        [JsonProperty("rank")]
        [SerializedName("rank")]
        public String Rank { get; set; }
        [JsonProperty("leaguePoints")]
        [SerializedName("leaguePoints")]
        public Int32 LeaguePoints { get; set; }
        [JsonProperty("leaguePointsDelta")]
        [SerializedName("leaguePointsDelta")]
        public Double LeaguePointsDelta { get; set; }
        [JsonProperty("previousDayLeaguePosition")]
        [SerializedName("previousDayLeaguePosition")]
        public Int32 PreviousDayLeaguePosition { get; set; }
        [JsonProperty("wins")]
        [SerializedName("wins")]
        public Int32 Wins { get; set; }
        [JsonProperty("losses")]
        [SerializedName("losses")]
        public Int32 Losses { get; set; }
        [JsonProperty("hotStreak")]
        [SerializedName("hotStreak")]
        public Boolean HotStreak { get; set; }
        [JsonProperty("veteran")]
        [SerializedName("veteran")]
        public Boolean Veteran { get; set; }
        [JsonProperty("freshBlood")]
        [SerializedName("freshBlood")]
        public Boolean FreshBlood { get; set; }
        [JsonProperty("lastPlayed")]
        [SerializedName("lastPlayed")]
        public Int64 LastPlayed { get; set; }
        [JsonProperty("inactivityStatus")]
        [SerializedName("inactivityStatus")]
        public String InactivityStatus { get; set; }
        [JsonProperty("timeUntilInactivityStatusChanges")]
        [SerializedName("timeUntilInactivityStatusChanges")]
        public Int32 TimeUntilInactivityStatusChanges { get; set; }
        [JsonProperty("timeLastDecayMessageShown")]
        [SerializedName("timeLastDecayMessageShown")]
        public Int32 TimeLastDecayMessageShown { get; set; }
        [JsonProperty("apexDaysUntilDecay")]
        [SerializedName("apexDaysUntilDecay")]
        public Double ApexDaysUntilDecay { get; set; }
        [JsonProperty("displayDecayWarning")]
        [SerializedName("displayDecayWarning")]
        public Boolean DisplayDecayWarning { get; set; }
        [JsonProperty("demotionWarning")]
        [SerializedName("demotionWarning")]
        public Int32 DemotionWarning { get; set; }
        [JsonProperty("inactive")]
        [SerializedName("inactive")]
        public Boolean Inactive { get; set; }
        [JsonProperty("miniSeries")]
        [SerializedName("miniSeries")]
        public object MiniSeries { get; set; }
        [JsonProperty("playstyle")]
        [SerializedName("playstyle")]
        public object PlayStyle { get; set; }
        [JsonProperty("playstyleRemainingWins")]
        [SerializedName("playstyleRemainingWins")]
        public Int32 PlayStyleReminingWins{ get; set; }

        [JsonProperty("seasonEndTier")]
        [SerializedName("seasonEndTier")]
        public String SeasonEndTier { get; set; }
        [JsonProperty("seasonEndRankr")]
        [SerializedName("seasonEndRankr")]
        public String SeasonEndRank { get; set; }
        [JsonProperty("seasonEndApexPosition")]
        [SerializedName("seasonEndApexPosition")]
        public Int32 SeasonEndApexPosition { get; set; }
        [JsonProperty("timeUntilDecay")]
        [SerializedName("timeUntilDecay")]
        public Int32 TimeUntilDecay { get; set; }
    }
}
