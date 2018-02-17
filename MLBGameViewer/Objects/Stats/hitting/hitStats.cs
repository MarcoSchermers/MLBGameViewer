using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLBGameViewer.Objects.Stats
{
    public class hitStats
    {
        public int ab { get; set; }
        public int lob { get; set; }
        public int rbi { get; set; }
        public float abhr { get; set; }
        public float abk { get; set; }
        public int bip { get; set; }
        public float babip { get; set; }
        public float bbk { get; set; }
        public float bbpa { get; set; }
        public float iso { get; set; }
        public float obp { get; set; }
        public float ops { get; set; }
        public float seca { get; set; }
        public float slg { get; set; }
        public int xbh { get; set; }
        public int pitch_count { get; set; }
        public int lob_risp_2out { get; set; }
        public int team_lob { get; set; }
        public int ab_risp { get; set; }
        public int hit_risp { get; set; }
        public int rbi_2out { get; set; }
        public int linedrive { get; set; }
        public int groundball { get; set; }
        public int popup { get; set; }
        public int flyball { get; set; }
        public int ap { get; set; }
        public string avg { get; set; }
        public float gofo { get; set; }

        public onbaseStats onbase { get; set; }
        public runStats runs { get; set; }
        public outcomeStats outcome { get; set; }
        public outStats outs { get; set; }
        public stealStats steal { get; set; }
        public gamesStats games { get; set; }

    }
}
