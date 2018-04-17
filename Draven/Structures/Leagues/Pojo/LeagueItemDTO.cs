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
        [SerializedName("previousDayLeaguePosition")]
        public Int32 PreviousDayLeaguePosition { get; set; }

        [SerializedName("timeLastDecayMessageShown")]
        public Int32 TimeLastDecayMessageShown { get; set; }

        [SerializedName("seasonEndTier")]
        public String SeasonEndTier { get; set; }

        [SerializedName("seasonEndRank")]
        public String SeasonEndRank { get; set; }

        [SerializedName("hotStreak")]
        public Boolean HotStreak { get; set; }

        [SerializedName("leagueName")]
        public String LeagueName { get; set; }

        [SerializedName("miniSeries")]
        public object MiniSeries { get; set; }

        [SerializedName("tier")]
        public String Tier { get; set; }

        [SerializedName("freshBlood")]
        public Boolean FreshBlood { get; set; }

        [SerializedName("lastPlayed")]
        public Int64 LastPlayed { get; set; }

        [SerializedName("timeUntilInactivityStatusChanges")]
        public Int32 TimeUntilInactivityStatusChanges { get; set; }

        [SerializedName("inactivityStatus")]
        public String InactivityStatus { get; set; }

        [SerializedName("playerOrTeamId")]
        public String PlayerOrTeamId { get; set; }

        [SerializedName("leaguePoints")]
        public Int32 LeaguePoints { get; set; }

        [SerializedName("demotionWarning")]
        public Int32 DemotionWarning { get; set; }

        [SerializedName("inactive")]
        public Boolean Inactive { get; set; }

        [SerializedName("seasonEndApexPosition")]
        public Int32 SeasonEndApexPosition { get; set; }

        [SerializedName("rank")]
        public String Rank { get; set; }

        [SerializedName("veteran")]
        public Boolean Veteran { get; set; }

        [SerializedName("queueType")]
        public String QueueType { get; set; }

        [SerializedName("losses")]
        public Int32 Losses { get; set; }

        [SerializedName("timeUntilDecay")]
        public Int32 TimeUntilDecay { get; set; }

        [SerializedName("displayDecayWarning")]
        public Boolean DisplayDecayWarning { get; set; }

        [SerializedName("playerOrteamName")]
        public String PlayerOrteamName { get; set; }

        [SerializedName("wins")]
        public Int32 Wins { get; set; }


    }
}
