using Draven.Structures;

using RtmpSharp.Messaging;

namespace Draven.Messages.LoginService
{
    class PerformLCDSHeartBeat : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            e.ReturnRequired = true;
            e.Data = "5";

            return e;
        }
    }
}
