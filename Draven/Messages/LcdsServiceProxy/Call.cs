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

namespace Draven.Messages.LcdsServiceProxy
{
    class Call : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            List<string> body = JsonConvert.DeserializeObject<List<string>>(JsonConvert.SerializeObject(e.Body));
            SummonerClient summonerSender = sender as SummonerClient;

            dynamic payloader = "";
            string methodName = "";
            switch (body[2])
            {
                case "requestSelectedWardSkin":
                    payloader = new System.Collections.Generic.Dictionary<string, int>();
                    payloader.Add("selectedWardSkinId", 41);
                    methodName = "receiveSelectedWardSkin";

                    Console.WriteLine("Requested " + body[1] + " : " + body[2]);
                    break;
                case "getAllPlayerLoot":
                    payloader = new List<PlayerLootDTO>
                    {
                        new PlayerLootDTO
                        {
                            playerId = summonerSender._sumId,
                            lootName = "MATERIAL_key_fragment",
                            count = 999,
                            expiryTime = 0
                        }
                    };

                    Console.WriteLine("Requested " + body[1] + " : " + body[2]);
                    break;
                case "getAllQueries":
                    payloader = new QueryResultDTO
                    {
                        QueryToLootNames = ""
                    };

                    Console.WriteLine("Requested " + body[1] + " : " + body[2]);
                    break;
                case "getAllPlayerLootAndAllDefinitions":
                    payloader = new PlayerLootDefinitionsDTO
                    {
                        LootItemList = new LootItemListClientDTO() {
                            LootItems = new List<LootItemDTO>
                            {
                                new LootItemDTO
                                {
                                    LootName = "MATERIAL_key_fragment",
                                    Type = "MATERIAL",
                                    Value = 0,
                                    DisplayCategories = new List<string>()
                                    {
                                        ""
                                    },
                                    LootLocalName  = "MATERIAL_key_fragment"
                                }
                            }
                        },
                        PlayerLoot = new List<PlayerLootDTO>
                        {
                            new PlayerLootDTO
                            {
                                playerId = summonerSender._sumId,
                                lootName = "MATERIAL_key_fragment",
                                count = 999,
                                expiryTime = 0
                            }
                        },
                        RecipeList = new RecipeListClientDTO
                        {
                            Recipes = new List<RecipeClientDTO>
                            {
                                new RecipeClientDTO
                                {
                                    
                                }
                            }
                        }
                    };

                    Console.WriteLine("Requested " + body[1] + " : " + body[2]);
                    break;
                default:
                    payloader = null;
                    break;
            }
            LcdsServiceProxyResponse lspr = new LcdsServiceProxyResponse()
            {
                Payload = JsonConvert.SerializeObject(payloader),
                Status = "OK",
                MessageId = body[0],
                MethodName = body[2],
                ServiceName = body[1]
            };
            
            summonerSender._rtmpClient.InvokeDestReceive("cn-" + summonerSender._accId, "cn-" + summonerSender._accId, "messagingDestination", lspr);

            e.ReturnRequired = true;
            e.Data = null;

            return e;
        }
    }
}