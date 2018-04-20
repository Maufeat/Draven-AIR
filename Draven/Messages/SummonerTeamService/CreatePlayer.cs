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
    using Draven.Structures.Team.DTO;

    class CreatePlayer : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            e.ReturnRequired = true;
            e.Data = new PlayerDTO()
            {
                PlayerId = 1,
                TeamsSummary = new ArrayCollection(),
                CreatedTeams = new ArrayCollection(),
                PlayerTeams = new ArrayCollection()
            };

            return e;
        }
    }
}
