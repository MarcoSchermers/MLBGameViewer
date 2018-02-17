using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLBGameViewer.Objects
{
    public class Pitcher : Player
    {
        public int win { get; set; }
        public int loss { get; set; }
        public float era { get; set; }
    }
}
