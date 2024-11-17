namespace SISA.View._3AdminWindow
{
    partial class UC_AdminUnitData
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
            label3 = new Label();
            panel3 = new Panel();
            cbTipe = new ComboBox();
            btnTambahUnit = new PictureBox();
            tbLokasi = new TextBox();
            label8 = new Label();
            tbKapasitas = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbNama = new TextBox();
            label4 = new Label();
            btnEditUnit = new PictureBox();
            btnHapusUnit = new PictureBox();
            btnHapusSeleksi = new PictureBox();
            label1 = new Label();
            dgvUnit = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnTambahUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHapusUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHapusSeleksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUnit).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(739, 29);
            label3.Name = "label3";
            label3.Size = new Size(199, 42);
            label3.TabIndex = 6;
            label3.Text = "Data Terseleksi";
            // 
            // panel3
            // 
            panel3.Controls.Add(cbTipe);
            panel3.Controls.Add(btnTambahUnit);
            panel3.Controls.Add(tbLokasi);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(tbKapasitas);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(tbNama);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnEditUnit);
            panel3.Controls.Add(btnHapusUnit);
            panel3.Location = new Point(693, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 487);
            panel3.TabIndex = 7;
            // 
            // cbTipe
            // 
            cbTipe.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTipe.FormattingEnabled = true;
            cbTipe.Location = new Point(18, 123);
            cbTipe.Name = "cbTipe";
            cbTipe.Size = new Size(262, 36);
            cbTipe.TabIndex = 17;
            // 
            // btnTambahUnit
            // 
            btnTambahUnit.Image = Properties.Resources.btnTambahUnit1;
            btnTambahUnit.Location = new Point(74, 416);
            btnTambahUnit.Name = "btnTambahUnit";
            btnTambahUnit.Size = new Size(138, 27);
            btnTambahUnit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnTambahUnit.TabIndex = 16;
            btnTambahUnit.TabStop = false;
            btnTambahUnit.Click += btnTambahUnit_Click;
            // 
            // tbLokasi
            // 
            tbLokasi.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLokasi.Location = new Point(18, 200);
            tbLokasi.Name = "tbLokasi";
            tbLokasi.Size = new Size(262, 31);
            tbLokasi.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 169);
            label8.Name = "label8";
            label8.Size = new Size(60, 28);
            label8.TabIndex = 14;
            label8.Text = "Lokasi";
            // 
            // tbKapasitas
            // 
            tbKapasitas.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbKapasitas.Location = new Point(18, 275);
            tbKapasitas.Name = "tbKapasitas";
            tbKapasitas.Size = new Size(262, 31);
            tbKapasitas.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 244);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 10;
            label6.Text = "Kapasitas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 92);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 8;
            label5.Text = "Tipe Unit";
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(18, 45);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(262, 31);
            tbNama.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 14);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 6;
            label4.Text = "Nama Unit";
            // 
            // btnEditUnit
            // 
            btnEditUnit.Image = Properties.Resources.btnEditDataUnit;
            btnEditUnit.Location = new Point(74, 328);
            btnEditUnit.Name = "btnEditUnit";
            btnEditUnit.Size = new Size(138, 27);
            btnEditUnit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnEditUnit.TabIndex = 2;
            btnEditUnit.TabStop = false;
            btnEditUnit.Click += btnEditUnit_Click;
            // 
            // btnHapusUnit
            // 
            btnHapusUnit.Image = Properties.Resources.btnHapusUnit;
            btnHapusUnit.Location = new Point(74, 370);
            btnHapusUnit.Name = "btnHapusUnit";
            btnHapusUnit.Size = new Size(138, 27);
            btnHapusUnit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnHapusUnit.TabIndex = 1;
            btnHapusUnit.TabStop = false;
            btnHapusUnit.Click += btnHapusUnit_Click;
            // 
            // btnHapusSeleksi
            // 
            btnHapusSeleksi.Image = Properties.Resources.btnHapusDataTerseleksi;
            btnHapusSeleksi.Location = new Point(756, 94);
            btnHapusSeleksi.Name = "btnHapusSeleksi";
            btnHapusSeleksi.Size = new Size(165, 27);
            btnHapusSeleksi.SizeMode = PictureBoxSizeMode.AutoSize;
            btnHapusSeleksi.TabIndex = 18;
            btnHapusSeleksi.TabStop = false;
            btnHapusSeleksi.Click += btnHapusSeleksi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 29);
            label1.Name = "label1";
            label1.Size = new Size(245, 42);
            label1.TabIndex = 9;
            label1.Text = "Data Unit Terdaftar";
            // 
            // dgvUnit
            // 
            dgvUnit.BackgroundColor = Color.CadetBlue;
            dgvUnit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnit.Location = new Point(51, 74);
            dgvUnit.Name = "dgvUnit";
            dgvUnit.Size = new Size(621, 558);
            dgvUnit.TabIndex = 10;
            // 
            // UC_AdminUnitData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(btnHapusSeleksi);
            Controls.Add(dgvUnit);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(label3);
            Name = "UC_AdminUnitData";
            Size = new Size(1035, 720);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnTambahUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHapusUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHapusSeleksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUnit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel3;
        private TextBox tbLokasi;
        private Label label8;
        private TextBox tbKapasitas;
        private Label label6;
        private Label label5;
        private TextBox tbNama;
        private Label label4;
        private PictureBox btnEditUnit;
        private PictureBox btnHapusUnit;
        private PictureBox btnTambahUnit;
        private Label label1;
        private ComboBox cbTipe;
        private DataGridView dgvUnit;
        private PictureBox btnHapusSeleksi;
    }
}
