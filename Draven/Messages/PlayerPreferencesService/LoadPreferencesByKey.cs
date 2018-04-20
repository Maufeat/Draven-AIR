using Draven.Structures;

using RtmpSharp.Messaging;

namespace Draven.Messages.PlayerPreferencesService
{
    class LoadPreferencesByKey : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            e.ReturnRequired = true;
            e.Data = null;

            return e;
        }
    }
}
