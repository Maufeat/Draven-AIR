using System;
using Draven.Structures;
using RtmpSharp.Messaging;
using Messages;

namespace Draven.Messages.LoginService
{
    class GetStoreUrl : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            e.ReturnRequired = true;
            e.Data = "https://store.euw1.lol.riotgames.com/?account_id=207410902&original_account_id=207410902&original_platform_id=EUW1&token=ff91c765-ddc0-450c-816b-d48a27881dac";

            return e;
        }
    }
}
