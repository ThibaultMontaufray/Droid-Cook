using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace UnitTestProject
{
    [TestClass]
    public class BaseTestApi
    {
        #region Attributes
        protected readonly string LOGIN = ConfigurationManager.AppSettings["LOGIN"];
        protected readonly string LOGINHEADER = ConfigurationManager.AppSettings["LOGINHEADER"];
        protected readonly string PASSWORD = ConfigurationManager.AppSettings["PASSWORD"];
        protected readonly string PASSWORDHEADER = ConfigurationManager.AppSettings["PASSWORDHEADER"];
        protected readonly string DESTINATION = ConfigurationManager.AppSettings["DESTINATION"];
        #endregion

        #region Constructor
        public BaseTestApi()
        {
        }
        #endregion

        #region Methods protected
        protected T Deserialize<T>(string input)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return (T)js.Deserialize(input, typeof(T));
        }
        protected string Serialize(object input)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(input);
        }

        protected WebResponse GetJsonResult(string url)
        {
            var webrequest = WebRequest.Create(url);
            webrequest.Method = "GET";
            return webrequest.GetResponse();
        }
        protected bool Authentication(string url, string login, string password)
        {
            string data = string.Format("clientId={0}&clientSecret={1}", login, password);
            var objText = SendData(url, data);
            var result = Deserialize<string>(objText);

            return result.Equals("Authorized");
        }
        protected string SendData(string url, string data)
        {
            try
            {
                byte[] dataStream = Encoding.UTF8.GetBytes(data);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentLength = dataStream.Length;
                Stream newStream = webRequest.GetRequestStream();

                newStream.Write(dataStream, 0, dataStream.Length);
                newStream.Close();
                WebResponse response = webRequest.GetResponse();

                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    return reader.ReadToEnd();
                }
            }
            catch (WebException exp)
            {
                using (var reader = new StreamReader(exp.Response.GetResponseStream()))
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    string ret = reader.ReadToEnd();
                    return string.IsNullOrEmpty(ret) ? exp.Message : ret;
                }
            }
        }
        protected string JsonPost(string url, string data)
        {
            try
            {
                byte[] dataStream = Encoding.UTF8.GetBytes(data);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/json";
                webRequest.ContentLength = dataStream.Length;
                Stream newStream = webRequest.GetRequestStream();

                newStream.Write(dataStream, 0, dataStream.Length);
                newStream.Close();
                WebResponse response = webRequest.GetResponse();

                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    return reader.ReadToEnd();
                }
            }
            catch (WebException exp)
            {
                using (var reader = new StreamReader(exp.Response.GetResponseStream()))
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    string ret = reader.ReadToEnd();
                    return string.IsNullOrEmpty(ret) ? exp.Message : ret;
                }
            }
        }
        protected string JsonGet(string url)
        {
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = "GET";
            WebResponse response = webRequest.GetResponse();

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                return reader.ReadToEnd();
            }
        }
        protected string JsonGetAuth(string url)
        {
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = "GET";
            webRequest.Headers.Add(LOGINHEADER, LOGIN);
            webRequest.Headers.Add(PASSWORDHEADER, PASSWORD);
            WebResponse response = webRequest.GetResponse();

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                return reader.ReadToEnd();
            }
        }
        protected async Task<HttpResponseMessage> JsonHead(string url)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, new Uri(url));

            HttpResponseMessage response = await httpClient.SendAsync(request);
            return response;
        }
        protected string JsonPut(string url, string data)
        {
            try
            {
                byte[] dataStream = Encoding.UTF8.GetBytes(data);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = "PUT";
                webRequest.ContentType = "application/json";
                webRequest.ContentLength = dataStream.Length;
                Stream newStream = webRequest.GetRequestStream();

                newStream.Write(dataStream, 0, dataStream.Length);
                newStream.Close();
                WebResponse response = webRequest.GetResponse();

                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    return reader.ReadToEnd();
                }
            }
            catch (WebException exp)
            {
                using (var reader = new StreamReader(exp.Response.GetResponseStream()))
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    string ret = reader.ReadToEnd();
                    return string.IsNullOrEmpty(ret) ? exp.Message : ret;
                }
            }
        }
        protected string GetDataDump(string url)
        {
            WebRequest http = WebRequest.Create(url);
            http.Method = "GET";
            return GetResult(http);
        }
        protected string GetResult(WebRequest http)
        {
            string retVal = string.Empty;
            try
            {
                HttpWebResponse response = http.GetResponse() as HttpWebResponse;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    retVal = reader.ReadToEnd();
                }
                response.Close();
            }
            catch (WebException exp)
            {
                using (var sr = new StreamReader(exp.Response.GetResponseStream()))
                {
                    retVal = sr.ReadToEnd();
                }
            }
            return retVal;
        }
        #endregion

        #region Methods private
        #endregion
    }
}
