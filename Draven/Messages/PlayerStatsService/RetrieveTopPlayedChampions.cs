using Draven.ServerModels;
using Draven.Structures;
using Messages;
using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System;

namespace Draven.Messages.PlayerStatsService
{
    class RetrieveTopPlayedChampions : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            object[] body = e.Body as object[];
            SummonerClient summonerSender = sender as SummonerClient;
            int accId = Convert.ToInt32(body[0]);
            string unknown = Convert.ToString(body[1]);

            /** 
                [LOG][test] Request for retrievePlayerStatsByAccountId : playerStatsService
                [LOG][test] Request for retrieveTopPlayedChampions : playerStatsService
             **/
            ArrayCollection rData = new ArrayCollection()
            {
                new ChampionStatInfo()
                {
                    TotalGammesPlayed = 17,
                    Stats = new ArrayCollection()
                    {
                        new PlayerChampionStats
                        {
                            Owned = true,
                            Stats = new ArrayCollection() {},
                            Wins = 1337,
                            TotalGamesPlayed = 9999
                        }
                    },
                    ChampionId = 17
                },
                new ChampionStatInfo()
                {
                    TotalGammesPlayed = 17,
                    Stats = new ArrayCollection()
                    {
                        new PlayerChampionStats
                        {
                            Owned = true,
                            Stats = new ArrayCollection() {},
                            Wins = 1337,
                            TotalGamesPlayed = 9999
                        }
                    },
                    ChampionId = 17
                },
                new ChampionStatInfo()
                {
                    TotalGammesPlayed = 17,
                    Stats = new ArrayCollection()
                    {
                        new PlayerChampionStats
                        {
                            Owned = true,
                            Stats = new ArrayCollection() {},
                            Wins = 1337,
                            TotalGamesPlayed = 9999
                        }
                    },
                    ChampionId = 17
                }
            };

            e.ReturnRequired = true;
            e.Data = rData;

            return e;
        }
    }
}
