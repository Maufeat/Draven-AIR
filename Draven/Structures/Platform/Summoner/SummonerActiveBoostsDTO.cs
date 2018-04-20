namespace Draven.Structures.Platform.Summoner
{
    using System;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.boost.SummonerActiveBoostsDTO")]
    public class SummonerActiveBoostsDTO
    {
        [SerializedName("summonerId")]
        public Int32 SummonerID { get; set; }
        [SerializedName("ipBoostEndDate")]
        public Double IPBoostEndDate { get; set; }
        [SerializedName("xpBoostEndDate")]
        public Double XPBoostEndDate { get; set; }
        [SerializedName("ipBoostPerWinCount")]
        public Int32 IPBoostPerWinCount { get; set; }
        [SerializedName("xpBoostPerWinCount")]
        public Int32 XPBoostPerWinCount { get; set; }
        [SerializedName("displayIpBoostPerWinCount")]
        public String DisplayIpBoostPerWinCount { get; set; }
        [SerializedName("displayXpBoostPerWinCount")]
        public String DisplayXpBoostPerWinCount { get; set; }
        [SerializedName("displayXpEndDate")]
        public String DisplayXpEndDate { get; set; }
        [SerializedName("displayIpEndDate")]
        public String DisplayIpEndDate { get; set; }
        [SerializedName("displayIpBoostTooltip")]
        public String DisplayIpBoostTooltip { get; set; }
        [SerializedName("checkBoostTimer")]
        public object CheckBoostTimer { get; set; }
    }
}
