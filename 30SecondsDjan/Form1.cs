using DjanControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30SecondsDjan
{
    public partial class MainForm : Form
    {
        public static new MainForm instance { get; set; }
        public Helpers h = new Helpers();
        public UCPlayerDjan PlayerControlDjan = new UCPlayerDjan();
        public UCTeam TeamControlDjan = new UCTeam();
        public int CurrentIDPlayersDjan { get; set; } = 1;
        public int CurrentIDTeamsDjan { get; set; } = 1;

        public MainForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            PlayerControlDjan = new UCPlayerDjan();
            PlayerControlDjan.ID = CurrentIDPlayersDjan;
            PlayerControlDjan.lblIDDjan.Text = CurrentIDPlayersDjan.ToString();
            PlayerControlDjan.BackColor = h.GetRandomColor();
            pnlPlayersDjan.Controls.Add(PlayerControlDjan);
            CurrentIDPlayersDjan++;
        }

        private void btnAddTeamsDjan_Click(object sender, EventArgs e)
        {
            TeamControlDjan = new UCTeam();
            TeamControlDjan.TeamName = $"{CurrentIDTeamsDjan}";
            TeamControlDjan.lblTeamNameValueDjan.Text = CurrentIDTeamsDjan.ToString();
            TeamControlDjan.TeamID = CurrentIDTeamsDjan;
            pnlTeamsDjan.Controls.Add(TeamControlDjan);
            CurrentIDTeamsDjan++;
        }

        
    }
}
