using RtmpSharp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.loot.dto.QueryResultDTO")]
    public class QueryResultDTO
    {
        [SerializedName("queryToLootNames")]
        public object QueryToLootNames{ get; set; }
        [SerializedName("lastUpdate")]
        public Double LastUpdate { get; set; }
    }
}
