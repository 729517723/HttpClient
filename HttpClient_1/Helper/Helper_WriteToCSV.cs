using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HttpClient_1
{
    public static class Helper_WriteToCSV
    {
     

        public static FileStream fs1;
        public static StreamWriter sw;

        public static void InitSaveElectricData(int SiteOrder)
        {
            //fs1 = new FileStream(@"Logs\Electric\"+DateTime.Now.ToString("yyyyMMdd") 
            String filepath = Common.filepath
                + DateTime.Now.ToString("yyyy") + "\\"
                + DateTime.Now.ToString("MM") + "\\"
                + DateTime.Now.ToString("dd") + "\\";

            if (!System.IO.Directory.Exists(filepath))
            {
                System.IO.Directory.CreateDirectory(filepath);
            }
            fs1 = new FileStream(filepath+ DateTime.Now.ToString("yyyyMMdd")
                + "_" + Common.Sites[SiteOrder][0] + "_" + Common.Sites[SiteOrder][1]+".csv", 
                FileMode.OpenOrCreate|FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs1);
        }

        public static void SaveElectricData(string data)
        {
            sw.WriteLine(data);
            sw.Flush();
        }
        public static void FinishSaveElectricData()
        {   
            sw.Close();
            fs1.Close();            
        }
    }
}
