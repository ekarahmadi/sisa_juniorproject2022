namespace SISA.Recycle
{
    partial class ReAuthentication
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
            btnEyeLock = new PictureBox();
            tbPassword = new TextBox();
            label1 = new Label();
            btnLanjut = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnEyeLock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLanjut).BeginInit();
            SuspendLayout();
            // 
            // btnEyeLock
            // 
            btnEyeLock.BackColor = SystemColors.ButtonFace;
            btnEyeLock.Image = Properties.Resources.btnEyeLock;
            btnEyeLock.Location = new Point(334, 85);
            btnEyeLock.Name = "btnEyeLock";
            btnEyeLock.Size = new Size(21, 17);
            btnEyeLock.SizeMode = PictureBoxSizeMode.AutoSize;
            btnEyeLock.TabIndex = 8;
            btnEyeLock.TabStop = false;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(27, 78);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(301, 31);
            tbPassword.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 16);
            label1.Name = "label1";
            label1.Size = new Size(256, 56);
            label1.TabIndex = 9;
            label1.Text = "Apakah tindakan benar anda?\r\nHarap Masukkan Password\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLanjut
            // 
            btnLanjut.Image = Properties.Resources.btnLanjutkanHover;
            btnLanjut.Location = new Point(124, 126);
            btnLanjut.Name = "btnLanjut";
            btnLanjut.Size = new Size(138, 27);
            btnLanjut.SizeMode = PictureBoxSizeMode.AutoSize;
            btnLanjut.TabIndex = 10;
            btnLanjut.TabStop = false;
            btnLanjut.Click += btnLanjut_Click;
            // 
            // ReAuthentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(376, 177);
            Controls.Add(btnLanjut);
            Controls.Add(label1);
            Controls.Add(btnEyeLock);
            Controls.Add(tbPassword);
            Name = "ReAuthentication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReAuthentication";
            ((System.ComponentModel.ISupportInitialize)btnEyeLock).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLanjut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnEyeLock;
        private TextBox tbPassword;
        private Label label1;
        private PictureBox btnLanjut;
    }
}