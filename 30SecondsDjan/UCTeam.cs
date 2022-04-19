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
        public string TeamName { get; set; }
        public int TeamID { get; set; }
        public UCTeam()
        {
            InitializeComponent();
            lblTeamNameValueDjan.Text = TeamName;
        }

        private void tbxChangeNameDjan_TextChanged(object sender, EventArgs e)
        {
            TeamName = tbxChangeNameDjan.Text;
            lblTeamNameValueDjan.Text = tbxChangeNameDjan.Text;
        }
    }
}
