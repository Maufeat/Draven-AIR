﻿﻿using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.clientfacade.domain.LoginDataPacket")]
    public class LoginDataPacket
    {
        [SerializedName("playerStatSummaries")]
        public PlayerStatSummaries PlayerStatSummaries { get; set; }
        [SerializedName("showEmailVerificationPopup")]
        public Boolean ShowEmailVerificationPopup { get; set; }
        [SerializedName("restrictedChatGamesRemaining")]
        public Int32 RestrictedChatGamesRemaining { get; set; }
        [SerializedName("restrictedGamesRemainingForRanked")]
        public Int32 RestrictedGamesRemainingForRanked { get; set; }
        [SerializedName("minutesUntilShutdown")]
        public Int32 MinutesUntilShutdown { get; set; }
        [SerializedName("minor")]
        public Boolean Minor { get; set; }
        [SerializedName("maxPracticeGameSize")]
        public Int32 MaxPracticeGameSize { get; set; }
        [SerializedName("summonerCatalog")]
        public SummonerCatalog SummonerCatalog { get; set; }
        [SerializedName("emailStatus")]
        public string EmailStatus { get; set; }
        [SerializedName("ipBalance")]
        public Int32 IpBalance { get; set; }
        [SerializedName("reconnectInfo")]
        public object ReconnectInfo { get; set; }
        [SerializedName("languages")]
        public ArrayCollection Locales { get; set; }
        [SerializedName("simpleMessages")]
        public ArrayCollection SimpleMessages { get; set; }
        [SerializedName("allSummonerData")]
        public AllSummonerData AllSummonerData { get; set; }
        [SerializedName("customMinutesLeftToday")]
        public Int32 CustomMinutesLeftToday { get; set; }
        [SerializedName("platformGameLifecycleDTO")]
        public object PlatformGameLifecycleDTO { get; set; }
        [SerializedName("coOpVsAiMinutesLeftToday")]
        public Int32 CoOpVsAiMinutesLeftToday { get; set; }
        [SerializedName("bingeData")]
        public object BingeData { get; set; }
        [SerializedName("inGhostGame")]
        public Boolean InGhostGame { get; set; }
        [SerializedName("leaverPenaltyLevel")]
        public Int32 LeaverPenaltyLevel { get; set; }
        [SerializedName("bingePreventionSystemEnabledForClient")]
        public Boolean BingePreventionSystemEnabledForClient { get; set; }
        [SerializedName("pendingBadges")]
        public Int32 PendingBadges { get; set; }
        [SerializedName("bannedUntilDateMillis")]
        public Int32 BannedUntilDateMillis { get; set; }
        [SerializedName("broadcastNotification")]
        public object BroadcastNotification { get; set; }
        [SerializedName("minutesUntilMidnight")]
        public Int32 MinutesUntilMidnight { get; set; }
        [SerializedName("timeUntilFirstWinOfDay")]
        public Double TimeUntilFirstWinOfDay { get; set; }
        [SerializedName("coOpVsAiMsecsUntilReset")]
        public Double CoOpVsAiMsecsUntilReset { get; set; }
        [SerializedName("clientSystemStates")]
        public ClientSystemStatesNotification ClientSystemStates { get; set; }
        [SerializedName("bingeMinutesRemaining")]
        public Double BingeMinutesRemaining { get; set; }
        [SerializedName("pendingKudosDTO")]
        public PendingKudosDTO PendingKudosDTO { get; set; }
        [SerializedName("leaverBusterPenaltyTime")]
        public Int32 LeaverBusterPenaltyTime { get; set; }
        [SerializedName("platformId")]
        public String PlatformId { get; set; }
        [SerializedName("matchMakingEnabled")]
        public Boolean MatchMakingEnabled { get; set; }
        [SerializedName("minutesUntilShutdownEnabled")]
        public Boolean MinutesUntilShutdownEnabled { get; set; }
        [SerializedName("rpBalance")]
        public Double RpBalance { get; set; }
        [SerializedName("gameTypeConfigs")]
        public ArrayCollection GameTypeConfigs { get; set; }
        [SerializedName("bingeIsPlayerInBingePreventionWindow")]
        public Boolean BingeIsPlayerInBingePreventionWindow { get; set; }
        [SerializedName("minorShutdownEnforced")]
        public Boolean MinorShutdownEnforced { get; set; }
        [SerializedName("competitiveRegion")]
        public String CompetitiveRegion { get; set; }
        [SerializedName("customMsecsUntilReset")]
        public Double CustomMsecsUntilReset { get; set; }
    }
}
