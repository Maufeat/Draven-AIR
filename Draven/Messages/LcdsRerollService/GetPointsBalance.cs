using Draven.Structures;
using Messages;
using RtmpSharp.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Messages.LcdsRerollService
{
    class GetPointsBalance : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            e.ReturnRequired = true;
            e.Data = new PointSummary()
            {
                PointsToNextRoll = 106,
                MaxRolls = 2,
                NumberOfRolls = 0,
                PointsCostToRoll = 250,
                CurrentPoints = 144
            };

            return e;
        }
    }
}
