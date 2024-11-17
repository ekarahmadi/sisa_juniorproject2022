namespace SISA.Recycle
{
    partial class UC_EditDataUser
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
            tbNamaPengguna = new TextBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            cbUnit = new ComboBox();
            btnSimpan = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnKembali = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSimpan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contentEditData;
            pictureBox1.Location = new Point(170, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(662, 464);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tbNamaPengguna
            // 
            tbNamaPengguna.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNamaPengguna.Location = new Point(521, 249);
            tbNamaPengguna.Name = "tbNamaPengguna";
            tbNamaPengguna.Size = new Size(252, 26);
            tbNamaPengguna.TabIndex = 1;
            tbNamaPengguna.TextChanged += tbNamaPengguna_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(521, 453);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(252, 26);
            tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(521, 384);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(252, 26);
            tbUsername.TabIndex = 3;
            // 
            // cbUnit
            // 
            cbUnit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(521, 314);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(252, 28);
            cbUnit.TabIndex = 4;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = SystemColors.ButtonFace;
            btnSimpan.Image = Properties.Resources.btnSimpan;
            btnSimpan.Location = new Point(652, 508);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(138, 27);
            btnSimpan.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSimpan.TabIndex = 5;
            btnSimpan.TabStop = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(521, 220);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 6;
            label1.Text = "Nama Pengguna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(521, 284);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 7;
            label2.Text = "Unit Kerja";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(521, 354);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 8;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(521, 422);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = SystemColors.ButtonFace;
            btnKembali.Image = Properties.Resources.btnKembali;
            btnKembali.Location = new Point(508, 508);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(138, 27);
            btnKembali.SizeMode = PictureBoxSizeMode.AutoSize;
            btnKembali.TabIndex = 10;
            btnKembali.TabStop = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // UC_EditDataUser
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
            Controls.Add(cbUnit);
            Controls.Add(tbUsername);
            Controls.Add(tbPassword);
            Controls.Add(tbNamaPengguna);
            Controls.Add(pictureBox1);
            Name = "UC_EditDataUser";
            Size = new Size(1035, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSimpan).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbNamaPengguna;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private ComboBox cbUnit;
        private PictureBox btnSimpan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox btnKembali;
    }
}
