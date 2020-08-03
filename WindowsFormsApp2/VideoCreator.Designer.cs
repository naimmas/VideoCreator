namespace WindowsFormsApp2
{
    partial class VideoCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoCreator));
            this.image = new System.Windows.Forms.Button();
            this.audio = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.Queue = new System.Windows.Forms.RadioButton();
            this.Manuel = new System.Windows.Forms.RadioButton();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.fr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.videoFormat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.imgFormat = new System.Windows.Forms.TextBox();
            this.audFormat = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.abr = new System.Windows.Forms.ComboBox();
            this.vbr = new System.Windows.Forms.ComboBox();
            this.asr = new System.Windows.Forms.ComboBox();
            this.vfr = new System.Windows.Forms.ComboBox();
            this.mltpli = new System.Windows.Forms.RadioButton();
            this.oneimg = new System.Windows.Forms.RadioButton();
            this.avoid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.image.Location = new System.Drawing.Point(15, 40);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(106, 60);
            this.image.TabIndex = 14;
            this.image.Text = "Image";
            this.image.UseVisualStyleBackColor = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // audio
            // 
            this.audio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.audio.Location = new System.Drawing.Point(15, 119);
            this.audio.Name = "audio";
            this.audio.Size = new System.Drawing.Size(106, 60);
            this.audio.TabIndex = 15;
            this.audio.Text = "Audio";
            this.audio.UseVisualStyleBackColor = false;
            this.audio.Click += new System.EventHandler(this.audio_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.save.Location = new System.Drawing.Point(15, 199);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(106, 60);
            this.save.TabIndex = 16;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(171, 40);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(429, 219);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // Queue
            // 
            this.Queue.AutoSize = true;
            this.Queue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Queue.Location = new System.Drawing.Point(12, 28);
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(56, 17);
            this.Queue.TabIndex = 1;
            this.Queue.TabStop = true;
            this.Queue.Text = "Queue";
            this.Queue.UseVisualStyleBackColor = true;
            this.Queue.CheckedChanged += new System.EventHandler(this.Queue_CheckedChanged);
            // 
            // Manuel
            // 
            this.Manuel.AutoSize = true;
            this.Manuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manuel.Location = new System.Drawing.Point(9, 118);
            this.Manuel.Name = "Manuel";
            this.Manuel.Size = new System.Drawing.Size(59, 17);
            this.Manuel.TabIndex = 1;
            this.Manuel.TabStop = true;
            this.Manuel.Text = "Manuel";
            this.Manuel.UseVisualStyleBackColor = true;
            this.Manuel.CheckedChanged += new System.EventHandler(this.Manuel_CheckedChanged);
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(18, 27);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(45, 20);
            this.from.TabIndex = 2;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(98, 28);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(45, 20);
            this.to.TabIndex = 3;
            // 
            // fr
            // 
            this.fr.AutoSize = true;
            this.fr.Location = new System.Drawing.Point(25, 12);
            this.fr.Name = "fr";
            this.fr.Size = new System.Drawing.Size(30, 13);
            this.fr.TabIndex = 0;
            this.fr.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.wmPlayer);
            this.groupBox1.Controls.Add(this.picBox);
            this.groupBox1.Controls.Add(this.image);
            this.groupBox1.Controls.Add(this.audio);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Location = new System.Drawing.Point(9, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 368);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wmPlayer
            // 
            this.wmPlayer.Enabled = true;
            this.wmPlayer.Location = new System.Drawing.Point(15, 285);
            this.wmPlayer.Name = "wmPlayer";
            this.wmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmPlayer.OcxState")));
            this.wmPlayer.Size = new System.Drawing.Size(585, 65);
            this.wmPlayer.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.avoid);
            this.groupBox2.Controls.Add(this.oneimg);
            this.groupBox2.Controls.Add(this.mltpli);
            this.groupBox2.Controls.Add(this.videoFormat);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.imgFormat);
            this.groupBox2.Controls.Add(this.audFormat);
            this.groupBox2.Controls.Add(this.from);
            this.groupBox2.Controls.Add(this.to);
            this.groupBox2.Controls.Add(this.fr);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(75, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 96);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // videoFormat
            // 
            this.videoFormat.AllowDrop = true;
            this.videoFormat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.videoFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoFormat.FormattingEnabled = true;
            this.videoFormat.Items.AddRange(new object[] {
            "avi",
            "mp4",
            "h264"});
            this.videoFormat.Location = new System.Drawing.Point(476, 27);
            this.videoFormat.Name = "videoFormat";
            this.videoFormat.Size = new System.Drawing.Size(53, 21);
            this.videoFormat.TabIndex = 6;
            this.videoFormat.SelectedIndexChanged += new System.EventHandler(this.videoFormat_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(199, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Video Format";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Audio Format";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(316, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(68, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Image format";
            // 
            // imgFormat
            // 
            this.imgFormat.Location = new System.Drawing.Point(326, 28);
            this.imgFormat.Name = "imgFormat";
            this.imgFormat.Size = new System.Drawing.Size(45, 20);
            this.imgFormat.TabIndex = 4;
            this.imgFormat.Text = ".jpg";
            // 
            // audFormat
            // 
            this.audFormat.Location = new System.Drawing.Point(401, 28);
            this.audFormat.Name = "audFormat";
            this.audFormat.Size = new System.Drawing.Size(45, 20);
            this.audFormat.TabIndex = 5;
            this.audFormat.Text = ".mp3";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(36, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Advenced";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.abr);
            this.groupBox3.Controls.Add(this.vbr);
            this.groupBox3.Controls.Add(this.asr);
            this.groupBox3.Controls.Add(this.vfr);
            this.groupBox3.Location = new System.Drawing.Point(9, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 100);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(340, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Best for video";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(113, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Best for still image";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Audio Bit Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Video Bit Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Audio Sample Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Frame Rate";
            // 
            // abr
            // 
            this.abr.AllowDrop = true;
            this.abr.BackColor = System.Drawing.Color.LightSteelBlue;
            this.abr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abr.FormattingEnabled = true;
            this.abr.Items.AddRange(new object[] {
            "32",
            "64",
            "96",
            "128",
            "160",
            "192",
            "224",
            "256",
            "320"});
            this.abr.Location = new System.Drawing.Point(474, 44);
            this.abr.Name = "abr";
            this.abr.Size = new System.Drawing.Size(121, 21);
            this.abr.TabIndex = 13;
            // 
            // vbr
            // 
            this.vbr.AllowDrop = true;
            this.vbr.BackColor = System.Drawing.Color.LightSteelBlue;
            this.vbr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vbr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbr.FormattingEnabled = true;
            this.vbr.Items.AddRange(new object[] {
            "300",
            "500",
            "700",
            "800",
            "1000",
            "1200",
            "1500"});
            this.vbr.Location = new System.Drawing.Point(124, 45);
            this.vbr.Name = "vbr";
            this.vbr.Size = new System.Drawing.Size(121, 21);
            this.vbr.TabIndex = 11;
            // 
            // asr
            // 
            this.asr.AllowDrop = true;
            this.asr.BackColor = System.Drawing.Color.LightSteelBlue;
            this.asr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.asr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asr.FormattingEnabled = true;
            this.asr.Items.AddRange(new object[] {
            "11025",
            "22050",
            "44100",
            "48000"});
            this.asr.Location = new System.Drawing.Point(474, 15);
            this.asr.Name = "asr";
            this.asr.Size = new System.Drawing.Size(121, 21);
            this.asr.TabIndex = 12;
            // 
            // vfr
            // 
            this.vfr.AllowDrop = true;
            this.vfr.BackColor = System.Drawing.Color.LightSteelBlue;
            this.vfr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vfr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vfr.FormattingEnabled = true;
            this.vfr.Items.AddRange(new object[] {
            "10",
            "12",
            "15",
            "20",
            "23.97",
            "24",
            "25",
            "29.97",
            "30"});
            this.vfr.Location = new System.Drawing.Point(124, 16);
            this.vfr.Name = "vfr";
            this.vfr.Size = new System.Drawing.Size(121, 21);
            this.vfr.TabIndex = 10;
            // 
            // mltpli
            // 
            this.mltpli.AllowDrop = true;
            this.mltpli.AutoSize = true;
            this.mltpli.Checked = true;
            this.mltpli.Location = new System.Drawing.Point(18, 63);
            this.mltpli.Name = "mltpli";
            this.mltpli.Size = new System.Drawing.Size(97, 17);
            this.mltpli.TabIndex = 8;
            this.mltpli.TabStop = true;
            this.mltpli.Text = "Multiple images";
            this.mltpli.UseVisualStyleBackColor = true;
            this.mltpli.CheckedChanged += new System.EventHandler(this.mltpli_CheckedChanged);
            // 
            // oneimg
            // 
            this.oneimg.AutoSize = true;
            this.oneimg.Location = new System.Drawing.Point(121, 63);
            this.oneimg.Name = "oneimg";
            this.oneimg.Size = new System.Drawing.Size(76, 17);
            this.oneimg.TabIndex = 8;
            this.oneimg.Text = "One image";
            this.oneimg.UseVisualStyleBackColor = true;
            this.oneimg.CheckedChanged += new System.EventHandler(this.oneimg_CheckedChanged);
            // 
            // avoid
            // 
            this.avoid.AutoSize = true;
            this.avoid.Location = new System.Drawing.Point(326, 63);
            this.avoid.Name = "avoid";
            this.avoid.Size = new System.Drawing.Size(134, 17);
            this.avoid.TabIndex = 9;
            this.avoid.Text = "Avoid non-existent files";
            this.avoid.UseVisualStyleBackColor = true;
            // 
            // VideoCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 657);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Manuel);
            this.Controls.Add(this.Queue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button image;
        private System.Windows.Forms.Button audio;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.RadioButton Queue;
        private System.Windows.Forms.RadioButton Manuel;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label fr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxWMPLib.AxWindowsMediaPlayer wmPlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox imgFormat;
        private System.Windows.Forms.TextBox audFormat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox vfr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox vbr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox abr;
        private System.Windows.Forms.ComboBox asr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox videoFormat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox avoid;
        private System.Windows.Forms.RadioButton oneimg;
        private System.Windows.Forms.RadioButton mltpli;
    }
}

