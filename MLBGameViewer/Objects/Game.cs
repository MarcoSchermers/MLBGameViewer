using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLBGameViewer.Objects;

namespace MLBGameViewer
{

    public class Game
    {
        public string gamePk { get; set; }
        public string link { get; set; }
        public gameSatus status { get; set; }
            
        public venue venue { get; set; }

        public teamSet teams { get; set; }

    }

}
