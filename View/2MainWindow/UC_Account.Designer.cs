namespace SISA.View._2MainWindow
{
    partial class UC_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Account));
            btnEditUser = new PictureBox();
            lblRole = new Label();
            lblUnit = new Label();
            lblUsername = new Label();
            lblNama = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblNamaUnit = new Label();
            lblTipeUnit = new Label();
            lblLokasiUnit = new Label();
            lblKapasitasUnit = new Label();
            btnEditUnit = new PictureBox();
            btnReload = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnEditUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReload).BeginInit();
            SuspendLayout();
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = SystemColors.ButtonFace;
            btnEditUser.Image = Properties.Resources.btnEditData1;
            btnEditUser.Location = new Point(380, 507);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(138, 27);
            btnEditUser.SizeMode = PictureBoxSizeMode.AutoSize;
            btnEditUser.TabIndex = 21;
            btnEditUser.TabStop = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = SystemColors.ButtonFace;
            lblRole.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(376, 466);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(95, 28);
            lblRole.TabIndex = 20;
            lblRole.Text = "Admin TPS";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.BackColor = SystemColors.ButtonFace;
            lblUnit.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnit.Location = new Point(374, 412);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(122, 28);
            lblUnit.TabIndex = 19;
            lblUnit.Text = "TPS Sinduadi 1";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ButtonFace;
            lblUsername.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(373, 359);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(122, 28);
            lblUsername.TabIndex = 18;
            lblUsername.Text = "eka_rahmadi";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = SystemColors.ButtonFace;
            lblNama.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(371, 307);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(181, 28);
            lblNama.TabIndex = 17;
            lblNama.Text = "Septian Eka Rahmadi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contentAccountUser;
            pictureBox1.Location = new Point(27, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(662, 464);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(686, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(339, 463);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // lblNamaUnit
            // 
            lblNamaUnit.AutoSize = true;
            lblNamaUnit.BackColor = SystemColors.ButtonFace;
            lblNamaUnit.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaUnit.Location = new Point(708, 307);
            lblNamaUnit.Name = "lblNamaUnit";
            lblNamaUnit.Size = new Size(122, 28);
            lblNamaUnit.TabIndex = 24;
            lblNamaUnit.Text = "TPS Sinduadi 1";
            // 
            // lblTipeUnit
            // 
            lblTipeUnit.AutoSize = true;
            lblTipeUnit.BackColor = SystemColors.ButtonFace;
            lblTipeUnit.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipeUnit.Location = new Point(708, 359);
            lblTipeUnit.Name = "lblTipeUnit";
            lblTipeUnit.Size = new Size(281, 28);
            lblTipeUnit.TabIndex = 25;
            lblTipeUnit.Text = "Tempat Pembuangan Sementara";
            // 
            // lblLokasiUnit
            // 
            lblLokasiUnit.AutoSize = true;
            lblLokasiUnit.BackColor = SystemColors.ButtonFace;
            lblLokasiUnit.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLokasiUnit.Location = new Point(708, 412);
            lblLokasiUnit.Name = "lblLokasiUnit";
            lblLokasiUnit.Size = new Size(203, 28);
            lblLokasiUnit.TabIndex = 26;
            lblLokasiUnit.Text = "Jalan Nandan Gg. Saridi";
            // 
            // lblKapasitasUnit
            // 
            lblKapasitasUnit.AutoSize = true;
            lblKapasitasUnit.BackColor = SystemColors.ButtonFace;
            lblKapasitasUnit.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKapasitasUnit.Location = new Point(708, 468);
            lblKapasitasUnit.Name = "lblKapasitasUnit";
            lblKapasitasUnit.Size = new Size(77, 28);
            lblKapasitasUnit.TabIndex = 27;
            lblKapasitasUnit.Text = "1000 ton";
            // 
            // btnEditUnit
            // 
            btnEditUnit.BackColor = SystemColors.ButtonFace;
            btnEditUnit.Image = Properties.Resources.btnEditData1;
            btnEditUnit.Location = new Point(729, 507);
            btnEditUnit.Name = "btnEditUnit";
            btnEditUnit.Size = new Size(138, 27);
            btnEditUnit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnEditUnit.TabIndex = 28;
            btnEditUnit.TabStop = false;
            btnEditUnit.Click += btnEditUnit_Click;
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.ButtonFace;
            btnReload.Image = Properties.Resources.btnReload;
            btnReload.Location = new Point(524, 507);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(97, 27);
            btnReload.SizeMode = PictureBoxSizeMode.AutoSize;
            btnReload.TabIndex = 29;
            btnReload.TabStop = false;
            btnReload.Click += btnReload_Click;
            // 
            // UC_Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(btnReload);
            Controls.Add(lblKapasitasUnit);
            Controls.Add(lblLokasiUnit);
            Controls.Add(lblTipeUnit);
            Controls.Add(lblNamaUnit);
            Controls.Add(pictureBox2);
            Controls.Add(btnEditUser);
            Controls.Add(lblRole);
            Controls.Add(lblUnit);
            Controls.Add(lblUsername);
            Controls.Add(lblNama);
            Controls.Add(pictureBox1);
            Controls.Add(btnEditUnit);
            Name = "UC_Account";
            Size = new Size(1035, 720);
            ((System.ComponentModel.ISupportInitialize)btnEditUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReload).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnEditUser;
        private Label lblRole;
        private Label lblUnit;
        private Label lblUsername;
        private Label lblNama;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblNamaUnit;
        private Label lblTipeUnit;
        private Label lblLokasiUnit;
        private Label lblKapasitasUnit;
        private PictureBox btnEditUnit;
        private PictureBox btnReload;
    }
}
