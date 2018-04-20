namespace Draven.Structures.Team.DTO
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.team.dto.PlayerDTO")]
    class PlayerDTO
    {
        [SerializedName("playerId")]
        public Int64 PlayerId { get; set; }

        [SerializedName("teamsSummary")]
        public ArrayCollection TeamsSummary { get; set; }

        [SerializedName("createdTeams")]
        public ArrayCollection CreatedTeams { get; set; }

        [SerializedName("playerTeams")]
        public ArrayCollection PlayerTeams { get; set; }

    }
}
