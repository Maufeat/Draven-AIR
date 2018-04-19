using RtmpSharp.Messaging;
using RtmpSharp.IO.AMF3;
using System.ComponentModel;
using Messages;
using Draven.ServerModels;
using System;
using Draven.Structures;
using Newtonsoft.Json;
using System.Collections.Generic;
using RtmpSharp.IO;
using Newtonsoft.Json.Serialization;

namespace Draven.Messages.LcdsServiceProxy
{
    class Call : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            List<string> body = JsonConvert.DeserializeObject<List<string>>(JsonConvert.SerializeObject(e.Body));
            SummonerClient summonerSender = sender as SummonerClient;

            string payloader = "{}";
            bool compressed = false;

            switch (body[2])
            {
                case "getAllPlayerLoot":
                    var allPlayerLoot = new List<PlayerLootDTO>
                    {
                            new PlayerLootDTO
                            {
                                playerId = summonerSender._sumId,
                                lootName = "MATERIAL_key",
                                count = 99,
                                expiryTime = 0
                            },
                            new PlayerLootDTO
                            {
                                playerId = summonerSender._sumId,
                                lootName = "CURRENCY_champion",
                                count = 99999,
                                expiryTime = 0
                            },
                            new PlayerLootDTO
                            {
                                playerId = summonerSender._sumId,
                                lootName = "MATERIAL_key_fragment",
                                count = 99999,
                                expiryTime = 0
                            },
                            new PlayerLootDTO
                            {
                                playerId = summonerSender._sumId,
                                lootName = "CURRENCY_cosmetic",
                                count = 99999,
                                expiryTime = 0
                            }
                    };
                    payloader = JsonConvert.SerializeObject(allPlayerLoot);
                    break;
                case "getAllQueries":
                    var allQueries = new QueryResultDTO
                    {
                        QueryToLootNames = ""
                    };
                    payloader = JsonConvert.SerializeObject(allQueries);
                    break;
                case "getAllPlayerLootAndAllDefinitions":
                    var allPlayerLootAndAllDefinitions = new PlayerLootDefinitionsDTO
                    {
                        LootItemList = new LootItemListClientDTO() {
                            LootItems = new List<LootItemDTO>
                            {
                                new LootItemDTO
                                {
                                    LootName = "CHEST_72",
                                    DisplayCategories = new List<string>{ "ALL", "CHEST" },
                                    ExpiryTime = 0,
                                    RentalGames = 0,
                                    RentalSeconds = 0,
                                    StoreItemId = 7,
                                    Tags = "",
                                    Type = "LootItemDTO",
                                    UpgradeLootName = "CHEST_72_open",
                                    Value = 1,
                                    Rarity = "DEFAULT",
                                    LootLocalName = ""
                                }
                            },
                            LastUpdate = 0
                        },
                        PlayerLoot = new List<PlayerLootDTO>
                        {
                            new PlayerLootDTO
                            {
                                playerId = summonerSender._sumId,
                                lootName = "MATERIAL_key",
                                count = 99,
                                expiryTime = 0
                            },
                            new PlayerLootDTO
                            {
                                playerId = summonerSender._sumId,
                                lootName = "CURRENCY_champion",
                                count = 99999,
                                expiryTime = 0
                            },
                            new PlayerLootDTO
                            {
                                playerId = summonerSender._sumId,
                                lootName = "CURRENCY_cosmetic",
                                count = 99999,
                                expiryTime = 0
                            }
                        },
                        RecipeList = new RecipeListClientDTO
                        {
                            Recipes = new List<RecipeClientDTO>
                            {
                                new RecipeClientDTO
                                {
                                    DisplayCategories = new List<string>{ "ALL", "CHEST" },
                                    Outputs = new List<RecipeOutputDTO>
                                    {
                                    },
                                    RecipeName = "CHEST_72_open",
                                    Slots = new List<RecipeSlotDTO>
                                    {
                                        new RecipeSlotDTO
                                        {
                                            Query = "CHEST_72",
                                            SlotNumber = 1,
                                            QuantityExpression = ""
                                        }
                                    },
                                    Type = "CHEST"
                                }
                            },
                            LastUpdate = 0
                        }
                    };
                    payloader = JsonConvert.SerializeObject(allPlayerLootAndAllDefinitions);
                    break;
                case "getChallengerLeague":
                    List<object> payloadData = JsonConvert.DeserializeObject<List<object>>(body[3]);
                    Console.WriteLine(payloadData[0].ToString());
                    var challengerLeague = new LeagueListDTO()
                    {
                        Name = "LeagueSandbox Is Master",
                        Entries = new List<LeagueItemDTO>
                        {
                            new LeagueItemDTO{
                                PlayerOrTeamId = summonerSender._accId.ToString(),
                                PlayerOrteamName = "Definitely Not Deudly",
                                LeagueName = "LeagueSandbox Is Master",
                                QueueType = payloadData[0].ToString(),
                                Tier = "CHALLENGER",
                                Rank = "I",
                                LeaguePoints = 1337,
                                PreviousDayLeaguePosition = 5,
                                Wins = 999,
                                Losses = 0,
                                LastPlayed = 0,
                                TimeUntilDecay = -1,
                                InactivityStatus = "OK",
                                TimeUntilInactivityStatusChanges = 0,
                                TimeLastDecayMessageShown = 0,
                                DisplayDecayWarning = false,
                                DemotionWarning = 0,
                                SeasonEndTier = "CHALLENGER",
                                SeasonEndRank = "I",
                                SeasonEndApexPosition = 1,
                                Veteran = true,
                                FreshBlood = true,
                                Inactive = false,
                                HotStreak = true
                            }
                        },
                        Tier = "CHALLENGER",
                        Queue = payloadData[0].ToString(),
                        RequestorsRank = "null",
                        NextApexUpdate = 84365595,
                        MaxLeagueSize = 200
                    };
                    payloader = JsonConvert.SerializeObject(challengerLeague);
                    //payloader = "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";
                    //compressed = true;
                    break;
                case "getAllLeaguesForPlayer":
                    var allLeaguesForPlayer = new SummonerLeaguesDTO
                    {   
                        SummonerLeagues = new List<LeagueListDTO>
                        {
                            new LeagueListDTO()
                            {
                                Name = "LeagueSandbox Is Master",
                                Entries = new List<LeagueItemDTO>
                                {
                                    new LeagueItemDTO{
                                        PlayerOrTeamId = summonerSender._sumId.ToString(),
                                        PlayerOrteamName = "Maufeat",
                                        LeagueName = "LeagueSandbox Is Master",
                                        QueueType = "RANKED_SOLO_5x5",
                                        Tier = "CHALLENGER",
                                        Rank = "I",
                                        LeaguePoints = 1337,
                                        PreviousDayLeaguePosition = 5,
                                        Wins = 999,
                                        Losses = 0,
                                        LastPlayed = 0,
                                        TimeUntilDecay = -1,
                                        InactivityStatus = "OK",
                                        TimeUntilInactivityStatusChanges = 0,
                                        TimeLastDecayMessageShown = 0,
                                        DisplayDecayWarning = false,
                                        DemotionWarning = 0,
                                        SeasonEndTier = "CHALLENGER",
                                        SeasonEndRank = "I",
                                        SeasonEndApexPosition = 1,
                                        Veteran = true,
                                        FreshBlood = true,
                                        Inactive = false,
                                        HotStreak = true
                                    }
                                },
                                Tier = "CHALLENGER",
                                Queue = "RANKED_SOLO_5x5",
                                RequestorsRank = "null",
                                NextApexUpdate = 84365595,
                                MaxLeagueSize = 200
                            }
                        }
                    };
                    
                    payloader = JsonConvert.SerializeObject(allLeaguesForPlayer);
                    break;
                default:
                    Console.WriteLine("Unknown LcdsCall: " + body[1] + " : " + body[2] + " (" + body[3] + ")");
                    break;
            }

            Console.WriteLine("(cn-" + summonerSender._accId + " | "+ body[2] +") Send LSPR: " + payloader);

            LcdsServiceProxyResponse lspr = new LcdsServiceProxyResponse()
            {
                Payload = payloader,
                Status = "OK",
                MessageId = body[0],
                MethodName = body[2],
                ServiceName = body[1],
                CompressedPayload = compressed,
            };

            summonerSender._rtmpClient.InvokeDestReceive("cn-" + summonerSender._accId, "cn-" + summonerSender._accId, "messagingDestination", lspr);

            e.ReturnRequired = true;
            e.Data = null;

            return e;
        }
    }
}