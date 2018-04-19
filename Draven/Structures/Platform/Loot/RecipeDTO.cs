using RtmpSharp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.loot.dto.RecipeClientDTO")]
    public class RecipeClientDTO
    {
        [SerializedName("recipeName")]
        public String RecipeName { get; set; }
        [SerializedName("type")]
        public String Type { get; set; }
        [SerializedName("displayCategories")]
        public List<string> DisplayCategories { get; set; }
        [SerializedName("slots")]
        public List<RecipeSlotDTO> Slots { get; set; }
        [SerializedName("outputs")]
        public List<RecipeOutputDTO> Outputs { get; set; }
    }
}
