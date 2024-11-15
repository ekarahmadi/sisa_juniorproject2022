﻿namespace SISA.View._2MainWindow
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
            GridViewSampah = new DataGridView();
            btnMuatData = new PictureBox();
            btnEditData = new PictureBox();
            btnTambahData = new PictureBox();
            txtMassaAdd = new TextBox();
            txtMassaMod = new TextBox();
            txtNoMod = new TextBox();
            tbOrderData = new TextBox();
            tbUnitID = new TextBox();
            tbName = new TextBox();
            tbCategory = new TextBox();
            tbLocation = new TextBox();
            tbPesananProcess = new TextBox();
            btnPesan = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            cmbTipeAdd = new ComboBox();
            cmbTipeMod = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridViewSampah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMuatData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTambahData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPesan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(973, 644);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // GridViewSampah
            // 
            GridViewSampah.BackgroundColor = Color.DarkSlateGray;
            GridViewSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewSampah.Location = new Point(56, 126);
            GridViewSampah.Name = "GridViewSampah";
            GridViewSampah.Size = new Size(555, 104);
            GridViewSampah.TabIndex = 2;
            GridViewSampah.CellContentClick += GridViewSampah_CellContentClick;
            // 
            // btnMuatData
            // 
            btnMuatData.Image = (Image)resources.GetObject("btnMuatData.Image");
            btnMuatData.Location = new Point(507, 237);
            btnMuatData.Name = "btnMuatData";
            btnMuatData.Size = new Size(100, 28);
            btnMuatData.TabIndex = 8;
            btnMuatData.TabStop = false;
            btnMuatData.Click += pictureBox2_Click_1;
            // 
            // btnEditData
            // 
            btnEditData.Image = (Image)resources.GetObject("btnEditData.Image");
            btnEditData.Location = new Point(519, 589);
            btnEditData.Name = "btnEditData";
            btnEditData.Size = new Size(89, 26);
            btnEditData.SizeMode = PictureBoxSizeMode.CenterImage;
            btnEditData.TabIndex = 10;
            btnEditData.TabStop = false;
            btnEditData.Click += pictureBox4_Click;
            // 
            // btnTambahData
            // 
            btnTambahData.Image = (Image)resources.GetObject("btnTambahData.Image");
            btnTambahData.Location = new Point(481, 404);
            btnTambahData.Name = "btnTambahData";
            btnTambahData.Size = new Size(130, 26);
            btnTambahData.SizeMode = PictureBoxSizeMode.CenterImage;
            btnTambahData.TabIndex = 11;
            btnTambahData.TabStop = false;
            btnTambahData.Click += btnTambahData_Click;
            // 
            // txtMassaAdd
            // 
            txtMassaAdd.BackColor = Color.CadetBlue;
            txtMassaAdd.ForeColor = SystemColors.ButtonHighlight;
            txtMassaAdd.Location = new Point(202, 331);
            txtMassaAdd.Name = "txtMassaAdd";
            txtMassaAdd.Size = new Size(168, 23);
            txtMassaAdd.TabIndex = 12;
            txtMassaAdd.TextChanged += txtMassaAdd_TextChanged;
            // 
            // txtMassaMod
            // 
            txtMassaMod.BackColor = Color.CadetBlue;
            txtMassaMod.ForeColor = SystemColors.ButtonHighlight;
            txtMassaMod.Location = new Point(202, 530);
            txtMassaMod.Name = "txtMassaMod";
            txtMassaMod.Size = new Size(168, 23);
            txtMassaMod.TabIndex = 15;
            txtMassaMod.TextChanged += txtMassaMod_TextChanged;
            // 
            // txtNoMod
            // 
            txtNoMod.BackColor = Color.CadetBlue;
            txtNoMod.ForeColor = SystemColors.ButtonHighlight;
            txtNoMod.Location = new Point(202, 498);
            txtNoMod.Name = "txtNoMod";
            txtNoMod.Size = new Size(168, 23);
            txtNoMod.TabIndex = 14;
            txtNoMod.TextChanged += txtNoMod_TextChanged;
            // 
            // tbOrderData
            // 
            tbOrderData.BackColor = Color.DarkSlateGray;
            tbOrderData.ForeColor = SystemColors.ButtonHighlight;
            tbOrderData.Location = new Point(659, 128);
            tbOrderData.Name = "tbOrderData";
            tbOrderData.Size = new Size(168, 23);
            tbOrderData.TabIndex = 18;
            tbOrderData.TextChanged += tbOrderData_TextChanged;
            // 
            // tbUnitID
            // 
            tbUnitID.Font = new Font("Microsoft Sans Serif", 12F);
            tbUnitID.Location = new Point(739, 510);
            tbUnitID.Name = "tbUnitID";
            tbUnitID.Size = new Size(138, 26);
            tbUnitID.TabIndex = 19;
            tbUnitID.TextChanged += tbUnitID_TextChanged;
            // 
            // tbName
            // 
            tbName.Font = new Font("Microsoft Sans Serif", 12F);
            tbName.Location = new Point(739, 542);
            tbName.Name = "tbName";
            tbName.Size = new Size(138, 26);
            tbName.TabIndex = 20;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // tbCategory
            // 
            tbCategory.Font = new Font("Microsoft Sans Serif", 12F);
            tbCategory.Location = new Point(739, 574);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(138, 26);
            tbCategory.TabIndex = 21;
            tbCategory.TextChanged += tbCategory_TextChanged;
            // 
            // tbLocation
            // 
            tbLocation.Font = new Font("Microsoft Sans Serif", 12F);
            tbLocation.Location = new Point(739, 604);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(138, 26);
            tbLocation.TabIndex = 22;
            tbLocation.TextChanged += tbLocation_TextChanged;
            // 
            // tbPesananProcess
            // 
            tbPesananProcess.BackColor = Color.DarkSlateGray;
            tbPesananProcess.ForeColor = SystemColors.ButtonHighlight;
            tbPesananProcess.Location = new Point(663, 290);
            tbPesananProcess.Name = "tbPesananProcess";
            tbPesananProcess.Size = new Size(168, 23);
            tbPesananProcess.TabIndex = 24;
            tbPesananProcess.TextChanged += tbPesananProcess_TextChanged;
            // 
            // btnPesan
            // 
            btnPesan.BackColor = Color.CadetBlue;
            btnPesan.Image = (Image)resources.GetObject("btnPesan.Image");
            btnPesan.Location = new Point(664, 166);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(118, 21);
            btnPesan.TabIndex = 25;
            btnPesan.TabStop = false;
            btnPesan.Click += btnPesan_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.CadetBlue;
            pictureBox2.Image = Properties.Resources.BerhasilNoHover;
            pictureBox2.Location = new Point(664, 356);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 21);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.CadetBlue;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(663, 327);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(79, 21);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // cmbTipeAdd
            // 
            cmbTipeAdd.BackColor = Color.CadetBlue;
            cmbTipeAdd.ForeColor = SystemColors.ButtonHighlight;
            cmbTipeAdd.FormattingEnabled = true;
            cmbTipeAdd.Location = new Point(202, 360);
            cmbTipeAdd.Name = "cmbTipeAdd";
            cmbTipeAdd.Size = new Size(168, 23);
            cmbTipeAdd.TabIndex = 28;
            // 
            // cmbTipeMod
            // 
            cmbTipeMod.BackColor = Color.CadetBlue;
            cmbTipeMod.ForeColor = SystemColors.ButtonHighlight;
            cmbTipeMod.FormattingEnabled = true;
            cmbTipeMod.Location = new Point(202, 559);
            cmbTipeMod.Name = "cmbTipeMod";
            cmbTipeMod.Size = new Size(168, 23);
            cmbTipeMod.TabIndex = 29;
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(cmbTipeMod);
            Controls.Add(cmbTipeAdd);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnPesan);
            Controls.Add(tbPesananProcess);
            Controls.Add(tbLocation);
            Controls.Add(tbCategory);
            Controls.Add(tbName);
            Controls.Add(tbUnitID);
            Controls.Add(tbOrderData);
            Controls.Add(txtMassaMod);
            Controls.Add(txtNoMod);
            Controls.Add(txtMassaAdd);
            Controls.Add(btnTambahData);
            Controls.Add(btnEditData);
            Controls.Add(btnMuatData);
            Controls.Add(GridViewSampah);
            Controls.Add(pictureBox1);
            Name = "UC_Dashboard";
            Size = new Size(1035, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridViewSampah).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMuatData).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditData).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTambahData).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPesan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView GridViewSampah;
        private PictureBox btnMuatData;
        private PictureBox btnEditData;
        private PictureBox btnTambahData;
        private TextBox txtMassaAdd;
        private TextBox txtMassaMod;
        private TextBox txtNoMod;
        private TextBox tbOrderData;
        private TextBox tbUnitID;
        private TextBox tbName;
        private TextBox tbCategory;
        private TextBox tbLocation;
        private TextBox tbPesananProcess;
        private PictureBox btnPesan;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ComboBox cmbTipeAdd;
        private ComboBox cmbTipeMod;
    }
}
