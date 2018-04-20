using Draven.ServerModels;
using Draven.Structures;

using RtmpSharp.Messaging;
using System;

namespace Draven.Messages.InventoryService
{
    using Draven.Structures.Platform.Summoner;

    //Not a typo
    class GetSumonerActiveBoosts : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            SummonerClient summonerSender = sender as SummonerClient;

            SummonerActiveBoostsDTO activeBoosts = new SummonerActiveBoostsDTO
            {
                SummonerID = Convert.ToInt32(summonerSender._sumId),
                IPBoostEndDate = 0.0,
                XPBoostEndDate = 0.0,
                IPBoostPerWinCount = 5,
                XPBoostPerWinCount = 5,
            };

            e.ReturnRequired = true;
            e.Data = activeBoosts;

            return e;
        }
    }
}
