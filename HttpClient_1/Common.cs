using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
namespace HttpClient_1
{
    public static class Common
    {
        private static Helper_Ini helper = new Helper_Ini("config.ini");

        public static List<List<string>> Sites = ReadAllSites();

        public static int SitesNum = Sites.Count;

        public static handle handler = new handle();

        public static String name = helper.ReadString("user", "name", "");
        public static String pwd = helper.ReadString("user", "password", "");

        public static String year = helper.ReadString("selected", "year", "");
        public static String month = helper.ReadString("selected", "month", "");
        public static String ID = helper.ReadString("selected", "pointID", "");

        public static string filepath = helper.ReadString("config", "logpath", "");
        public static int LoopTime = helper.ReadInteger("config", "looptime", 10);
        public static int TaskNum = helper.ReadInteger("config", "tasknum", 1);
        public static int Timeout = helper.ReadInteger("config", "timeout", 20);

        public static int TotalCount = helper.ReadInteger("count", "TotalCount", 0);
        public static int ElecWarnCount = helper.ReadInteger("count", "ElecWarnCount", 0);

        public static string Login_URL = helper.ReadString("url", "Login_URL", "");
        public static string getCurrentWarnings_URL = helper.ReadString("url", "getCurrentWarnings_URL", "");
        public static string getWarningTotalDetail_URL = helper.ReadString("url", "getWarningTotalDetail_URL", "");
        public static string getElectric_URL = helper.ReadString("url", "getElectric_URL", "");

        //private static Dictionary<string, string> ReadAllSites()
        //{
        //    Dictionary<string,string> temp = new Dictionary<string, string>();
        //    FileStream fs = new FileStream(@"site.conf",FileMode.Open,FileAccess.Read);
        //    StreamReader reader = new StreamReader(fs, Encoding.Default);
        //    string TempRead;
        //    string SiteName;
        //    string SiteID;
        //    string[] TempStr = new string[2];
        //    while ((TempRead = reader.ReadLine()) != null)
        //    {
        //        TempStr = Regex.Split(TempRead, ",", RegexOptions.IgnoreCase);
        //        SiteName = TempStr[0];
        //        SiteID = TempStr[1];
        //        temp.Add(SiteName, SiteID);
        //    }
        //    return temp;
        //}

        private static List<List<string>> ReadAllSites()
        {
            List<List<string>> temp = new List<List<string>>();
            int i = 0;
            FileStream fs = new FileStream(@"site.conf", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs, Encoding.Default);
            string TempRead;
            string SiteName;
            string SiteID;
            string[] TempStr = new string[2];

            while ((TempRead = reader.ReadLine()) != null)
            {
                TempStr = Regex.Split(TempRead, ",", RegexOptions.IgnoreCase);
                List<string> list = new List<string>();
                SiteName = TempStr[0];
                SiteID = TempStr[1];
                list.Add(SiteName);
                list.Add(SiteID);
                temp.Add(list);
            }
            return temp;
        }

    }
}
