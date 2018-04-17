using RtmpSharp.Messaging;

namespace Messages
{
    interface IMessage
    {
        RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e);
    }
}
