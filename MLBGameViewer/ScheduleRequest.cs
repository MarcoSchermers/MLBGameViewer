using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace MLBGameViewer
{
    class ScheduleRequest
    {
        public static String baseUrl = "http://statsapi.mlb.com/api/v1/schedule/games/?sportId=1&date={0}";

        public string APIKEY { get; set; }
        public string accessLevel { get; set; }
        public DateTime gamesDate { get; set; }

        public static string requestUrl;

        public Schedule Request()
        {
            requestUrl = String.Format(baseUrl, gamesDate.ToString("d"));
            WebRequest r;
            r = WebRequest.Create(requestUrl);

            Stream responseStream = r.GetResponse().GetResponseStream();

            StreamReader sreader = new StreamReader(responseStream);
            var result = sreader.ReadToEnd();

            Schedule sched = JsonConvert.DeserializeObject<Schedule>(result);
            return JsonConvert.DeserializeObject<Schedule>(result);
            Console.WriteLine("kappa");
        }
    }
}
