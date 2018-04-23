using Draven.Structures;

using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Messages.SummonerTeamService
{
    using Draven.ServerModels;
    using Draven.Structures.Team.DTO;

    class CreatePlayer : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            SummonerClient summonerSender = sender as SummonerClient;

            e.ReturnRequired = true;
            e.Data = new PlayerDTO()
            {
                PlayerId = Convert.ToInt64(summonerSender._sumId),
                TeamsSummary = new ArrayCollection(),
                CreatedTeams = new ArrayCollection(),
                PlayerTeams = new ArrayCollection()
            };

            return e;
        }
    }
}
