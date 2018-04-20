namespace Draven.Structures.Platform.Catalog
{
    using System;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.catalog.runes.RuneType")]
    public class RuneType
    {
        [SerializedName("runeTypeId")]
        public Int32 Id { get; set; }
        [SerializedName("name")]
        public String Name { get; set; }
    }
}
