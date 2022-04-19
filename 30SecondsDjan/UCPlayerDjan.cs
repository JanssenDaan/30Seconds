using _30SecondsDjan.Objects;
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
    public partial class UCPlayerDjan : UserControl
    {
        public Player PlayerDjan = new Player();
        public List<UCTeam> UCTeamList { get; set; }
        public UCPlayerDjan()
        {
            InitializeComponent();
            lblIDDjan.Text = $"ID: {PlayerDjan.ID}";

            
        }

        private void btnChangeColorDjan_Click(object sender, EventArgs e)
        {
            cdlColorDjan.AllowFullOpen = true;
            cdlColorDjan.FullOpen = true;
            cdlColorDjan.ShowDialog();
            this.BackColor = cdlColorDjan.Color;
            PlayerDjan.color = cdlColorDjan.Color; 
        }

        private void cbxTeamDjan_Click(object sender, EventArgs e)
        {
            cbxTeamDjan.Items.Clear();
            UCTeamList = MainForm.instance.pnlTeamsDjan.Controls.OfType<UCTeam>().ToList(); ;
            foreach (UCTeam uc in UCTeamList)
            {
                cbxTeamDjan.Items.Add(uc.TeamDjan.TeamName);
            }
        }

        private void tbxChangePlayernameDjan_TextChanged(object sender, EventArgs e)
        {
            lblPlayerNameDjan.Text = tbxChangePlayernameDjan.Text;
            PlayerDjan.Playername = tbxChangePlayernameDjan.Text;
        }

        private void btnCloseDjan_Click(object sender, EventArgs e)
        {
            MainForm.instance.pnlPlayersDjan.Controls.Remove(this);
        }

        private void cbxTeamDjan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cbx)
            {
                PlayerDjan.TeamName = cbx.Text;
            }
            
        }
    }
}
