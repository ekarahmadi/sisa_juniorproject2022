namespace SISA.View._4TPAWindow
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
            pictureBox1 = new PictureBox();
            btnJemput = new PictureBox();
            btnSelesai = new PictureBox();
            btnOlahSampah = new PictureBox();
            lblOrganik = new Label();
            lblAnorganik = new Label();
            tbMassaSampah = new TextBox();
            cbJenisSampah = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbIDJemput = new Label();
            lbIDSelesai = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnJemput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSelesai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOlahSampah).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CadetBlue;
            pictureBox1.Image = Properties.Resources.TPADashboard1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1035, 720);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnJemput
            // 
            btnJemput.BackColor = Color.FromArgb(59, 115, 120);
            btnJemput.Image = Properties.Resources.btnJemput;
            btnJemput.Location = new Point(295, 314);
            btnJemput.Name = "btnJemput";
            btnJemput.Size = new Size(81, 26);
            btnJemput.SizeMode = PictureBoxSizeMode.AutoSize;
            btnJemput.TabIndex = 1;
            btnJemput.TabStop = false;
            // 
            // btnSelesai
            // 
            btnSelesai.BackColor = Color.FromArgb(59, 115, 120);
            btnSelesai.Image = Properties.Resources.btnSelesai;
            btnSelesai.Location = new Point(295, 635);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(76, 26);
            btnSelesai.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSelesai.TabIndex = 2;
            btnSelesai.TabStop = false;
            // 
            // btnOlahSampah
            // 
            btnOlahSampah.BackColor = Color.FromArgb(37, 54, 66);
            btnOlahSampah.Image = Properties.Resources.btnOlahSampah;
            btnOlahSampah.Location = new Point(863, 447);
            btnOlahSampah.Name = "btnOlahSampah";
            btnOlahSampah.Size = new Size(126, 26);
            btnOlahSampah.SizeMode = PictureBoxSizeMode.AutoSize;
            btnOlahSampah.TabIndex = 3;
            btnOlahSampah.TabStop = false;
            // 
            // lblOrganik
            // 
            lblOrganik.BackColor = Color.FromArgb(53, 74, 75);
            lblOrganik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrganik.ForeColor = Color.White;
            lblOrganik.Location = new Point(804, 193);
            lblOrganik.Name = "lblOrganik";
            lblOrganik.Size = new Size(159, 21);
            lblOrganik.TabIndex = 4;
            lblOrganik.Text = "0";
            lblOrganik.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAnorganik
            // 
            lblAnorganik.BackColor = Color.FromArgb(53, 74, 75);
            lblAnorganik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnorganik.ForeColor = Color.White;
            lblAnorganik.Location = new Point(804, 223);
            lblAnorganik.Name = "lblAnorganik";
            lblAnorganik.Size = new Size(159, 21);
            lblAnorganik.TabIndex = 5;
            lblAnorganik.Text = "0";
            lblAnorganik.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbMassaSampah
            // 
            tbMassaSampah.Location = new Point(841, 391);
            tbMassaSampah.Name = "tbMassaSampah";
            tbMassaSampah.Size = new Size(122, 23);
            tbMassaSampah.TabIndex = 0;
            // 
            // cbJenisSampah
            // 
            cbJenisSampah.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJenisSampah.FormattingEnabled = true;
            cbJenisSampah.Location = new Point(841, 362);
            cbJenisSampah.Name = "cbJenisSampah";
            cbJenisSampah.Size = new Size(148, 23);
            cbJenisSampah.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(53, 74, 75);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(960, 223);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 6;
            label1.Text = "kg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(53, 74, 75);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(960, 193);
            label2.Name = "label2";
            label2.Size = new Size(29, 21);
            label2.TabIndex = 7;
            label2.Text = "kg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(37, 54, 66);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(965, 391);
            label3.Name = "label3";
            label3.Size = new Size(29, 21);
            label3.TabIndex = 8;
            label3.Text = "kg";
            // 
            // lbIDJemput
            // 
            lbIDJemput.BackColor = Color.FromArgb(59, 115, 120);
            lbIDJemput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIDJemput.ForeColor = Color.White;
            lbIDJemput.Location = new Point(224, 314);
            lbIDJemput.Name = "lbIDJemput";
            lbIDJemput.Size = new Size(65, 25);
            lbIDJemput.TabIndex = 9;
            lbIDJemput.Text = "000";
            lbIDJemput.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbIDSelesai
            // 
            lbIDSelesai.BackColor = Color.FromArgb(59, 115, 120);
            lbIDSelesai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIDSelesai.ForeColor = Color.White;
            lbIDSelesai.Location = new Point(224, 636);
            lbIDSelesai.Name = "lbIDSelesai";
            lbIDSelesai.Size = new Size(65, 25);
            lbIDSelesai.TabIndex = 10;
            lbIDSelesai.Text = "000";
            lbIDSelesai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(lbIDSelesai);
            Controls.Add(lbIDJemput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbJenisSampah);
            Controls.Add(tbMassaSampah);
            Controls.Add(lblAnorganik);
            Controls.Add(lblOrganik);
            Controls.Add(btnOlahSampah);
            Controls.Add(btnSelesai);
            Controls.Add(btnJemput);
            Controls.Add(pictureBox1);
            Name = "UC_Dashboard";
            Size = new Size(1035, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnJemput).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSelesai).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOlahSampah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox btnJemput;
        private PictureBox btnSelesai;
        private PictureBox btnOlahSampah;
        private Label lblOrganik;
        private Label lblAnorganik;
        private TextBox tbMassaSampah;
        private ComboBox cbJenisSampah;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbIDJemput;
        private Label lbIDSelesai;
    }
}
