using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Droid_Cook.Controler
{
    public static class ApiAccessor
    {
        #region Attributes
        public static readonly string LOGIN = ConfigurationManager.AppSettings["LOGIN"];
        public static readonly string LOGINHEADER = ConfigurationManager.AppSettings["LOGINHEADER"];
        public static readonly string PASSWORD = ConfigurationManager.AppSettings["PASSWORD"];
        public static readonly string PASSWORDHEADER = ConfigurationManager.AppSettings["PASSWORDHEADER"];
        public static readonly string DESTINATION = ConfigurationManager.AppSettings["DESTINATION"];
        #endregion

        #region Methods public
        public static string JsonGetAuth(string url)
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
        public static T Deserialize<T>(string input)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return (T)js.Deserialize(input, typeof(T));
        }
        public static string Serialize(object input)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(input);
        }
        #endregion
    }
}
