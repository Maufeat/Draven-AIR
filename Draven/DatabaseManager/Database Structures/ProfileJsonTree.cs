namespace Draven.DatabaseManager
{
    using System.Collections.Generic;

    public class ProfileJsonTree
    {
        public string type { get; set; }
        public string version { get; set; }
        public Dictionary<string, ProfileIconTree> data { get; set; }
    }
}