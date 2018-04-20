using Draven.Structures;

using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;

namespace Draven.Messages.InventoryService
{
    //Not a typo
    class GetOwnedWardSkin : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            ArrayCollection wards = new ArrayCollection() { 3, 41, 0 };

            e.ReturnRequired = true;
            e.Data = wards;

            return e;
        }
    }
}
