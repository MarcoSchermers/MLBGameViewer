using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLBGameViewer.Objects.Stats.fielding
{
    public class fieldStats
    {
        public int po { get; set; }
        public int a { get; set; }
        public int dp { get; set; }
        public int tp { get; set; }
        public int error { get; set; }
        public int tc { get; set; }
        public float fpct { get; set; }
        public int c_wp { get; set; }
        public int pb { get; set; }
        public float rf { get; set; }
        public errorStats errors { get; set; }
        public gamesStats games { get; set; }
    }
}
