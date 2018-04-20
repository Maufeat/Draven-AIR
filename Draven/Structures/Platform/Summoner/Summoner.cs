namespace Draven.Structures.Platform.Summoner
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.Summoner")]
    public class Summoner : BaseSummoner
    {
        [SerializedName("sumId")]
        public Double SumId { get; set; }
        [SerializedName("revisionId")]
        public Double RevisionId { get; set; }
        [SerializedName("revisionDate")]
        public DateTime RevisionDate { get; set; }
        [SerializedName("lastGameDate")]
        public DateTime LastGameDate { get; set; }
        [SerializedName("socialNetworkUserIds")]
        public ArrayCollection SocialNetworkUserIds { get; set; }
        [SerializedName("previousSeasonHighestTier")]
        public String PreviousSeasonHighestTier { get; set; }
        [SerializedName("previousSeasonHighestTeamReward")]
        public Int32 PreviousSeasonHighestTeamReward { get; set; }
        [SerializedName("tutorialFlag")]
        public Boolean TutorialFlag { get; set; }
        [SerializedName("helpFlag")]
        public Boolean HelpFlag { get; set; }
        [SerializedName("displayEloQuestionaire")]
        public Boolean DisplayEloQuestionaire { get; set; }
        [SerializedName("nameChangeFlag")]
        public Boolean NameChangeFlag { get; set; }
        [SerializedName("advancedTutorialFlag")]
        public Boolean AdvancedTutorialFlag { get; set; }
    }
}
