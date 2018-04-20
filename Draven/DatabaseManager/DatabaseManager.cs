namespace Draven.DatabaseManager
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Net;

    using Draven.Structures.Platform.Catalog;
    using Draven.Structures.Platform.Summoner;

    using MySql.Data.MySqlClient;

    using Newtonsoft.Json;

    using RtmpSharp.IO.AMF3;

    public static class DatabaseManager
    {
        public static ArrayCollection TalentTree { get; set; }
        public static ArrayCollection RuneTree { get; set; }

        public static MySqlConnection connection { get; set; }
        public static MySqlDataReader rdr = null;
        public static object Locker = new object();

        public static bool InitConnection()
        {
            try
            {
                Console.WriteLine("[LOG] Connecting to database");
                connection = new MySqlConnection("Database=" + Program.database + ";Data Source=" + Program.host + ";User Id = " + Program.user + "; Password = " + Program.pass + "; SslMode=none");
                connection.Open();
                Console.WriteLine("[LOG] Connection established");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("[LOG] Couldn't connect to database.\n" + e.Message);
                return false;
            }
        }


        public static void InitMasteryAndRuneTree()
        {
            Dictionary<string, int> _masterySort = new Dictionary<string, int> { { "Offense", 1 }, { "Defense", 2 }, { "Utility", 3 } };

            Console.WriteLine("[LOG] Initialize Mastery and Rune Tree");
            using (WebClient client = new WebClient())
            {
                //Download the latest mastery daata
                string MasteryData = client.DownloadString("http://ddragon.leagueoflegends.com/cdn/7.12.1/data/en_US/mastery.json");
                
                Masteries mData = JsonConvert.DeserializeObject<Masteries>(MasteryData);
                TalentTree = new ArrayCollection();

                //Parse the data and convert it into a type that is sent in the LoginDataPacket
                foreach (KeyValuePair<string, List<List<MasteryLite>>> mastery in mData.tree)
                {
                    TalentGroup group = new TalentGroup
                    {
                        Name = mastery.Key,
                        TalentRows = new ArrayCollection(),
                        TltGroupId = _masterySort[mastery.Key],
                        Index = _masterySort[mastery.Key] - 1
                    };

                    for (int i = 0; i < mastery.Value.Count; i++)
                    {
                        ArrayCollection talentList = new ArrayCollection();
                        List<MasteryLite> masteryList = mastery.Value[i];
                        for (int j = 0; j < masteryList.Count; j++)
                        {
                            if (masteryList[j] == null)
                                continue;

                            var data = mData.data[masteryList[j].masteryId];
                            Talent t = new Talent
                            {
                                Index = j,
                                Name = data.name,
                                Level1Desc = data.name,
                                Level2Desc = data.name,
                                Level3Desc = data.name,
                                Level4Desc = data.name,
                                Level5Desc = data.name,
                                GameCode = data.id,
                                TltId = data.id,
                                MaxRank = data.ranks,
                                MinLevel = 1,
                                MinTier = 1,
                                TalentGroupId = group.TltGroupId,
                                TalentRowId = (i + 1) * group.TltGroupId
                            };

                            if (data.preReq != "0")
                                t.PrereqTalentGameCode = Convert.ToInt32(data.preReq);

                            talentList.Add(t);
                        }

                        TalentRow row = new TalentRow
                        {
                            Index = i,
                            Talents = talentList,
                            PointsToActivate = i * 4,
                            TltRowId = (i + 1) * group.TltGroupId,
                            TltGroupId = group.TltGroupId
                        };

                        group.TalentRows.Add(row);
                    }

                    TalentTree.Add(group);
                }

                #region Rune Loading
                RuneTree = new ArrayCollection();

                //This code is... bad. 
                int Modifier = 0; //Skip 10, 20, 30
                int Take = 3; //Take one each loop and it will increase what it starts from (1 - 2 - 3)
                //Loop from 1-9 and do it 3 times to generate the red, yellow and blue runes
                for (int i = 1; i <= 9; i++)
                {
                    //At 10, 20 and 30 you need to increment the min level.
                    if ((i - 1) % 3 == 0 && i != 1)
                    {
                        Modifier += 1;
                    }

                    //The id goes past 9 so add the required amount that we have looped
                    int IdAdd = (Math.Abs(Take - 3) * 10);
                    //Take the amount that it has gone over
                    IdAdd -= Math.Abs(Take - 3);

                    RuneSlot slot = new RuneSlot()
                    {
                        Id = IdAdd + i,
                        RuneType = new RuneType(),
                        MinLevel = (3 * i + 1) - Take + Modifier
                    };

                    if (Take == 3)
                    {
                        slot.RuneType.Name = "Red";
                        slot.RuneType.Id = 1;
                    }
                    else if (Take == 2)
                    {
                        slot.RuneType.Name = "Yellow";
                        slot.RuneType.Id = 3;
                    }
                    else
                    {
                        slot.RuneType.Name = "Blue";
                        slot.RuneType.Id = 5;
                    }

                    RuneTree.Add(slot);

                    //Re do the loop, reset the modifier and take one from the take so the min level starts off one integer higher than last time
                    if (i == 9 && Take > 1)
                    {
                        Take -= 1;
                        i = 0;
                        Modifier = 0;
                    }
                }

                //Add black runes
                for (int i = 1; i <= 3; i++)
                {
                    RuneSlot slot = new RuneSlot()
                    {
                        Id = 27 + i, //Start id from 27 since thats where we left off
                        RuneType = new RuneType
                        {
                            Id = 7,
                            Name = "Black"
                        },
                        MinLevel = 10 * i
                    };

                    RuneTree.Add(slot);
                }

                #endregion
            }
           
        }



        public static List<int> ProfileIcons = new List<int>();

        public static void InitProfileIcons()
        {
            using (WebClient client = new WebClient())
            {
                Console.WriteLine("[LOG] Initialize Profile Icons");

                string ProfileData = client.DownloadString("http://ddragon.leagueoflegends.com/cdn/7.12.1/data/en_US/profileicon.json");

                ProfileJsonTree mData = JsonConvert.DeserializeObject<ProfileJsonTree>(ProfileData);

                foreach (var iconData in mData.data)
                {
                        ProfileIcons.Add(iconData.Value.id);
                }
            }
        }

        public static Dictionary<string, string> getAccountData(string user, string pass)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM accounts WHERE username='" + user + "' AND password='" + pass + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dtCustomers = new DataTable();
            dtCustomers.Load(reader);
            var dataArray = new Dictionary<string, string>();
            foreach (DataRow row in dtCustomers.Rows)
            {
                dataArray["id"] = row["id"].ToString();
                dataArray["summonerId"] = row["summonerId"].ToString();
                dataArray["RP"] = row["RP"].ToString();
                dataArray["IP"] = row["IP"].ToString();
                dataArray["banned"] = row["isBanned"].ToString();
            }
            return dataArray;
        }

        public static Dictionary<string, string> getSummonerData(string sumId)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM summoner WHERE id='" + sumId + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dtCustomers = new DataTable();
            dtCustomers.Load(reader);
            var dataArray = new Dictionary<string, string>();
            foreach (DataRow row in dtCustomers.Rows)
            {
                dataArray["id"] = row["id"].ToString();
                dataArray["summonerName"] = row["summonerName"].ToString();
                dataArray["icon"] = row["icon"].ToString();
            }
            return dataArray;
        }

        public class DBChampions
        {
            public int ID { get; set; }
            public bool IsFreeToPlay { get; set; }
        }

        public static List<DBChampions> getAllChampions()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM champions";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dtChampions = new DataTable();
            dtChampions.Load(reader);
            var dataArray = new List<DBChampions>();
            foreach (DataRow row in dtChampions.Rows)
            {
                dataArray.Add(new DBChampions() { ID = Convert.ToInt32(row["id"].ToString()), IsFreeToPlay = Convert.ToBoolean(Convert.ToInt32(row["freeToPlay"].ToString())) });
            }
            return dataArray;
        }

        public static List<int> getAllChampionSkinsForId(int id)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM championSkins WHERE championId='"+ id + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dtSkins = new DataTable();
            dtSkins.Load(reader);
            var dataArray = new List<int>();
            foreach (DataRow row in dtSkins.Rows)
            {
                dataArray.Add(Convert.ToInt32(row["id"].ToString()));
            }
            return dataArray;
        }
        

        public static void updateSummonerIconById(int sumId, int iconId)
        {
            try {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE summoner SET icon='" + iconId + "' WHERE id='" + sumId + "'";
                cmd.ExecuteNonQuery();
            } catch (MySqlException sex)
            {
                Console.WriteLine(sex.Message);
            }
        }

        public static bool checkAccount(string user, string pass)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT count(*) FROM accounts WHERE username='" + user + "' AND password='" + pass + "'";
                int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                if (userCount > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
