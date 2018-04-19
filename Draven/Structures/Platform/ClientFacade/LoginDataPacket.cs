﻿using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.clientfacade.domain.LoginDataPacket")]
    public class LoginDataPacket
    {
        [SerializedName("maxPracticeGameSize")]
        public Int32 MaxPracticeGameSize { get; set; }
        [SerializedName("matchMakingEnabled")]
        public Boolean MatchMakingEnabled { get; set; }
        [SerializedName("clientHeartBeatEnabled")]
        public Boolean ClientHeartBeatEnabled { get; set; } //n
        [SerializedName("inGhostGame")]
        public Boolean InGhostGame { get; set; }
        [SerializedName("allSummonerData")]
        public AllSummonerData AllSummonerData { get; set; }
        [SerializedName("summonerCatalog")]
        public SummonerCatalog SummonerCatalog { get; set; }
        [SerializedName("reconnectInfo")]
        public object ReconnectInfo { get; set; }
        [SerializedName("languages")]
        public ArrayCollection Locales { get; set; }
        [SerializedName("ipBalance")]
        public Double IpBalance { get; set; }
        [SerializedName("rpBalance")]
        public Double RpBalance { get; set; }
        [SerializedName("clientSystemStates")]
        public ClientSystemStatesNotification ClientSystemStates { get; set; }
        [SerializedName("gameTypeConfigs")]
        public ArrayCollection GameTypeConfigs { get; set; }
        [SerializedName("timeUntilFirstWinOfDay")]
        public Double TimeUntilFirstWinOfDay { get; set; }
        [SerializedName("restrictedChatGamesRemaining")]
        public Int32 RestrictedChatGamesRemaining { get; set; }
        [SerializedName("restrictedGamesRemainingForRanked")]
        public Int32 RestrictedGamesRemainingForRanked { get; set; }
        [SerializedName("customMinutesLeftToday")]
        public Int32 CustomMinutesLeftToday { get; set; }
        [SerializedName("coOpVsAiMinutesLeftToday")]
        public Int32 CoOpVsAiMinutesLeftToday { get; set; }
        [SerializedName("customMsecsUntilReset")]
        public Double CustomMsecsUntilReset { get; set; }
        [SerializedName("coOpVsAiMsecsUntilReset")]
        public Double CoOpVsAiMsecsUntilReset { get; set; }
        [SerializedName("displayPrimeReformCard")]
        public Boolean DisplayPrimeReformCard { get; set; }
        [SerializedName("bannedUntilDateMillis")]
        public Int32 BannedUntilDateMillis { get; set; }
        [SerializedName("minorShutdownEnforced")]
        public Boolean MinorShutdownEnforced { get; set; }
        [SerializedName("minor")]
        public Boolean Minor { get; set; }
        [SerializedName("minutesUntilMidnight")]
        public Int32 MinutesUntilMidnight { get; set; }
        [SerializedName("minutesUntilShutdownEnabled")]
        public Boolean MinutesUntilShutdownEnabled { get; set; }
        [SerializedName("minutesUntilShutdown")]
        public Int32 MinutesUntilShutdown { get; set; }
        [SerializedName("playerStatSummaries")]
        public PlayerStatSummaries PlayerStatSummaries { get; set; }
        [SerializedName("broadcastNotification")]
        public object BroadcastNotification { get; set; }
        [SerializedName("pendingKudosDTO")]
        public PendingKudosDTO PendingKudosDTO { get; set; }
        [SerializedName("pendingBadges")]
        public Int32 PendingBadges { get; set; }
        [SerializedName("leaverBusterPenaltyTime")]
        public Int32 LeaverBusterPenaltyTime { get; set; }
        [SerializedName("platformId")]
        public String PlatformId { get; set; }
        [SerializedName("competitiveRegion")]
        public String CompetitiveRegion { get; set; }
        [SerializedName("bingeIsPlayerInBingePreventionWindow")]
        public Boolean BingeIsPlayerInBingePreventionWindow { get; set; }
        [SerializedName("bingeMinutesRemaining")]
        public Double BingeMinutesRemaining { get; set; }
        [SerializedName("bingeData")]
        public object BingeData { get; set; }
        [SerializedName("bingePreventionSystemEnabledForClient")]
        public Boolean BingePreventionSystemEnabledForClient { get; set; }
        [SerializedName("simpleMessages")]
        public ArrayCollection SimpleMessages { get; set; }
        [SerializedName("emailStatus")]
        public string EmailStatus { get; set; }
        [SerializedName("showEmailVerificationPopup")]
        public Boolean ShowEmailVerificationPopup { get; set; }
        //[SerializedName("platformGameLifecycleDTO")]
        //public object PlatformGameLifecycleDTO { get; set; }
        //[SerializedName("leaverPenaltyLevel")]
        //public Int32 LeaverPenaltyLevel { get; set; }
    }
}
