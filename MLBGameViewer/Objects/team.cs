using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLBGameViewer.Objects;
using MLBGameViewer.Objects.Stats;

namespace MLBGameViewer

{
    public class team
    {
        public string id { get; set; }
        public string name { get; set; }
        public string market { get; set; }
        public string abbr { get; set; }

        public int runs { get; set; }
        public int hits { get; set; }
        public int errors { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public PlayerStats statistics { get; set; }

        public Pitcher probable_pitcher { get; set; }
        public Pitcher starting_pitcher { get; set; }

        public List<Player> roster { get; set; }
        public List<Player> lineup { get; set; }
        public List<Inning> scoring{ get; set; }
        public List<Player> players { get; set; }
    }

}
