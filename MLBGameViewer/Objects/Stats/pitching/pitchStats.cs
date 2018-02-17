namespace MLBGameViewer.Objects.Stats
{
    public class pitchStats
    {
        public float oba { get; set; }
        public int lob { get; set; }
        public float era { get; set; }
        public float k9 { get; set; }
        public float whip { get; set; }
        public float kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public float ip_1 { get; set; }
        public float ip_2 { get; set; }
        public int bf { get; set; }
        public float gofo { get; set; }

        public onbaseStats onbase { get; set; }
        public runStats runs { get; set; }
        public outcomeStats outcome { get; set; }
        public outStats outs { get; set; }
        public stealStats steal { get; set; }
        public gamesStats games { get; set; }
    }
}