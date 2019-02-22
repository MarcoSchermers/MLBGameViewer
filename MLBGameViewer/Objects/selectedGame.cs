using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLBGameViewer.Objects
{
    public class selectedGame
    {
        public dynamic boxScore { get; set; }
        public dynamic lineScore { get; set; }

        public selectedGame(dynamic box, dynamic line)
        {
            this.boxScore = box;
            this.lineScore = line;
        }
    }
}
