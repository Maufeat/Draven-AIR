﻿using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.PlayerStatSummaries")]
    public class PlayerStatSummaries
    {
        [SerializedName("playerStatSummarySet")]
        public ArrayCollection SummaryList { get; set; }
        [SerializedName("userId")]
        public Int32 UserID { get; set; }
    }
}
