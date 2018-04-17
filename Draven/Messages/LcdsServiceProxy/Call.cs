using RtmpSharp.Messaging;
using RtmpSharp.IO.AMF3;
using System.ComponentModel;
using Messages;
using Draven.ServerModels;
using System;
using Draven.Structures;

namespace Draven.Messages.LcdsServiceProxy
{
    class Call : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            object[] body = e.Body as object[];
            SummonerClient summonerSender = sender as SummonerClient;

            Console.WriteLine("["+ summonerSender._session.Summary.Username +"][0] : " + Convert.ToString(body[1]));
            Console.WriteLine("[" + summonerSender._session.Summary.Username + "][1] : " + Convert.ToString(body[2]));
            Console.WriteLine("[" + summonerSender._session.Summary.Username + "][2] : " + Convert.ToString(body[3]));
            //Console.WriteLine("[" + summonerSender._session.Summary.Username + "][3] : " + Convert.ToString(body[4]));

            dynamic payloader = "";
            string methodName = "";
            switch (Convert.ToString(body[1])){
                case "requestSelectedWardSkin":
                    payloader = new System.Collections.Generic.Dictionary<string, int>();
                    payloader.Add("selectedWardSkinId", 41);
                    methodName = "receiveSelectedWardSkin";
                    break;
                default:
                    payloader = null;
                    break;
            }
            LcdsServiceProxyResponse lspr = new LcdsServiceProxyResponse()
            {
                Payload = payloader,
                Status = "OK",
                MessageId = "message",
                MethodName = methodName,
                ServiceName = Convert.ToString(body[0])
            };
            
            summonerSender._rtmpClient.InvokeDestReceive("cn-" + summonerSender._rtmpClient.ClientId, "cn-" + summonerSender._rtmpClient.ClientId, "messagingDestination", lspr);

            e.ReturnRequired = true;
            e.Data = null;

            return e;
        }
    }
}