using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.leagues.pojo.LeagueListDTO")]
    class LeagueListDTO
    {
        [SerializedName("queue")]
        public String Queue { get; set; }

        [SerializedName("name")]
        public String Name { get; set; }

        [SerializedName("tier")]
        public String Tier { get; set; }

        [SerializedName("requestorsRank")]
        public String RequestorsRank { get; set; }

        [SerializedName("entries")]
        public ArrayCollection Entries { get; set; }

        [SerializedName("nextApexUpdate")]
        public Int32 NextApexUpdate { get; set; }

        [SerializedName("maxLeagueSize")]
        public Int32 MaxLeagueSize { get; set; }

        [SerializedName("requestorsName")]
        public object RequestorsName { get; set; }
    }
}
