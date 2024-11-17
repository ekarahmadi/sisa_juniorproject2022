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
            btnLoadPenjemputan = new PictureBox();
            btnLoadOlah = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnLoadPenjemputan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLoadOlah).BeginInit();
            SuspendLayout();
            // 
            // btnLoadPenjemputan
            // 
            btnLoadPenjemputan.BackColor = Color.FromArgb(59, 115, 120);
            btnLoadPenjemputan.Image = Properties.Resources.TPALoad;
            btnLoadPenjemputan.Location = new Point(893, 322);
            btnLoadPenjemputan.Name = "btnLoadPenjemputan";
            btnLoadPenjemputan.Size = new Size(98, 26);
            btnLoadPenjemputan.SizeMode = PictureBoxSizeMode.AutoSize;
            btnLoadPenjemputan.TabIndex = 0;
            btnLoadPenjemputan.TabStop = false;
            // 
            // btnLoadOlah
            // 
            btnLoadOlah.BackColor = Color.FromArgb(59, 115, 120);
            btnLoadOlah.Image = Properties.Resources.TPALoad;
            btnLoadOlah.Location = new Point(893, 655);
            btnLoadOlah.Name = "btnLoadOlah";
            btnLoadOlah.Size = new Size(98, 26);
            btnLoadOlah.SizeMode = PictureBoxSizeMode.AutoSize;
            btnLoadOlah.TabIndex = 1;
            btnLoadOlah.TabStop = false;
            // 
            // UC_Riwayat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TPARiwayat;
            Controls.Add(btnLoadOlah);
            Controls.Add(btnLoadPenjemputan);
            Name = "UC_Riwayat";
            Size = new Size(1035, 720);
            ((System.ComponentModel.ISupportInitialize)btnLoadPenjemputan).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLoadOlah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnLoadPenjemputan;
        private PictureBox btnLoadOlah;
    }
}
