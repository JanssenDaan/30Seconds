using _30SecondsDjan.Objects;
using DjanControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;/
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
        public ReadFileForm ReadFileForm = new ReadFileForm();
        public List<string> WordsDjan = new List<string>();
        public List<string> WordsDoneDjan = new List<string>();

        public string playerNames { get; set; }
        public int Countdown { get; set; }

        public MainForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (pnlPlayersDjan.Controls.Count >= 9)
            {
                h.ShowError("Jammer, max 8 spelers");
                return;
            }
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
            if (pnlTeamsDjan.Controls.Count >= 5)
            {
                h.ShowError("Jammer, max 4 teams!");
                return;
            }
            TeamControlDjan = new UCTeam();

            TeamControlDjan.TeamDjan.TeamName = $"{CurrentIDTeamsDjan}";
            TeamControlDjan.lblTeamNameValueDjan.Text = CurrentIDTeamsDjan.ToString();

            TeamControlDjan.TeamDjan.TeamID = CurrentIDTeamsDjan;
            
            pnlTeamsDjan.Controls.Add(TeamControlDjan);
            CurrentIDTeamsDjan++;
        }

        private void btnToGameSettingsDjan_Click(object sender, EventArgs e)
        {
            if (pnlPlayersDjan.Controls.Count > 3 && pnlTeamsDjan.Controls.Count > 1)
            {
                lbxTeamsDjan.Items.Clear();
                tclOne.SelectedTab = tbpGameDjan;
                ucTeamList = pnlTeamsDjan.Controls.OfType<UCTeam>().ToList(); ;

                foreach (UCTeam team in ucTeamList)
                {
                    lbxTeamsDjan.Items.Add(team.TeamDjan);
                }

                lbxTeamsDjan.DisplayMember = "TeamName";
                lbxTeamsDjan.ValueMember = "TeamName";
            }
            else
            {
                h.ShowError("Minimaal 2 teams en 4 spelers.");
            }
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
            foreach (UCPlayerDjan p in pnlPlayersDjan.Controls.OfType<UCPlayerDjan>().ToList())
            {
                GameDetails.Players.Add(p.PlayerDjan);
            }

            foreach (UCTeam t in ucTeamList)
            {
                GameDetails.TeamsDjan.Add(t.TeamDjan);
            }
            ReadFileForm = new ReadFileForm();
            ReadFileForm.Show();
        }

        public void GoToGameDjan(List<string> list)
        {
            tclOne.SelectedTab = tbpPlayDjan;
            WordsDjan = list;
            
        }

        private void btnStartPlayDjan_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Visible = false;
                tmrGamePlayDjan.Start();
                Countdown = 30;
            }
            btnNextPlayer.Visible = false;
            GetNextPlayerDjan();
            ChangeWordsDjan();
            lblTeamOneDjan.Text = $"Team {GameDetails.TeamsDjan[0].TeamName} Score: {GameDetails.ScoreT1Djan.ToString()}";
            lblTeamTwoDjan.Text = $"Team {GameDetails.TeamsDjan[1].TeamName} Score: {GameDetails.ScoreT2Djan.ToString()}";


            if (GameDetails.TeamsDjan.Count == 3 || GameDetails.TeamsDjan.Count == 4)
            {
                lblTeamThreeDjan.Text = $"Team {GameDetails.TeamsDjan[2].TeamName} Score: {GameDetails.ScoreT3Djan.ToString()}";
            }
            if (GameDetails.TeamsDjan.Count == 4)
            {
                lblTeamFourDjan.Text = $"Team {GameDetails.TeamsDjan[3].TeamName} Score: {GameDetails.ScoreT4Djan.ToString()}";
            }
            

        }

        private void GetNextPlayerDjan()
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            h.PlaySound(CurrentDirectory + "\\wait.wav");
            if (GameDetails.GamePlayerID == GameDetails.Players.Count)
            {
                GameDetails.GamePlayerID = 0;
            }
            GameDetails.CurrentPlayer = GameDetails.Players[GameDetails.GamePlayerID].Playername;

            lblCurrentPlayerDjan.Text = $"Current Player: {GameDetails.CurrentPlayer}  \nFrom Team: {GameDetails.Players[GameDetails.GamePlayerID].TeamName}";

            GameDetails.CurrentTeam = GameDetails.Players[GameDetails.GamePlayerID].TeamName;
            GameDetails.GamePlayerID++;
        }

        private void tmrGamePlayDjan_Tick(object sender, EventArgs e)
        {
            if (Countdown == 0)
            {
                tmrGamePlayDjan.Stop();
                pgbTimeDjan.Value = 0;
                pgbTimeDjan.Text = 0.ToString();
                btnNextPlayer.Visible = true;
            }
            else
            {
                pgbTimeDjan.Text = Countdown.ToString();
                pgbTimeDjan.Value = Countdown;
            }
            Countdown--;
        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            
            ChangeWordsDjan();

            lblTeamOneDjan.Text = $"Team {GameDetails.TeamsDjan[0].TeamName} Score: {GameDetails.ScoreT1Djan.ToString()}";
            lblTeamTwoDjan.Text = $"Team {GameDetails.TeamsDjan[1].TeamName} Score: {GameDetails.ScoreT2Djan.ToString()}";
            

            if (GameDetails.TeamsDjan.Count == 3 || GameDetails.TeamsDjan.Count == 4)
            {
                lblTeamThreeDjan.Text = $"Team {GameDetails.TeamsDjan[2].TeamName} Score: {GameDetails.ScoreT3Djan.ToString()}";
            }
            if (GameDetails.TeamsDjan.Count == 4)
            {
                lblTeamFourDjan.Text = $"Team {GameDetails.TeamsDjan[3].TeamName} Score: {GameDetails.ScoreT4Djan.ToString()}";
            }

            if (GameDetails.CurrentTeam == GameDetails.TeamsDjan[0].TeamName)
            {
                GameDetails.ScoreT1Djan = GameDetails.ScoreT1Djan + 
                    Convert.ToInt32(cbxOneDjan.Checked) + 
                    Convert.ToInt32(cbxTwoDjan.Checked) + 
                    Convert.ToInt32(cbxThreeDjan.Checked) + 
                    Convert.ToInt32(cbxFourDjan.Checked) + 
                    Convert.ToInt32(cbxFiveDjan.Checked);
                lblTeamOneDjan.Text = $"Team {GameDetails.TeamsDjan[0].TeamName} Score: {GameDetails.ScoreT1Djan.ToString()}";
            }
            if (GameDetails.CurrentTeam == GameDetails.TeamsDjan[1].TeamName)
            {
                GameDetails.ScoreT2Djan = GameDetails.ScoreT2Djan + 
                    Convert.ToInt32(cbxOneDjan.Checked) +
                    Convert.ToInt32(cbxTwoDjan.Checked) +
                    Convert.ToInt32(cbxThreeDjan.Checked) +
                    Convert.ToInt32(cbxFourDjan.Checked) +
                    Convert.ToInt32(cbxFiveDjan.Checked); 
                lblTeamTwoDjan.Text = $"Team {GameDetails.TeamsDjan[1].TeamName} Score: {GameDetails.ScoreT2Djan.ToString()}";
            }
            if (GameDetails.TeamsDjan.Count == 3 || GameDetails.TeamsDjan.Count == 4)
            {
                if (GameDetails.CurrentTeam == GameDetails.TeamsDjan[2].TeamName)
                {
                    GameDetails.ScoreT3Djan = GameDetails.ScoreT3Djan +
                    Convert.ToInt32(cbxOneDjan.Checked) +
                    Convert.ToInt32(cbxTwoDjan.Checked) +
                    Convert.ToInt32(cbxThreeDjan.Checked) +
                    Convert.ToInt32(cbxFourDjan.Checked) +
                    Convert.ToInt32(cbxFiveDjan.Checked);
                    lblTeamThreeDjan.Text = $"Team {GameDetails.TeamsDjan[2].TeamName} Score: {GameDetails.ScoreT3Djan.ToString()}";
                }
            }
            if (GameDetails.TeamsDjan.Count == 4)
            {
                if (GameDetails.CurrentTeam == GameDetails.TeamsDjan[3].TeamName)
                {
                    GameDetails.ScoreT4Djan = GameDetails.ScoreT4Djan +
                     Convert.ToInt32(cbxOneDjan.Checked) +
                     Convert.ToInt32(cbxTwoDjan.Checked) +
                     Convert.ToInt32(cbxThreeDjan.Checked) +
                     Convert.ToInt32(cbxFourDjan.Checked) +
                     Convert.ToInt32(cbxFiveDjan.Checked);
                    lblTeamFourDjan.Text = $"Team {GameDetails.TeamsDjan[3].TeamName} Score: {GameDetails.ScoreT4Djan.ToString()}";
                }
            }

            if (GameDetails.ScoreT1Djan >= 30)
            {
                h.ShowMessage($"Team: {GameDetails.TeamsDjan[0].TeamName} with players: {GetPlayerNames(GameDetails.TeamsDjan[0].TeamName)} has won!");
                btnNextPlayer.Visible = false;
                WriteFile(GetPlayerNames(GameDetails.TeamsDjan[0].TeamName), GameDetails.TeamsDjan[0].TeamName, GameDetails.ScoreT1Djan.ToString());
                return;
            }
            if (GameDetails.ScoreT2Djan >= 30)
            {
                h.ShowMessage($"Team: {GameDetails.TeamsDjan[1].TeamName} with players: {GetPlayerNames(GameDetails.TeamsDjan[1].TeamName)} has won!");
                btnNextPlayer.Visible = false;
                WriteFile(GetPlayerNames(GameDetails.TeamsDjan[1].TeamName), GameDetails.TeamsDjan[1].TeamName, GameDetails.ScoreT2Djan.ToString());

                return;
            }
            if (GameDetails.ScoreT3Djan >= 30)
            {
                h.ShowMessage($"Team: {GameDetails.TeamsDjan[2].TeamName} with players: {GetPlayerNames(GameDetails.TeamsDjan[2].TeamName)} has won!"); 
                btnNextPlayer.Visible = false;
                WriteFile(GetPlayerNames(GameDetails.TeamsDjan[2].TeamName), GameDetails.TeamsDjan[2].TeamName, GameDetails.ScoreT3Djan.ToString());
                return;
            }
            if (GameDetails.ScoreT4Djan >= 5)
            {
                h.ShowMessage($"Team: {GameDetails.TeamsDjan[3].TeamName} with players: {GetPlayerNames(GameDetails.TeamsDjan[3].TeamName)} has won!"); 
                btnNextPlayer.Visible = false;
                WriteFile(GetPlayerNames(GameDetails.TeamsDjan[3].TeamName), GameDetails.TeamsDjan[3].TeamName, GameDetails.ScoreT4Djan.ToString());
                return;
            }
            Countdown = 30;
            GetNextPlayerDjan();
            tmrGamePlayDjan.Start();
            btnNextPlayer.Visible = false;
            cbxOneDjan.Checked = false;
            cbxThreeDjan.Checked = false;
            cbxTwoDjan.Checked = false;
            cbxFourDjan.Checked = false;
            cbxFiveDjan.Checked = false;
        }

        private void WriteFile(string Players, string Team, string Points)
        {
            StreamWriter writer = new StreamWriter("winnings.txt", true);
            writer.WriteLine($"Congrats!, Players {Players} has won in team {Team} with {Points} points!");
            writer.Close();
        }

        private void ChangeWordsDjan()
        {
            

            lblWordOneDjan.Text = GetNextWord();
            lblWordTwoDjan.Text = GetNextWord();
            lblWordThreeDjan.Text = GetNextWord();
            lblWordFourDjan.Text = GetNextWord();
            lblWordFiveDjan.Text = GetNextWord();

        }

        public string GetNextWord()
        {
            string WordToReturnDjan = "";
            int indexDjan = h.RandomNumber(1, WordsDjan.Count + 1);
            WordToReturnDjan = WordsDjan[indexDjan];
            if (WordsDoneDjan.Contains(WordsDjan[indexDjan]))
            {
                return GetNextWord();
            }
            else
            {
                WordsDoneDjan.Add(WordToReturnDjan);
                return WordToReturnDjan;
            }
            return "";
        }

        public string GetPlayerNames(string TeamNameDjan)
        {
            playerNames = "";
            foreach (Player player in GameDetails.Players)
            {
                if (player.TeamName == TeamNameDjan)
                {
                    playerNames = playerNames + $"{player.Playername}, ";
                }
            }
            return playerNames;
        }

        private void btnStopGameDjan_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void StopGame()
        {
            GameDetails.TeamsDjan.Clear();
            GameDetails.Players.Clear();
            GameDetails.ScoreT1Djan = 0;
            GameDetails.ScoreT2Djan = 0;
            GameDetails.ScoreT3Djan = 0;
            GameDetails.ScoreT4Djan = 0;
            tmrGamePlayDjan.Stop();
            Countdown = 0;
            tclOne.SelectedTab = tbpHomeDjan;

            lblTeamOneDjan.Text = "--";
            lblTeamTwoDjan.Text = "--";
            lblTeamThreeDjan.Text = "--";
            lblTeamFourDjan.Text = "--";

            h.StopSound();
            btnStartGameDjan.Visible = true;
            //MainForm main = new MainForm();
            //main = new MainForm();
            //main.Show();
            //this.Close();

        }

        private void btnStopWhilePlay_Click(object sender, EventArgs e)
        {
            StopGame();
        }
    }
}
