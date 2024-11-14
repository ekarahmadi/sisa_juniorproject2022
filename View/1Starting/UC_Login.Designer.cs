namespace SISA.View._1Starting
{
    partial class UC_Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            linkDaftar = new LinkLabel();
            btnLogin = new PictureBox();
            btnEyeLock = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEyeLock).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contentLoginRev;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 464);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(355, 193);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(301, 31);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(355, 248);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(301, 31);
            tbPassword.TabIndex = 2;
            // 
            // linkDaftar
            // 
            linkDaftar.AutoSize = true;
            linkDaftar.BackColor = SystemColors.ButtonFace;
            linkDaftar.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkDaftar.Location = new Point(639, 375);
            linkDaftar.Name = "linkDaftar";
            linkDaftar.Size = new Size(82, 23);
            linkDaftar.TabIndex = 4;
            linkDaftar.TabStop = true;
            linkDaftar.Text = "Daftar dulu";
            linkDaftar.LinkClicked += linkDaftar_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonFace;
            btnLogin.Image = Properties.Resources.btnLogin;
            btnLogin.Location = new Point(355, 371);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(138, 27);
            btnLogin.SizeMode = PictureBoxSizeMode.AutoSize;
            btnLogin.TabIndex = 5;
            btnLogin.TabStop = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnEyeLock
            // 
            btnEyeLock.BackColor = SystemColors.ButtonFace;
            btnEyeLock.Image = Properties.Resources.btnEyeLock;
            btnEyeLock.Location = new Point(662, 255);
            btnEyeLock.Name = "btnEyeLock";
            btnEyeLock.Size = new Size(21, 17);
            btnEyeLock.SizeMode = PictureBoxSizeMode.AutoSize;
            btnEyeLock.TabIndex = 6;
            btnEyeLock.TabStop = false;
            btnEyeLock.Click += btnEyeLock_Click;
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(btnEyeLock);
            Controls.Add(btnLogin);
            Controls.Add(linkDaftar);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(pictureBox1);
            Name = "UC_Login";
            Size = new Size(802, 464);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEyeLock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private LinkLabel linkDaftar;
        private PictureBox btnLogin;
        private PictureBox btnEyeLock;
    }
}
