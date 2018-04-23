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
                SummonerId = summonerSender._sumId,
                DateString = "",
                BookPages = new ArrayCollection()
                    {
                        new MasteryBookPageDTO
                        {
                            Current = true,
                            SummonerId = summonerSender._sumId,
                            PageId = 1,
                            Name = "Mastery Page 1",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 2,
                            Name = "Mastery Page 2",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 3,
                            Name = "Mastery Page 3",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 4,
                            Name = "Mastery Page 4",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 5,
                            Name = "Mastery Page 5",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 6,
                            Name = "Mastery Page 6",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 7,
                            Name = "Mastery Page 7",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 8,
                            Name = "Mastery Page 8",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 9,
                            Name = "Mastery Page 9",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 10,
                            Name = "Mastery Page 10",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 11,
                            Name = "Mastery Page 11",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 12,
                            Name = "Mastery Page 12",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 13,
                            Name = "Mastery Page 13",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 14,
                            Name = "Mastery Page 14",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 15,
                            Name = "Mastery Page 15",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 16,
                            Name = "Mastery Page 16",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 17,
                            Name = "Mastery Page 17",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 18,
                            Name = "Mastery Page 18",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 19,
                            Name = "Mastery Page 19",
                            Entries = new ArrayCollection()
                        },
                        new MasteryBookPageDTO
                        {
                            Current = false,
                            SummonerId = summonerSender._sumId,
                            PageId = 20,
                            Name = "Mastery Page 20",
                            Entries = new ArrayCollection()
                        },
                    }
            };

            e.ReturnRequired = true;
            e.Data = MasteryBook;

            return e;
        }
    }
}
