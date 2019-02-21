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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            games.gamesDate = gamesDateSelect.Value;


            SelectedSchedule = games.Request();



            new MainForm().Show(this);


            this.Hide();

            Console.WriteLine("kappa");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
