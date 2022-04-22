namespace _30SecondsDjan
{
    partial class UCTeam
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
            this.lblTeamNameDjan = new System.Windows.Forms.Label();
            this.lblTeamNameValueDjan = new System.Windows.Forms.Label();
            this.tbxChangeNameDjan = new System.Windows.Forms.TextBox();
            this.btnCloseDjan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTeamNameDjan
            // 
            this.lblTeamNameDjan.AutoSize = true;
            this.lblTeamNameDjan.Location = new System.Drawing.Point(4, 4);
            this.lblTeamNameDjan.Name = "lblTeamNameDjan";
            this.lblTeamNameDjan.Size = new System.Drawing.Size(66, 13);
            this.lblTeamNameDjan.TabIndex = 0;
            this.lblTeamNameDjan.Text = "Teamname: ";
            // 
            // lblTeamNameValueDjan
            // 
            this.lblTeamNameValueDjan.AutoSize = true;
            this.lblTeamNameValueDjan.Location = new System.Drawing.Point(76, 4);
            this.lblTeamNameValueDjan.Name = "lblTeamNameValueDjan";
            this.lblTeamNameValueDjan.Size = new System.Drawing.Size(35, 13);
            this.lblTeamNameValueDjan.TabIndex = 1;
            this.lblTeamNameValueDjan.Text = "label1";
            // 
            // tbxChangeNameDjan
            // 
            this.tbxChangeNameDjan.Location = new System.Drawing.Point(7, 44);
            this.tbxChangeNameDjan.Name = "tbxChangeNameDjan";
            this.tbxChangeNameDjan.Size = new System.Drawing.Size(100, 20);
            this.tbxChangeNameDjan.TabIndex = 2;
            this.tbxChangeNameDjan.Text = "Change Name";
            this.tbxChangeNameDjan.TextChanged += new System.EventHandler(this.tbxChangeNameDjan_TextChanged);
            // 
            // btnCloseDjan
            // 
            this.btnCloseDjan.BackColor = System.Drawing.Color.Red;
            this.btnCloseDjan.Location = new System.Drawing.Point(179, 42);
            this.btnCloseDjan.Name = "btnCloseDjan";
            this.btnCloseDjan.Size = new System.Drawing.Size(25, 23);
            this.btnCloseDjan.TabIndex = 9;
            this.btnCloseDjan.Text = "❌";
            this.btnCloseDjan.UseVisualStyleBackColor = false;
            this.btnCloseDjan.Click += new System.EventHandler(this.btnCloseDjan_Click);
            // 
            // UCTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCloseDjan);
            this.Controls.Add(this.tbxChangeNameDjan);
            this.Controls.Add(this.lblTeamNameValueDjan);
            this.Controls.Add(this.lblTeamNameDjan);
            this.Name = "UCTeam";
            this.Size = new System.Drawing.Size(207, 67);
            this.Load += new System.EventHandler(this.UCTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeamNameDjan;
        private System.Windows.Forms.TextBox tbxChangeNameDjan;
        public System.Windows.Forms.Label lblTeamNameValueDjan;
        private System.Windows.Forms.Button btnCloseDjan;
    }
}
