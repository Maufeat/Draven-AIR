using RtmpSharp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.loot.dto.RecipeOutputDTO")]
    public class RecipeOutputDTO
    {
        [SerializedName("lootName")]
        public String LootName{ get; set; }
        [SerializedName("quantityExpression")]
        public String QuantityExpression { get; set; }
    }
}
