using _30SecondsDjan.Objects;
using DjanControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Player> SelectedPlayersDjan = new ObservableCollection<Player>();
        public int CurrentIDPlayersDjan { get; set; } = 1;
        public int CurrentIDTeamsDjan { get; set; } = 1;
        public List<UCTeam> ucTeamList = new List<UCTeam>();
        public List<UCPlayerDjan> UCPlayerListDjan = new List<UCPlayerDjan>();
        public GameDetails GameDetails = new GameDetails();



        public MainForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            PlayerControlDjan = new UCPlayerDjan();

            PlayerControlDjan.PlayerDjan.ID = CurrentIDPlayersDjan;
            PlayerControlDjan.lblIDDjan.Text = CurrentIDPlayersDjan.ToString();

            Color colorDjan = h.GetRandomColor();
            PlayerControlDjan.BackColor = colorDjan;
            PlayerControlDjan.PlayerDjan.color = colorDjan;

            PlayerControlDjan.lblPlayerNameDjan.Text = $"Player {CurrentIDPlayersDjan}";
            PlayerControlDjan.PlayerDjan.Playername = $"Player {CurrentIDPlayersDjan}";

            pnlPlayersDjan.Controls.Add(PlayerControlDjan);
            CurrentIDPlayersDjan++;
        }

        private void btnAddTeamsDjan_Click(object sender, EventArgs e)
        {
            TeamControlDjan = new UCTeam();

            TeamControlDjan.TeamDjan.TeamName = $"{CurrentIDTeamsDjan}";
            TeamControlDjan.lblTeamNameValueDjan.Text = CurrentIDTeamsDjan.ToString();

            TeamControlDjan.TeamDjan.TeamID = CurrentIDTeamsDjan;
            
            pnlTeamsDjan.Controls.Add(TeamControlDjan);
            CurrentIDTeamsDjan++;
        }

        private void btnToGameSettingsDjan_Click(object sender, EventArgs e)
        {
            tclOne.SelectedTab = tbpGameDjan;
            ucTeamList = pnlTeamsDjan.Controls.OfType<UCTeam>().ToList(); ;

            foreach (UCTeam team in ucTeamList)
            {
                lbxTeamsDjan.Items.Add(team.TeamDjan);
            }

            lbxTeamsDjan.DisplayMember = "TeamName";
            lbxTeamsDjan.ValueMember = "TeamName";
        }

        private void lbxTeamsDjan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPlayersDjan.Clear();
            lbxPlayersDjan.Items.Clear();
            if (sender is ListBox listBox)
            {
                
                    UCPlayerListDjan = pnlPlayersDjan.Controls.OfType<UCPlayerDjan>().ToList(); ;
                    foreach (UCPlayerDjan uc in UCPlayerListDjan)
                    {
                    if (uc.PlayerDjan.TeamName == listBox.Text)
                    {
                        SelectedPlayersDjan.Add(uc.PlayerDjan);
                    }
                }
                
            }
            

            lbxPlayersDjan.DisplayMember = "Player.Playername";
            foreach (Player p in SelectedPlayersDjan)
            {
                lbxPlayersDjan.Items.Add(p);
            }

        }

        private void btnStartGameDjan_Click(object sender, EventArgs e)
        {
            tclOne.SelectedTab = tbpGameDjan;
            foreach (UCPlayerDjan p in UCPlayerListDjan)
            {
                GameDetails.Players.Add(p.PlayerDjan);
            }

            foreach (UCTeam t in ucTeamList)
            {
                GameDetails.TeamsDjan.Add(t.TeamDjan);
            }
        }
    }
}
