namespace SISA.View._2MainWindow
{
    partial class AdminTPSWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTPSWindow));
            pictureBox1 = new PictureBox();
            btnDashboard = new PictureBox();
            btnRiwayat = new PictureBox();
            btnAccount = new PictureBox();
            btnKeluar = new PictureBox();
            btnHome = new PictureBox();
            panelContent = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKeluar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.ButtonFace;
            btnDashboard.Image = Properties.Resources.nvDashboard;
            btnDashboard.Location = new Point(24, 274);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(187, 38);
            btnDashboard.SizeMode = PictureBoxSizeMode.AutoSize;
            btnDashboard.TabIndex = 1;
            btnDashboard.TabStop = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = SystemColors.ButtonFace;
            btnRiwayat.Image = Properties.Resources.nvRiwayat;
            btnRiwayat.Location = new Point(24, 327);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(145, 37);
            btnRiwayat.SizeMode = PictureBoxSizeMode.AutoSize;
            btnRiwayat.TabIndex = 2;
            btnRiwayat.TabStop = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = SystemColors.ButtonFace;
            btnAccount.Image = Properties.Resources.nvAccount;
            btnAccount.Location = new Point(24, 381);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(151, 37);
            btnAccount.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAccount.TabIndex = 3;
            btnAccount.TabStop = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = SystemColors.ButtonFace;
            btnKeluar.Image = Properties.Resources.nvKeluar;
            btnKeluar.Location = new Point(24, 656);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(128, 39);
            btnKeluar.SizeMode = PictureBoxSizeMode.AutoSize;
            btnKeluar.TabIndex = 4;
            btnKeluar.TabStop = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ButtonFace;
            btnHome.Image = Properties.Resources.nvLogo;
            btnHome.Location = new Point(24, 27);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(198, 38);
            btnHome.SizeMode = PictureBoxSizeMode.AutoSize;
            btnHome.TabIndex = 5;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelContent
            // 
            panelContent.Location = new Point(244, -1);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1035, 720);
            panelContent.TabIndex = 6;
            panelContent.Paint += panelContent_Paint;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1279, 716);
            Controls.Add(panelContent);
            Controls.Add(btnHome);
            Controls.Add(btnKeluar);
            Controls.Add(btnAccount);
            Controls.Add(btnRiwayat);
            Controls.Add(btnDashboard);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKeluar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox btnDashboard;
        private PictureBox btnRiwayat;
        private PictureBox btnAccount;
        private PictureBox btnKeluar;
        private PictureBox btnHome;
        private Panel panelContent;
    }
}