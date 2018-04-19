using RtmpSharp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.loot.dto.RecipeListClientDTO")]
    public class RecipeListClientDTO
    {
        [SerializedName("recipes")]
        public List<RecipeClientDTO> Recipes{ get; set; }
        [SerializedName("lastUpdate")]
        public Double LastUpdate{ get; set; }
    }
}
