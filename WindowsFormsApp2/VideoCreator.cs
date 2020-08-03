using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class VideoCreator : Form
    {
        private string AudLen, phFormat, adFormat, AudPath, ImPath, currentDir, SavePath, ext;

        private int start, end;

        public VideoCreator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            videoFormat.SelectedIndex = 0;
        }

        private static TimeSpan GetVideoDuration(string filePath)
        {
            using (var shell = ShellObject.FromParsingName(filePath))
            {
                IShellProperty prop = shell.Properties.System.Media.Duration;
                var t = (ulong)prop.ValueAsObject;
                int precision = 0; // Specify how many digits past the decimal point
                TimeSpan t1 = new TimeSpan((long)t); // sample input value
                const int TIMESPAN_SIZE = 7;
                int factor = (int)Math.Pow(10, (TIMESPAN_SIZE - precision));
                TimeSpan roundedTimeSpan = new TimeSpan(((long)Math.Round((1.0 * t1.Ticks / factor)) * factor));
                return roundedTimeSpan;
            }
        }

        private void image_Click(object sender, EventArgs e)
        {
            try
            {
                ImPath = OpenFile("jpg,jpeg,png,bmp|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*");
                if (ImPath != "")
                {
                    if (picBox.Image != null)
                    {
                        picBox.Image.Dispose();
                    }
                    picBox.Image = new Bitmap(ImPath);
                    if (!oneimg.Checked)
                    {
                        audio.Enabled = true;
                    }                    
                    label1.Text = "Image Succefully Loaded";
                }
            }
            catch (Exception)
            {
                label1.Text = "Image Couldn't Be Loaded";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vfr.SelectedItem = "10";
            vbr.SelectedItem = "800";
            asr.SelectedItem = "44100";
            abr.SelectedItem = "192";
        }

        private void videoFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void mltpli_CheckedChanged(object sender, EventArgs e)
        {
            image.Enabled = false;
        }

        private void oneimg_CheckedChanged(object sender, EventArgs e)
        {
            image.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vfr.SelectedItem = "30";
            vbr.SelectedItem = "1000";
            asr.SelectedItem = "44100";
            abr.SelectedItem = "224";
        }

        private string OpenFile(string ext)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                ofd.Filter = ext;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return ofd.FileName;
                }
                else
                    return string.Empty;
            }
        }

        private void audio_Click(object sender, EventArgs e)
        {
            try
            {
                AudPath = OpenFile("mp3, m4a, wav|*.mp3;*.m4a;*.wav|All files (*.*)|*.*");
                if (AudPath != "")
                {
                    AudLen = GetVideoDuration(AudPath).ToString();
                    wmPlayer.URL = AudPath;
                    wmPlayer.Ctlcontrols.stop();
                    label1.Text = "Audio Succefully Loaded";
                    save.Enabled = true;
                }
            }
            catch (Exception)
            {
                label1.Text = "Audio Couldn't Be Loaded";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "AVI|*.avi|MP4|*.mp4|H264|*.h264";
            saveFileDialog1.DefaultExt = "avi";
            saveFileDialog1.FileName = "video";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Title = "Save Video";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        ext = "avi";
                        break;

                    case 2:
                        ext = "mp4";
                        break;

                    case 3:
                        ext = "h264";
                        break;
                }
                SavePath = saveFileDialog1.FileName;
                SaveVideo();
            }
        }

        private void SaveVideo()
        {
            string vFrameRate;
            string vBitrate;
            string aSampleRate;
            string aBitrate;
            if (checkBox1.Checked)
            {
                vFrameRate = vfr.SelectedItem.ToString();
                vBitrate = vbr.SelectedItem.ToString();
                aSampleRate = asr.SelectedItem.ToString();
                aBitrate = abr.SelectedItem.ToString();
            }
            else
            {
                vFrameRate = "10"; //Common video framerates (10, 12, 15, 20, 23.97, 24, 25, 29.97, 30)
                vBitrate = "800"; //Common video bitrates (300, 500, 700, 800, 1000, 1200, 1500)
                aSampleRate = "44100"; //Common audio sample rates (11025, 22050, 44100, 48000)
                aBitrate = "192"; //Common audio bitrates (32, 64, 96, 128, 160, 192, 224, 256, 320)
            }
            string iPath = (char)34 + ImPath + (char)34;
            string aPath = (char)34 + AudPath + (char)34;
            string sPath = (char)34 + SavePath + (char)34;
            ProcessStartInfo startInfo = new ProcessStartInfo("ffmpeg.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = $"-f image2 -loop 1 -i {iPath} -i {aPath} -f {ext} -c:v mpeg4 -r {vFrameRate} -b:v {vBitrate}k -g 300 -bf 2 -c:a libmp3lame -b:a {aBitrate}k -ar {aSampleRate} -t {AudLen} -y {sPath}";
            var process = Process.Start(startInfo);
            Cursor.Current = Cursors.WaitCursor;
            label1.Text = "Please Wait...";
            process.WaitForExit();
            System.Media.SystemSounds.Beep.Play();
            label1.Text = "Video Succefully Created";
            Cursor.Current = Cursors.Default;
        }

        private void Manuel_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            image.Enabled = true;
            audio.Enabled = false;
            save.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (oneimg.Checked && String.IsNullOrEmpty(ImPath))
            {
                MessageBox.Show("Please make sure that you have selected the image from the image button below");
                return;
            }
            FolderBrowserDialog folder = new System.Windows.Forms.FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                currentDir = folder.SelectedPath;
            }
            if (String.IsNullOrEmpty(from.Text) && String.IsNullOrEmpty(from.Text))
            {
                MessageBox.Show("Two box can not be empty");
                return;
            }
            start = Int32.Parse(from.Text);
            end = Int32.Parse(to.Text);
            if (start >= end)
            {
                MessageBox.Show("From must be smaller than To");
                return;
            }
            phFormat = imgFormat.Text;
            adFormat = audFormat.Text;
            ext = videoFormat.SelectedItem.ToString();
            bool f;
            try
            {
                while (start <= end)
                {
                    f = true;
                    if (avoid.Checked)
                    {
                        while (f)
                        {
                            try
                            {
                                AudPath = currentDir + "\\" + start.ToString() + adFormat;
                                AudLen = GetVideoDuration(AudPath).ToString();
                                f = false;
                            }
                            catch (Exception)
                            {                               
                                    start++;
                                if (start==end)
                                {
                                    MessageBox.Show("An error occured\nBe sure the files are in the folder and formats are correct");
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        AudPath = currentDir + "\\" + start.ToString() + adFormat;
                        AudLen = GetVideoDuration(AudPath).ToString();
                    }
                    if (mltpli.Checked)
                    {
                        ImPath = currentDir + "\\" + start.ToString() + phFormat;
                    }
                    SavePath = currentDir + "\\" + start.ToString() + "." + ext;
                    if (picBox.Image != null)
                    {
                        picBox.Image.Dispose();
                    }
                    picBox.Image = new Bitmap(ImPath);
                    SaveVideo();
                    start++;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An error occured\nBe sure the files are in the folder and formats are correct");
            }
        }

        private void Queue_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            audio.Enabled = false;
            save.Enabled = false;
            image.Enabled = false;
        }
    }
}