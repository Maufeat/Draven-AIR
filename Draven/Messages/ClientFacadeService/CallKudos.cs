using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draven.ServerModels;
using Newtonsoft.Json;
using RtmpSharp.IO;
using RtmpSharp.Messaging;

namespace Draven.Messages.ClientFacadeService
{
    class CallKudos : IMessage
    {
        [Serializable]
        [SerializedName("com.riotgames.platform.harassment.LcdsResponseString")]

        public class LcdsResponseString
        {
            [JsonProperty("value")]
            [SerializedName("value")]
            public String Value { get; set; }
        }

        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            SummonerClient summonerSender = sender as SummonerClient;

            int[] points = new int[4]{ 9, 9, 9, 9 };

            var obj = new Dictionary<string, int[]>
            {
                {
                    "totals",
                    new int[4] { 4, 4, 4, 4 }
                }
            };

            var res = new LcdsResponseString
            {
                Value = JsonConvert.SerializeObject(obj)
            };

            e.ReturnRequired = true;
            e.Data = res;

            return e;
        }
    }
}
