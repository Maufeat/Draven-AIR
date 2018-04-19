﻿using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.spellbook.SpellBookDTO")]
    public class SpellBookDTO
    {
        [SerializedName("sortByPageId")]
        public object SortByPageId { get; set; }
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
        [SerializedName("dateString")]
        public String DateString { get; set; }
        [SerializedName("bookPages")]
        public ArrayCollection BookPages { get; set; }
    }
}
