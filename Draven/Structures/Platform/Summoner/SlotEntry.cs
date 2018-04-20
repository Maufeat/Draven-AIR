namespace Draven.Structures.Platform.Summoner
{
    using System;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.spellbook.SlotEntry")]
    public class SlotEntry
    {
        [SerializedName("runeId")]
        public Int32 RuneId { get; set; }
        [SerializedName("runeSlotId")]
        public Int32 RuneSlotId { get; set; }
    }
}
