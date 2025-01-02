namespace SAMPMusicURLGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.versiontxt = new System.Windows.Forms.Label();
            this.convertNamelbl = new System.Windows.Forms.Label();
            this.convertNametxt = new System.Windows.Forms.TextBox();
            this.statuslbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.convertToUrlBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.audioUrlOutputPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AudioURLtxt = new System.Windows.Forms.TextBox();
            this.selectedAudio = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.audioUrlOutputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 674);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 66);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(209, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 33);
            this.label9.TabIndex = 8;
            this.label9.Text = "SAMPRL";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SAMPMusicURLGenerator.Properties.Resources.The_San_Andreas_Multiplayer_Official_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(80, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAMPMusicURLGenerator.Properties.Resources.ggproz;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(286, 674);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.versiontxt);
            this.panel2.Controls.Add(this.convertNamelbl);
            this.panel2.Controls.Add(this.convertNametxt);
            this.panel2.Controls.Add(this.statuslbl);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.convertToUrlBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.audioUrlOutputPanel);
            this.panel2.Controls.Add(this.selectedAudio);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 674);
            this.panel2.TabIndex = 2;
            // 
            // versiontxt
            // 
            this.versiontxt.AutoSize = true;
            this.versiontxt.ForeColor = System.Drawing.Color.White;
            this.versiontxt.Location = new System.Drawing.Point(868, 9);
            this.versiontxt.Name = "versiontxt";
            this.versiontxt.Size = new System.Drawing.Size(109, 20);
            this.versiontxt.TabIndex = 16;
            this.versiontxt.Text = "v1.0.0 Version";
            // 
            // convertNamelbl
            // 
            this.convertNamelbl.AutoSize = true;
            this.convertNamelbl.ForeColor = System.Drawing.Color.Silver;
            this.convertNamelbl.Location = new System.Drawing.Point(59, 184);
            this.convertNamelbl.Name = "convertNamelbl";
            this.convertNamelbl.Size = new System.Drawing.Size(51, 20);
            this.convertNamelbl.TabIndex = 15;
            this.convertNamelbl.Text = "Name";
            // 
            // convertNametxt
            // 
            this.convertNametxt.Location = new System.Drawing.Point(63, 207);
            this.convertNametxt.Name = "convertNametxt";
            this.convertNametxt.Size = new System.Drawing.Size(298, 26);
            this.convertNametxt.TabIndex = 14;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.statuslbl.ForeColor = System.Drawing.Color.White;
            this.statuslbl.Location = new System.Drawing.Point(701, 347);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 33);
            this.statuslbl.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 470);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(983, 10);
            this.progressBar1.TabIndex = 12;
            // 
            // convertToUrlBtn
            // 
            this.convertToUrlBtn.Location = new System.Drawing.Point(63, 239);
            this.convertToUrlBtn.Name = "convertToUrlBtn";
            this.convertToUrlBtn.Size = new System.Drawing.Size(132, 43);
            this.convertToUrlBtn.TabIndex = 11;
            this.convertToUrlBtn.Text = "Convert";
            this.convertToUrlBtn.UseVisualStyleBackColor = true;
            this.convertToUrlBtn.Visible = false;
            this.convertToUrlBtn.Click += new System.EventHandler(this.convertToUrlBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(82, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "3. Your music url will be popup";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(82, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "2. Press \"Convert\" button";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(82, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "1. Select Audio";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(23, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "here the step:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(63, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(23, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "This application are build to help SAMP community developer to produce an audio i" +
    "nto URL Streaming";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // audioUrlOutputPanel
            // 
            this.audioUrlOutputPanel.Controls.Add(this.textBox1);
            this.audioUrlOutputPanel.Controls.Add(this.label8);
            this.audioUrlOutputPanel.Controls.Add(this.label2);
            this.audioUrlOutputPanel.Controls.Add(this.AudioURLtxt);
            this.audioUrlOutputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.audioUrlOutputPanel.Location = new System.Drawing.Point(0, 480);
            this.audioUrlOutputPanel.Name = "audioUrlOutputPanel";
            this.audioUrlOutputPanel.Size = new System.Drawing.Size(983, 194);
            this.audioUrlOutputPanel.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(814, 39);
            this.textBox1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 33);
            this.label8.TabIndex = 6;
            this.label8.Text = "Script";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Music URL";
            // 
            // AudioURLtxt
            // 
            this.AudioURLtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioURLtxt.Location = new System.Drawing.Point(26, 53);
            this.AudioURLtxt.Name = "AudioURLtxt";
            this.AudioURLtxt.Size = new System.Drawing.Size(814, 39);
            this.AudioURLtxt.TabIndex = 1;
            // 
            // selectedAudio
            // 
            this.selectedAudio.AutoSize = true;
            this.selectedAudio.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.selectedAudio.ForeColor = System.Drawing.Color.White;
            this.selectedAudio.Location = new System.Drawing.Point(120, 53);
            this.selectedAudio.Name = "selectedAudio";
            this.selectedAudio.Size = new System.Drawing.Size(250, 33);
            this.selectedAudio.TabIndex = 3;
            this.selectedAudio.Text = "No File Selected";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SAMPMusicURLGenerator.Properties.Resources.folder;
            this.pictureBox2.Location = new System.Drawing.Point(63, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Upload Audio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SAMP RL Music";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.audioUrlOutputPanel.ResumeLayout(false);
            this.audioUrlOutputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox AudioURLtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label selectedAudio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel audioUrlOutputPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convertToUrlBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label statuslbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label convertNamelbl;
        private System.Windows.Forms.TextBox convertNametxt;
        private System.Windows.Forms.Label versiontxt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
    }
}

