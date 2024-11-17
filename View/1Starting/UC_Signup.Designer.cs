namespace SISA.View._1Starting
{
    partial class UC_Signup
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
            tbNama = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            cbKetentuan = new CheckBox();
            cbUnit = new ComboBox();
            btnDaftar = new PictureBox();
            btnKembali = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDaftar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contentSignupRev3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 464);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(355, 170);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(301, 31);
            tbNama.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(355, 223);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(171, 31);
            tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(564, 223);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(171, 31);
            tbPassword.TabIndex = 4;
            // 
            // cbKetentuan
            // 
            cbKetentuan.AutoSize = true;
            cbKetentuan.BackColor = SystemColors.ButtonFace;
            cbKetentuan.Location = new Point(357, 313);
            cbKetentuan.Name = "cbKetentuan";
            cbKetentuan.Size = new Size(15, 14);
            cbKetentuan.TabIndex = 5;
            cbKetentuan.UseVisualStyleBackColor = false;
            // 
            // cbUnit
            // 
            cbUnit.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(355, 279);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(171, 27);
            cbUnit.TabIndex = 6;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = SystemColors.ButtonFace;
            btnDaftar.Image = Properties.Resources.btnDaftar;
            btnDaftar.Location = new Point(500, 371);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(138, 27);
            btnDaftar.SizeMode = PictureBoxSizeMode.AutoSize;
            btnDaftar.TabIndex = 7;
            btnDaftar.TabStop = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = SystemColors.ButtonFace;
            btnKembali.Image = Properties.Resources.btnKembali;
            btnKembali.Location = new Point(355, 371);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(138, 27);
            btnKembali.SizeMode = PictureBoxSizeMode.AutoSize;
            btnKembali.TabIndex = 8;
            btnKembali.TabStop = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // UC_Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(btnKembali);
            Controls.Add(btnDaftar);
            Controls.Add(cbUnit);
            Controls.Add(cbKetentuan);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbNama);
            Controls.Add(pictureBox1);
            Name = "UC_Signup";
            Size = new Size(802, 464);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDaftar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbNama;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private CheckBox cbKetentuan;
        private ComboBox cbUnit;
        private PictureBox btnDaftar;
        private PictureBox btnKembali;
    }
}
