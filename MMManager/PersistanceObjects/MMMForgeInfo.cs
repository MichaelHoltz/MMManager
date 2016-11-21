using System;
namespace MMManager.PersistanceObjects
{
    [Serializable]
    class MMMForgeInfo
    {
        public String Version { get; set; }
        public String Location { get; set; }
        public MMMForgeInfo()
        {
            Version = "1";
            Location = "test";
        }
    }
}
