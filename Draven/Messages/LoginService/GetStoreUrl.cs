using System;
using Draven.Structures;
using RtmpSharp.Messaging;

namespace Draven.Messages.LoginService
{
    class GetStoreUrl : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            e.ReturnRequired = true;
            e.Data = "http://127.0.0.1:8080/";

            return e;
        }
    }
}
