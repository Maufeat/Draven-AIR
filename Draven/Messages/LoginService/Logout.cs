using Draven.Structures;
using Messages;
using RtmpSharp.Messaging;

namespace Draven.Messages.LoginService
{
    class Logout : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            e.ReturnRequired = true;
            e.Data = null;

            return e;
        }
    }
}
