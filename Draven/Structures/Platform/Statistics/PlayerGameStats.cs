namespace Draven.Structures.Platform.Statistics
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.PlayerGameStats")]
    class PlayerGameStats
    {
        [SerializedName("userId")]
        public Double UserId { get; set; }
        [SerializedName("gameId")]
        public Double GameId { get; set; }
        [SerializedName("gameMapId")]
        public Double GameMapId { get; set; }
        [SerializedName("championId")]
        public Double ChampionId { get; set; }
        [SerializedName("teamId")]
        public Double TeamId { get; set; }
        [SerializedName("createDate")]
        public DateTime CreateDate { get; set; }
        [SerializedName("ranked")]
        public Boolean Ranked { get; set; }
        [SerializedName("invalid")]
        public Boolean Invalid { get; set; }
        [SerializedName("queueType")]
        public String QueueType { get; set; }
        [SerializedName("gameMode")]
        public String GameMode { get; set; }
        [SerializedName("spell1")]
        public Double Spell1 { get; set; }
        [SerializedName("spell2")]
        public Double Spell2 { get; set; }
        [SerializedName("ipEarned")]
        public Double IPEarned{ get; set; }
        [SerializedName("experienceEarned")]
        public Double ExperienceEarned { get; set; }
        [SerializedName("statistics")]
        public object Statistics { get; set; }
        [SerializedName("rawStats")]
        public ArrayCollection RawStats { get; set; }
        [SerializedName("leveledUp")]
        public Boolean LeveledUp { get; set; }
        [SerializedName("gameType")]
        public String GameType { get; set; }
        [SerializedName("leaver")]
        public Boolean Leaver { get; set; }
        [SerializedName("fellowPlayers")]
        public ArrayCollection FellowPlayers { get; set; }
        [SerializedName("gameMutators")]
        public ArrayCollection GameMutators { get; set; }
    }
}
