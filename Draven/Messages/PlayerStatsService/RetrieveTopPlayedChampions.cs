using Draven.ServerModels;
using Draven.Structures;

using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System;

namespace Draven.Messages.PlayerStatsService
{
    using Draven.Structures.Platform.Statistics;

    class RetrieveTopPlayedChampions : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            object[] body = e.Body as object[];
            SummonerClient summonerSender = sender as SummonerClient;
            int accId = Convert.ToInt32(body[0]);
            string unknown = Convert.ToString(body[1]);
            
            ArrayCollection rData = new ArrayCollection()
            {
                new ChampionStatInfo()
                {
                    ChampionId = 17
                },
                new ChampionStatInfo()
                {
                    ChampionId = 17
                },
                new ChampionStatInfo()
                {
                    ChampionId = 17
                }
            };

            e.ReturnRequired = true;
            e.Data = rData;
            return e;
        }
    }
}
