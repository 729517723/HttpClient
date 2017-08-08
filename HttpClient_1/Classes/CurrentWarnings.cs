using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpClient_1
{
    public class CurrentWarnings
    {
        public class Warning
        {
            public string warningPointName { get; set; }
            public string warningPointId { get; set; }
            public string lon { get; set; }
            public string lat { get; set; }
            public string level { get; set; }
            public string groupName { get; set; }
            public string groupId { get; set; }
            public string startTime { get; set; }
            public int direction { get; set; }
        }

        public class Direction
        {
            public string groupId { get; set; }
            public string degree { get; set; }
            public int direction { get; set; }
        }

        public List<Warning> warning { get; set; }
        public List<Direction> directions { get; set; }
    }
}
