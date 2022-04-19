namespace _30SecondsDjan
{
    partial class ReadFileForm
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
            this.btnReadFileDjan = new System.Windows.Forms.Button();
            this.rtbWordsDjan = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnReadFileDjan
            // 
            this.btnReadFileDjan.Location = new System.Drawing.Point(12, 12);
            this.btnReadFileDjan.Name = "btnReadFileDjan";
            this.btnReadFileDjan.Size = new System.Drawing.Size(250, 55);
            this.btnReadFileDjan.TabIndex = 0;
            this.btnReadFileDjan.Text = "Read Text File";
            this.btnReadFileDjan.UseVisualStyleBackColor = true;
            this.btnReadFileDjan.Click += new System.EventHandler(this.btnReadFileDjan_Click);
            // 
            // rtbWordsDjan
            // 
            this.rtbWordsDjan.AutoWordSelection = true;
            this.rtbWordsDjan.Location = new System.Drawing.Point(12, 74);
            this.rtbWordsDjan.Name = "rtbWordsDjan";
            this.rtbWordsDjan.ReadOnly = true;
            this.rtbWordsDjan.Size = new System.Drawing.Size(250, 243);
            this.rtbWordsDjan.TabIndex = 1;
            this.rtbWordsDjan.Text = "";
            // 
            // ReadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 340);
            this.Controls.Add(this.rtbWordsDjan);
            this.Controls.Add(this.btnReadFileDjan);
            this.Name = "ReadFileForm";
            this.Text = "ReadFileForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadFileDjan;
        private System.Windows.Forms.RichTextBox rtbWordsDjan;
    }
}