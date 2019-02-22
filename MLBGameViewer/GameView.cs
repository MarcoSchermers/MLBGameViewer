using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLBGameViewer.Objects;

namespace MLBGameViewer
{
    public partial class GameView : Form
    {
        public GameView()
        {
            InitializeComponent();
        }


        private dynamic lineScore;
        private dynamic boxScore;

        /// <summary>
        /// add given team's data to given row index
        /// </summary>
        /// <param name="team">which team's data to add</param>
        /// <param name="row">row it is added to</param>
        private void populateLineScore() {
            dataLineScore.Rows[0].Cells[0].Value = boxScore.teams.away.team.shortName;
            dataLineScore.Rows[1].Cells[0].Value = boxScore.teams.home.team.shortName;
            for (int i = 0; i < lineScore.innings.Count; i++)
            {
                dataLineScore.Rows[0].Cells[i + 1].Value = lineScore.innings[i].away.runs;
                dataLineScore.Rows[1].Cells[i + 1].Value = lineScore.innings[i].home.runs;
            }
            
        }


        /// <summary>
        /// get lineup for game and add it to respective lineup dataGrid
        /// </summary>
        /// <param name="team">team lineup to add</param>
        /// <param name="grid">grid to add it to</param>
        private void populateLineup(string team, DataGridView grid) {
            if (team == "away")
            {
                int j = 1;
                for (int i = 0; i < boxScore.teams.away.battingOrder.Count; i++)
                {
                    foreach(dynamic batter in boxScore.teams.away.players)
                    {
                        if (batter.First.person.id == boxScore.teams.away.battingOrder[i])
                        {
                            grid.Rows.Add(j, batter.First.person.fullName, batter.First.position.abbreviation);
                            j++;
                        }
                    }
                }
            }
            else
            {
                int j = 1;
                for (int i = 0; i < boxScore.teams.home.battingOrder.Count; i++)
                {
                    foreach (dynamic batter in boxScore.teams.home.players)
                    {
                        if (batter.First.person.id == boxScore.teams.home.battingOrder[i])
                        {
                            grid.Rows.Add(j, batter.First.person.fullName, batter.First.position.abbreviation);
                            j++;
                        }
                    }
                }
            }
            //dynamically resize reach row height
            for (int i = 0; i < grid.Rows.Count; i++) {
                grid.Rows[i].Height = (grid.Height - grid.ColumnHeadersHeight) / grid.Rows.Count;
            }

            grid.Sort(grid.Columns[0], ListSortDirection.Ascending);
        }

        private void GameView_Load(object sender, EventArgs e)
        {

            lineScore = MainForm.requestedGame.lineScore;
            boxScore = MainForm.requestedGame.boxScore;


            //get away team name and set label
            awayTeamLbl.Text = boxScore.teams.away.team.name;

            //add each team's row to linescore
            dataLineScore.Rows.Add(boxScore.teams.away.team.name);
            dataLineScore.Rows.Add(boxScore.teams.home.team.name);

            //add each team's data to line score
            populateLineScore();

            //get home team's name and set label
            homeTeamLbl.Text = boxScore.teams.home.team.name;

            //changing position of label based on length of name
            homeTeamLbl.Location = new Point(panelTitle.Size.Width - homeTeamLbl.Size.Width - 3, 18);

            //get lineup for game and add it to respective lineup dataGrid
            populateLineup("away", dataAwayLineup);
            populateLineup("home", dataHomeLineup);

            //set height of data grid view to be fluch with data
            dataLineScore.Size = new Size(dataLineScore.Size.Width, 2 * dataLineScore.Rows[0].Height + dataLineScore.ColumnHeadersHeight);

            //sorted lineup lists
            //awayLineup = MainForm.requestedGame.game.teams.away.lineup.OrderBy(p => p.order).ToList<Player>();
            //homeLineup = MainForm.requestedGame.game.teams.home.lineup.OrderBy(p => p.order).ToList<Player>();

        }

        private void GameView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataAwayLineup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
