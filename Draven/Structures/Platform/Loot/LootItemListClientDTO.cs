using RtmpSharp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.loot.dto.LootItemListClientDTO")]
    public class LootItemListClientDTO
    {
        [SerializedName("lootItems")]
        public List<LootItemDTO> LootItems { get; set; }
        [SerializedName("lastUpdate")]
        public Double LastUpdate{ get; set; }
    }
}
