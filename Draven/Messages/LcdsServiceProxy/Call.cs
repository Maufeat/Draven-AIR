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

            string payloader = "";
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
                case "getChampionMasteryScoreAndChest":
                    var scoreChest = new ScoreChestDTO
                    {
                        EarnableChests = 6,
                        MaximumChests = 6,
                        NextChestRechargeTime = 0,
                        Score = 100
                    };
                    payloader = JsonConvert.SerializeObject(scoreChest);
                    break;
                case "getAllChampionMasteries":
                    var championMasteryList = new List<ChampionMasteryDTO>();
                    foreach(var champion in DatabaseManager.getAllChampions())
                    {
                        var championMastery = new ChampionMasteryDTO
                        {
                            ChampionId = champion.ID,
                            ChampionLevel = 5,
                            ChampionPoints = 1000000,
                            ChestGranted = true,
                            HighestGrade = "I",
                            Score = 55555,
                            LastPlayTime = 0
                        };
                        championMasteryList.Add(championMastery);
                    }
                    payloader = JsonConvert.SerializeObject(championMasteryList);
                    Console.WriteLine(payloader);
                    break;
                case "getMasterLeagueTopX":
                case "getChallengerLeague":
                    List<object> payloadData = JsonConvert.DeserializeObject<List<object>>(body[3]);
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
                    break;
                case "getAllLeaguesForPlayer":
                    var allLeaguesForPlayer = new LeagueListDTO()
                    {
                        Name = "LeagueSandbox Is Master",
                        Entries = new List<LeagueItemDTO>
                        {
                            new LeagueItemDTO{
                                PlayerOrTeamId = summonerSender._accId.ToString(),
                                PlayerOrteamName = "Definitely Not Deudly",
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
                    };
                    payloader = JsonConvert.SerializeObject(allLeaguesForPlayer);
                    break;
                default:
                    Console.WriteLine("Unknown LcdsCall: " + body[1] + " : " + body[2] + " (" + body[3] + ")");
                    break;
            }

            LcdsServiceProxyResponse lspr = new LcdsServiceProxyResponse()
            {
                Payload = payloader,
                Status = "OK",
                MessageId = body[0],
                MethodName = body[2],
                ServiceName = body[1],
                CompressedPayload = compressed,
            };

            if (payloader != "")
                summonerSender._rtmpClient.InvokeDestReceive("cn-" + summonerSender._accId, "cn-" + summonerSender._accId, "messagingDestination", lspr);
            else
                Console.WriteLine("Empty payloader for: " + lspr.ServiceName + " : " + lspr.MethodName + "");

            e.ReturnRequired = true;
            e.Data = null;

            return e;
        }
    }
}