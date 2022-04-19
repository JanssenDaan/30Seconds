namespace _30SecondsDjan
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tclOne = new System.Windows.Forms.TabControl();
            this.tbpHomeDjan = new System.Windows.Forms.TabPage();
            this.btnToGameSettingsDjan = new System.Windows.Forms.Button();
            this.pnlTeamsDjan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTeamsDjan = new System.Windows.Forms.Button();
            this.pnlPlayersDjan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.tbpGameDjan = new System.Windows.Forms.TabPage();
            this.btnStartGameDjan = new System.Windows.Forms.Button();
            this.lbxPlayersDjan = new System.Windows.Forms.ListBox();
            this.btnStopGameDjan = new System.Windows.Forms.Button();
            this.lbxTeamsDjan = new System.Windows.Forms.ListBox();
            this.tbpPlayDjan = new System.Windows.Forms.TabPage();
            this.btnNextPlayer = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.GroupBox();
            this.lblTeamFourDjan = new System.Windows.Forms.Label();
            this.lblTeamThreeDjan = new System.Windows.Forms.Label();
            this.lblTeamTwoDjan = new System.Windows.Forms.Label();
            this.lblTeamOneDjan = new System.Windows.Forms.Label();
            this.pgbTimeDjan = new CircularProgressBar.CircularProgressBar();
            this.btnStartPlayDjan = new System.Windows.Forms.Button();
            this.lblCurrentPlayerDjan = new System.Windows.Forms.Label();
            this.tmrGamePlayDjan = new System.Windows.Forms.Timer(this.components);
            this.cbxOneDjan = new System.Windows.Forms.CheckBox();
            this.lblWordOneDjan = new System.Windows.Forms.Label();
            this.lblWordTwoDjan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWordThreeDjan = new System.Windows.Forms.Label();
            this.lblWordFourDjan = new System.Windows.Forms.Label();
            this.lblWordFiveDjan = new System.Windows.Forms.Label();
            this.cbxFourDjan = new System.Windows.Forms.CheckBox();
            this.cbxTwoDjan = new System.Windows.Forms.CheckBox();
            this.cbxThreeDjan = new System.Windows.Forms.CheckBox();
            this.cbxFiveDjan = new System.Windows.Forms.CheckBox();
            this.tclOne.SuspendLayout();
            this.tbpHomeDjan.SuspendLayout();
            this.tbpGameDjan.SuspendLayout();
            this.tbpPlayDjan.SuspendLayout();
            this.e.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclOne
            // 
            this.tclOne.Controls.Add(this.tbpHomeDjan);
            this.tclOne.Controls.Add(this.tbpGameDjan);
            this.tclOne.Controls.Add(this.tbpPlayDjan);
            this.tclOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclOne.Location = new System.Drawing.Point(0, 0);
            this.tclOne.Name = "tclOne";
            this.tclOne.SelectedIndex = 0;
            this.tclOne.Size = new System.Drawing.Size(1122, 561);
            this.tclOne.TabIndex = 0;
            // 
            // tbpHomeDjan
            // 
            this.tbpHomeDjan.Controls.Add(this.btnToGameSettingsDjan);
            this.tbpHomeDjan.Controls.Add(this.pnlTeamsDjan);
            this.tbpHomeDjan.Controls.Add(this.btnAddTeamsDjan);
            this.tbpHomeDjan.Controls.Add(this.pnlPlayersDjan);
            this.tbpHomeDjan.Controls.Add(this.btnAddPlayer);
            this.tbpHomeDjan.Location = new System.Drawing.Point(4, 22);
            this.tbpHomeDjan.Name = "tbpHomeDjan";
            this.tbpHomeDjan.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHomeDjan.Size = new System.Drawing.Size(1114, 535);
            this.tbpHomeDjan.TabIndex = 0;
            this.tbpHomeDjan.Text = "Home";
            this.tbpHomeDjan.UseVisualStyleBackColor = true;
            // 
            // btnToGameSettingsDjan
            // 
            this.btnToGameSettingsDjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToGameSettingsDjan.Location = new System.Drawing.Point(858, 6);
            this.btnToGameSettingsDjan.Name = "btnToGameSettingsDjan";
            this.btnToGameSettingsDjan.Size = new System.Drawing.Size(248, 83);
            this.btnToGameSettingsDjan.TabIndex = 5;
            this.btnToGameSettingsDjan.Text = "Next";
            this.btnToGameSettingsDjan.UseVisualStyleBackColor = true;
            this.btnToGameSettingsDjan.Click += new System.EventHandler(this.btnToGameSettingsDjan_Click);
            // 
            // pnlTeamsDjan
            // 
            this.pnlTeamsDjan.AutoScroll = true;
            this.pnlTeamsDjan.Location = new System.Drawing.Point(146, 6);
            this.pnlTeamsDjan.Name = "pnlTeamsDjan";
            this.pnlTeamsDjan.Size = new System.Drawing.Size(238, 521);
            this.pnlTeamsDjan.TabIndex = 4;
            // 
            // btnAddTeamsDjan
            // 
            this.btnAddTeamsDjan.Location = new System.Drawing.Point(5, 6);
            this.btnAddTeamsDjan.Name = "btnAddTeamsDjan";
            this.btnAddTeamsDjan.Size = new System.Drawing.Size(135, 46);
            this.btnAddTeamsDjan.TabIndex = 2;
            this.btnAddTeamsDjan.Text = "Add Team";
            this.btnAddTeamsDjan.UseVisualStyleBackColor = true;
            this.btnAddTeamsDjan.Click += new System.EventHandler(this.btnAddTeamsDjan_Click);
            // 
            // pnlPlayersDjan
            // 
            this.pnlPlayersDjan.AutoScroll = true;
            this.pnlPlayersDjan.Location = new System.Drawing.Point(531, 8);
            this.pnlPlayersDjan.Name = "pnlPlayersDjan";
            this.pnlPlayersDjan.Size = new System.Drawing.Size(321, 521);
            this.pnlPlayersDjan.TabIndex = 1;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(390, 8);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(135, 46);
            this.btnAddPlayer.TabIndex = 0;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // tbpGameDjan
            // 
            this.tbpGameDjan.Controls.Add(this.btnStartGameDjan);
            this.tbpGameDjan.Controls.Add(this.lbxPlayersDjan);
            this.tbpGameDjan.Controls.Add(this.btnStopGameDjan);
            this.tbpGameDjan.Controls.Add(this.lbxTeamsDjan);
            this.tbpGameDjan.Location = new System.Drawing.Point(4, 22);
            this.tbpGameDjan.Name = "tbpGameDjan";
            this.tbpGameDjan.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGameDjan.Size = new System.Drawing.Size(1114, 535);
            this.tbpGameDjan.TabIndex = 1;
            this.tbpGameDjan.Text = "Game";
            this.tbpGameDjan.UseVisualStyleBackColor = true;
            // 
            // btnStartGameDjan
            // 
            this.btnStartGameDjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGameDjan.Location = new System.Drawing.Point(531, 7);
            this.btnStartGameDjan.Name = "btnStartGameDjan";
            this.btnStartGameDjan.Size = new System.Drawing.Size(575, 305);
            this.btnStartGameDjan.TabIndex = 3;
            this.btnStartGameDjan.Text = "Start Game!";
            this.btnStartGameDjan.UseVisualStyleBackColor = true;
            this.btnStartGameDjan.Click += new System.EventHandler(this.btnStartGameDjan_Click);
            // 
            // lbxPlayersDjan
            // 
            this.lbxPlayersDjan.FormattingEnabled = true;
            this.lbxPlayersDjan.Location = new System.Drawing.Point(363, 7);
            this.lbxPlayersDjan.Name = "lbxPlayersDjan";
            this.lbxPlayersDjan.Size = new System.Drawing.Size(161, 329);
            this.lbxPlayersDjan.TabIndex = 2;
            // 
            // btnStopGameDjan
            // 
            this.btnStopGameDjan.Location = new System.Drawing.Point(9, 7);
            this.btnStopGameDjan.Name = "btnStopGameDjan";
            this.btnStopGameDjan.Size = new System.Drawing.Size(140, 63);
            this.btnStopGameDjan.TabIndex = 1;
            this.btnStopGameDjan.Text = "Stop Game";
            this.btnStopGameDjan.UseVisualStyleBackColor = true;
            // 
            // lbxTeamsDjan
            // 
            this.lbxTeamsDjan.FormattingEnabled = true;
            this.lbxTeamsDjan.Location = new System.Drawing.Point(155, 6);
            this.lbxTeamsDjan.Name = "lbxTeamsDjan";
            this.lbxTeamsDjan.Size = new System.Drawing.Size(161, 329);
            this.lbxTeamsDjan.TabIndex = 0;
            this.lbxTeamsDjan.SelectedIndexChanged += new System.EventHandler(this.lbxTeamsDjan_SelectedIndexChanged);
            // 
            // tbpPlayDjan
            // 
            this.tbpPlayDjan.Controls.Add(this.cbxFiveDjan);
            this.tbpPlayDjan.Controls.Add(this.cbxThreeDjan);
            this.tbpPlayDjan.Controls.Add(this.cbxTwoDjan);
            this.tbpPlayDjan.Controls.Add(this.cbxFourDjan);
            this.tbpPlayDjan.Controls.Add(this.lblWordFiveDjan);
            this.tbpPlayDjan.Controls.Add(this.lblWordFourDjan);
            this.tbpPlayDjan.Controls.Add(this.lblWordThreeDjan);
            this.tbpPlayDjan.Controls.Add(this.label3);
            this.tbpPlayDjan.Controls.Add(this.lblWordTwoDjan);
            this.tbpPlayDjan.Controls.Add(this.lblWordOneDjan);
            this.tbpPlayDjan.Controls.Add(this.cbxOneDjan);
            this.tbpPlayDjan.Controls.Add(this.btnNextPlayer);
            this.tbpPlayDjan.Controls.Add(this.e);
            this.tbpPlayDjan.Controls.Add(this.pgbTimeDjan);
            this.tbpPlayDjan.Controls.Add(this.btnStartPlayDjan);
            this.tbpPlayDjan.Controls.Add(this.lblCurrentPlayerDjan);
            this.tbpPlayDjan.Location = new System.Drawing.Point(4, 22);
            this.tbpPlayDjan.Name = "tbpPlayDjan";
            this.tbpPlayDjan.Size = new System.Drawing.Size(1114, 535);
            this.tbpPlayDjan.TabIndex = 2;
            this.tbpPlayDjan.Text = "Play";
            this.tbpPlayDjan.UseVisualStyleBackColor = true;
            // 
            // btnNextPlayer
            // 
            this.btnNextPlayer.Location = new System.Drawing.Point(482, 49);
            this.btnNextPlayer.Name = "btnNextPlayer";
            this.btnNextPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnNextPlayer.TabIndex = 4;
            this.btnNextPlayer.Text = "Next";
            this.btnNextPlayer.UseVisualStyleBackColor = true;
            this.btnNextPlayer.Click += new System.EventHandler(this.btnNextPlayer_Click);
            // 
            // e
            // 
            this.e.Controls.Add(this.lblTeamFourDjan);
            this.e.Controls.Add(this.lblTeamThreeDjan);
            this.e.Controls.Add(this.lblTeamTwoDjan);
            this.e.Controls.Add(this.lblTeamOneDjan);
            this.e.Location = new System.Drawing.Point(806, 3);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(305, 242);
            this.e.TabIndex = 3;
            this.e.TabStop = false;
            this.e.Text = "GameStats";
            // 
            // lblTeamFourDjan
            // 
            this.lblTeamFourDjan.AutoSize = true;
            this.lblTeamFourDjan.Location = new System.Drawing.Point(7, 92);
            this.lblTeamFourDjan.Name = "lblTeamFourDjan";
            this.lblTeamFourDjan.Size = new System.Drawing.Size(10, 13);
            this.lblTeamFourDjan.TabIndex = 3;
            this.lblTeamFourDjan.Text = "-";
            // 
            // lblTeamThreeDjan
            // 
            this.lblTeamThreeDjan.AutoSize = true;
            this.lblTeamThreeDjan.Location = new System.Drawing.Point(7, 69);
            this.lblTeamThreeDjan.Name = "lblTeamThreeDjan";
            this.lblTeamThreeDjan.Size = new System.Drawing.Size(10, 13);
            this.lblTeamThreeDjan.TabIndex = 2;
            this.lblTeamThreeDjan.Text = "-";
            // 
            // lblTeamTwoDjan
            // 
            this.lblTeamTwoDjan.AutoSize = true;
            this.lblTeamTwoDjan.Location = new System.Drawing.Point(7, 46);
            this.lblTeamTwoDjan.Name = "lblTeamTwoDjan";
            this.lblTeamTwoDjan.Size = new System.Drawing.Size(10, 13);
            this.lblTeamTwoDjan.TabIndex = 1;
            this.lblTeamTwoDjan.Text = "-";
            // 
            // lblTeamOneDjan
            // 
            this.lblTeamOneDjan.AutoSize = true;
            this.lblTeamOneDjan.Location = new System.Drawing.Point(7, 24);
            this.lblTeamOneDjan.Name = "lblTeamOneDjan";
            this.lblTeamOneDjan.Size = new System.Drawing.Size(10, 13);
            this.lblTeamOneDjan.TabIndex = 0;
            this.lblTeamOneDjan.Text = "-";
            // 
            // pgbTimeDjan
            // 
            this.pgbTimeDjan.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pgbTimeDjan.AnimationSpeed = 500;
            this.pgbTimeDjan.BackColor = System.Drawing.Color.Transparent;
            this.pgbTimeDjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pgbTimeDjan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pgbTimeDjan.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pgbTimeDjan.InnerMargin = 2;
            this.pgbTimeDjan.InnerWidth = -1;
            this.pgbTimeDjan.Location = new System.Drawing.Point(841, 251);
            this.pgbTimeDjan.MarqueeAnimationSpeed = 2000;
            this.pgbTimeDjan.Maximum = 30;
            this.pgbTimeDjan.Name = "pgbTimeDjan";
            this.pgbTimeDjan.OuterColor = System.Drawing.Color.Black;
            this.pgbTimeDjan.OuterMargin = -25;
            this.pgbTimeDjan.OuterWidth = 26;
            this.pgbTimeDjan.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pgbTimeDjan.ProgressWidth = 25;
            this.pgbTimeDjan.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pgbTimeDjan.Size = new System.Drawing.Size(256, 259);
            this.pgbTimeDjan.StartAngle = 270;
            this.pgbTimeDjan.Step = 1;
            this.pgbTimeDjan.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pgbTimeDjan.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pgbTimeDjan.SubscriptText = "";
            this.pgbTimeDjan.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pgbTimeDjan.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pgbTimeDjan.SuperscriptText = "";
            this.pgbTimeDjan.TabIndex = 2;
            this.pgbTimeDjan.Text = "30";
            this.pgbTimeDjan.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pgbTimeDjan.Value = 30;
            // 
            // btnStartPlayDjan
            // 
            this.btnStartPlayDjan.Location = new System.Drawing.Point(482, 18);
            this.btnStartPlayDjan.Name = "btnStartPlayDjan";
            this.btnStartPlayDjan.Size = new System.Drawing.Size(75, 23);
            this.btnStartPlayDjan.TabIndex = 1;
            this.btnStartPlayDjan.Text = "Start Game";
            this.btnStartPlayDjan.UseVisualStyleBackColor = true;
            this.btnStartPlayDjan.Click += new System.EventHandler(this.btnStartPlayDjan_Click);
            // 
            // lblCurrentPlayerDjan
            // 
            this.lblCurrentPlayerDjan.AutoSize = true;
            this.lblCurrentPlayerDjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayerDjan.Location = new System.Drawing.Point(19, 18);
            this.lblCurrentPlayerDjan.Name = "lblCurrentPlayerDjan";
            this.lblCurrentPlayerDjan.Size = new System.Drawing.Size(156, 25);
            this.lblCurrentPlayerDjan.TabIndex = 0;
            this.lblCurrentPlayerDjan.Text = "CurrentPlayer: ";
            // 
            // tmrGamePlayDjan
            // 
            this.tmrGamePlayDjan.Enabled = true;
            this.tmrGamePlayDjan.Interval = 1000;
            this.tmrGamePlayDjan.Tick += new System.EventHandler(this.tmrGamePlayDjan_Tick);
            // 
            // cbxOneDjan
            // 
            this.cbxOneDjan.AutoSize = true;
            this.cbxOneDjan.Location = new System.Drawing.Point(275, 228);
            this.cbxOneDjan.Name = "cbxOneDjan";
            this.cbxOneDjan.Size = new System.Drawing.Size(80, 17);
            this.cbxOneDjan.TabIndex = 5;
            this.cbxOneDjan.Text = "checkBox1";
            this.cbxOneDjan.UseVisualStyleBackColor = true;
            // 
            // lblWordOneDjan
            // 
            this.lblWordOneDjan.AutoSize = true;
            this.lblWordOneDjan.Location = new System.Drawing.Point(22, 232);
            this.lblWordOneDjan.Name = "lblWordOneDjan";
            this.lblWordOneDjan.Size = new System.Drawing.Size(16, 13);
            this.lblWordOneDjan.TabIndex = 6;
            this.lblWordOneDjan.Text = "---";
            // 
            // lblWordTwoDjan
            // 
            this.lblWordTwoDjan.AutoSize = true;
            this.lblWordTwoDjan.Location = new System.Drawing.Point(22, 271);
            this.lblWordTwoDjan.Name = "lblWordTwoDjan";
            this.lblWordTwoDjan.Size = new System.Drawing.Size(16, 13);
            this.lblWordTwoDjan.TabIndex = 7;
            this.lblWordTwoDjan.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "---";
            // 
            // lblWordThreeDjan
            // 
            this.lblWordThreeDjan.AutoSize = true;
            this.lblWordThreeDjan.Location = new System.Drawing.Point(22, 311);
            this.lblWordThreeDjan.Name = "lblWordThreeDjan";
            this.lblWordThreeDjan.Size = new System.Drawing.Size(16, 13);
            this.lblWordThreeDjan.TabIndex = 8;
            this.lblWordThreeDjan.Text = "---";
            // 
            // lblWordFourDjan
            // 
            this.lblWordFourDjan.AutoSize = true;
            this.lblWordFourDjan.Location = new System.Drawing.Point(22, 353);
            this.lblWordFourDjan.Name = "lblWordFourDjan";
            this.lblWordFourDjan.Size = new System.Drawing.Size(16, 13);
            this.lblWordFourDjan.TabIndex = 9;
            this.lblWordFourDjan.Text = "---";
            // 
            // lblWordFiveDjan
            // 
            this.lblWordFiveDjan.AutoSize = true;
            this.lblWordFiveDjan.Location = new System.Drawing.Point(22, 393);
            this.lblWordFiveDjan.Name = "lblWordFiveDjan";
            this.lblWordFiveDjan.Size = new System.Drawing.Size(16, 13);
            this.lblWordFiveDjan.TabIndex = 10;
            this.lblWordFiveDjan.Text = "---";
            // 
            // cbxFourDjan
            // 
            this.cbxFourDjan.AutoSize = true;
            this.cbxFourDjan.Location = new System.Drawing.Point(275, 349);
            this.cbxFourDjan.Name = "cbxFourDjan";
            this.cbxFourDjan.Size = new System.Drawing.Size(80, 17);
            this.cbxFourDjan.TabIndex = 11;
            this.cbxFourDjan.Text = "checkBox2";
            this.cbxFourDjan.UseVisualStyleBackColor = true;
            // 
            // cbxTwoDjan
            // 
            this.cbxTwoDjan.AutoSize = true;
            this.cbxTwoDjan.Location = new System.Drawing.Point(275, 267);
            this.cbxTwoDjan.Name = "cbxTwoDjan";
            this.cbxTwoDjan.Size = new System.Drawing.Size(80, 17);
            this.cbxTwoDjan.TabIndex = 11;
            this.cbxTwoDjan.Text = "checkBox2";
            this.cbxTwoDjan.UseVisualStyleBackColor = true;
            // 
            // cbxThreeDjan
            // 
            this.cbxThreeDjan.AutoSize = true;
            this.cbxThreeDjan.Location = new System.Drawing.Point(275, 307);
            this.cbxThreeDjan.Name = "cbxThreeDjan";
            this.cbxThreeDjan.Size = new System.Drawing.Size(80, 17);
            this.cbxThreeDjan.TabIndex = 12;
            this.cbxThreeDjan.Text = "checkBox4";
            this.cbxThreeDjan.UseVisualStyleBackColor = true;
            // 
            // cbxFiveDjan
            // 
            this.cbxFiveDjan.AutoSize = true;
            this.cbxFiveDjan.Location = new System.Drawing.Point(275, 389);
            this.cbxFiveDjan.Name = "cbxFiveDjan";
            this.cbxFiveDjan.Size = new System.Drawing.Size(80, 17);
            this.cbxFiveDjan.TabIndex = 13;
            this.cbxFiveDjan.Text = "checkBox5";
            this.cbxFiveDjan.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 561);
            this.Controls.Add(this.tclOne);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tclOne.ResumeLayout(false);
            this.tbpHomeDjan.ResumeLayout(false);
            this.tbpGameDjan.ResumeLayout(false);
            this.tbpPlayDjan.ResumeLayout(false);
            this.tbpPlayDjan.PerformLayout();
            this.e.ResumeLayout(false);
            this.e.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclOne;
        private System.Windows.Forms.TabPage tbpHomeDjan;
        private System.Windows.Forms.TabPage tbpGameDjan;
        private System.Windows.Forms.TabPage tbpPlayDjan;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnAddTeamsDjan;
        public System.Windows.Forms.FlowLayoutPanel pnlTeamsDjan;
        public System.Windows.Forms.FlowLayoutPanel pnlPlayersDjan;
        private System.Windows.Forms.Button btnToGameSettingsDjan;
        private System.Windows.Forms.ListBox lbxTeamsDjan;
        private System.Windows.Forms.Button btnStopGameDjan;
        private System.Windows.Forms.ListBox lbxPlayersDjan;
        private System.Windows.Forms.Button btnStartGameDjan;
        private System.Windows.Forms.Label lblCurrentPlayerDjan;
        private System.Windows.Forms.Button btnStartPlayDjan;
        private CircularProgressBar.CircularProgressBar pgbTimeDjan;
        private System.Windows.Forms.Timer tmrGamePlayDjan;
        private System.Windows.Forms.GroupBox e;
        private System.Windows.Forms.Label lblTeamFourDjan;
        private System.Windows.Forms.Label lblTeamThreeDjan;
        private System.Windows.Forms.Label lblTeamTwoDjan;
        private System.Windows.Forms.Label lblTeamOneDjan;
        private System.Windows.Forms.Button btnNextPlayer;
        private System.Windows.Forms.CheckBox cbxFiveDjan;
        private System.Windows.Forms.CheckBox cbxThreeDjan;
        private System.Windows.Forms.CheckBox cbxTwoDjan;
        private System.Windows.Forms.CheckBox cbxFourDjan;
        private System.Windows.Forms.Label lblWordFiveDjan;
        private System.Windows.Forms.Label lblWordFourDjan;
        private System.Windows.Forms.Label lblWordThreeDjan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWordTwoDjan;
        private System.Windows.Forms.Label lblWordOneDjan;
        private System.Windows.Forms.CheckBox cbxOneDjan;
    }
}

