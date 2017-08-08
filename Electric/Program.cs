using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HttpClient_1;
using System.Threading;

namespace SaveElectric
{
    class Program
    {

        static handle hand = new handle();
        static LoginInfo login = new LoginInfo();
        static Electric electric = new Electric();

        static string LoginStr;
        static string ElectricStr;
       
        static void Runable()
        {
            int i = 0;
            try
            {
                while (true)
                {
                    for (i = 0; i < Common.SitesNum; i++)
                    {
                        Helper_WriteToCSV.InitSaveElectricData(i);
                        ElectricStr = Common.handler.GetElectric(i);
                        Helper_log.Write_log(ElectricStr);
                        electric = (Electric)Helper_Json.JsonToObject(ElectricStr, electric);
                        Helper_SaveData.SaveElectric(electric);
                        Helper_WriteToCSV.FinishSaveElectricData();

                        Thread.Sleep(Common.LoopTime * 1000);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(Runable);

            int i=0;
            
            hand.Init();
            LoginStr = hand.Login();

            do
            {
                login = (LoginInfo)Helper_Json.JsonToObject(LoginStr, login);
                Helper_log.Write_log(LoginStr);
                i++;
            } while (i < 10 || login.success == false);

            if (login.success == false)
            {
                Console.WriteLine("登录失败，请重新尝试！！");
                return;
            }

            thread.Start();
            Console.ReadLine();
          
        }
    }
}
