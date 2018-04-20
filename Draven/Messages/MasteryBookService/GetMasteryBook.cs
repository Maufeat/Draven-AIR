using Draven.ServerModels;
using Draven.Structures;

using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System.Collections.Generic;

namespace Draven.Messages.MasteryBookService
{
    using Draven.Structures.Platform.Summoner;

    class GetMasteryBook : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            SummonerClient summonerSender = sender as SummonerClient;

            MasteryBookDTO MasteryBook = new MasteryBookDTO
            {
                SummonerId = int.MaxValue - 1,
                DateString = "Wed Apr 23 00:33:57 PDT 2014",
                BookPages = new ArrayCollection()
                {
                    new MasteryBookPageDTO
                    {
                        Current = true,
                        SummonerId = summonerSender._sumId,
                        PageId = 1,
                        Name = "Mastery Page 1",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 2,
                        Name = "Mastery Page 2",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 3,
                        Name = "Mastery Page 3",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 4,
                        Name = "Mastery Page 4",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 5,
                        Name = "Mastery Page 5",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 6,
                        Name = "Mastery Page 6",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 7,
                        Name = "Mastery Page 7",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 8,
                        Name = "Mastery Page 8",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 9,
                        Name = "Mastery Page 9",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 10,
                        Name = "Mastery Page 10",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 11,
                        Name = "Mastery Page 11",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 12,
                        Name = "Mastery Page 12",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 13,
                        Name = "Mastery Page 13",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 14,
                        Name = "Mastery Page 14",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 15,
                        Name = "Mastery Page 15",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 16,
                        Name = "Mastery Page 16",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 17,
                        Name = "Mastery Page 17",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 18,
                        Name = "Mastery Page 18",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 19,
                        Name = "Mastery Page 19",
                        TalentEntries = new ArrayCollection()
                    },
                    new MasteryBookPageDTO
                    {
                        Current = false,
                        SummonerId = summonerSender._sumId,
                        PageId = 20,
                        Name = "Mastery Page 20",
                        TalentEntries = new ArrayCollection()
                    },
                }
            };

            e.ReturnRequired = true;
            e.Data = MasteryBook;

            return e;
        }
    }
}
