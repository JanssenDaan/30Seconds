namespace _30SecondsDjan
{
    partial class UCPlayerDjan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayerNameDjan = new System.Windows.Forms.Label();
            this.cdlColorDjan = new System.Windows.Forms.ColorDialog();
            this.cbxTeamDjan = new System.Windows.Forms.ComboBox();
            this.lblTeamsDjan = new System.Windows.Forms.Label();
            this.lblPlayerDjan = new System.Windows.Forms.Label();
            this.btnChangeColorDjan = new System.Windows.Forms.Button();
            this.lblIDDjan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayerNameDjan
            // 
            this.lblPlayerNameDjan.AutoSize = true;
            this.lblPlayerNameDjan.Location = new System.Drawing.Point(48, 5);
            this.lblPlayerNameDjan.Name = "lblPlayerNameDjan";
            this.lblPlayerNameDjan.Size = new System.Drawing.Size(64, 13);
            this.lblPlayerNameDjan.TabIndex = 0;
            this.lblPlayerNameDjan.Text = "PlayerName";
            // 
            // cbxTeamDjan
            // 
            this.cbxTeamDjan.FormattingEnabled = true;
            this.cbxTeamDjan.Location = new System.Drawing.Point(163, 21);
            this.cbxTeamDjan.Name = "cbxTeamDjan";
            this.cbxTeamDjan.Size = new System.Drawing.Size(121, 21);
            this.cbxTeamDjan.TabIndex = 1;
            this.cbxTeamDjan.Click += new System.EventHandler(this.cbxTeamDjan_Click);
            // 
            // lblTeamsDjan
            // 
            this.lblTeamsDjan.AutoSize = true;
            this.lblTeamsDjan.Location = new System.Drawing.Point(209, 5);
            this.lblTeamsDjan.Name = "lblTeamsDjan";
            this.lblTeamsDjan.Size = new System.Drawing.Size(37, 13);
            this.lblTeamsDjan.TabIndex = 2;
            this.lblTeamsDjan.Text = "Team:";
            // 
            // lblPlayerDjan
            // 
            this.lblPlayerDjan.AutoSize = true;
            this.lblPlayerDjan.Location = new System.Drawing.Point(3, 5);
            this.lblPlayerDjan.Name = "lblPlayerDjan";
            this.lblPlayerDjan.Size = new System.Drawing.Size(39, 13);
            this.lblPlayerDjan.TabIndex = 3;
            this.lblPlayerDjan.Text = "Player:";
            // 
            // btnChangeColorDjan
            // 
            this.btnChangeColorDjan.Location = new System.Drawing.Point(4, 59);
            this.btnChangeColorDjan.Name = "btnChangeColorDjan";
            this.btnChangeColorDjan.Size = new System.Drawing.Size(75, 42);
            this.btnChangeColorDjan.TabIndex = 4;
            this.btnChangeColorDjan.Text = "Change Color";
            this.btnChangeColorDjan.UseVisualStyleBackColor = true;
            this.btnChangeColorDjan.Click += new System.EventHandler(this.btnChangeColorDjan_Click);
            // 
            // lblIDDjan
            // 
            this.lblIDDjan.AutoSize = true;
            this.lblIDDjan.Location = new System.Drawing.Point(210, 87);
            this.lblIDDjan.Name = "lblIDDjan";
            this.lblIDDjan.Size = new System.Drawing.Size(24, 13);
            this.lblIDDjan.TabIndex = 5;
            this.lblIDDjan.Text = "ID: ";
            // 
            // UCPlayerDjan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIDDjan);
            this.Controls.Add(this.btnChangeColorDjan);
            this.Controls.Add(this.lblPlayerDjan);
            this.Controls.Add(this.lblTeamsDjan);
            this.Controls.Add(this.cbxTeamDjan);
            this.Controls.Add(this.lblPlayerNameDjan);
            this.Name = "UCPlayerDjan";
            this.Size = new System.Drawing.Size(287, 104);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerNameDjan;
        private System.Windows.Forms.ColorDialog cdlColorDjan;
        private System.Windows.Forms.ComboBox cbxTeamDjan;
        private System.Windows.Forms.Label lblTeamsDjan;
        private System.Windows.Forms.Label lblPlayerDjan;
        private System.Windows.Forms.Button btnChangeColorDjan;
        public System.Windows.Forms.Label lblIDDjan;
    }
}
