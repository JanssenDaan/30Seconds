using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30SecondsDjan
{
    public partial class ReadFileForm : Form
    {
        public List<string> WordsDjan = new List<string>();
        public ReadFileForm()
        {
            InitializeComponent();
        }

        private void btnReadFileDjan_Click(object sender, EventArgs e)
        {
            btnReadFileDjan.Text = "Loading...";
            WordsDjan.Clear();
            OpenFileDialog dialogDjan = new OpenFileDialog();
            dialogDjan.Title = "Textbestand pakken kut";
            dialogDjan.Filter = "TXT files|*.txt";
            dialogDjan.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ;
            if (dialogDjan.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(dialogDjan.FileName))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            WordsDjan.Add(line);
                            rtbWordsDjan.AppendText(line + "\n");
                            rtbWordsDjan.ScrollToCaret();
                            //Thread.Sleep(3);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Fout bij openen bestand. " + ex.Message);
                }
                btnReadFileDjan.Text = "Loading Finished! :)";
                Thread.Sleep(30);
                MainForm.instance.GoToGameDjan(WordsDjan);
                Thread.Sleep(10);

                this.Close();

            }

        }
    }
}
