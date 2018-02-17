using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLBGameViewer
{
    public partial class initForm : Form
    {
        public initForm()
        {
            InitializeComponent();
        }

        private ScheduleRequest games = new ScheduleRequest();
        private Schedule selectedSchedule;
        public bool trial;
        public string APIKEY;

        public Schedule SelectedSchedule { get => selectedSchedule; set => selectedSchedule = value; }

        private void initForm_Load(object sender, EventArgs e)
        {
            APIKEY = "97qg4ep2vwwhhax3bmy24rfn";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            trial = rbtnTrial.Checked;
            games.gamesDate = gamesDateSelect.Value.Date.ToString("yyyy/MM/dd");
            if (rbtnTrial.Checked)
            {
                games.accessLevel = "t";
            } else
            {
                games.accessLevel = "p";
            }
            
            //games.APIKEY = txtAPIKEY.Text;
            games.APIKEY = APIKEY;
            SelectedSchedule = games.Request();



            MainForm mainForm = new MainForm();
            mainForm.Show(this);


            this.Hide();

            Console.WriteLine("kappa");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
