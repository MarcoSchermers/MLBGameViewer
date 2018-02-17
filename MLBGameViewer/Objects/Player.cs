using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLBGameViewer.Objects.Stats;

namespace MLBGameViewer.Objects
{
    public class Player
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string id { get; set; }
        public string order { get; set; }

        public string status { get; set; }
        public string position { get; set; }
        public string primary_position { get; set; }

        public PlayerStats statistics { get; set; }


    }
}
