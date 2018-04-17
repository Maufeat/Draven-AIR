using RtmpSharp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.MatchMakerParams")]
    class MatchMakerParams
    {
        [SerializedName("botDifficulty")]
        public String BotDifficulty { get; set; }

        [SerializedName("queueIDs")]
        public List<int> QueueIDs { get; set; }

        [SerializedName("invitationID")]
        public Object InvitationID { get; set; }

        [SerializedName("lastMaestroMessage")]
        public Object LastMaestroMessage { get; set; }

        [SerializedName("teamID")]
        public Object TeamID { get; set; }

        [SerializedName("team")]
        public Object Team { get; set; }

        [SerializedName("languages")]
        public Object Languages { get; set; }
    }
}
