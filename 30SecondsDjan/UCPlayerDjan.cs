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
        public List<UCTeam> UCTeamList { get; set; }
        public int ID { get; set; }
        public UCPlayerDjan()
        {
            InitializeComponent();
            lblIDDjan.Text = $"ID: {ID}";
        }

        private void btnChangeColorDjan_Click(object sender, EventArgs e)
        {
            cdlColorDjan.AllowFullOpen = true;
            cdlColorDjan.FullOpen = true;
            cdlColorDjan.ShowDialog();
            this.BackColor = cdlColorDjan.Color;
        }

       

        private void cbxTeamDjan_Click(object sender, EventArgs e)
        {
            cbxTeamDjan.Items.Clear();
            UCTeamList = MainForm.instance.pnlTeamsDjan.Controls.OfType<UCTeam>().ToList(); ;
            foreach (UCTeam uc in UCTeamList)
            {
                cbxTeamDjan.Items.Add(uc.TeamName);
            }
        }
    }
}
