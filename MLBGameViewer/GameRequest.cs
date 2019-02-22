using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using MLBGameViewer.Objects;
using Newtonsoft.Json.Linq;

namespace MLBGameViewer
{
    class GameRequest
    {
        public static string baseUrl = "https://statsapi.mlb.com/api/v1/game/{0}/{1}";

        public string APIKEY { get; set; }
        public string accessLevel { get; set; }
        public string gameId { get; set; }

        public string requestUrl;


        public dynamic getBox() {
            requestUrl = String.Format(baseUrl, gameId, "boxscore");
            WebRequest r;
            r = WebRequest.Create(requestUrl);

            Stream responseStream = r.GetResponse().GetResponseStream();

            StreamReader sreader = new StreamReader(responseStream);
            var result = sreader.ReadToEnd();

            return JObject.Parse(result);
        }
        public dynamic getLine()
        {
            requestUrl = String.Format(baseUrl, gameId, "linescore");
            WebRequest r;
            r = WebRequest.Create(requestUrl);

            Stream responseStream = r.GetResponse().GetResponseStream();

            StreamReader sreader = new StreamReader(responseStream);
            var result = sreader.ReadToEnd();

            return JObject.Parse(result);
        }
        public selectedGame getGame()
        {
            return new selectedGame(getBox(), getLine());
        }
    }
}
