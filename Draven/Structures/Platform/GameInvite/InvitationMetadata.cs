namespace Draven.Structures.Platform.GameInvite
{
    using System;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    public class InvitationMetadata
    {
        [SerializedName("gameMetaData")]
        public String GameMetaData { get; set; }
        [SerializedName("jsonBlob")]
        public object JSONBlob { get; set; }
    }
}
