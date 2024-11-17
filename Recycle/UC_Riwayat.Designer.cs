namespace SISA.View._4TPAWindow
{
    partial class UC_Riwayat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Riwayat));
            lblTitle = new Label();
            comboBoxRiwayat = new ComboBox();
            pictureBox1 = new PictureBox();
            dgvRiwayat = new DataGridView();
            label1 = new Label();
            lblTypeUnit = new Label();
            lblNamaUnit = new Label();
            lblUnitID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Poppins", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(24, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 56);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Data Riwayat";
            // 
            // comboBoxRiwayat
            // 
            comboBoxRiwayat.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRiwayat.FormattingEnabled = true;
            comboBoxRiwayat.Location = new Point(24, 143);
            comboBoxRiwayat.Name = "comboBoxRiwayat";
            comboBoxRiwayat.Size = new Size(461, 36);
            comboBoxRiwayat.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(506, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.BackgroundColor = Color.CadetBlue;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Location = new Point(24, 199);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.Size = new Size(963, 491);
            dgvRiwayat.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 103);
            label1.Name = "label1";
            label1.Size = new Size(393, 37);
            label1.TabIndex = 4;
            label1.Text = "Silahkan pilih data yang ingin dilihat";
            // 
            // lblTypeUnit
            // 
            lblTypeUnit.AutoSize = true;
            lblTypeUnit.BackColor = Color.DarkSlateGray;
            lblTypeUnit.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTypeUnit.ForeColor = SystemColors.ButtonFace;
            lblTypeUnit.Location = new Point(906, 137);
            lblTypeUnit.Name = "lblTypeUnit";
            lblTypeUnit.Size = new Size(54, 37);
            lblTypeUnit.TabIndex = 25;
            lblTypeUnit.Text = "TPA";
            lblTypeUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNamaUnit
            // 
            lblNamaUnit.AutoSize = true;
            lblNamaUnit.BackColor = Color.DarkSlateGray;
            lblNamaUnit.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaUnit.ForeColor = SystemColors.ButtonFace;
            lblNamaUnit.Location = new Point(736, 137);
            lblNamaUnit.Name = "lblNamaUnit";
            lblNamaUnit.Size = new Size(136, 34);
            lblNamaUnit.TabIndex = 24;
            lblNamaUnit.Text = "TPS Sinduadi";
            lblNamaUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUnitID
            // 
            lblUnitID.AutoSize = true;
            lblUnitID.BackColor = Color.DarkSlateGray;
            lblUnitID.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnitID.ForeColor = SystemColors.ButtonFace;
            lblUnitID.Location = new Point(688, 137);
            lblUnitID.Name = "lblUnitID";
            lblUnitID.Size = new Size(24, 37);
            lblUnitID.TabIndex = 23;
            lblUnitID.Text = "1";
            lblUnitID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_Riwayat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(lblTypeUnit);
            Controls.Add(lblNamaUnit);
            Controls.Add(lblUnitID);
            Controls.Add(label1);
            Controls.Add(dgvRiwayat);
            Controls.Add(pictureBox1);
            Controls.Add(comboBoxRiwayat);
            Controls.Add(lblTitle);
            Name = "UC_Riwayat";
            Size = new Size(1035, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox comboBoxRiwayat;
        private PictureBox pictureBox1;
        private DataGridView dgvRiwayat;
        private Label label1;
        private Label lblTypeUnit;
        private Label lblNamaUnit;
        private Label lblUnitID;
    }
}
