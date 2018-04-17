using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.leagues.client.dto.SummonerLeaguesDTO")]
    class SummonerLeaguesDTO
    {
        [SerializedName("summonerLeagues")]
        public ArrayCollection SummonerLeagues { get; set; }
    }
}
