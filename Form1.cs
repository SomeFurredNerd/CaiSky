using System.Diagnostics;

namespace CaiSky
{
    public partial class Form1 : Form
    {
        string postingerror, errorLogPath;
        DateTime time;
        string filePath = @$"{System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)}\bskypost.txt";
        public Form1()
        {
            InitializeComponent();
            
            // File.WriteAllText("currentworkingdirectory.txt", "a"); debug line to make sure i'm working in the right directory lol
            process2.Start();
            process2.WaitForExit();
            // Console.WriteLine(process2.ExitCode);
            if (process2.ExitCode != 0)
            {
                Form2 f2 = new Form2();
                var result = f2.ShowDialog();
                if (result == DialogResult.Cancel && f2.LoggedIn == 0)
                {
                    Environment.Exit(7);
                }

            }
            string username = File.ReadAllText("username.txt");
            label4.Text = username;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            statusLabel.Visible = false;

            label7.Text = $"{300 - textBox1.Text.Length} characters left";

            if (textBox1.Text == "Hi Atlas")
            {
                pictureBox3.Visible = true;
            }

        }

        private void postButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                File.WriteAllText(filePath, textBox1.Text);

                label5.Visible = true;
                label6.Visible = false;
                linkLabel1.Visible = false;

                // ProcessStartInfo process1;
                process1.StartInfo.UseShellExecute = false;
                process1.StartInfo.RedirectStandardError = true;
                process1.Start();
                process1.WaitForExit();
                postingerror = process1.StandardError.ReadToEnd();
                time = DateTime.Now;
                if (!string.IsNullOrWhiteSpace(postingerror))
                {
                    errorLogPath = @$"logs\postingerror{time.ToString("ddMMyyyy_hhmmsss")}.txt";
                    Directory.CreateDirectory("logs");
                    File.WriteAllText($"{errorLogPath}", $"{postingerror}");
                    label5.Visible = false;
                    label6.Visible = true;
                    linkLabel1.Visible = true;


                }
                else
                {
                    label5.Visible = false;
                    statusLabel.Visible = true;
                    statusLabel.Text = "Complete!";
                }


                


            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void process1_Exited(object sender, EventArgs e)
        {
            statusLabel.Visible = true;
            statusLabel.Text = "Complete!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            var resultf3 = f3.ShowDialog();
            if (resultf3 == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = @$"{errorLogPath}",
                UseShellExecute = true
            };
            Process.Start(processStartInfo);
        }
    }
}
