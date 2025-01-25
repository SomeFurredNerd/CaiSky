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
        public int LoggedIn { get; set; }
        public Form2()
        {
            InitializeComponent();
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

                process2.Start();
                process2.WaitForExit();
                label7.Visible = false;
                if (process2.ExitCode != 0)
                {
                    textBox2.Clear();
                    label4.Visible = true;

                }
                else
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

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void process2_Exited(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "https://bsky.app/settings/app-passwords",
                UseShellExecute = true
            };
            Process.Start(processStartInfo);
        }
    }
}
