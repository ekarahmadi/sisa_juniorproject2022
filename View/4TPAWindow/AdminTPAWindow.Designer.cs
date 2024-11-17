namespace SISA.View._4TPAWindow
{
    partial class AdminTPAWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTPAWindow));
            pictureBox1 = new PictureBox();
            panelContent = new Panel();
            btnHome = new PictureBox();
            btnDashboard = new PictureBox();
            btnRiwayat = new PictureBox();
            btnAccount = new PictureBox();
            btnKeluar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKeluar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.CadetBlue;
            panelContent.Location = new Point(244, -1);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1035, 720);
            panelContent.TabIndex = 7;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ButtonFace;
            btnHome.Image = Properties.Resources.nvLogo;
            btnHome.Location = new Point(24, 27);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(198, 38);
            btnHome.SizeMode = PictureBoxSizeMode.AutoSize;
            btnHome.TabIndex = 8;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.ButtonFace;
            btnDashboard.Image = Properties.Resources.nvDashboard;
            btnDashboard.Location = new Point(24, 274);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(187, 38);
            btnDashboard.SizeMode = PictureBoxSizeMode.AutoSize;
            btnDashboard.TabIndex = 9;
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
            btnRiwayat.TabIndex = 10;
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
            btnAccount.TabIndex = 11;
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
            btnKeluar.TabIndex = 12;
            btnKeluar.TabStop = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // AdminTPAWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 716);
            Controls.Add(btnKeluar);
            Controls.Add(btnAccount);
            Controls.Add(btnRiwayat);
            Controls.Add(btnDashboard);
            Controls.Add(btnHome);
            Controls.Add(panelContent);
            Controls.Add(pictureBox1);
            Name = "AdminTPAWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminTPAWindow";
            Load += AdminTPAWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKeluar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelContent;
        private PictureBox btnHome;
        private PictureBox btnDashboard;
        private PictureBox btnRiwayat;
        private PictureBox btnAccount;
        private PictureBox btnKeluar;
    }
}