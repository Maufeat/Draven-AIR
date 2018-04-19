using RtmpSharp.IO;
using System;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.SummonerLevel")]
    public class SummonerLevel
    {
        [SerializedName("summonerLevel")]
        public Double Level { get; set; }
        [SerializedName("summonerTier")]
        public Double SummonerTier { get; set; }
        [SerializedName("infTierMod")]
        public Double InfTierMod { get; set; }
        [SerializedName("expTierMod")]
        public Double ExpTierMod { get; set; }
        [SerializedName("expToNextLevel")]
        public Double ExpToNextLevel { get; set; }

        //[SerializedName("grantRp")]
        //public Double GrantRp { get; set; }
        //[SerializedName("expForLoss")]
        //public Double ExpForLoss { get; set; }
        //[SerializedName("expForWin")]
        //public Double ExpForWin { get; set; }
    }
}
