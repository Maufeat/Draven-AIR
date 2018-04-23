using Draven.ServerModels;
using Draven.Structures;

using RtmpSharp.Messaging;
using System;

namespace Draven.Messages.PlayerStatsService
{
    using Draven.Structures.Platform.Statistics;
    using System.Collections.Generic;

    class RetrievePlayerStatsByAccountId : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            SummonerClient summonerSender = sender as SummonerClient;
            object[] body = e.Body as object[];
            int accId = Convert.ToInt32(body[0]);
            int unknown = Convert.ToInt32(body[1]);

            PlayerLifetimeStats PLSData = new PlayerLifetimeStats()
            {
                PlayerStatSummaries = new PlayerStatSummaries()
                {
                    UserID = Convert.ToInt32(summonerSender._sumId),
                    SummaryList = new RtmpSharp.IO.AMF3.ArrayCollection()
                    {
                        new PlayerStatSummary()
                        {
                            ModifyDate = new DateTime(2016, 08, 11, 12, 00, 00),
                            Type = "AramUnranked5x5",
                            Wins = 9000,
                            AggregatedStats = new SummaryAggStats
                            {
                                Stats = new RtmpSharp.IO.AMF3.ArrayCollection
                                {
                                    new SummaryAggStat
                                    {
                                        StatType = "totalTurretsKilled",
                                        Value = 1337
                                    },
                                    new SummaryAggStat
                                    {
                                        StatType = "totalAssists",
                                        Value = 1337
                                    },
                                    new SummaryAggStat
                                    {
                                        StatType = "totalChampionKills",
                                        Value = 1337
                                    },
                                }
                            }
                        },
                        new PlayerStatSummary()
                        {
                            Type = "RankedSolo5x5",
                            MaxRating = 3000,
                            Rating = 3000,
                            ModifyDate = new DateTime(2016, 08, 11, 12, 00, 00),
                            Wins = 55,
                            Losses = 5,
                            AggregatedStats = new SummaryAggStats
                            {
                                Stats = new RtmpSharp.IO.AMF3.ArrayCollection
                                {
                                    new SummaryAggStat
                                    {
                                        StatType = "totalNeutralMinionsKilled",
                                        Value = 1337
                                    },
                                    new SummaryAggStat
                                    {
                                        StatType = "totalChampionKills",
                                        Value = 1337
                                    },
                                    new SummaryAggStat
                                    {
                                        StatType = "totalAssists",
                                        Value = 1337
                                    },
                                    new SummaryAggStat
                                    {
                                        StatType = "totalTurretsKilled",
                                        Value = 1337
                                    },
                                }
                            },
                        },
                        new PlayerStatSummary()
                        {
                            ModifyDate = new DateTime(2016, 08, 11, 12, 00, 00),
                            Type = "RankedTeam5x5",
                            Losses = 1337,
                            Wins = 9000,
                            Leaves = 0,
                            AggregatedStats = new SummaryAggStats
                            {
                                Stats = new RtmpSharp.IO.AMF3.ArrayCollection
                                {
                                    new SummaryAggStat
                                    {
                                        StatType = "totalNeutralMinionsKilled",
                                        Value = 1337
                                    },
                                    new SummaryAggStat
                                    {
                                        StatType = "totalChampionKills",
                                        Value = 1337
                                    },
                                    new SummaryAggStat
                                    {
                                        StatType = "totalAssists",
                                        Value = 1337
                                    },
                                    new SummaryAggStat
                                    {
                                        StatType = "totalTurretsKilled",
                                        Value = 1337
                                    },
                                }
                            },
                            UserId = Convert.ToInt32(summonerSender._sumId),
                        },
                        new PlayerStatSummary()
                        {
                            ModifyDate = new DateTime(2016, 08, 11, 12, 00, 00),
                            Type = "Unranked",
                            Losses = 1337,
                            Wins = 9000,
                            Leaves = 0,
                            AggregatedStats = new SummaryAggStats
                            {
                                Stats = new RtmpSharp.IO.AMF3.ArrayCollection
                                {
                                    new SummaryAggStat
                                    {
                                        StatType = "totalNeutralMinionsKilled",
                                        Value = 1337
                                    },
                                    new SummaryAggStat
                                    {
                                        StatType = "totalChampionKills",
                                        Value = 1337
                                    },
                                    new SummaryAggStat
                                    {
                                        StatType = "totalAssists",
                                        Value = 1337
                                    },
                                    new SummaryAggStat
                                    {
                                        StatType = "totalTurretsKilled",
                                        Value = 1337
                                    },
                                }
                            },
                        },
                    }
                },
                PreviousFirstWinOfDay = new DateTime(2016, 08, 11, 12, 00, 00),
                UserId = Convert.ToInt32(summonerSender._sumId),
                PlayerStats = new PlayerStats
                {
                    PromoGamesPlayed = 11,
                    PromoGamesPlayedLastUpdate = DateTime.Now
                },
                GameStatistics = new RtmpSharp.IO.AMF3.ArrayCollection()
                {
                    new PlayerGameStats{
                        ChampionId = 17,
                        CreateDate = DateTime.Now,
                        ExperienceEarned = 9999,
                        IPEarned = 9999,
                        FellowPlayers = new RtmpSharp.IO.AMF3.ArrayCollection(),
                        GameId = 1,
                        GameMapId = 11,
                        GameMode = "CLASSIC",
                        GameMutators = new RtmpSharp.IO.AMF3.ArrayCollection(),
                        GameType = "RankedSolo5x5",
                        Invalid = false,
                        Leaver = false,
                        LeveledUp = true,
                        QueueType = "RANKED_SOLO_5x5",
                        Ranked = true,
                        RawStats = new RtmpSharp.IO.AMF3.ArrayCollection(),
                        Spell1 = 5,
                        Spell2 = 5,
                        Statistics = null,
                        TeamId = 100,
                        UserId = summonerSender._sumId
                    }
                }
            };

            e.ReturnRequired = true;
            e.Data = PLSData;

            return e;
        }
    }
}
