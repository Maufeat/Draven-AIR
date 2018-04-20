using Draven.ServerModels;

using RtmpSharp.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Messages.SummonerService
{
    using Draven.DatabaseManager;

    class UpdateProfileIconId : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            object[] body = e.Body as object[];
            SummonerClient summonerSender = sender as SummonerClient;
            int creds = Convert.ToInt32(body[0]);

            DatabaseManager.updateSummonerIconById((int)summonerSender._sumId, creds);

            e.ReturnRequired = true;
            e.Data = null;

            return e;
        }
    }
}
