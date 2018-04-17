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
        private string ObjectToXml(object output)
        {
            string objectAsXmlString;

            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(output.GetType());
            using (System.IO.StringWriter sw = new System.IO.StringWriter())
            {
                try
                {
                    xs.Serialize(sw, output);
                    objectAsXmlString = sw.ToString();
                }
                catch (Exception ex)
                {
                    objectAsXmlString = ex.ToString();
                }
            }

            return objectAsXmlString;
        }

        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            MatchMakerParams mmp = e.Body as MatchMakerParams;

            foreach(var x in mmp.QueueIds)
            {
                Console.WriteLine(x);
            }
            
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
