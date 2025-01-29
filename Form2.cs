using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CaiSky
{
    public partial class Form2 : Form
    {
        string loginError, loginErrorPath;
        DateTime time;
        
        public int LoggedIn { get; set; }
        public Form2()
        {
            InitializeComponent();
            logLabel.Visible = false; // linkLabel2 was obliterated and logLabel took its place, which magically fixed everything. fuck you linkLabel2 no-one likes you.
            //if (this.DialogResult == DialogResult.Cancel)
            //{
            //    this.Close();
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                label7.Visible = true;

                LoggedIn = 0;
                File.WriteAllText("username.txt", textBox1.Text);
                File.WriteAllText("password.txt", textBox2.Text);


                process2.StartInfo.RedirectStandardError = true;
                process2.StartInfo.UseShellExecute = false;
                process2.Start();
                process2.WaitForExit();


                loginError = process2.StandardError.ReadToEnd();
                if (!string.IsNullOrWhiteSpace(loginError))
                {
                    time = DateTime.Now;
                    loginErrorPath = @$"logs\loginerror{time.ToString("ddMMyyyy_hhmmsss")}.txt";
                    Directory.CreateDirectory("logs");
                    File.WriteAllText(loginErrorPath, loginError);

                    if (loginError.Contains("Invalid identifier or password"))
                    {
                        label4.Visible = true;
                    }
                    else
                    {
                        label8.Visible = true;
                        logLabel.Visible = true;
                        logLabel.BringToFront();
                        logLabel.Refresh();
                    }


                }


                label7.Visible = false;
                if (process2.ExitCode == 0)
                {
                    LoggedIn = 1;
                    this.Close();
                }


            }
            else
            {
                label5.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label8.Visible = false;
            // logLabel.Visible = false;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            ProcessStartInfo appPasswordLink = new ProcessStartInfo
            {
                FileName = "https://bsky.app/settings/app-passwords",
                UseShellExecute = true
            };
            Process.Start(appPasswordLink);
        }

        private void logLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logLabel.LinkVisited = true;
            ProcessStartInfo loginErrorLog = new ProcessStartInfo
            {
                FileName = @$"{loginErrorPath}",
                UseShellExecute = true
            };
            Process.Start(loginErrorPath);

        }
    }
}
