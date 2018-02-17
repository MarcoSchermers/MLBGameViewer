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

        private String playerName = "{0} {1}";
        private List<Player> awayLineup = new List<Player>();
        private List<Player> homeLineup = new List<Player>();
        private String[] runs = new String[MainForm.requestedGame.game.away.scoring.Count];

        /// <summary>
        /// add given team's data to given row index
        /// </summary>
        /// <param name="team">which team's data to add</param>
        /// <param name="row">row it is added to</param>
        private void populateLineScore(team team, int row) {
            for (int i = 0; i < team.scoring.Count; i++)
            {
                runs[i] = team.scoring[i].runs;
            }
            for (int i = 1; i < dataLineScore.Rows[0].Cells.Count - 3; i++)
            {
                dataLineScore.Rows[row].Cells[i].Value = runs[i - 1];
            }
            dataLineScore.Rows[row].Cells[10].Value = team.runs;
            dataLineScore.Rows[row].Cells[11].Value = team.hits;
            dataLineScore.Rows[row].Cells[12].Value = team.errors;
        }


        /// <summary>
        /// get lineup for game and add it to respective lineup dataGrid
        /// </summary>
        /// <param name="team">team lineup to add</param>
        /// <param name="grid">grid to add it to</param>
        private void populateLineup(team team, DataGridView grid) {
            foreach (Player player in team.lineup)
            {
                foreach (Player rosPlayer in team.roster)
                {
                    if (player.id == rosPlayer.id)
                    {
                        playerName = String.Format(playerName, rosPlayer.first_name, rosPlayer.last_name);

                        grid.Rows.Add(player.order, playerName, rosPlayer.primary_position);
                        

                        playerName = "{0} {1}";
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
            //get away team name and set label
            awayTeamLbl.Text = MainForm.requestedGame.game.away.name;

            //add each team's row to linescore
            dataLineScore.Rows.Add(MainForm.requestedGame.game.away.name);
            dataLineScore.Rows.Add(MainForm.requestedGame.game.home.name);

            //add each team's data to line score
            populateLineScore(MainForm.requestedGame.game.away,0);
            populateLineScore(MainForm.requestedGame.game.home,1);

            //get home team's name and set label
            homeTeamLbl.Text = MainForm.requestedGame.game.home.name;

            //changing position of label based on length of name
            homeTeamLbl.Location = new Point(panelTitle.Size.Width - homeTeamLbl.Size.Width - 3, 18);

            //get lineup for game and add it to respective lineup dataGrid
            populateLineup(MainForm.requestedGame.game.away, dataAwayLineup);
            populateLineup(MainForm.requestedGame.game.home, dataHomeLineup);

            //set height of data grid view to be fluch with data
            dataLineScore.Size = new Size(dataLineScore.Size.Width, 2 * dataLineScore.Rows[0].Height + dataLineScore.ColumnHeadersHeight);

            //sorted lineup lists
            awayLineup = MainForm.requestedGame.game.away.lineup.OrderBy(p => p.order).ToList<Player>();
            homeLineup = MainForm.requestedGame.game.home.lineup.OrderBy(p => p.order).ToList<Player>();

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
