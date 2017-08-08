using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpClient_1.Classes
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

    public class CurrentWarnings
    {
        public List<Warning> warning { get; set; }
        public List<Direction> directions { get; set; }
    }

    public class E
    {
        public string t { get; set; }
        public string h { get; set; }
        public string s { get; set; }
        public string d { get; set; }
        public double k { get; set; }
        public int n { get; set; }
        public double k_abs { get; set; }
    }

    public class Electric
    {
        public List<List<double>> d { get; set; }
        public E e { get; set; }
    }

    public class Row
    {
        public string warningPointName { get; set; }
        public string warningPointId { get; set; }
        public string levelName { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
    }

    public class WarningTotalDetail
    {
        public int total { get; set; }
        public List<Row> rows { get; set; }
    }


}
