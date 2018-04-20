using Draven.Messages;
using Draven.Redirector;
using Draven.ServerModels;
using Draven.Structures;
using Newtonsoft.Json;
using RtmpSharp.IO;
using RtmpSharp.Messaging;
using RtmpSharp.Messaging.Messages;
using RtmpSharp.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Draven
{
    using Draven.Certificate;
    using Draven.Structures.Platform.Client;

    public static class Program
    {
        //Console
        private static string Header1 = "Draven v0.0.1 - Based on Poro from Snowl";
        private static string Header2 = "http://www.VoliBot.com/FORUM";
        private static string Header3 = "JOIN THE COMMUNITY";

        //Database
        public static string host = "127.0.0.1";
        public static string user = "root";
        public static string pass = "";
        public static string database = "lol";

        //Server
        private static AuthServer.AuthServer _auth;
        private static SerializationContext _context;
        private static RtmpServer _server;
        private static MessageHandler _handler;
        private static PropertyRedirector _redirector;

        public static List<SummonerClient> _connectedClients = new List<SummonerClient>();

        //Settings
        public static string RTMPSHost = "127.0.0.1";
        public static int RTMPSPort = 2099;
        public static string LeagueDrive = "C:/";
        public static string[] AuthLocations = new string[] { "http://127.0.0.1:8080/" };

        static void Main(string[] args)
        {
            Console.Title = "Draven";
            printHeader();

            if (!DatabaseManager.DatabaseManager.InitConnection())
            {
                Console.WriteLine("[ERR] Press any Key to exit... (Check your Database Connection)");
                Console.ReadKey();
                return;
            }

            //DatabaseManager.InitMasteryAndRuneTree();
            DatabaseManager.DatabaseManager.InitProfileIcons();

            //Create the Authentication Server to handle login requests and client page
            _auth = new AuthServer.AuthServer(AuthServer.AuthServer.HandleWebServ, AuthLocations);
            
            //Load the certificate store for the RTMPS server
            var certificateStore = new X509Store(StoreName.TrustedPeople, StoreLocation.LocalMachine);
            certificateStore.Open(OpenFlags.MaxAllowed);

            //Remove last certificate in case it wasn't deleted on close
            foreach (var cert in certificateStore.Certificates)
            {
                if (cert.IssuerName.Name == $"CN={RTMPSHost}")
                {
                    certificateStore.Remove(cert);
                }
            }

            //Generate new certificate for this run and add it to the store.
            var _rtmpsCert = CertGen.CreateSelfSignedCertificate(RTMPSHost);
            certificateStore.Add(_rtmpsCert);
            certificateStore.Close();
            /**/
            //Generate the SerializationContext
            _context = new SerializationContext();
            var structures = Assembly.GetExecutingAssembly().GetTypes().Where(x => String.Equals(x.Namespace, "Draven.Structures", StringComparison.Ordinal));

            foreach (Type ObjectType in structures)
                _context.Register(ObjectType);

            //Create the RTMPS server with the context and certificate
            _server = new RtmpServer(new IPEndPoint(IPAddress.Parse(RTMPSHost), RTMPSPort), _context, _rtmpsCert);
            _server.ClientCommandReceived += ClientCommandReceieved;
            _server.ClientMessageReceived += ClientMessageReceived;

            //Set up the handler
            _handler = new MessageHandler();
            _handler.Register("LoginService");
            _handler.Register("MatchmakerService");
            _handler.Register("ClientFacadeService");
            _handler.Register("InventoryService");
            _handler.Register("MasteryBookService");
            _handler.Register("SummonerRuneService");
            _handler.Register("PlayerPreferencesService");
            _handler.Register("LcdsGameInvitationService");
            _handler.Register("LeaguesServiceProxy");
            _handler.Register("SummonerIconService");
            _handler.Register("LcdsServiceProxy");
            _handler.Register("SummonerService");
            _handler.Register("LcdsRerollService");
            _handler.Register("SummonerTeamService");
            _handler.Register("PlayerStatsService");

            //Set up the property redirector
            _redirector = new PropertyRedirector();

            Console.WriteLine("[LOG] AuthServer listening on port 8080");
            _auth.Start();

            Console.WriteLine("[LOG] RTMPS Server listening at rtmps://{0}:{1}", RTMPSHost, RTMPSPort);
            _server.Listen();
            while (true) { }
        }

        internal static byte[] ReadFile(string fileName)
        {
            FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int size = (int)f.Length;
            byte[] data = new byte[size];
            size = f.Read(data, 0, size);
            f.Close();
            return data;
        }
        static void ClientMessageReceived(object sender, RemotingMessageReceivedEventArgs e)
        {
            try
            {
                RemotingMessageReceivedEventArgs tempRecv = null;
                if (e.Operation == "login") tempRecv = _handler.Handle(sender, e);

                RtmpClient client = sender as RtmpClient;
                SummonerClient targetSummoner = _connectedClients.FirstOrDefault(tSum => tSum._rtmpClient.ClientId == client.ClientId);

                if (e.Operation != "login") tempRecv = _handler.Handle(targetSummoner, e);

                LogRequest(tempRecv, e, targetSummoner);
                e = tempRecv;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        static void LogRequest(RemotingMessageReceivedEventArgs tempRecv, RemotingMessageReceivedEventArgs e, SummonerClient sc)
        {
            if (tempRecv == null)
                Console.WriteLine(string.Format("[LOG][{2}] Bad request for {0} : {1}", e.Operation, e.Destination, sc._session.Summary.Username));
            else
                Console.WriteLine(string.Format("[LOG][{2}] Request for {0} : {1}", e.Operation, e.Destination, sc._session.Summary.Username));
        }

        static void ClientCommandReceieved(object sender, CommandMessageReceivedEventArgs e)
        {
            RtmpClient client = sender as RtmpClient;
            SummonerClient targetSummoner = _connectedClients.FirstOrDefault<SummonerClient>(tSum => client.ClientId == tSum._rtmpClient.ClientId);
            
            if (e.Message.Operation == CommandOperation.Login)
            {
                var configData = new Dictionary<string, dynamic>
                {
                    {
                        "Chroma",
                        new Dictionary<string, dynamic>
                        {
                            {
                                "IsEnabled",
                                true
                            }
                        }
                    },
                    {
                        "LootConfig",
                        new Dictionary<string, dynamic>
                        {
                            {
                                "NewPlayerChestEnabled",
                                true
                            },
                            {
                                "Enabled",
                                true
                            },
                            {
                                "PurchaseChestsEnabled",
                                true
                            },
                            {
                                "MinSummonerLevel",
                                5
                            },
                            {
                                "Visible",
                                true
                            },
                            {
                                "NoRefundConfirmationEnabled",
                                true
                            },
                            {
                                "EventChestsEnabled",
                                true
                            },
                        }
                    },
                    {
                        "ChampionMasteryConfig",
                        new Dictionary<string, dynamic>
                        {
                            {
                                "Enabled",
                                true
                            },
                            {
                                "MinSummonerLevel",
                                5
                            },
                            {
                                "EndOfGameEnabled",
                                true
                            },
                            {
                                "SupportedQueueTypes",
                                "RANKED_SOLO_5x5,RANKED_TEAM_5x5,CAP_5x5,NORMAL,RANKED_PREMADE_3x3,RANKED_PREMADE_5x5,RANKED_TEAM_3x3,NORMAL_3x3,ARAM_UNRANKED_5x5,ASCENSION,KING_PORO"
                            },
                            {
                                "MaxChampionLevel",
                                5
                            },
                            {
                                "LootChestsEnabled",
                                true
                            },
                            {
                                "ShowGradeAvailablePopup",
                                true
                            },
                            {
                                "ChampionPointQueueTypes",
                                "RANKED_SOLO_5x5,RANKED_TEAM_5x5,CAP_5x5,NORMAL,KING_PORO,ASCENSION"
                            },
                            {
                                "GradeEnabled",
                                true
                            },
                            {
                                "CapUnlockChampionLevel",
                                4
                            }
                        }
                    },
                    {
                        "ProfileHoverCard",
                        new Dictionary<string, dynamic>
                        {
                            {
                                "ACSLookup",
                                true
                            },
                            {
                                "IsEnabledForBuddyPanelView",
                                true
                            },
                            {
                                "CreateStringConfiguration",
                                null
                            },
                            {
                                "IsEnabledForSummonerQuickView",
                                true
                            },
                            {
                                "IsEnabledForClubChatParticipants",
                                true
                            },
                            {
                                "IsEnabledForGameLobbySuggestedPlayers",
                                true
                            },
                            {
                                "IsEnabledForGroupFinderCapViewSuggestedPlayers",
                                true
                            },
                            {
                                "IsEnabledForChatFriendsList",
                                true
                            },
                            {
                                "IsEnabledForChatGroupChatParticipants",
                                true
                            },
                            {
                                "IsEnabled",
                                true
                            },
                            {
                                "ChampionMasteryLookup",
                                true
                            },
                            {
                                "LeagueLookup",
                                true
                            },
                            {
                                "IsEnabledForCustomGameLobby",
                                true
                            },
                            {
                                "IsEnabledForTeamBuilderSuggestedPlayers",
                                true
                            }
                        }
                    }
                };
                //Console.WriteLine(JsonConvert.SerializeObject(configData));
                ClientDynamicConfigurationNotification clientConfig = new ClientDynamicConfigurationNotification
                {
                    Delta = false,
                    //Config = JsonConvert.SerializeObject(configData)
                    //TODO: not have this data stored in code
                    Config = "{\"Chroma\":{\"IsEnabled\":true},\"LcuAlphaShutdown\":{\"Countdown\":15,\"Enabled\":true},\"Masteries\":{\"ShowPointsResetMessage\":false},\"DisabledChampion\":{\"ODINBOT-5x5\":null},\"PlatformShutdown\":{\"Enabled\":false},\"BotConfigurations\":{\"IntermediateInCustoms\":true},\"ShareMatchHistory\":{\"MatchHistoryUrlTemplate\":\"http://matchhistory.euw.leagueoflegends.com/{2}/#login?redirect=%23player-search%2FcurrentAccount%2FEUW1%2F{0}\",\"AdvancedGameDetailsUrlTemplate\":\"http://matchhistory.euw.leagueoflegends.com/{2}/#match-details/EUW1/{0}/{1}/eog\",\"AdvancedGameDetailsEnabled\":false,\"MatchDetailsUrlTemplate\":\"http://matchhistory.euw.leagueoflegends.com/{2}/#match-details/EUW1/{0}/{1}\",\"ShareEndOfGameEnabled\":true,\"ShareGameUrlTemplate\":\"http://matchhistory.euw.leagueoflegends.com/{2}/#match-details/EUW1/{0}/{1}/eog\",\"MatchHistoryEnabled\":true},\"CustomGame\":{\"BotsAvailableInAram\":false},\"GuestSlots\":{\"Enabled\":null},\"ServiceStatusAPI\":{\"Enabled\":true},\"FriendRecommendations\":{\"FaqLink\":\"http://euw.leagueoflegends.com/{0}/page/features/faq-add-friends\",\"StatusExpiryMillis\":300000,\"EnableAddFriendButton\":true,\"EnabledPercent\":100,\"ShowToolTip\":true,\"RegistrationPollRateMillis\":5000,\"HideFriends\":false,\"PlayerLevelForNewNotification\":5,\"RegistrationPollDurationMillis\":300000,\"ContactsUrlTemplate\":\"https://recofriender.leagueoflegends.com/v1/contacts/{0}/{1}\",\"ContactDetailsUrlTemplate\":\"https://recofriender.leagueoflegends.com/v1/contactdetails/{0}/{1}/{2}/\",\"AssociationUrlTemplate\":\"https://recofriender.leagueoflegends.com/v1/facebook-oauth?locale={0}\",\"EnableViewAllPanel\":true,\"UnlinkUrlTemplate\":\"https://recofriender.leagueoflegends.com/v1/facebook-oauth/unlink/{0}/{1}\",\"UseNativeFacebookPop\":false},\"GameTimerSync\":{\"Enabled\":false,\"PercentOfTotalTimerToSyncAt\":0.8},\"DockedPrompt\":{\"EnabledNewDockedPromptRenderer\":true},\"QueueRestriction\":{\"ServiceEnabled\":true,\"RankedDuoQueueRestrictionMode\":\"TIER\",\"RankedLowSkillRestrictionMaxDelta\":1,\"KarmaEnabled\":true,\"RankedDuoQueueRestrictionMaxDelta\":1,\"RankedHighSkillLowestTier\":\"DIAMOND\",\"RankedLowSkillRestrictionMode\":\"TIER\",\"RankedHighSkillRestrictionMaxDelta\":2,\"RankedHighSkillRestrictionMode\":\"RANK\",\"RankedDuoQueueDefaultUnseededTier\":\"SILVER\"},\"PartyRewards\":{\"Enabled\":false,\"GameFlowVisualUpdate\":false},\"QueueImages\":{\"OverrideQueueImage\":true},\"PlayerFeedbackTool\":{\"BackendUrl\":\"\"},\"TeamBoost\":{\"RandomSkinEnabled\":\"ON\",\"AllSkinEnabled\":\"OFF\"},\"SuggestedPlayers\":{\"HonoredPlayersLimit\":4,\"FriendsOfFriendsLimit\":22,\"Enabled\":true,\"OnlineFriendsLimit\":4,\"PreviousPremadesLimit\":4,\"MaxNumSuggestedPlayers\":8,\"VictoriousComradesLimit\":4,\"FriendsOfFriendsEnabled\":true,\"MaxNumReplacements\":22},\"PersonalizedOffers\":{\"BaseServiceURL\":\"po-service.euw1.leagueoflegends.com\",\"Port\":443,\"ServiceConfig\":\"[{\\\"endpoint\\\":\\\"/player/offers\\\",\\\"version\\\":1,\\\"operation\\\":\\\"GET\\\"},{\\\"endpoint\\\":\\\"/player/offers/accept\\\",\\\"version\\\":1,\\\"operation\\\":\\\"POST\\\"},{\\\"endpoint\\\":\\\"/player/offers/deny\\\",\\\"version\\\":1,\\\"operation\\\":\\\"POST\\\"},{\\\"endpoint\\\":\\\"/player/offers/view\\\",\\\"version\\\":1,\\\"operation\\\":\\\"POST\\\"},{\\\"endpoint\\\":\\\"/player/wallet\\\",\\\"version\\\":1,\\\"operation\\\":\\\"GET\\\"},{\\\"endpoint\\\":\\\"/player/authenticate\\\",\\\"version\\\":1,\\\"operation\\\":\\\"POST\\\"},{\\\"endpoint\\\":\\\"/player/payletter\\\",\\\"version\\\":1,\\\"operation\\\":\\\"GET\\\"}]\",\"ServicePath\":\"personalized-offers/\",\"HubEnabled\":false,\"Protocol\":\"https://\"},\"DisabledChampions\":{\"ARAM_BOT\":\"[]\",\"KINGPORO\":\"[]\",\"FIRSTBLOOD\":\"[]\",\"ARAM_UNRANKED_5x5\":\"[]\",\"ONEFORALL_5x5\":\"[17,30]\",\"ODINBOT-5x5\":\"[14]\",\"ASCENSION\":\"[]\",\"SR_6x6\":\"[]\",\"BILGEWATER\":\"[]\",\"KING_PORO\":\"[]\",\"ODIN_UNRANKED\":\"[]\",\"URF\":\"[]\",\"ODINBOT\":\"[14]\",\"NIGHTMARE_BOT\":\"[]\",\"ODINBOT_5x5\":\"[14]\",\"RANKED_SOLO_5x5\":\"[]\",\"TUTORIAL\":\"[]\",\"URF_BOT\":\"[]\",\"KINGPORO-5X5\":\"[161]\",\"FIRSTBLOOD_1x1\":\"[]\",\"FIRSTBLOOD_2x2\":\"[]\",\"CLASSIC\":\"[]\",\"RANKED_TEAM_5x5\":\"[]\",\"COUNTER_PICK\":\"[]\",\"RANKED_TEAM_3x3\":\"[]\",\"HEXAKILL\":\"[]\",\"BOT\":\"[]\",\"ODIN\":\"[]\",\"RANKED_PREMADE_3x3\":\"[]\",\"ONEFORALL\":\"[17,30]\",\"NORMAL\":\"[]\",\"BOT_3x3\":\"[]\",\"NORMAL_3x3\":\"[]\",\"ARAM\":\"[]\",\"RANKED_PREMADE_5x5\":\"[]\"},\"PersonlizedOffers\":{\"Port\":443,\"BaseServiceURL\":\"po-service.usw2.leagueoflegends.com\",\"ServiceConfig\":\"[{\\\"endpoint\\\":\\\"/player/offers\\\",\\\"version\\\":1,\\\"operation\\\":\\\"GET\\\"},{\\\"endpoint\\\":\\\"/player/offers/accept\\\",\\\"version\\\":1,\\\"operation\\\":\\\"POST\\\"},{\\\"endpoint\\\":\\\"/player/offers/deny\\\",\\\"version\\\":1,\\\"operation\\\":\\\"POST\\\"},{\\\"endpoint\\\":\\\"/player/offers/view\\\",\\\"version\\\":1,\\\"operation\\\":\\\"POST\\\"},{\\\"endpoint\\\":\\\"/player/wallet\\\",\\\"version\\\":1,\\\"operation\\\":\\\"GET\\\"},{\\\"endpoint\\\":\\\"/player/authenticate\\\",\\\"version\\\":1,\\\"operation\\\":\\\"POST\\\"},{\\\"endpoint\\\":\\\"/player/payletter\\\",\\\"version\\\":1,\\\"operation\\\":\\\"GET\\\"}]\",\"HubEnabled\":true,\"ServicePath\":\"personalized-offers/\",\"Protocol\":\"https://\"},\"Mutators\":{\"CustomGameMutators\":\"[]\",\"BattleTrainingMutators\":\"[]\",\"EnabledMutators\":\"[]\",\"BasicTutorialMutators\":\"[\\\"BasicTutorial\\\"]\",\"EnabledModes\":\"[\\\"CLASSIC\\\",\\\"TUTORIAL\\\",\\\"ARAM\\\"]\"},\"EndOfGameGifting\":{\"Enabled\":true},\"ProfileHoverCard\":{\"ACSLookup\":\"true\",\"IsEnabledForBuddyPanelView\":\"true\",\"CreateStringConfiguration\":null,\"IsEnabledForSummonerQuickView\":\"true\",\"IsEnabledForClubChatParticipants\":\"true\",\"IsEnabledForGameLobbySuggestedPlayers\":\"true\",\"IsEnabledForGroupFinderCapViewSuggestedPlayers\":null,\"IsEnabledForChatFriendsList\":\"true\",\"IsEnabledForChatGroupChatParticipants\":\"true\",\"IsEnabledForCustomGameLobby\":\"true\",\"IsEnabled\":\"true\",\"ChampionMasteryLookup\":\"true\",\"LeagueLookup\":\"true\",\"IsEnabledForTeamBuilderSuggestedPlayers\":\"true\"},\"SkinRentals\":{\"Enabled\":\"ON\"},\"ContextualEducation\":{\"TargetMinionsPerWave\":0.4,\"Enabled\":false,\"MaxTargetSummonerLevel\":10.0},\"DisabledChampionSkins\":{\"DisabledChampionSkins\":\"[]\"},\"ChampionMasteryConfig\":{\"Enabled\":true,\"MinSummonerLevel\":5,\"EndOfGameEnabled\":true,\"SupportedQueueTypes\":\"RANKED_SOLO_5x5,RANKED_TEAM_5x5,CAP_5x5,NORMAL,RANKED_PREMADE_3x3,RANKED_PREMADE_5x5,RANKED_TEAM_3x3,NORMAL_3x3,ARAM_UNRANKED_5x5,ASCENSION,KING_PORO\",\"MaxChampionLevel\":5,\"LootChestsEnabled\":true,\"ShowGradeAvailablePopup\":true,\"ChampionPointQueueTypes\":\"RANKED_SOLO_5x5,RANKED_TEAM_5x5,CAP_5x5,NORMAL,KING_PORO,ASCENSION\",\"GradeEnabled\":true,\"CapUnlockChampionLevel\":4},\"WardSkinConfig\":{\"WardSkinSelection\":true},\"EndOfGameGiftSettings\":{\"SenderGiftDailyMax\":5,\"GiftRecipientLevelMin\":5,\"GiftSenderRPMax\":50000,\"RecipientGiftDailyMax\":5,\"GiftSenderLevelMin\":15},\"Esports\":{\"NotificationsAssetMagickURL\":\"http://am-a.akamaihd.net/image/?f=\",\"NotificationsStreamGroupSlug\":\"eu-lcs,na-lcs\",\"NotificationsServiceEndpoint\":\"http://api.lolesports.com/api/v2/streamgroups\",\"NotificationsEnabled\":true,\"NotificationsStreamURL\":\"http://watch.lolesports.com?utm_source=euw_pvp_client\\u0026utm_medium=referral\\u0026utm_campaign=match_notifications\"},\"PlayerPreferences\":{\"Enabled\":true,\"ServiceEndpoint\":\"https://playerpreferences.riotgames.com:443\"},\"GameInvites\":{\"ServiceEnabled\":true,\"GameInviteServiceEnabled\":false,\"InviteBulkMaxSize\":200,\"LobbyCreationEnabled\":true},\"Chat\":{\"Rename_general_group_throttle\":1.0,\"Default_public_chat_rooms\":\"\",\"MaximumRosterSize\":325,\"ChatHistoryEnabled\":true,\"ChatHistoryThreshold\":1.0,\"MobileEnabled\":true},\"NewMatchHistory\":{\"Enabled\":true,\"PostIPXPToLegSEnabled\":true,\"SharingEnabled\":true},\"ContextualEducationURLs\":{\"LAST_HIT\":\"null\"},\"NewPlayerRouter\":{\"QueueID\":\"31\",\"ABDisablingOfTutorial\":true},\"TeamBuilderDraft\":{\"TakeoverEnabled\":true,\"SkinPurchaseEnabled\":false},\"Clubs\":{\"ClubsEnabled\":true,\"InviteToClubLobbyEnabled\":true,\"ClubServiceUrl\":\"https://clubs.leagueoflegends.com/\",\"ClubPresenceDecryptionKey\":\"-----BEGIN RSA PRIVATE KEY-----|MIICXAIBAAKBgQCIPHDgCEhsrODynDW4ecpo5JnQi31Iow9oq4x1pQvtMVynAtrq|zUj9eowbfi2dpcr8+fnpmJIs5+Q8LCT5KC2DmXVdzeDXR1VFh85GL7gSW81QWr0R|y1i/pLI5TIC+x1wx2zu74TmLm2rXCGnPmpYDWiLIg6AaKkgUKPaJe4i3DwIDAQAB|AoGAP1rELxsK+ybmMUy9mr1giKkOcrH7oCTcTJPCbQ9E3Zgf+zbTsW+n6uDrePmT|owVvwXdKZfxitelc9TKeOxQZHbN6ySjYmPWYRpzRzTK028TCxSoFA4Gbw7Y5pvCF|w6efflWMZFcbCY5pIhSRtl++hSk/xVTemXalEvnbIqMeZaECQQDXAAaurwa8D+6J|zcoZg1vBlQMOlxWEcZ8DBRXnC4K12EY2CXVCMHecCo3xPEw3zGi5bo9Hs9eff1j7|6E4AeZT/AkEAojdHA6DpZbjNKNIKzZbgo1q3aeHRHRpwYzRBdSjcxQrhS+JE2D5A|ZSAOg1OfnRuph+iOxaNHparSntAWLv2N8QJAYnyTkw+AMUPHDH8lVfyTWqDs7pEM|/UejBJoex2DBdpVkzDoW6cQT9nnrPZdWfrT3QAJCRiE+48RNOc/Xc2Y+dwJAHQvW|3HB4um0v10pdAtksWjPJOd1ki1iLnUfjHK53cZT0KJlYiHwFHdZyotNbdk9YuOxM|fFkzYBfJZQSPpFRkkQJBALAlNqBc4VPBKiwgBN9sHexfgCsVEnedrXsTsWXj1tCY|nK4RQUMFTs3uDucwju0fgLeef25CSdxxKBi2j1QhlzI=|-----END RSA PRIVATE KEY-----\"},\"SeasonReward\":{\"Maximum_team_reward_level\":3,\"Enabled\":false,\"ServiceCallEnabled\":true,\"QualificationWarningEnabled\":true,\"Minimum_points_per_reward_level\":\"20,45,75\",\"Minimum_win_team_reward_level_2\":35,\"Minimum_win_team_reward_level_1\":10,\"Minimum_win_team_reward_level_3\":75},\"LootConfig\":{\"NewPlayerChestEnabled\":true,\"Enabled\":true,\"PurchaseChestsEnabled\":true,\"MinSummonerLevel\":5,\"Visible\":true,\"NoRefundConfirmationEnabled\":false,\"EventChestsEnabled\":false},\"LeagueConfig\":{\"PromoHelperEnabled\":true,\"IsPreseason\":false,\"MasterTierEnabled\":true,\"PreseasonName\":\"2016\",\"SeasonName\":\"2016\"},\"ChampionTradeService\":{\"Enabled\":true},\"ChampionSelect\":{\"UseOptimizedChampSelectProcessor\":false,\"UseOptimizedSpellSelectProcessor\":false,\"AllChampsAvailableInAram\":false,\"UseOptimizedBotChampionSelectProcessor\":false,\"AutoReconnectEnabled\":true,\"CollatorChampionFilterEnabled\":false,\"AlwaysShowRewardIcon\":false},\"FeaturedGame\":{\"MetadataEnabled\":\"OFF\"}}"
                };

                client.InvokeDestReceive("cn-" + targetSummoner._accId, "cn-" + targetSummoner._accId, "messagingDestination", clientConfig);
            }
        }

        #region ConsoleHeader

        private static void printHeader()
        {
            drawLine(false);
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + Header1.Length / 2) + "}", Header1));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + Header2.Length / 2) + "}", Header2));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + Header3.Length / 2) + "}", Header3));
            drawLine(true);
        }

        private static void drawLine(bool _break)
        {
            for (int i = 1; i <= Console.WindowWidth; i++)
            {
                if (i >= Console.WindowWidth && _break)
                {
                    Console.Write("\n");
                    return;
                }
                else if (i >= Console.WindowWidth && !_break)
                {
                    Console.Write("\n");
                    return;
                }
                else
                {
                    Console.Write("=");
                }
            }
        }

        #endregion
    }
}
