using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLBGameViewer.Objects.Stats
{
    public class PlayerStats
    {
        public HittingStats hitting { get; set; }
        public FieldingStats fielding { get; set; }
        public PitchingStats pitching { get; set; }
    }
}
