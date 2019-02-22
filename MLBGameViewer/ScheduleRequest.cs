using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MLBGameViewer
{
    class ScheduleRequest
    {
        public static String baseUrl = "http://statsapi.mlb.com/api/v1/schedule/games/?sportId=1&date={0}";
        
        public DateTime gamesDate { get; set; }

        public static string requestUrl;

        public dynamic Request()
        {
            requestUrl = String.Format(baseUrl, gamesDate.ToString("d"));
            WebRequest r;
            r = WebRequest.Create(requestUrl);

            Stream responseStream = r.GetResponse().GetResponseStream();

            StreamReader sreader = new StreamReader(responseStream);
            var result = sreader.ReadToEnd();



            return JObject.Parse(result);
        }
    }
}
