namespace SISA.View._2MainWindow
{
    partial class FormSelectTPA
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
            dgvTPA = new DataGridView();
            btnConfirm = new PictureBox();
            btnCancel = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnConfirm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).BeginInit();
            SuspendLayout();
            // 
            // dgvTPA
            // 
            dgvTPA.BackgroundColor = Color.CadetBlue;
            dgvTPA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTPA.Location = new Point(38, 29);
            dgvTPA.Name = "dgvTPA";
            dgvTPA.Size = new Size(391, 300);
            dgvTPA.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Image = Properties.Resources.btnKonfirmasi;
            btnConfirm.Location = new Point(85, 357);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(133, 27);
            btnConfirm.SizeMode = PictureBoxSizeMode.AutoSize;
            btnConfirm.TabIndex = 1;
            btnConfirm.TabStop = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.btnGaJadi;
            btnCancel.Location = new Point(242, 357);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 27);
            btnCancel.SizeMode = PictureBoxSizeMode.AutoSize;
            btnCancel.TabIndex = 2;
            btnCancel.TabStop = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormSelectTPA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(475, 410);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(dgvTPA);
            Name = "FormSelectTPA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSelectTPA";
            Load += FormSelectTPA_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnConfirm).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTPA;
        private PictureBox btnConfirm;
        private PictureBox btnCancel;
    }
}