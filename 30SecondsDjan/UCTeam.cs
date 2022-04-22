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
    public partial class UCTeam : UserControl
    {
        public Team TeamDjan = new Team();
        public UCTeam()
        {
            InitializeComponent();
            lblTeamNameValueDjan.Text = TeamDjan.TeamName;
        }

        private void tbxChangeNameDjan_TextChanged(object sender, EventArgs e)
        {
            TeamDjan.TeamName = tbxChangeNameDjan.Text;
            lblTeamNameValueDjan.Text = tbxChangeNameDjan.Text;
        }

        private void btnCloseDjan_Click(object sender, EventArgs e)
        {
            MainForm.instance.pnlTeamsDjan.Controls.Remove(this);
        }

        private void UCTeam_Load(object sender, EventArgs e)
        {

        }
    }
}
