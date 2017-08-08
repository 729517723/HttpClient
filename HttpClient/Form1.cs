using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HttpClient_1;
using System.Threading;
using System.IO;

namespace HttpClient
{
    public partial class Form1 : Form
    {
        string ElectricStr;

        WarningTotalDetail total = new WarningTotalDetail();
        Electric electric = new Electric();
        LoginInfo login = new LoginInfo();

        public Form1()
        {
            InitializeComponent();
            Login();
        }

        void GetElec()
        {
            while (true)
            {
                for (int i = 0; i < Common.SitesNum; i++)
                {
                    try
                    {
                        Helper_WriteToCSV.InitSaveElectricData(i);
                        ElectricStr = Common.handler.GetElectric(i);
                        Helper_log.Write_log(ElectricStr);
                        electric = (Electric)Helper_Json.JsonToObject(ElectricStr, electric);
                        Helper_SaveData.SaveElectric(electric);
                        Helper_WriteToCSV.FinishSaveElectricData();
                        Thread.Sleep(Common.LoopTime * 1000);
                    }
                    catch (Exception ex)
                    {
                        Helper_log.Write_Error(ex.ToString());
                    }
                }
            }
        }

        private void btn_GetElec_Click(object sender, EventArgs e)
        {

            if (Flags.LoginFlag != 1)
            {
                MessageBox.Show("你尚未登录请登录后重试！", "错误", MessageBoxButtons.OKCancel);
            }
            else
            {
                Thread thread = new Thread(GetElec);
                thread.IsBackground = true;
                MessageBox.Show("正在获取数据！", "成功", MessageBoxButtons.OKCancel);
                thread.Start();
                btn_GetElec.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckFile();
        }

        private void Login()
        { 
            Helper_Ini helper = new Helper_Ini("config.ini");

            Common.handler.Init();

            String LoginStr;

            try
            {
                LoginStr = Common.handler.Login();
                login = (LoginInfo)Helper_Json.JsonToObject(LoginStr, login);
                Helper_log.Write_log(LoginStr);
            }
            catch(Exception ex)
            {
                login.success = false;
                MessageBox.Show("连接网络失败", "错误", MessageBoxButtons.OK);
            }

            if (login.success != true)
            {
                MessageBox.Show("密码错误，请重试", "错误", MessageBoxButtons.OK);
                Flags.LoginFlag = 0;
            }
            else
            {
                MessageBox.Show("登录成功", "成功", MessageBoxButtons.OK);
                Flags.LoginFlag = 1;
            }
            
        }

        private void CheckFile()
        {
            String DelFile;
            for (int i = 0; i < Common.SitesNum; i++)
            {
                DelFile = Common.filepath
                + DateTime.Now.ToString("yyyy") + "\\"
                + DateTime.Now.ToString("MM") + "\\"
                + DateTime.Now.ToString("dd") + "\\"
                + DateTime.Now.ToString("yyyyMMdd")
                + "_" + Common.Sites[i][0] + "_" + Common.Sites[i][1] + ".csv";
                if (File.Exists(DelFile))
                {
                    File.Delete(DelFile);
                }
            }
        }
        
    }
}
