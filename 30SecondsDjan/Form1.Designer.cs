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
            this.tclOne = new System.Windows.Forms.TabControl();
            this.tbpHomeDjan = new System.Windows.Forms.TabPage();
            this.pnlTeamsDjan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTeamsDjan = new System.Windows.Forms.Button();
            this.pnlPlayersDjan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.tbpGameDjan = new System.Windows.Forms.TabPage();
            this.tbpPlayDjan = new System.Windows.Forms.TabPage();
            this.btnToGameSettingsDjan = new System.Windows.Forms.Button();
            this.lbxTeamsDjan = new System.Windows.Forms.ListBox();
            this.btnStopGameDjan = new System.Windows.Forms.Button();
            this.tclOne.SuspendLayout();
            this.tbpHomeDjan.SuspendLayout();
            this.tbpGameDjan.SuspendLayout();
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
            // tbpPlayDjan
            // 
            this.tbpPlayDjan.Location = new System.Drawing.Point(4, 22);
            this.tbpPlayDjan.Name = "tbpPlayDjan";
            this.tbpPlayDjan.Size = new System.Drawing.Size(1114, 535);
            this.tbpPlayDjan.TabIndex = 2;
            this.tbpPlayDjan.Text = "Play";
            this.tbpPlayDjan.UseVisualStyleBackColor = true;
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
            // lbxTeamsDjan
            // 
            this.lbxTeamsDjan.FormattingEnabled = true;
            this.lbxTeamsDjan.Location = new System.Drawing.Point(155, 6);
            this.lbxTeamsDjan.Name = "lbxTeamsDjan";
            this.lbxTeamsDjan.Size = new System.Drawing.Size(161, 524);
            this.lbxTeamsDjan.TabIndex = 0;
            this.lbxTeamsDjan.SelectedIndexChanged += new System.EventHandler(this.lbxTeamsDjan_SelectedIndexChanged);
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
    }
}

