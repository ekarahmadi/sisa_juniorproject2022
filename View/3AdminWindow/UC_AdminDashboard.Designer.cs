namespace SISA.View._3AdminWindow
{
    partial class UC_AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AdminDashboard));
            pictureBox1 = new PictureBox();
            lblTotalUser = new Label();
            lblTotalRequest = new Label();
            lblTotalTPS = new Label();
            lblTotalTPA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(993, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTotalUser
            // 
            lblTotalUser.AutoSize = true;
            lblTotalUser.BackColor = SystemColors.ButtonFace;
            lblTotalUser.Font = new Font("Poppins", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalUser.Location = new Point(53, 114);
            lblTotalUser.Name = "lblTotalUser";
            lblTotalUser.Size = new Size(128, 113);
            lblTotalUser.TabIndex = 1;
            lblTotalUser.Text = "50";
            lblTotalUser.Click += lblTotalUser_Click;
            // 
            // lblTotalRequest
            // 
            lblTotalRequest.AutoSize = true;
            lblTotalRequest.BackColor = SystemColors.ButtonFace;
            lblTotalRequest.Font = new Font("Poppins", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRequest.Location = new Point(382, 114);
            lblTotalRequest.Name = "lblTotalRequest";
            lblTotalRequest.Size = new Size(128, 113);
            lblTotalRequest.TabIndex = 2;
            lblTotalRequest.Text = "50";
            // 
            // lblTotalTPS
            // 
            lblTotalTPS.AutoSize = true;
            lblTotalTPS.BackColor = SystemColors.ButtonFace;
            lblTotalTPS.Font = new Font("Poppins", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTPS.Location = new Point(787, 117);
            lblTotalTPS.Name = "lblTotalTPS";
            lblTotalTPS.Size = new Size(64, 56);
            lblTotalTPS.TabIndex = 3;
            lblTotalTPS.Text = "50";
            // 
            // lblTotalTPA
            // 
            lblTotalTPA.AutoSize = true;
            lblTotalTPA.BackColor = SystemColors.ButtonFace;
            lblTotalTPA.Font = new Font("Poppins", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTPA.Location = new Point(787, 167);
            lblTotalTPA.Name = "lblTotalTPA";
            lblTotalTPA.Size = new Size(64, 56);
            lblTotalTPA.TabIndex = 4;
            lblTotalTPA.Text = "50";
            // 
            // UC_AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(lblTotalTPA);
            Controls.Add(lblTotalTPS);
            Controls.Add(lblTotalRequest);
            Controls.Add(lblTotalUser);
            Controls.Add(pictureBox1);
            Name = "UC_AdminDashboard";
            Size = new Size(1035, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTotalUser;
        private Label lblTotalRequest;
        private Label lblTotalTPS;
        private Label lblTotalTPA;
    }
}
