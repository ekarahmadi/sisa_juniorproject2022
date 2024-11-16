namespace SISA.View._2MainWindow
{
    partial class UC_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            pictureBox1 = new PictureBox();
            btnTambahDataSampah = new PictureBox();
            btnBuatPermintaan = new PictureBox();
            btnUpdateStatus = new PictureBox();
            btnBatalkanStatus = new PictureBox();
            btnEditDataSampah = new PictureBox();
            btnHapusDataSampah = new PictureBox();
            cbKategori = new ComboBox();
            tbBerat = new TextBox();
            dgvDataSampah = new DataGridView();
            dgvPermintaan = new DataGridView();
            lblBelumDiambil = new Label();
            lblSudahDiambil = new Label();
            lblTotalOrganik = new Label();
            lblTotalAnorganik = new Label();
            lblTotalB3 = new Label();
            lblTotalHarian = new Label();
            lblUnitID = new Label();
            lblNamaUnit = new Label();
            lblTypeUnit = new Label();
            lblKapasitasUnit = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTambahDataSampah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuatPermintaan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBatalkanStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditDataSampah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHapusDataSampah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataSampah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPermintaan).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(991, 648);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnTambahDataSampah
            // 
            btnTambahDataSampah.BackColor = SystemColors.ButtonFace;
            btnTambahDataSampah.Image = Properties.Resources.btnTambahDataSampah;
            btnTambahDataSampah.Location = new Point(48, 257);
            btnTambahDataSampah.Name = "btnTambahDataSampah";
            btnTambahDataSampah.Size = new Size(133, 27);
            btnTambahDataSampah.SizeMode = PictureBoxSizeMode.AutoSize;
            btnTambahDataSampah.TabIndex = 1;
            btnTambahDataSampah.TabStop = false;
            btnTambahDataSampah.Click += btnTambahDataSampah_Click;
            // 
            // btnBuatPermintaan
            // 
            btnBuatPermintaan.BackColor = SystemColors.ButtonFace;
            btnBuatPermintaan.Image = Properties.Resources.btnBuatPermintaan;
            btnBuatPermintaan.Location = new Point(198, 257);
            btnBuatPermintaan.Name = "btnBuatPermintaan";
            btnBuatPermintaan.Size = new Size(133, 27);
            btnBuatPermintaan.SizeMode = PictureBoxSizeMode.AutoSize;
            btnBuatPermintaan.TabIndex = 2;
            btnBuatPermintaan.TabStop = false;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.DarkSlateGray;
            btnUpdateStatus.Image = Properties.Resources.btnUpdateStatusSampah;
            btnUpdateStatus.Location = new Point(404, 557);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(133, 27);
            btnUpdateStatus.SizeMode = PictureBoxSizeMode.AutoSize;
            btnUpdateStatus.TabIndex = 3;
            btnUpdateStatus.TabStop = false;
            // 
            // btnBatalkanStatus
            // 
            btnBatalkanStatus.BackColor = Color.DarkSlateGray;
            btnBatalkanStatus.Image = Properties.Resources.btnBatalkanStatus;
            btnBatalkanStatus.Location = new Point(543, 557);
            btnBatalkanStatus.Name = "btnBatalkanStatus";
            btnBatalkanStatus.Size = new Size(133, 27);
            btnBatalkanStatus.SizeMode = PictureBoxSizeMode.AutoSize;
            btnBatalkanStatus.TabIndex = 4;
            btnBatalkanStatus.TabStop = false;
            // 
            // btnEditDataSampah
            // 
            btnEditDataSampah.BackColor = SystemColors.ButtonFace;
            btnEditDataSampah.Image = Properties.Resources.btnEditDataSampah;
            btnEditDataSampah.Location = new Point(48, 294);
            btnEditDataSampah.Name = "btnEditDataSampah";
            btnEditDataSampah.Size = new Size(133, 27);
            btnEditDataSampah.SizeMode = PictureBoxSizeMode.AutoSize;
            btnEditDataSampah.TabIndex = 5;
            btnEditDataSampah.TabStop = false;
            // 
            // btnHapusDataSampah
            // 
            btnHapusDataSampah.BackColor = SystemColors.ButtonFace;
            btnHapusDataSampah.Image = Properties.Resources.btnHapusDataSampah;
            btnHapusDataSampah.Location = new Point(198, 294);
            btnHapusDataSampah.Name = "btnHapusDataSampah";
            btnHapusDataSampah.Size = new Size(133, 27);
            btnHapusDataSampah.SizeMode = PictureBoxSizeMode.AutoSize;
            btnHapusDataSampah.TabIndex = 6;
            btnHapusDataSampah.TabStop = false;
            // 
            // cbKategori
            // 
            cbKategori.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(48, 128);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(283, 36);
            cbKategori.TabIndex = 7;
            // 
            // tbBerat
            // 
            tbBerat.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBerat.Location = new Point(48, 201);
            tbBerat.Name = "tbBerat";
            tbBerat.Size = new Size(283, 31);
            tbBerat.TabIndex = 8;
            // 
            // dgvDataSampah
            // 
            dgvDataSampah.BackgroundColor = Color.DarkSlateGray;
            dgvDataSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataSampah.Location = new Point(404, 93);
            dgvDataSampah.Name = "dgvDataSampah";
            dgvDataSampah.Size = new Size(587, 228);
            dgvDataSampah.TabIndex = 9;
            // 
            // dgvPermintaan
            // 
            dgvPermintaan.BackgroundColor = Color.DarkSlateGray;
            dgvPermintaan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermintaan.Location = new Point(404, 422);
            dgvPermintaan.Name = "dgvPermintaan";
            dgvPermintaan.Size = new Size(587, 119);
            dgvPermintaan.TabIndex = 10;
            // 
            // lblBelumDiambil
            // 
            lblBelumDiambil.AutoSize = true;
            lblBelumDiambil.BackColor = SystemColors.ButtonFace;
            lblBelumDiambil.Font = new Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBelumDiambil.Location = new Point(78, 456);
            lblBelumDiambil.Name = "lblBelumDiambil";
            lblBelumDiambil.Size = new Size(86, 65);
            lblBelumDiambil.TabIndex = 11;
            lblBelumDiambil.Text = "100";
            lblBelumDiambil.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSudahDiambil
            // 
            lblSudahDiambil.AutoSize = true;
            lblSudahDiambil.BackColor = SystemColors.ButtonFace;
            lblSudahDiambil.Font = new Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSudahDiambil.Location = new Point(224, 456);
            lblSudahDiambil.Name = "lblSudahDiambil";
            lblSudahDiambil.Size = new Size(86, 65);
            lblSudahDiambil.TabIndex = 12;
            lblSudahDiambil.Text = "100";
            lblSudahDiambil.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTotalOrganik
            // 
            lblTotalOrganik.AutoSize = true;
            lblTotalOrganik.BackColor = SystemColors.ButtonFace;
            lblTotalOrganik.Font = new Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalOrganik.Location = new Point(78, 535);
            lblTotalOrganik.Name = "lblTotalOrganik";
            lblTotalOrganik.Size = new Size(86, 65);
            lblTotalOrganik.TabIndex = 13;
            lblTotalOrganik.Text = "100";
            lblTotalOrganik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalAnorganik
            // 
            lblTotalAnorganik.AutoSize = true;
            lblTotalAnorganik.BackColor = SystemColors.ButtonFace;
            lblTotalAnorganik.Font = new Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAnorganik.Location = new Point(224, 535);
            lblTotalAnorganik.Name = "lblTotalAnorganik";
            lblTotalAnorganik.Size = new Size(86, 65);
            lblTotalAnorganik.TabIndex = 14;
            lblTotalAnorganik.Text = "100";
            lblTotalAnorganik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalB3
            // 
            lblTotalB3.AutoSize = true;
            lblTotalB3.BackColor = SystemColors.ButtonFace;
            lblTotalB3.Font = new Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalB3.Location = new Point(78, 619);
            lblTotalB3.Name = "lblTotalB3";
            lblTotalB3.Size = new Size(86, 65);
            lblTotalB3.TabIndex = 15;
            lblTotalB3.Text = "100";
            lblTotalB3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalHarian
            // 
            lblTotalHarian.AutoSize = true;
            lblTotalHarian.BackColor = SystemColors.ButtonFace;
            lblTotalHarian.Font = new Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalHarian.Location = new Point(224, 619);
            lblTotalHarian.Name = "lblTotalHarian";
            lblTotalHarian.Size = new Size(86, 65);
            lblTotalHarian.TabIndex = 16;
            lblTotalHarian.Text = "100";
            lblTotalHarian.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUnitID
            // 
            lblUnitID.AutoSize = true;
            lblUnitID.BackColor = Color.DarkSlateGray;
            lblUnitID.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnitID.ForeColor = SystemColors.ButtonFace;
            lblUnitID.Location = new Point(620, 647);
            lblUnitID.Name = "lblUnitID";
            lblUnitID.Size = new Size(50, 37);
            lblUnitID.TabIndex = 17;
            lblUnitID.Text = "100";
            lblUnitID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNamaUnit
            // 
            lblNamaUnit.AutoSize = true;
            lblNamaUnit.BackColor = Color.DarkSlateGray;
            lblNamaUnit.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaUnit.ForeColor = SystemColors.ButtonFace;
            lblNamaUnit.Location = new Point(725, 647);
            lblNamaUnit.Name = "lblNamaUnit";
            lblNamaUnit.Size = new Size(50, 37);
            lblNamaUnit.TabIndex = 18;
            lblNamaUnit.Text = "100";
            lblNamaUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTypeUnit
            // 
            lblTypeUnit.AutoSize = true;
            lblTypeUnit.BackColor = Color.DarkSlateGray;
            lblTypeUnit.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTypeUnit.ForeColor = SystemColors.ButtonFace;
            lblTypeUnit.Location = new Point(840, 647);
            lblTypeUnit.Name = "lblTypeUnit";
            lblTypeUnit.Size = new Size(50, 37);
            lblTypeUnit.TabIndex = 19;
            lblTypeUnit.Text = "100";
            lblTypeUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKapasitasUnit
            // 
            lblKapasitasUnit.AutoSize = true;
            lblKapasitasUnit.BackColor = Color.DarkSlateGray;
            lblKapasitasUnit.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKapasitasUnit.ForeColor = SystemColors.ButtonFace;
            lblKapasitasUnit.Location = new Point(941, 647);
            lblKapasitasUnit.Name = "lblKapasitasUnit";
            lblKapasitasUnit.Size = new Size(50, 37);
            lblKapasitasUnit.TabIndex = 20;
            lblKapasitasUnit.Text = "100";
            lblKapasitasUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(lblKapasitasUnit);
            Controls.Add(lblTypeUnit);
            Controls.Add(lblNamaUnit);
            Controls.Add(lblUnitID);
            Controls.Add(lblTotalHarian);
            Controls.Add(lblTotalB3);
            Controls.Add(lblTotalAnorganik);
            Controls.Add(lblTotalOrganik);
            Controls.Add(lblSudahDiambil);
            Controls.Add(lblBelumDiambil);
            Controls.Add(dgvPermintaan);
            Controls.Add(dgvDataSampah);
            Controls.Add(tbBerat);
            Controls.Add(cbKategori);
            Controls.Add(btnHapusDataSampah);
            Controls.Add(btnEditDataSampah);
            Controls.Add(btnBatalkanStatus);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnBuatPermintaan);
            Controls.Add(btnTambahDataSampah);
            Controls.Add(pictureBox1);
            Name = "UC_Dashboard";
            Size = new Size(1035, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTambahDataSampah).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuatPermintaan).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBatalkanStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditDataSampah).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHapusDataSampah).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataSampah).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPermintaan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox btnTambahDataSampah;
        private PictureBox btnBuatPermintaan;
        private PictureBox btnUpdateStatus;
        private PictureBox btnBatalkanStatus;
        private PictureBox btnEditDataSampah;
        private PictureBox btnHapusDataSampah;
        private ComboBox cbKategori;
        private TextBox tbBerat;
        private DataGridView dgvDataSampah;
        private DataGridView dgvPermintaan;
        private Label lblBelumDiambil;
        private Label lblSudahDiambil;
        private Label lblTotalOrganik;
        private Label lblTotalAnorganik;
        private Label lblTotalB3;
        private Label lblTotalHarian;
        private Label lblUnitID;
        private Label lblNamaUnit;
        private Label lblTypeUnit;
        private Label lblKapasitasUnit;
    }
}
