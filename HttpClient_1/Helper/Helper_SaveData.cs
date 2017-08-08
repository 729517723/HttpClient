using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpClient_1
{
    public static class Helper_SaveData
    {
        public static void SaveCurrentWarnings(CurrentWarnings CW)
        {
            String Temp;
            int count = CW.warning.Count;

        }

        public static void SaveWarningTotalDetail(WarningTotalDetail WTD)
        {
            String Temp="";
            if (WTD.total != Common.TotalCount)
            {
                Helper_Ini Helper = new Helper_Ini("config.ini");

                if (WTD.rows.Count > Common.TotalCount)
                {                    
                for (int i = 0; i < WTD.rows.Count - Common.TotalCount; i++)
                {
                       Temp = "  " + WTD.rows[i].warningPointName.ToString()
                        + "  "+WTD.rows[i].warningPointId.ToString()
                        + "  "+WTD.rows[i].levelName.ToString()
                        + "  "+WTD.rows[i].startTime.ToString()
                        + "  "+WTD.rows[i].endTime.ToString();
                       Helper_log.WriteWarningTotalDetail_log(Temp);
                }
                Helper.WriteInteger("count", "TotalCount", WTD.total);
                }
            }
        }

        public static void SaveElectric(Electric elec)
        {
            string Temp = "";
            int eleccount = 0;
            Helper_Ini Helper = new Helper_Ini("config.ini");
            eleccount = Helper.ReadInteger("count", "ElecWarnCount", 0);
            if (elec.d.Count != 0)
            {
                if (elec.d[0][0] < eleccount)
                {
                    Helper.WriteInteger("count", "ElecWarnCount", 0);
                    eleccount = 0;
                }
                for (int i = 0; i < elec.d.Count; i++)
                {
                    TimeSpan ts = new TimeSpan(0, 0, Int32.Parse(elec.d[i][0].ToString()));
                    Temp = ts.Hours+":"+ts.Minutes+":"+ts.Seconds
                     + "," + elec.d[i][1].ToString();
                    Helper_WriteToCSV.SaveElectricData(Temp);
                }
                Helper.WriteInteger("count", "ElecWarnCount", (int)(elec.d.Count + elec.d[0][0]));
            }
        }
    }
}