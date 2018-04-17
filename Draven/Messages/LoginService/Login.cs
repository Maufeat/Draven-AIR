using Draven.ServerModels;
using Draven.Structures;
using Messages;
using RtmpSharp.Messaging;
using RtmpSharp.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Draven.Messages.LoginService
{
    class Login : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            object[] body = e.Body as object[];

            AuthenticationCredentials creds = body[0] as AuthenticationCredentials;
            
            //Console.WriteLine("Login von: " + creds.Username + " : " + creds.Password);
            
            RtmpClient client = sender as RtmpClient;
            SummonerClient newClient = new SummonerClient(client, creds.Username);

            Dictionary<string, string> Data = DatabaseManager.getAccountData(creds.Username, creds.Password);
            
            Dictionary<string, string> SummonerData = DatabaseManager.getSummonerData(Data["summonerId"]);

            
            Session session = new Session
            {
                Password = creds.Password,
                Summary = new AccountSummary
                {
                    AccountId = Convert.ToDouble(Data["id"]),
                    Username = creds.Username,
                    HasBetaAccess = true,
                    IsAdministrator = true,
                    PartnerMode = true,
                    NeedsPasswordReset = false
                },
                Token = creds.AuthToken
            };

            
            newClient.setSession(session);
            newClient._sumId = Convert.ToDouble(SummonerData["id"]);
            newClient._summonername = SummonerData["summonerName"];
            newClient._sumIcon = Convert.ToDouble(SummonerData["icon"]);
            newClient._IP = Convert.ToDouble(Data["IP"]);
            newClient._RP = Convert.ToDouble(Data["RP"]);

            e.ReturnRequired = true;
            e.Data = session;

            return e;
        }
    }
}
