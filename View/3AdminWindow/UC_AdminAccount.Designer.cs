﻿namespace SISA.View._3AdminWindow
{
    partial class UC_AdminAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AdminAccount));
            lblRole = new Label();
            lblUnit = new Label();
            lblUsername = new Label();
            lblNama = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = SystemColors.ButtonFace;
            lblRole.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(528, 459);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(88, 20);
            lblRole.TabIndex = 14;
            lblRole.Text = "Admin TPS";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.BackColor = SystemColors.ButtonFace;
            lblUnit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnit.Location = new Point(527, 405);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(118, 20);
            lblUnit.TabIndex = 13;
            lblUnit.Text = "TPS Sinduadi 1";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ButtonFace;
            lblUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(528, 352);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(101, 20);
            lblUsername.TabIndex = 12;
            lblUsername.Text = "eka_rahmadi";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = SystemColors.ButtonFace;
            lblNama.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(527, 300);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(164, 20);
            lblNama.TabIndex = 11;
            lblNama.Text = "Septian Eka Rahmadi";
            lblNama.Click += lblNama_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(662, 464);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // UC_AdminAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(lblRole);
            Controls.Add(lblUnit);
            Controls.Add(lblUsername);
            Controls.Add(lblNama);
            Controls.Add(pictureBox1);
            Name = "UC_AdminAccount";
            Size = new Size(1035, 720);
            Load += UC_AdminAccount_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRole;
        private Label lblUnit;
        private Label lblUsername;
        private Label lblNama;
        private PictureBox pictureBox1;
    }
}
