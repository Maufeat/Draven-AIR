using Draven.ServerModels;
using Draven.Structures;
using Messages;
using RtmpSharp.Messaging;
using System;

namespace Draven.Messages.PlayerStatsService
{
    class RetrievePlayerStatsByAccountId : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            object[] body = e.Body as object[];
            SummonerClient summonerSender = sender as SummonerClient;
            int accId = Convert.ToInt32(body[0]);
            int unknown = Convert.ToInt32(body[1]);

            PlayerLifetimeStats PLSData = new PlayerLifetimeStats()
            {
                PlayerStatSummaries = new PlayerStatSummaries()
                {
                    Season = 4,
                    UserID = Convert.ToInt32(summonerSender._sumId),
                    SummaryList = new RtmpSharp.IO.AMF3.ArrayCollection()
                    {
                        new PlayerStatSummary()
                        {
                            MaxRating = 0,
                            TypeString = "Unranked",
                            Type = "Unranked",
                            Losses = 1337,
                            Wins = 9000,
                            Leaves = 0,
                            Rating = 400,
                            AggregatedStats = new SummaryAggStats
                            {
                                Stats = new RtmpSharp.IO.AMF3.ArrayCollection()
                            },
                            UserId = Convert.ToInt32(summonerSender._sumId),
                        }
                    }
                },
                PreviousFirstWinOfDay = new DateTime(2016, 08, 11, 12, 00, 00),
                UserId = Convert.ToInt32(summonerSender._sumId),
                DodgeStreak = 0,
                DodgePenaltyDate = null,
                PlayerStatsJson = null,
                PlayerStats = new PlayerStats()
                {
                    TimeTrackedStats = new RtmpSharp.IO.AMF3.ArrayCollection()
                    {

                    },
                    PromoGamesPlayed = 0,
                    PromoGamesPlayedLastUpdate = null,
                    LifetimeGamesPlayed = null
                }
            };

            e.ReturnRequired = true;
            e.Data = PLSData;

            return e;
        }
    }
}
