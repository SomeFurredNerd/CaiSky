namespace CaiSky
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            process2 = new System.Diagnostics.Process();
            label4 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            logLabel = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 29);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 138);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(177, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.Location = new Point(177, 59);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 3;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F);
            label3.Location = new Point(177, 112);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(181, 167);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // process2
            // 
            process2.StartInfo.Arguments = "\"login.py\"";
            process2.StartInfo.CreateNoWindow = true;
            process2.StartInfo.Domain = "";
            process2.StartInfo.FileName = "Python";
            process2.StartInfo.LoadUserProfile = false;
            process2.StartInfo.Password = null;
            process2.StartInfo.StandardErrorEncoding = null;
            process2.StartInfo.StandardInputEncoding = null;
            process2.StartInfo.StandardOutputEncoding = null;
            process2.StartInfo.UseCredentialsForNetworkingOnly = false;
            process2.StartInfo.UserName = "";
            process2.SynchronizingObject = this;
            process2.Exited += process2_Exited;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 195);
            label4.Name = "label4";
            label4.Size = new Size(439, 15);
            label4.TabIndex = 6;
            label4.Text = "The username and password seem to be incorrect. Check the details and try again.";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 195);
            label5.Name = "label5";
            label5.Size = new Size(232, 15);
            label5.TabIndex = 7;
            label5.Text = "Please input your username and password.";
            label5.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(44, 146);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "app password.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 131);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 9;
            label6.Text = "Please use an";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(184, 195);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 10;
            label7.Text = "Signing in...";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 195);
            label8.Name = "label8";
            label8.Size = new Size(358, 15);
            label8.TabIndex = 11;
            label8.Text = "An error occurred while signing in. Check the         for more details.";
            label8.Visible = false;
            label8.Click += label8_Click;
            // 
            // logLabel
            // 
            logLabel.AutoSize = true;
            logLabel.Location = new Point(286, 195);
            logLabel.Name = "logLabel";
            logLabel.Size = new Size(24, 15);
            logLabel.TabIndex = 12;
            logLabel.TabStop = true;
            logLabel.Text = "log";
            logLabel.LinkClicked += logLabel_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 219);
            Controls.Add(logLabel);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private System.Diagnostics.Process process2;
        private Label label4;
        private Label label5;
        private Label label6;
        private LinkLabel linkLabel1;
        private Label label7;
        private Label label8;
        public LinkLabel logLabel;
    }
}