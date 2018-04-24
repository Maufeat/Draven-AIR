using Draven.ServerModels;
using Draven.Structures;

using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Messages.SummonerService
{
    using Draven.Structures.Platform.Summoner;
    using Newtonsoft.Json;

    class GetAllSummonerDataByAccount : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            object[] body = e.Body as object[];
            SummonerClient summonerSender = sender as SummonerClient;
            int creds = Convert.ToInt32(body[0]);

            AllSummonerData allSD = new AllSummonerData()
            {
                SummonerDefaultSpells = new SummonerDefaultSpells()
                {
                    SummonerId = summonerSender._sumId,
                    SpellDefault1 = new ArrayCollection(),
                    SpellDefault2 = new ArrayCollection()
                },
                SummonerTalentsAndPoints = new SummonerTalentsAndPoints()
                {
                    TalentPoints = 30,
                    ModifyDate = new DateTime(2016, 08, 11, 12, 00, 00),
                    CreateDate = new DateTime(2016, 08, 11, 12, 00, 00),
                    SummonerId = summonerSender._sumId
                },
                Summoner = new Summoner()
                {
                    InternalName = summonerSender._session.Summary.Username,
                    PreviousSeasonHighestTier = "CHALLENGER",
                    PreviousSeasonHighestTeamReward = 5,
                    AcctId = summonerSender._accId,
                    HelpFlag = false,
                    SumId = summonerSender._sumId,
                    ProfileIconId = Convert.ToInt32(summonerSender._sumIcon),
                    DisplayEloQuestionaire = false,
                    LastGameDate = new DateTime(2016, 08, 11, 12, 00, 00),
                    RevisionDate = new DateTime(2016, 08, 11, 12, 00, 00),
                    AdvancedTutorialFlag = false,
                    RevisionId = 1,
                    Name = summonerSender._summonername,
                    NameChangeFlag = false,
                    TutorialFlag = false,
                    SummonerId = summonerSender._sumId
                },
                SummonerLevel = new SummonerLevel
                {
                    ExpTierMod = 1.0,
                    SummonerTier = 5.0,
                    InfTierMod = 1.0,
                    ExpToNextLevel = 32651,
                    Level = 30.0
                },
                SummonerLevelAndPoints = new SummonerLevelAndPoints
                {
                    InfPoints = 0,
                    ExpPoints = 32651,
                    SummonerId = summonerSender._sumId,
                    SummonerLevel = 30
                },
                SpellBook = new SpellBookDTO
                {
                    SummonerId = summonerSender._sumId,
                    DateString = "Wed Jul 17 23:05:42 PDT 2013",
                    BookPages = new ArrayCollection
                                {
                                    new SpellBookPageDTO
                                    {
                                        Current = true,
                                        SummonerId = summonerSender._sumId,
                                        PageId = 2.0,
                                        CreateDate = DateTime.Now,
                                        Name = "Rune Page 1",
                                        SlotEntries = new ArrayCollection()
                                    },
                                    new SpellBookPageDTO
                                    {
                                        Current = false,
                                        SummonerId = summonerSender._sumId,
                                        PageId = 3.0,
                                        CreateDate = DateTime.Now,
                                        Name = "Rune Page 2",
                                        SlotEntries = new ArrayCollection()
                                    }
                                }
                },

            };

            Console.WriteLine(JsonConvert.SerializeObject(allSD));

            e.ReturnRequired = true;
            e.Data = allSD;
            return e;
        }
    }
}
