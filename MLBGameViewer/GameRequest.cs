using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using MLBGameViewer.Objects;

namespace MLBGameViewer
{
    class GameRequest
    {
        public static string baseUrl = "https://api.sportradar.us/mlb-{0}6/games/{1}/summary.json?api_key={2}";

        public string APIKEY { get; set; }
        public string accessLevel { get; set; }
        public string gameId { get; set; }

        public string requestUrl;

        public selectedGame getGame() {
            requestUrl = String.Format(baseUrl, accessLevel, gameId, APIKEY);
            WebRequest r;
            r = WebRequest.Create(requestUrl);

            Stream responseStream = r.GetResponse().GetResponseStream();

            StreamReader sreader = new StreamReader(responseStream);
            var result = sreader.ReadToEnd();

            return JsonConvert.DeserializeObject<selectedGame>(result);
        }
    }
}
