using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using HttpClient_1;

namespace HttpClient_1
{
    class Program
    {
        static void Main(string[] args)
        {
            handle hand = new handle();

            LoginInfo login = new LoginInfo();
            Electric electric = new Electric();
            CurrentWarnings warnings = new CurrentWarnings();
            WarningTotalDetail total = new WarningTotalDetail();

            string LoginStr;
            string CurrentWarningsStr;
            string WarningTotalDetailStr;
            string ElectricStr;

            //Dictionary<string, string> Site = new Dictionary<string,string>();
            //List<List<string>> Sites = new List<List<string>>();
            //Sites = Common.Sites;
            
            hand.Init();
            LoginStr = hand.Login();
            login = (LoginInfo)Helper_Json.JsonToObject(LoginStr, login);

            Console.WriteLine(login.success);
            Console.WriteLine(login.lat);
            Console.WriteLine(login.lon);
                        
            Helper_log.Write_log("dddd");
            Helper_log.WriteCurrentWarnings_log("CurrentWarningsTest");

            
            //Helper_log.WriteElectric_log("ElectricTest");

            //Helper_SaveData.save(DateTime.Now.ToShortDateString().ToString().Replace('/','.'),"asd","jjjjj");

            //hand.GetElectric();

            while (true)
            {
                WarningTotalDetailStr = hand.GetWarningTotalDetail();
                total = (WarningTotalDetail)Helper_Json.JsonToObject(WarningTotalDetailStr, total);
                Helper_SaveData.SaveWarningTotalDetail(total);

                CurrentWarningsStr = hand.GetCurrentWarnings();
                warnings = (CurrentWarnings)Helper_Json.JsonToObject(CurrentWarningsStr, warnings);

                for (int i = 0; i < Common.SitesNum;i++ )
                {
                    Helper_WriteToCSV.InitSaveElectricData(i);
                    ElectricStr = hand.GetElectric(i);
                    electric = (Electric)Helper_Json.JsonToObject(ElectricStr, electric);
                    Helper_SaveData.SaveElectric(electric);
                    Helper_WriteToCSV.FinishSaveElectricData();
                    Thread.Sleep(Common.LoopTime * 1000);
                }

                //if (electric.d.Count != 0)
                //{
                //    Console.WriteLine(electric.d[0][0]);
                //    Console.WriteLine(electric.d[0][1]);
                //    Console.WriteLine(electric.e);
                //}
            }

            //hand.Login();
            //hand.GetCurrentWarnings();
            //hand.GetWarningTotalDetail();
            //while (true)
            //{
            //    hand.GetElectric();
            //    Thread.Sleep(10000);
            //}
            
            Console.ReadKey();
        }
    }
}
