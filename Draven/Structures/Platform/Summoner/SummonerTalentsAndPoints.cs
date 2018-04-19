﻿using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.SummonerTalentsAndPoints")]
    public class SummonerTalentsAndPoints
    {
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
        [SerializedName("talentPoints")]
        public Int32 TalentPoints { get; set; }
        [SerializedName("summonerAssociatedTalents")]
        public ArrayCollection SummonerAssociatedTalents { get; set; }
        [SerializedName("modifyDate")]
        public DateTime ModifyDate { get; set; }
        [SerializedName("createDate")]
        public DateTime CreateDate { get; set; }
    }
}
