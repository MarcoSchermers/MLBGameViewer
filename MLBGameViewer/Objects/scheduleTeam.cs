namespace MLBGameViewer
{
    public class scheduleTeam : team
    {
        //new
        public leagueRecord leagueRecord { get; set; }
        public string score { get; set; }
        public miniTeam team { get; set; }

    }
}