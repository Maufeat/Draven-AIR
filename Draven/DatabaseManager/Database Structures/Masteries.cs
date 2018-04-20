namespace Draven.DatabaseManager
{
    using System.Collections.Generic;

    public class Masteries
    {
        public string type { get; set; }

        public string version { get; set; }

        public Dictionary<string, MasteryData> data { get; set; }

        public Dictionary<string, List<List<MasteryLite>>> tree { get; set; }
    }
}