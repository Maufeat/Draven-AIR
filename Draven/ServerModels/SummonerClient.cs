using Draven.Structures;
using RtmpSharp.IO;
using RtmpSharp.Messaging;
using RtmpSharp.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Draven.ServerModels
{
    class SummonerClient
    {
        public double _sumId { get; set; }
        public double _accId { get; set; }

        public double _IP { get; set; }
        public double _RP { get; set; }

        public string _summonername { get; set; }
        public double _sumLvl { get; set; }
        public double _sumIcon { get; set;  }

        public Session _session { get; set; }
        public RtmpClient _rtmpClient;

        public SummonerClient(RtmpClient _rC, Session _s) {
            Program._connectedClients.Add(this);
            _rtmpClient = _rC;
            _session = _s;
            _rtmpClient.MessageReceived += _rtmpClient_MessageReceived;
            _rtmpClient.CallbackException += _rtmpClient_CallbackException;
            _rtmpClient.Disconnected += _rtmpClient_Disconnected;
            Console.WriteLine("[" + _session.Summary.Username + "] Connected1");
        }

        public SummonerClient(RtmpClient _rC, string _summonerName)
        {
            Program._connectedClients.Add(this);
            _rtmpClient = _rC;
            _rtmpClient.Disconnected += _rtmpClient_Disconnected;
            Console.WriteLine("[" + _summonerName + "] Connected2");
        }

        public void setSession(Session _s)
        {
            _session = _s;
        }

        private void _rtmpClient_Disconnected(object sender, EventArgs e)
        {
            Console.WriteLine("[" + _session.Summary.Username + "] Disconnected");
        }

        private void _rtmpClient_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            Console.WriteLine("[" + _session.Summary.Username + "] [Recieved]");
        }

        private void _rtmpClient_CallbackException(object sender, Exception e)
        {
            Console.WriteLine("[" + _session.Summary.Username + "] " + e.Message);
        }

    }
}
