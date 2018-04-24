using Draven.ServerModels;
using Draven.Structures.Platform.GameInvite;
using Newtonsoft.Json;
using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System;
using System.Collections.Generic;

namespace Draven.Messages.LcdsGameInvitationService
{
    class CreateGroupFinderLobby : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            SummonerClient summonerClient = sender as SummonerClient;

            var payload = new LobbyStatus
            {
                Owner = new InvitationPlayer
                {
                    SummonerId = 1,
                    SummonerName = "Maufeat",
                },
                Members = new ArrayCollection
                {
                    new Member
                    {
                        SummonerId = 1,
                        SummonerName = "Maufeat",
                        HasDelegatedInvitePower = false
                    }
                },
                Invitees = new ArrayCollection
                {
                },
                InvitationId = "",
                GameMetaData = "{\"mapId\":11,\"gameMode\":\"CLASSIC\",\"gameMutators\":[],\"gameType\":\"NORMAL_GAME\",\"queueId\":2,\"isRanked\":false,\"gameId\":1,\"groupFinderId\":\"00000000-0000-0000-0000-000000000000\",\"gameTypeConfigId\":18}",
            };

            e.ReturnRequired = true;
            e.Data = payload;

            return e;
        }
    }
}
