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
        public static String baseUrl = "https://api.sportradar.us/mlb-{0}6/games/{1}/schedule.json?api_key={2}";

        public string APIKEY { get; set; }
        public string accessLevel { get; set; }
        public string gamesDate { get; set; }

        public static string requestUrl;

        public Schedule Request()
        {
            requestUrl = String.Format(baseUrl, accessLevel, gamesDate, APIKEY);
            WebRequest r;
            r = WebRequest.Create(requestUrl);

            Stream responseStream = r.GetResponse().GetResponseStream();

            StreamReader sreader = new StreamReader(responseStream);
            var result = sreader.ReadToEnd();

            return JsonConvert.DeserializeObject<Schedule>(result);
            Console.WriteLine("kappa");
        }
    }
}
