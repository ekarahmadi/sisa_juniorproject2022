namespace SISA.View._3AdminWindow
{
    partial class AdminWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWindow));
            btnAdminHome = new PictureBox();
            btnHome = new PictureBox();
            btnAdminKeluar = new PictureBox();
            btnAdminDashboard = new PictureBox();
            btnAdminRequest = new PictureBox();
            btnAdminUnitData = new PictureBox();
            btnAdminAccount = new PictureBox();
            panelAdminContent = new Panel();
            ((System.ComponentModel.ISupportInitialize)btnAdminHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminKeluar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminRequest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminUnitData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminAccount).BeginInit();
            SuspendLayout();
            // 
            // btnAdminHome
            // 
            btnAdminHome.Image = (Image)resources.GetObject("btnAdminHome.Image");
            btnAdminHome.Location = new Point(-1, -1);
            btnAdminHome.Name = "btnAdminHome";
            btnAdminHome.Size = new Size(240, 720);
            btnAdminHome.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAdminHome.TabIndex = 0;
            btnAdminHome.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ButtonFace;
            btnHome.Image = Properties.Resources.nvAdminLogo;
            btnHome.Location = new Point(23, 24);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(198, 38);
            btnHome.SizeMode = PictureBoxSizeMode.AutoSize;
            btnHome.TabIndex = 8;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnAdminKeluar
            // 
            btnAdminKeluar.BackColor = SystemColors.ButtonFace;
            btnAdminKeluar.Image = Properties.Resources.nvAdminKeluar;
            btnAdminKeluar.Location = new Point(23, 653);
            btnAdminKeluar.Name = "btnAdminKeluar";
            btnAdminKeluar.Size = new Size(128, 39);
            btnAdminKeluar.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAdminKeluar.TabIndex = 7;
            btnAdminKeluar.TabStop = false;
            btnAdminKeluar.Click += btnAdminKeluar_Click;
            // 
            // btnAdminDashboard
            // 
            btnAdminDashboard.BackColor = SystemColors.ButtonFace;
            btnAdminDashboard.Image = Properties.Resources.nvAdminDashboard;
            btnAdminDashboard.Location = new Point(22, 257);
            btnAdminDashboard.Name = "btnAdminDashboard";
            btnAdminDashboard.Size = new Size(187, 38);
            btnAdminDashboard.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAdminDashboard.TabIndex = 6;
            btnAdminDashboard.TabStop = false;
            btnAdminDashboard.Click += btnAdminDashboard_Click;
            // 
            // btnAdminRequest
            // 
            btnAdminRequest.BackColor = SystemColors.ButtonFace;
            btnAdminRequest.Image = Properties.Resources.nvAdminRequest;
            btnAdminRequest.Location = new Point(23, 311);
            btnAdminRequest.Name = "btnAdminRequest";
            btnAdminRequest.Size = new Size(148, 36);
            btnAdminRequest.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAdminRequest.TabIndex = 9;
            btnAdminRequest.TabStop = false;
            btnAdminRequest.Click += btnAdminRequest_Click;
            // 
            // btnAdminUnitData
            // 
            btnAdminUnitData.BackColor = SystemColors.ButtonFace;
            btnAdminUnitData.Image = Properties.Resources.nvAdminUnitData;
            btnAdminUnitData.Location = new Point(20, 361);
            btnAdminUnitData.Name = "btnAdminUnitData";
            btnAdminUnitData.Size = new Size(165, 44);
            btnAdminUnitData.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAdminUnitData.TabIndex = 10;
            btnAdminUnitData.TabStop = false;
            btnAdminUnitData.Click += btnAdminUnitData_Click;
            // 
            // btnAdminAccount
            // 
            btnAdminAccount.BackColor = SystemColors.ButtonFace;
            btnAdminAccount.Image = Properties.Resources.nvAdminAccount;
            btnAdminAccount.Location = new Point(23, 418);
            btnAdminAccount.Name = "btnAdminAccount";
            btnAdminAccount.Size = new Size(153, 37);
            btnAdminAccount.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAdminAccount.TabIndex = 11;
            btnAdminAccount.TabStop = false;
            btnAdminAccount.Click += btnAdminAccount_Click;
            // 
            // panelAdminContent
            // 
            panelAdminContent.Location = new Point(245, -1);
            panelAdminContent.Name = "panelAdminContent";
            panelAdminContent.Size = new Size(1035, 720);
            panelAdminContent.TabIndex = 12;
            // 
            // AdminWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1279, 716);
            Controls.Add(panelAdminContent);
            Controls.Add(btnAdminAccount);
            Controls.Add(btnAdminUnitData);
            Controls.Add(btnAdminRequest);
            Controls.Add(btnHome);
            Controls.Add(btnAdminKeluar);
            Controls.Add(btnAdminDashboard);
            Controls.Add(btnAdminHome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminWindow";
            ((System.ComponentModel.ISupportInitialize)btnAdminHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminKeluar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminRequest).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminUnitData).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnAdminHome;
        private PictureBox btnHome;
        private PictureBox btnAdminKeluar;
        private PictureBox btnAdminDashboard;
        private PictureBox btnAdminRequest;
        private PictureBox btnAdminUnitData;
        private PictureBox btnAdminAccount;
        private Panel panelAdminContent;
    }
}