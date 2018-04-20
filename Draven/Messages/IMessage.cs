namespace Draven.Messages
{
    using RtmpSharp.Messaging;

    interface IMessage
    {
        RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e);
    }
}
