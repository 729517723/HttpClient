using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpClient_1
{
    public class WarningTotalDetail
    {
        public class Row
        {
            public string warningPointName { get; set; }
            public string warningPointId { get; set; }
            public string levelName { get; set; }
            public string startTime { get; set; }
            public string endTime { get; set; }
        }

        public int total { get; set; }
        public List<Row> rows { get; set; }
    }
}
