﻿namespace SISA.View._3AdminWindow
{
    partial class UC_AdminAccRequest
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
            panel1 = new Panel();
            dgvCalonUser = new DataGridView();
            panel2 = new Panel();
            dgvTerdaftar = new DataGridView();
            panel3 = new Panel();
            tbWaktu = new TextBox();
            label7 = new Label();
            tbUnitKerja = new TextBox();
            label6 = new Label();
            tbUsername = new TextBox();
            label5 = new Label();
            tbNama = new TextBox();
            label4 = new Label();
            btnTerima = new PictureBox();
            btnTolak = new PictureBox();
            btnEdit = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbRole = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalonUser).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTerdaftar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnTerima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTolak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEdit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvCalonUser);
            panel1.Location = new Point(32, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 250);
            panel1.TabIndex = 0;
            // 
            // dgvCalonUser
            // 
            dgvCalonUser.AllowUserToOrderColumns = true;
            dgvCalonUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalonUser.Dock = DockStyle.Fill;
            dgvCalonUser.Location = new Point(0, 0);
            dgvCalonUser.Name = "dgvCalonUser";
            dgvCalonUser.Size = new Size(650, 250);
            dgvCalonUser.TabIndex = 0;
            dgvCalonUser.CellClick += dgvCalonUser_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvTerdaftar);
            panel2.Location = new Point(32, 396);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 250);
            panel2.TabIndex = 1;
            // 
            // dgvTerdaftar
            // 
            dgvTerdaftar.AllowUserToOrderColumns = true;
            dgvTerdaftar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerdaftar.Dock = DockStyle.Fill;
            dgvTerdaftar.Location = new Point(0, 0);
            dgvTerdaftar.Name = "dgvTerdaftar";
            dgvTerdaftar.Size = new Size(650, 250);
            dgvTerdaftar.TabIndex = 0;
            dgvTerdaftar.CellClick += dgvTerdaftar_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbRole);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(tbWaktu);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(tbUnitKerja);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(tbUsername);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(tbNama);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnTerima);
            panel3.Controls.Add(btnTolak);
            panel3.Controls.Add(btnEdit);
            panel3.Location = new Point(702, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 558);
            panel3.TabIndex = 2;
            // 
            // tbWaktu
            // 
            tbWaktu.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbWaktu.Location = new Point(18, 360);
            tbWaktu.Name = "tbWaktu";
            tbWaktu.Size = new Size(262, 31);
            tbWaktu.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 329);
            label7.Name = "label7";
            label7.Size = new Size(280, 28);
            label7.TabIndex = 12;
            label7.Text = "Waktu mendaftar / terakhir diedit";
            // 
            // tbUnitKerja
            // 
            tbUnitKerja.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUnitKerja.Location = new Point(18, 275);
            tbUnitKerja.Name = "tbUnitKerja";
            tbUnitKerja.Size = new Size(262, 31);
            tbUnitKerja.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 244);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 10;
            label6.Text = "Unit Kerja";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(18, 123);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(262, 31);
            tbUsername.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 92);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 8;
            label5.Text = "Username";
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
            label4.Size = new Size(61, 28);
            label4.TabIndex = 6;
            label4.Text = "Nama";
            // 
            // btnTerima
            // 
            btnTerima.Image = Properties.Resources.btnTerima;
            btnTerima.Location = new Point(74, 423);
            btnTerima.Name = "btnTerima";
            btnTerima.Size = new Size(154, 27);
            btnTerima.SizeMode = PictureBoxSizeMode.AutoSize;
            btnTerima.TabIndex = 2;
            btnTerima.TabStop = false;
            btnTerima.Click += btnTerima_Click;
            // 
            // btnTolak
            // 
            btnTolak.Image = Properties.Resources.btnTolak1;
            btnTolak.Location = new Point(74, 465);
            btnTolak.Name = "btnTolak";
            btnTolak.Size = new Size(154, 27);
            btnTolak.SizeMode = PictureBoxSizeMode.AutoSize;
            btnTolak.TabIndex = 1;
            btnTolak.TabStop = false;
            btnTolak.Click += btnTolak_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.btnEditData;
            btnEdit.Location = new Point(74, 507);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(154, 27);
            btnEdit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnEdit.TabIndex = 0;
            btnEdit.TabStop = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 33);
            label1.Name = "label1";
            label1.Size = new Size(212, 42);
            label1.TabIndex = 3;
            label1.Text = "Data Calon User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 351);
            label2.Name = "label2";
            label2.Size = new Size(252, 42);
            label2.TabIndex = 4;
            label2.Text = "Data User Terdaftar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(702, 33);
            label3.Name = "label3";
            label3.Size = new Size(199, 42);
            label3.TabIndex = 5;
            label3.Text = "Data Terseleksi";
            // 
            // tbRole
            // 
            tbRole.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbRole.Location = new Point(18, 200);
            tbRole.Name = "tbRole";
            tbRole.Size = new Size(262, 31);
            tbRole.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 169);
            label8.Name = "label8";
            label8.Size = new Size(46, 28);
            label8.TabIndex = 14;
            label8.Text = "Role";
            // 
            // UC_AdminAccRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_AdminAccRequest";
            Size = new Size(1035, 720);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCalonUser).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTerdaftar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnTerima).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTolak).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private PictureBox btnTerima;
        private PictureBox btnTolak;
        private PictureBox btnEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private TextBox tbUnitKerja;
        private Label label6;
        private TextBox tbUsername;
        private Label label5;
        private TextBox tbNama;
        private DataGridView dgvCalonUser;
        private DataGridView dgvTerdaftar;
        private TextBox tbWaktu;
        private TextBox tbRole;
        private Label label8;
    }
}
