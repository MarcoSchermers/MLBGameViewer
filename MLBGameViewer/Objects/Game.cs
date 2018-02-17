using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLBGameViewer.Objects;

namespace MLBGameViewer
{

    public class Game
    {
        public string id { get; set; }
        public string status { get; set; }
        public string coverage { get; set; }
        public string scheduled { get; set; }
        public string day_night { get; set; }
        public string duration { get; set; }

        public int game_number { get; set; }
        public int attendance { get; set; }   
        
        public venue venue { get; set; }
        
        public team home { get; set; }
        public team away { get; set; }

    }

}
