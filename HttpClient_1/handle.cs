using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;

namespace HttpClient_1
{
    /// <summary>
    /// 
    /// </summary>
    public class handle
    {             
        private static HttpClient httpClient;
        private static HttpClientHandler handler;
        private static Helper_Ini helper = new Helper_Ini("config.ini");
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        public string  Init()
        {
            handler = new HttpClientHandler();
            handler.AllowAutoRedirect = false;

            httpClient = new HttpClient(handler);


            httpClient.MaxResponseContentBufferSize = 1225600;

            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("ContentType", "text/plain");
            httpClient.DefaultRequestHeaders.Add("charset", "UTF-8");
            return "OK";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Login()
        {
            try
            {                
                var task = httpClient.GetAsync(Common.Login_URL + "entity.loginAccount=" + Common.name + "&entity.loginPasswd=" + Common.pwd);//entity.loginAccount=fjqx01&entity.loginPasswd=fjqx01
                task.Result.EnsureSuccessStatusCode();
                HttpResponseMessage response = task.Result;

                var result = response.Content.ReadAsStringAsync();
                string responseBodyAsText = result.Result;
                responseBodyAsText = responseBodyAsText.Replace("<br>", Environment.NewLine);

                Helper_log.Write_log(Common.Login_URL + "entity.loginAccount=" + Common.name + "&entity.loginPasswd=" + Common.pwd);

                return responseBodyAsText;
            }
            catch (HttpRequestException hre)
            {
                return hre.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetCurrentWarnings()
        {
            try
            {
                var task = httpClient.GetAsync(Common.getCurrentWarnings_URL);
                task.Result.EnsureSuccessStatusCode();
                HttpResponseMessage response = task.Result;

                var result = response.Content.ReadAsStringAsync();
                string responseBodyAsText = result.Result;
                responseBodyAsText = responseBodyAsText.Replace("<br>", Environment.NewLine);

                return responseBodyAsText;
            }
            catch (HttpRequestException hre)
            {
                return hre.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetWarningTotalDetail()
        {      
            try
            {
                var task = httpClient.GetAsync(Common.getWarningTotalDetail_URL
                    + "?year=" + Common.year + "&month=" + Common.month);
                task.Result.EnsureSuccessStatusCode();
                HttpResponseMessage response = task.Result;

                var result = response.Content.ReadAsStringAsync();
                string responseBodyAsText = result.Result;
                responseBodyAsText = responseBodyAsText.Replace("<br>", Environment.NewLine); 
               
                return responseBodyAsText;

            }
            catch (HttpRequestException hre)
            {
                return hre.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetElectric(int SiteOrder)
        {
            try
            {
                var task = httpClient.GetAsync(Common.getElectric_URL + Common.Sites[SiteOrder][1]);    

                task.Result.EnsureSuccessStatusCode();
                HttpResponseMessage response = task.Result;

               
                var result = response.Content.ReadAsStringAsync();
                string responseBodyAsText = result.Result;
                responseBodyAsText = responseBodyAsText.Replace("<br>", Environment.NewLine);
               
                return responseBodyAsText;

            }
            catch (HttpRequestException hre)
            {
                return hre.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

    }
}
