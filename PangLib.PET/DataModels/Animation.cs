using System.Collections.Generic;

namespace PangLib.PET.DataModels
{
    public class Animation
    {
        public byte BoneID;
        public List<AnimationProperty> AnimationProperties = new List<AnimationProperty>();
        public uint Unknown1;
        public List<RotationData> RotationData = new List<RotationData>();
    }
}