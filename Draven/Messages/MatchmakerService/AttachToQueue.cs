using Draven.Structures;
using Messages;
using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System;
using System.Collections.Generic;

namespace Draven.Messages.MatchmakerService
{
    class AttachToQueue: IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            MatchMakerParams obj2 = e.Body as MatchMakerParams;
            foreach (var obj in obj2.QueueIDs)
                Console.WriteLine(obj);

            SearchingForMatchNotification notification = new SearchingForMatchNotification
            {
                JoinedQueues = new ArrayCollection
                {
                    new QueueInfo
                    {
                        WaitTime = 5000,
                        QueueID = 65,
                        QueueLength = 5000
                    }
                }
            };

            e.ReturnRequired = true;
            e.Data = notification;

            return e;
        }
    }
}
