using Draven.ServerModels;
using Draven.Structures;
using Messages;
using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System.Collections.Generic;

namespace Draven.Messages.SummonerIconService
{
    class GetSummonerIconInventory : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            SummonerClient summonerSender = sender as SummonerClient;
            SummonerIconInventoryDTO SummonerIconInventory = new SummonerIconInventoryDTO
            {
                SummonerId = int.MaxValue - 1,
                DateString = "Wed Apr 23 00:33:57 PDT 2014",
                SummonerIcons = new ArrayCollection
                {
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 554.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 555.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 556.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 557.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 558.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 559.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 560.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 561.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 562.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 563.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 564.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 565.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 566.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 567.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 568.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 569.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 570.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 571.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 572.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 573.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 574.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 593.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 594.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 595.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 596.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 597.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 598.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 599.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 600.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 601.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 602.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 607.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 608.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 609.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 610.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 611.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 612.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 613.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 614.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 615.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 616.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 617.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 618.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 619.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 620.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 621.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 622.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 623.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 624.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 625.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 626.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 627.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 628.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1000.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1001.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1002.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1003.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1004.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1005.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1006.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1007.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1008.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1009.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1010.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1011.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1012.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1013.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1014.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1015.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1016.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1017.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1018.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1019.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1020.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1021.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1022.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1023.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1024.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1025.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1026.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1027.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1028.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1029.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1030.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1031.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1032.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1033.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1034.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1035.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1036.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1037.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1038.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1039.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1040.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1041.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1042.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1043.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1044.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1045.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1046.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1047.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1048.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1049.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1050.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1051.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1052.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1053.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1054.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1055.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1056.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1057.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1058.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1059.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1060.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1061.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1062.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1063.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1064.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1065.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1066.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1067.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1068.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1069.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1070.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1071.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1072.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1073.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1074.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1075.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1076.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1077.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1078.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1079.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1080.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1081.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1082.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1083.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1084.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1085.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1086.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1087.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1088.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1089.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1090.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1091.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1092.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1093.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1094.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1095.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1096.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1097.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1098.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1099.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1100.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1101.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1102.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1103.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1104.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1105.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1106.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1107.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1108.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1109.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1110.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1111.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1112.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1113.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1114.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1115.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1116.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1117.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1118.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1119.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1120.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1121.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1122.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1123.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1124.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1125.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1126.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1127.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1128.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1129.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1130.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1132.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1133.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1134.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 1135.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 629.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 630.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 631.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 632.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 633.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 634.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 635.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 636.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 637.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 638.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 639.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 640.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 641.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 642.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 655.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 656.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 657.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 658.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 659.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 660.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 661.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 662.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 663.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 664.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 665.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 666.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 667.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 668.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 669.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 670.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 671.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 672.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 673.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 674.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 675.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 676.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 677.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 678.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 679.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 680.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 681.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 682.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 683.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 684.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 685.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 686.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 687.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 692.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 693.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 694.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 695.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 696.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 697.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 698.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 699.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 700.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 701.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 702.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 703.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 704.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 705.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 706.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 707.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 708.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 709.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 710.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 711.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 712.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 713.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 714.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 715.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 716.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 717.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 718.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 719.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 720.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 721.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 722.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 723.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 724.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 725.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 726.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 727.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 728.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 729.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 730.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 731.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 732.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 733.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 734.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 735.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 736.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 737.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 738.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 739.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 740.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 741.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 742.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 743.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 744.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 745.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 746.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 747.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 748.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 749.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 750.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 751.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 752.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 753.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 754.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 755.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 756.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 757.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 758.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 759.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 760.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 761.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 762.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 763.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 764.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 765.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 766.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 767.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 768.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 769.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 770.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 771.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 772.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 773.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 774.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 775.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 776.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 777.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 778.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 779.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 780.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 781.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 782.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 783.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 784.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 785.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 786.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 787.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 788.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 789.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 790.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 791.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 792.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 793.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 794.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 795.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 796.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 797.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 798.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 799.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 801.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 803.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 804.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 805.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 806.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 808.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 809.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 810.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 811.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 812.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 813.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 814.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 815.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 816.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 817.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 818.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 819.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 820.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 821.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 822.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 823.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 824.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 825.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 826.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 827.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 828.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 829.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 830.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 831.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 832.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 833.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 834.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 835.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 836.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 837.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 838.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 839.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 840.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 841.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 842.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 843.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 844.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 845.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 846.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 847.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 848.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 849.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 850.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 851.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 852.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 853.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 854.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 855.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 856.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 857.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 858.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 859.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 860.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 861.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 862.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 863.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 864.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 865.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 866.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 867.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 868.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 869.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 870.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 871.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 872.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 873.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 874.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 875.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 876.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 877.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 878.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 879.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 880.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 881.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 882.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 883.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 884.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 885.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 886.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 887.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 888.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 889.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 890.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 891.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 892.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 893.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 894.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 895.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 896.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 897.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 898.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 899.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 900.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 901.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 902.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 903.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 904.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 905.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 906.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 907.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 908.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 909.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 910.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 911.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 912.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 913.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 914.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 915.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 916.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 917.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 918.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 919.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 920.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 921.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 922.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 923.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 924.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 925.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 926.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 927.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 928.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 929.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 930.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 931.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 932.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 933.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 934.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 935.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 936.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 937.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 938.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 939.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 940.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 941.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 942.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 943.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 944.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 945.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 946.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 948.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 949.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 950.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 951.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 952.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 953.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 954.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 955.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 956.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 957.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 958.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 959.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 960.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 961.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 962.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 963.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 964.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 965.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 966.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 967.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 968.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 969.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 970.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 971.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 972.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 973.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 974.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 975.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 976.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 977.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 978.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 979.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 980.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 981.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 982.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 983.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 984.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 985.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 986.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 987.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 988.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 989.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 990.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 991.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 992.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 993.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 994.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 995.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 996.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 997.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 998.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    },
                    new SummonerIcon
                    {
                    Icon = new object(),
                    SummonerId = summonerSender._sumId,
                    IconId = 999.0,
                    PurchaseDate = "/Date(1383172733000)/"
                    }

                }
            };

            e.ReturnRequired = true;
            e.Data = SummonerIconInventory;

            return e;
        }
    }
}
