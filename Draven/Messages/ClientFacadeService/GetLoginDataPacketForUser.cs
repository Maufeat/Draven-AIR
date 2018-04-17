using Draven.ServerModels;
using Draven.Structures;
using Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System;
using System.Collections.Generic;
using System.Net;

namespace Draven.Messages.ClientFacadeService
{

    class GetLoginDataPacketForUser : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            SummonerClient summonerSender = sender as SummonerClient;

            LoginDataPacket packet = new LoginDataPacket
            {
                RestrictedGamesRemainingForRanked = -1,
                PlayerStatSummaries = new PlayerStatSummaries
                {
                    UserID = Convert.ToInt32(summonerSender._session.Summary.AccountId), //Account ID
                    Season = 4,
                    SummaryList = new ArrayCollection()
                    {
                        new PlayerStatSummary
                        {
                            MaxRating = 0,
                            TypeString = "Unranked",
                            Type = "Unranked",
                            AggregatedStats = new SummaryAggStats
                            {
                                Stats = new ArrayCollection()
                            },
                            UserId = Convert.ToInt32(summonerSender._session.Summary.AccountId),
                            Losses = 555,
                            Wins = 1337,
                            Leaves = 0,
                            Rating = 3333,
                            ModifyDate = new DateTime(1428707144676)
                        }
                    }
                },
                RestrictedChatGamesRemaining = -1,
                MinutesUntilShutdown = -1,
                Minor = false,
                MaxPracticeGameSize = 5,
                SummonerCatalog = new SummonerCatalog
                {
                    Items = null,
                    TalentTree = DatabaseManager.TalentTree,
                    SpellBookConfig = DatabaseManager.RuneTree
                },
                IpBalance = Convert.ToInt32(summonerSender._IP),
                ReconnectInfo = null,
                Locales = new ArrayCollection { "en_US" },
                SimpleMessages = null,
                AllSummonerData = new AllSummonerData
                {
                    SpellBook = new SpellBookDTO
                    {
                        SummonerId = summonerSender._sumId,
                        DateString = "Wed Jul 17 23:05:42 PDT 2013",
                        BookPages = new ArrayCollection
                                {
                                    new SpellBookPageDTO
                                    {
                                        Current = true,
                                        SummonerId = summonerSender._sumId,
                                        PageId = 2.0,
                                        CreateDate = DateTime.Now,
                                        Name = "Rune Page 1",
                                        SlotEntries = new ArrayCollection()
                                    },
                                    new SpellBookPageDTO
                                    {
                                        Current = false,
                                        SummonerId = summonerSender._sumId,
                                        PageId = 3.0,
                                        CreateDate = DateTime.Now,
                                        Name = "Rune Page 2",
                                        SlotEntries = new ArrayCollection()
                                    }
                                }
                    },
                    SummonerDefaultSpells = new SummonerDefaultSpells //TODO
                    {
                        SummonerId = summonerSender._sumId,
                        SummonerDefaultSpellMap = new AsObject()
                    },
                    SummonerTalentsAndPoints = new SummonerTalentsAndPoints
                    {
                        CreateDate = DateTime.Now,
                        SummonerId = summonerSender._sumId,
                        TalentPoints = 1,
                        ModifyDate = DateTime.Now,
                    },
                    Summoner = new Summoner
                    {
                        InternalName = summonerSender._session.Summary.Username,
                        DisplayEloQuestionaire = false,
                        AcctId = (int) summonerSender._session.Summary.AccountId,
                        SeasonTwoTier = "CHALLENGER",
                        ProfileIconId = (int)summonerSender._sumIcon,
                        AdvancedTutorialFlag = false,
                        HelpFlag = false,
                        LastGameDate = DateTime.Now,
                        RevisionDate = DateTime.Now,
                        Name = summonerSender._summonername,
                        NameChangeFlag = false,
                        RevisionId = 0,
                        SumId = summonerSender._sumId,
                        TutorialFlag = true
                    },
                    MasteryBook = new MasteryBookDTO
                    {
                        SummonerId = summonerSender._sumId,
                        DateString = "Wed Apr 23 00:33:57 PDT 2014",
                        BookPages = new ArrayCollection
                                {
                                    new MasteryBookPageDTO
                                    {
                                        Current = true,
                                        SummonerId = summonerSender._sumId,
                                        PageId = 1.0,
                                        Name = "Mastery Page 1",
                                        TalentEntries = new ArrayCollection()
                                    }
                                }
                    },
                    SummonerLevel = new SummonerLevel
                    {
                        ExpTierMod = 1.0,
                        GrantRp = 0.0,
                        ExpForLoss = 0,
                        SummonerTier = 1.0,
                        InfTierMod = 1.0,
                        ExpToNextLevel = 1250.0,
                        ExpForWin = 0.0,
                        Level = 99.0
                    },
                    SummonerLevelAndPoints = new SummonerLevelAndPoints
                    {
                        InfPoints = 69974.0,
                        ExpPoints = 555,
                        SummonerId = summonerSender._sumId,
                        SummonerLevel = 30
                    }
                },
                CustomMinutesLeftToday = 120,
                PlatformGameLifecycleDTO = null,
                CoOpVsAiMinutesLeftToday = 180,
                BingeData = null,
                InGhostGame = false,
                BingePreventionSystemEnabledForClient = false,
                PendingBadges = 0,
                BannedUntilDateMillis = 0,
                BroadcastNotification = null,
                MinutesUntilMidnight = 0,
                TimeUntilFirstWinOfDay = 0,
                CoOpVsAiMsecsUntilReset = -1,
                ClientSystemStates = new ClientSystemStatesNotification
                {
                    Json = "{\"championTradeThroughLCDS\":true,\"practiceGameEnabled\":true,\"advancedTutorialEnabled\":true,\"minNumPlayersForPracticeGame\":1,\"practiceGameTypeConfigIdList\":[1,4,6,2],\"freeToPlayChampionIdList\":[19,24,25,96,99,102,105,119,122,131],\"freeToPlayChampionForNewPlayersIdList\":[110,21,86,22,102,63,13,122,55,89],\"freeToPlayChampionsForNewPlayersMaxLevel\":5,\"inactiveChampionIdList\":[],\"gameModeToInactiveSpellIds\":{\"CLASSIC\":[17,31,30],\"ASCENSION\":[9,10,11,12,17,16,20,31,30],\"KINGPORO\":[1,2,3,4,6,7,9,10,11,12,13,14,17,16,21,20],\"ALL_GAME_MODES_DISABLED_SPELLS_KEY\":[9,10,16,20],\"ARAM\":[2,9,10,11,12,17,31,30],\"TUTORIAL\":[17,20,31,30],\"ODIN\":[9,10,11,12,31,30]},\"inactiveSpellIdList\":[9,10,16,20],\"inactiveTutorialSpellIdList\":[17,20,31,30],\"inactiveClassicSpellIdList\":[17,31,30],\"inactiveOdinSpellIdList\":[9,10,11,12,31,30],\"inactiveAramSpellIdList\":[2,9,10,11,12,17,31,30],\"enabledQueueIdsList\":[2,4,31,32,33,42,61,65],\"unobtainableChampionSkinIDList\":[1001,1002,1003,1007,3002,3005,4001,4003,4007,6002,7003,8003,9002,9004,9007,10001,10003,10005,12001,12003,12005,13001,13004,13005,13006,13008,14001,15002,15003,15005,15006,17001,17003,18001,18002,18003,18006,19001,19002,19005,20001,20002,20006,21004,23001,23006,24001,24003,24004,25006,26001,26004,27001,27006,28002,29001,29002,29003,30001,31001,32001,32002,32004,33001,33003,34001,35003,35004,36001,36002,36004,36007,37001,37003,38001,40004,41003,41004,42001,42002,42003,43003,44001,45002,45007,48003,51003,51006,53001,53002,53005,53007,54001,55002,55004,55007,56004,57003,57004,58005,59004,60002,61002,61004,63004,74001,74004,75004,76001,76002,76005,78001,78002,78003,78004,79001,79003,81001,81002,81006,82001,84002,84003,85002,86002,89003,90001,92004,92005,96001,96002,96004,98001,98002,98006,103003,104003,104004,113003,114003,115004,117004,120003,412002],\"archivedStatsEnabled\":true,\"queueThrottleDTO\":{},\"gameMapEnabledDTOList\":[{\"gameMapId\":10,\"minPlayers\":1},{\"gameMapId\":12,\"minPlayers\":1},{\"gameMapId\":11,\"minPlayers\":1},{\"gameMapId\":8,\"minPlayers\":1}],\"storeCustomerEnabled\":true,\"runeUniquePerSpellBook\":false,\"tribunalEnabled\":true,\"observerModeEnabled\":true,\"spectatorSlotLimit\":4,\"clientHeartBeatRateSeconds\":120,\"observableGameModes\":[\"SR_6x6\",\"CAP_5x5\",\"ARAM_UNRANKED_2x2\",\"CAP_1x1\",\"TEAM_BUILDER_DRAFT_UNRANKED_3x3\",\"TT_5x5\",\"RANKED_SOLO_3x3\",\"RANKED_TEAM_3x3\",\"URF\",\"HEXAKILL\",\"TEAM_BUILDER_DRAFT_UNRANKED_5x5\",\"ARAM_UNRANKED_5x5\",\"NORMAL_3x3\",\"TEAM_BUILDER_DRAFT_RANKED_5x5\",\"FEATURED\",\"NORMAL\",\"ONEFORALL_1x1\",\"FIRSTBLOOD_1x1\",\"RANKED_PREMADE_5x5\",\"RANKED_PREMADE_3x3\",\"RANKED_SOLO_5x5\",\"ARAM_UNRANKED_1x1\",\"ARAM_UNRANKED_3x3\",\"COUNTER_PICK\",\"ARAM_UNRANKED_6x6\",\"FIRSTBLOOD_2x2\",\"TEAM_BUILDER_DRAFT_RANKED_3x3\",\"TEAM_BUILDER_DRAFT_UNRANKED_1x1\",\"ODIN_UNRANKED\",\"RANKED_TEAM_5x5\",\"ODIN_RANKED_SOLO\",\"KING_PORO\",\"TEAM_BUILDER_DRAFT_RANKED_1x1\",\"ASCENSION\",\"RANKED_SOLO_1x1\",\"ODIN_RANKED_TEAM\",\"ONEFORALL_5x5\"],\"observableCustomGameModes\":\"ALL\",\"teamServiceEnabled\":true,\"leagueServiceEnabled\":true,\"modularGameModeEnabled\":false,\"riotDataServiceDataSendProbability\":0.2,\"displayPromoGamesPlayedEnabled\":false,\"masteryPageOnServer\":false,\"maxMasteryPagesOnServer\":20,\"tournamentSendStatsEnabled\":true,\"replayServiceAddress\":\"\",\"kudosEnabled\":true,\"buddyNotesEnabled\":true,\"localeSpecificChatRoomsEnabled\":false,\"replaySystemStates\":{\"replayServiceEnabled\":false,\"replayServiceAddress\":\"\",\"endOfGameEnabled\":false,\"matchHistoryEnabled\":true,\"getReplaysTabEnabled\":true,\"backpatchingEnabled\":false},\"sendFeedbackEventsEnabled\":false,\"knownGeographicGameServerRegions\":[\"\"],\"leaguesDecayMessagingEnabled\":true,\"currentSeason\":6}"
                },
                BingeMinutesRemaining = 0,
                PendingKudosDTO = new PendingKudosDTO
                {
                    PendingCounts = new ArrayCollection() { 0, 0, 0, 0, 0 }
                },
                LeaverBusterPenaltyTime = 60,
                PlatformId = "EUW1",
                EmailStatus = "validated",
                MatchMakingEnabled = true,
                MinutesUntilShutdownEnabled = false,
                RpBalance = summonerSender._RP,
                ShowEmailVerificationPopup = true,
                BingeIsPlayerInBingePreventionWindow = false,

                GameTypeConfigs = new ArrayCollection
                {
                    new GameTypeConfigDTO
                    {
                        AllowTrades = false,
                        BanTimerDuration = 0,
                        MaxAllowableBans = 0,
                        PostPickTimerDuration = 0,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        Id = 1,
                        DuplicatePick = false,
                        ExclusivePick = false,
                        Name = "GAME_CFG_PICK_BLIND",
                        PickMode = "SimulPickStrategy",
                        MainPickTimerDuration = 93
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = true,
                        BanTimerDuration = 38,
                        MaxAllowableBans = 6,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 33,
                        Id = 2,
                        DuplicatePick = false,
                        ExclusivePick = true,
                        Name = "GAME_CFG_DRAFT_STD",
                        PickMode = "DraftModeSinglePickStrategy",
                        MainPickTimerDuration = 43
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = true,
                        BanTimerDuration = 0,
                        MaxAllowableBans = 0,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 33,
                        Id = 3,
                        DuplicatePick = false,
                        ExclusivePick = true,
                        Name = "GAME_CFG_DRAFT_NOBAN",
                        PickMode = "DraftModeSinglePickStrategy",
                        MainPickTimerDuration = 43
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = true,
                        BanTimerDuration = 0,
                        MaxAllowableBans = 0,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 70,
                        Id = 4,
                        DuplicatePick = false,
                        ExclusivePick = true,
                        Name = "GAME_CFG_PICK_RANDOM",
                        PickMode = "AllRandomPickStrategy",
                        MainPickTimerDuration = 0
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = false,
                        BanTimerDuration = 0,
                        MaxAllowableBans = 0,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 13,
                        Id = 5,
                        DuplicatePick = false,
                        ExclusivePick = false,
                        Name = "GAME_CFG_PICK_SIMUL",
                        PickMode = "SimulPickStrategy",
                        MainPickTimerDuration = 93
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = true,
                        BanTimerDuration = 33,
                        MaxAllowableBans = 6,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 63,
                        Id = 6,
                        DuplicatePick = false,
                        ExclusivePick = true,
                        Name = "GAME_CFG_DRAFT_TOURNAMENT",
                        PickMode = "DraftModeSinglePickStrategy",
                        MainPickTimerDuration = 63
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = false,
                        BanTimerDuration = 28,
                        MaxAllowableBans = 6,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 43,
                        Id = 7,
                        DuplicatePick = false,
                        ExclusivePick = false,
                        Name = "GAME_CFG_PICK_SIMUL_TD",
                        PickMode = "SimulPickStrategy",
                        MainPickTimerDuration = 53
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = false,
                        BanTimerDuration = 0,
                        MaxAllowableBans = 0,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 0,
                        Id = 10,
                        DuplicatePick = false,
                        ExclusivePick = false,
                        Name = "GAME_CFG_BASIC_TUTORIAL",
                        PickMode = "SimulPickStrategy",
                        MainPickTimerDuration = 93
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = false,
                        BanTimerDuration = 0,
                        MaxAllowableBans = 0,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 0,
                        Id = 11,
                        DuplicatePick = false,
                        ExclusivePick = false,
                        Name = "GAME_CFG_ADV_TUTORIAL",
                        PickMode = "SimulPickStrategy",
                        MainPickTimerDuration = 900
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = false,
                        BanTimerDuration = 0,
                        MaxAllowableBans = 0,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 0,
                        Id = 12,
                        DuplicatePick = false,
                        ExclusivePick = false,
                        Name = "GAME_CFG_CAP",
                        PickMode = "SkipPickStrategy",
                        MainPickTimerDuration = 0
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = true,
                        BanTimerDuration = 0,
                        MaxAllowableBans = 0,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 70,
                        Id = 13,
                        DuplicatePick = false,
                        ExclusivePick = true,
                        Name = "GAME_CFG_BLIND_RANDOM",
                        PickMode = "AllRandomPickStrategy",
                        MainPickTimerDuration = 0
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = false,
                        BanTimerDuration = 38,
                        MaxAllowableBans = 6,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = true,
                        PostPickTimerDuration = 63,
                        Id = 14,
                        DuplicatePick = true,
                        ExclusivePick = false,
                        Name = "GAME_CFG_BLIND_DUPE",
                        PickMode = "OneTeamVotePickStrategy",
                        MainPickTimerDuration = 43
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = false,
                        BanTimerDuration = 0,
                        MaxAllowableBans = 0,
                        CrossTeamChampionPool = true,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 63,
                        Id = 15,
                        DuplicatePick = true,
                        ExclusivePick = false,
                        Name = "GAME_CFG_CROSS_DUPE",
                        PickMode = "AllTeamVotePickStrategy",
                        MainPickTimerDuration = 43
                    },
                    new GameTypeConfigDTO
                    {
                        AllowTrades = false,
                        BanTimerDuration = 28,
                        MaxAllowableBans = 6,
                        CrossTeamChampionPool = false,
                        TeamChampionPool = false,
                        PostPickTimerDuration = 13,
                        Id = 16,
                        DuplicatePick = false,
                        ExclusivePick = true,
                        Name = "GAME_CFG_BLIND_DRAFT_ST",
                        PickMode = "SimulPickStrategy",
                        MainPickTimerDuration = 53
                    },
                },
                MinorShutdownEnforced = false,
                CompetitiveRegion = "EUW",
                CustomMsecsUntilReset = -1
            };

            e.ReturnRequired = true;
            e.Data = packet;

            return e;
        }
    }
}
