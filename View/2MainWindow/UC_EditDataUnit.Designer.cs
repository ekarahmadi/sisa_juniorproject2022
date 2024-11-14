namespace SISA.Recycle
{
    partial class UC_EditDataUnit
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSimpan = new PictureBox();
            cbUnitKerja = new ComboBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbNamaPengguna = new TextBox();
            pictureBox1 = new PictureBox();
            btnKembali = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnSimpan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(521, 422);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 19;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(521, 354);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 18;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(521, 284);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 17;
            label2.Text = "Unit Kerja";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(521, 220);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 16;
            label1.Text = "Nama Pengguna";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = SystemColors.ButtonFace;
            btnSimpan.Image = Properties.Resources.btnSimpan;
            btnSimpan.Location = new Point(652, 508);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(138, 27);
            btnSimpan.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSimpan.TabIndex = 15;
            btnSimpan.TabStop = false;
            // 
            // cbUnitKerja
            // 
            cbUnitKerja.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUnitKerja.FormattingEnabled = true;
            cbUnitKerja.Location = new Point(521, 314);
            cbUnitKerja.Name = "cbUnitKerja";
            cbUnitKerja.Size = new Size(252, 36);
            cbUnitKerja.TabIndex = 14;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(521, 384);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(252, 31);
            tbUsername.TabIndex = 13;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(521, 453);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(252, 31);
            tbPassword.TabIndex = 12;
            // 
            // tbNamaPengguna
            // 
            tbNamaPengguna.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNamaPengguna.Location = new Point(521, 249);
            tbNamaPengguna.Name = "tbNamaPengguna";
            tbNamaPengguna.Size = new Size(252, 31);
            tbNamaPengguna.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contentEditData;
            pictureBox1.Location = new Point(170, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(662, 464);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = SystemColors.ButtonFace;
            btnKembali.Image = Properties.Resources.btnKembali;
            btnKembali.Location = new Point(508, 508);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(138, 27);
            btnKembali.SizeMode = PictureBoxSizeMode.AutoSize;
            btnKembali.TabIndex = 20;
            btnKembali.TabStop = false;
            btnKembali.Click += this.BtnKembali_Click;
            // 
            // UC_EditDataUnit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(btnKembali);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(cbUnitKerja);
            Controls.Add(tbUsername);
            Controls.Add(tbPassword);
            Controls.Add(tbNamaPengguna);
            Controls.Add(pictureBox1);
            Name = "UC_EditDataUnit";
            Size = new Size(1035, 720);
            ((System.ComponentModel.ISupportInitialize)btnSimpan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox btnSimpan;
        private ComboBox cbUnitKerja;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbNamaPengguna;
        private PictureBox pictureBox1;
        private PictureBox btnKembali;
    }
}
