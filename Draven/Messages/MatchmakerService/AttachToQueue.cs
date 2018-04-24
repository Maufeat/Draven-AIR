using Draven.Structures;

using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System;
using System.Collections.Generic;

namespace Draven.Messages.MatchmakerService
{
    using Draven.Structures.Platform.Login.Matchmaking;
    using Draven.Structures.Platform.Matchmaking;
    using Newtonsoft.Json;

    class AttachToQueue: IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            Console.WriteLine(JsonConvert.SerializeObject(e.Body));

            SearchingForMatchNotification notification = new SearchingForMatchNotification
            {
                PlayerJoinFailures = new ArrayCollection
                {
                    new QueueDisabled
                    {
                        Message = "QUEUE_DISABLED",
                        QueueId = 1
                    }
                },
                GhostGameSummoners = new ArrayCollection(),
                JoinedQueues = new ArrayCollection()
            };

            e.ReturnRequired = true;
            e.Data = notification;

            return e;
        }
    }
}
