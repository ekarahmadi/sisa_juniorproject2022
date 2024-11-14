namespace SISA.View._1Starting
{
    partial class UC_Start
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
            contentStart = new PictureBox();
            btnStart = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)contentStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnStart).BeginInit();
            SuspendLayout();
            // 
            // contentStart
            // 
            contentStart.Image = Properties.Resources.contentGetStarted;
            contentStart.Location = new Point(0, 0);
            contentStart.Name = "contentStart";
            contentStart.Size = new Size(802, 464);
            contentStart.SizeMode = PictureBoxSizeMode.AutoSize;
            contentStart.TabIndex = 0;
            contentStart.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ButtonFace;
            btnStart.Image = Properties.Resources.btnStart;
            btnStart.Location = new Point(355, 371);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(138, 27);
            btnStart.SizeMode = PictureBoxSizeMode.AutoSize;
            btnStart.TabIndex = 1;
            btnStart.TabStop = false;
            btnStart.Click += btnStart_Click;
            // 
            // UC_Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(btnStart);
            Controls.Add(contentStart);
            Name = "UC_Start";
            Size = new Size(802, 464);
            ((System.ComponentModel.ISupportInitialize)contentStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnStart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox contentStart;
        private PictureBox btnStart;
    }
}
