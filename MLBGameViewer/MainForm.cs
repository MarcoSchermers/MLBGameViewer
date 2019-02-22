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
using Newtonsoft.Json.Linq;

namespace MLBGameViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private dynamic games;
        private GameRequest r = new GameRequest();

        public static selectedGame requestedGame;

        private void MainForm_Load(object sender, EventArgs e)
        {


            games = ((initForm)Owner).SelectedSchedule.dates[0].games;
            
            for (int i = 0; i < games.Count; i++)
            {
                gameList.Rows.Insert(i, games[i].teams.away.team.name, games[i].teams.home.team.name);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(games[gameList.CurrentRow.Index].gamePk);
            Console.WriteLine("kappa");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            r.gameId = games[gameList.CurrentRow.Index].gamePk;
            requestedGame = r.getGame();

            GameView gameViewer = new GameView();
            gameViewer.Show(this);

            this.Hide();

            Console.WriteLine(games[gameList.CurrentRow.Index].gamePk);
        }

        private void gameList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
