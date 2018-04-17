using Draven.ServerModels;
using Draven.Structures;
using Messages;
using Newtonsoft.Json;
using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System.Collections.Generic;
using System.Net;

namespace Draven.Messages.SummonerIconService
{
    class GetSummonerIconInventory : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            SummonerClient summonerSender = sender as SummonerClient;
            SummonerIconInventoryDTO SummonerIconInventory = new SummonerIconInventoryDTO
            {
                SummonerId = int.MaxValue - 1,
                DateString = "Wed Apr 23 00:33:57 PDT 2014",
                SummonerIcons = new ArrayCollection()
            };
            
            foreach (var iconData in DatabaseManager.ProfileIcons)
            {
                var iconDto = new SummonerIcon
                {
                    Icon = new object(),
                    SummonerId = summonerSender._sumLvl,
                    IconId = iconData,
                    PurchaseDate = "/Date(1383172733000)/"
                };
                SummonerIconInventory.SummonerIcons.Add(iconDto);
            }

            e.ReturnRequired = true;
            e.Data = SummonerIconInventory;

            return e;
        }
    }
}
