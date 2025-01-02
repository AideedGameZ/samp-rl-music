using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SAMPMusicURLGenerator.Class;
using Microsoft.Win32;
using System.Diagnostics;

namespace SAMPMusicURLGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            convertToUrlBtn.Visible = false;
            convertNamelbl.Visible = false;
            convertNametxt.Visible = false;

            audioUrlOutputPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "music | *.mp3";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                byte[] filetest = File.ReadAllBytes(openFileDialog1.FileName);
                audioUrlOutputPanel.Visible = false;

                if (filetest.Length <= 10000000)
                {
                    convertToUrlBtn.Visible = true;
                    convertNamelbl.Visible = true;
                    convertNametxt.Visible = true;

                    button1.Text = "Change Audio";

                    String[] arr = openFileDialog1.FileName.Split('\\');
                    String filename = arr[arr.Length - 1];

                    selectedAudio.Text = filename.Length > 30 ? filename.Substring(0, 30) + "..." : filename;
                }
                else
                {
                    MessageBox.Show( "You cannot upload music more than 10 MB.", "Oh no!");
                    selectedAudio.Text = "No File Selected";
                    openFileDialog1.Reset();

                    convertToUrlBtn.Visible = false;
                    convertNamelbl.Visible = false;
                    convertNametxt.Visible = false;
                }
            }
        }

        private void convertToUrlBtn_Click(object sender, EventArgs e)
        {
            if(convertNametxt.Text.Length > 0)
            {
                DbInterface db = new DbInterface();
                DataTable existsdt = db.GetMusicName(convertNametxt.Text);

                if(existsdt.Rows.Count < 1)
                {
                    convertToUrlBtn.Visible = false;
                    convertNamelbl.Visible = false;
                    convertNametxt.Visible = false;
                    button1.Visible = false;
                    statuslbl.Text = "Converting to URL...";

                    byte[] filebyte = File.ReadAllBytes(openFileDialog1.FileName);

                    name = convertNametxt.Text.Replace(" ","_");
                    hash = Convert.ToBase64String(filebyte);

                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show( "This name has already been taken. Try something else.", "Ohh no!");
                }
            }
        }

        String hash = "";
        String name = "";

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DbInterface db = new DbInterface();

            String name = convertNametxt.Text;

            String upload = db.AddMusic(name, hash);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            

            statuslbl.Text = "";

            progressBar1.Value = 100;
            audioUrlOutputPanel.Visible = true;
            button1.Text = "Upload Audio";
            AudioURLtxt.Text = $"https://samprl.xyz?m={name}";
            textBox1.Text = $"PlayAudioStreamForPlayer(playerid, \"{AudioURLtxt.Text}\", x, y, z, distance, true);";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            versiontxt.Text = $"{Details.Version} Version";

            DbInterface db = new DbInterface();

            DataTable dt = db.GetConfig("version");


            String currVersion = dt.Rows[0]["config_out"].ToString();
            if (Details.Version.Equals(currVersion))
            {

            }
            else
            {
                MessageBox.Show("This launcher version are not latest\nPlease check in moddb and update to prevent these situation:\n\n- Missed out new features.\n- URL may not work.","WARNING!");

            }
        }
    }
}
