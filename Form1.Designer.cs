namespace CaiSky
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            postButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            process1 = new System.Diagnostics.Process();
            process2 = new System.Diagnostics.Process();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            imageList1 = new ImageList(components);
            statusLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // postButton
            // 
            postButton.Location = new Point(349, 318);
            postButton.Name = "postButton";
            postButton.Size = new Size(99, 23);
            postButton.TabIndex = 0;
            postButton.Text = "Post to Bluesky";
            postButton.UseVisualStyleBackColor = true;
            postButton.Click += postButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Coolvetica", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(722, 38);
            label1.TabIndex = 1;
            label1.Text = "Cairo's incredibly well made BlueSky posting interface";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 160);
            textBox1.MaxLength = 300;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 138);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Coolvetica", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 108);
            label2.Name = "label2";
            label2.Size = new Size(284, 29);
            label2.TabIndex = 3;
            label2.Text = "What do you want to say?";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_8;
            pictureBox1.InitialImage = Properties.Resources.image_8;
            pictureBox1.Location = new Point(12, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lil_guy;
            pictureBox2.Location = new Point(572, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 160);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // process1
            // 
            process1.StartInfo.Arguments = "\"bskypost.py\"";
            process1.StartInfo.CreateNoWindow = true;
            process1.StartInfo.Domain = "";
            process1.StartInfo.ErrorDialog = true;
            process1.StartInfo.FileName = "Python";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.RedirectStandardInput = true;
            process1.StartInfo.RedirectStandardOutput = true;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            process1.Exited += process1_Exited;
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
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 376);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 8;
            label3.Text = "Currently signed in as: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 391);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 9;
            label4.Text = "If you see this, no you don't";
            label4.Click += label4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icelas;
            pictureBox3.Location = new Point(547, 304);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(255, 147);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(367, 344);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(62, 15);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Complete!";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            statusLabel.Visible = false;
            statusLabel.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 344);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 5;
            label5.Text = "Attempting to post...";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 344);
            label6.Name = "label6";
            label6.Size = new Size(199, 30);
            label6.TabIndex = 11;
            label6.Text = "An error occurred while posting. \r\nCheck the        for more information.";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(362, 359);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(24, 15);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "log";
            linkLabel1.Visible = false;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.Location = new Point(-1, 3);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 13;
            label7.Text = "300 characters left";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Location = new Point(349, 299);
            panel1.Name = "panel1";
            panel1.Size = new Size(99, 19);
            panel1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(statusLabel);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(postButton);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "The best Bluesky API interface ever";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button postButton;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Diagnostics.Process process1;
        private System.Diagnostics.Process process2;
        private Button button1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
        private ImageList imageList1;
        private Label label5;
        private Label statusLabel;
        private LinkLabel linkLabel1;
        private Label label6;
        private Label label7;
        private Panel panel1;
    }
}
