using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpClient_1
{
    class profile
    {
        public static string Login_URL = "http://120.36.142.50:8888/thunder1/web/loginjson.html?";
        public static string Login_Post = "entity.loginAccount=fjqx01&entity.loginPasswd=fjqx01";

        public static string getCurrentWarnings_URL = "http://120.36.142.50:8888/thunder1/sys/warning/getCurrentWarnings.html";

        public static string getWarningTotalDetail_URL = "http://120.36.142.50:8888/thunder1/sys/warning/getWarningTotalDetailJson.html";

        public static string getElectric_URL = "http://120.36.142.50:8888/data_server/data/electric/new?deviceId=";

    }
}
