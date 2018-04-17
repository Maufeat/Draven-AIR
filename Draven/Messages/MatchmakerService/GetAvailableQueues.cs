using Draven.Structures;
using Messages;
using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System.Collections.Generic;

namespace Draven.Messages.MatchmakerService
{
    class GetAvailableQueues : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            ArrayCollection data = new ArrayCollection
            {
                new GameQueueConfig {
                    BlockedMinutesThreshold = 60,
                    Ranked = false,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 100,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 1,
                    MinLevel = 3,
                    QueueState = "ON",
                    Type = "NORMAL",
                    CacheName = "matching-queue-NORMAL-5x5-game-queue",
                    Id = 2.0,
                    QueueBonusKey = "normalQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "normalSummonersRift",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = false,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "NORMAL",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = true,
                    GameMutators = new ArrayCollection{ "MapMusic(Bilgewater)" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 60,
                    Ranked = false,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 30,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 4,
                    MinLevel = 5,
                    QueueState = "ON",
                    Type = "ARAM_UNRANKED_5x5",
                    CacheName = "matching-queue-BILGEWATER_ARAM-5x5-game-queue",
                    Id = 100.0,
                    QueueBonusKey = "ARAMQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "normalARAM",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = true,
                    SupportedMapIds = new ArrayCollection{ 14 },
                    GameMode = "ARAM",
                    TypeString = "ARAM_UNRANKED_5x5",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "LAST",
                    BotsCanSpawnOnBlueSide = true,
                    GameMutators = new ArrayCollection{ "ReRoll", "BattleBoost" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 60,
                    Ranked = false,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 30,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 1,
                    MinLevel = 0,
                    QueueState = "ON",
                    Type = "BOT",
                    CacheName = "matching-queue-BOT_INTRO-5x5-game-queue",
                    Id = 31.0,
                    QueueBonusKey = "matchedBotsQueueBonuses",
                    MaxSummonerLevelForFWOTD = 9,
                    QueueStateString = "ON",
                    PointsConfigKey = "coOpVsAiSummonersRift",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = true,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "BOT",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = false,
                    GameMutators = new ArrayCollection{ "OnboardCoopBeginner", "LearningQuests", "MapMusic(Bilgewater)" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 60,
                    Ranked = false,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 30,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 1,
                    MinLevel = 0,
                    QueueState = "ON",
                    Type = "BOT",
                    CacheName = "matching-queue-BOT_EASY-5x5-game-queue",
                    Id = 32.0,
                    QueueBonusKey = "matchedBotsQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "coOpVsAiSummonersRift",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = true,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "BOT",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = false,
                    GameMutators = new ArrayCollection{ "AdvancedLearningQuests", "MapMusic(Bilgewater)" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 60,
                    Ranked = false,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 30,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 1,
                    MinLevel = 0,
                    QueueState = "ON",
                    Type = "BOT",
                    CacheName = "matching-queue-BOT_MEDIUM-5x5-game-queue",
                    Id = 33.0,
                    QueueBonusKey = "matchedBotsQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "coOpVsAiSummonersRift",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = true,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "BOT",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = false,
                    GameMutators = new ArrayCollection{ "AdvancedLearningQuests", "MapMusic(Bilgewater)" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                }
            };
            e.ReturnRequired = true;
            e.Data = data;

            return e;
        }
    }
}
