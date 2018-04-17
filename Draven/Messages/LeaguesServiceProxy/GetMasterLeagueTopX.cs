using Draven.ServerModels;
using Draven.Structures;
using Messages;
using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Messages.LeaguesServiceProxy
{
    class GetMasterLeagueTopX : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            object[] body = e.Body as object[];
            SummonerClient summonerSender = sender as SummonerClient;
            string creds = Convert.ToString(body[0]);

            LeagueListDTO rData;

            switch (creds)
            {
                case "RANKED_SOLO_5x5":
                    rData = new LeagueListDTO()
                    {
                        Queue = "RANKED_SOLO_5x5",
                        Name = "Sahin The Master",
                        Tier = "MASTER",
                        RequestorsRank = "null",
                        Entries = new ArrayCollection()
                        {
                            new LeagueItemDTO()
                            {
                                PreviousDayLeaguePosition = 1,
                                SeasonEndTier = "MASTER",
                                SeasonEndRank = "I",
                                HotStreak = true,
                                LeagueName = "Sahin The Master",
                                MiniSeries = null,
                                Tier = "MASTER",
                                FreshBlood = true,
                                LastPlayed = 0,
                                TimeUntilInactivityStatusChanges = 0,
                                InactivityStatus = "OK",
                                PlayerOrTeamId = "1",
                                LeaguePoints = 9999,
                                DemotionWarning = 0,
                                Inactive = false,
                                SeasonEndApexPosition = 1,
                                Rank = "I",
                                Veteran = true,
                                QueueType = "RANKED_SOLO_5x5",
                                Losses = 0,
                                TimeUntilDecay = -1,
                                DisplayDecayWarning = false,
                                PlayerOrteamName = "Maufeat",
                                Wins = 999
                            }
                        },
                        NextApexUpdate = 7430971,
                        MaxLeagueSize = 200,
                        RequestorsName = null
                    };
                    break;
                case "RANKED_TEAM_3x3":
                    rData = new LeagueListDTO()
                    {
                        Queue = "RANKED_TEAM_3x3",
                        Name = "Riven\'s Zealots",
                        Tier = "MASTER",
                        RequestorsRank = "null",
                        Entries = new ArrayCollection()
                        {
                            new LeagueItemDTO()
                            {
                                PreviousDayLeaguePosition = 1,
                                SeasonEndTier = "MASTER",
                                SeasonEndRank = "I",
                                HotStreak = true,
                                LeagueName = "Riven\'s Zealots",
                                MiniSeries = null,
                                Tier = "MASTER",
                                FreshBlood = true,
                                LastPlayed = 0,
                                TimeUntilInactivityStatusChanges = 0,
                                InactivityStatus = "OK",
                                PlayerOrTeamId = "1",
                                LeaguePoints = 9999,
                                DemotionWarning = 0,
                                Inactive = false,
                                SeasonEndApexPosition = 1,
                                Rank = "I",
                                Veteran = true,
                                QueueType = "RANKED_TEAM_3x3",
                                Losses = 0,
                                TimeUntilDecay = -1,
                                DisplayDecayWarning = false,
                                PlayerOrteamName = "Magische Mießmuschel",
                                Wins = 999
                            }
                        },
                        NextApexUpdate = 7430971,
                        MaxLeagueSize = 50,
                        RequestorsName = null
                    };
                    break;
                case "RANKED_TEAM_5x5":
                    rData = new LeagueListDTO()
                    {
                        Queue = "RANKED_TEAM_5x5",
                        Name = "Talon\'s Warriors",
                        Tier = "MASTER",
                        RequestorsRank = "null",
                        Entries = new ArrayCollection()
                        {
                            new LeagueItemDTO()
                            {
                                PreviousDayLeaguePosition = 1,
                                SeasonEndTier = "CHALLENGER",
                                SeasonEndRank = "I",
                                HotStreak = true,
                                LeagueName = "Talon\'s Warriors",
                                MiniSeries = null,
                                Tier = "MASTER",
                                FreshBlood = true,
                                LastPlayed = 0,
                                TimeUntilInactivityStatusChanges = 0,
                                InactivityStatus = "OK",
                                PlayerOrTeamId = "1",
                                LeaguePoints = 9999,
                                DemotionWarning = 0,
                                Inactive = false,
                                SeasonEndApexPosition = 1,
                                Rank = "I",
                                Veteran = true,
                                QueueType = "RANKED_TEAM_5x5",
                                Losses = 0,
                                TimeUntilDecay = -1,
                                DisplayDecayWarning = false,
                                PlayerOrteamName = "Magische Mießmuschel 5x5",
                                Wins = 999
                            }
                        },
                        NextApexUpdate = 7430971,
                        MaxLeagueSize = 50,
                        RequestorsName = null
                    };
                    break;
                default:
                    rData = null;
                    break;
            }

            e.ReturnRequired = true;
            e.Data = rData;

            return e;
        }
    }
}
