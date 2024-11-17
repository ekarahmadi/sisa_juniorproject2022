namespace SISA.View._2MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Riwayat));
            pictureBox1 = new PictureBox();
            GridRiwayat = new DataGridView();
            btnRiwayat = new PictureBox();
            gridRequest = new DataGridView();
            btnLoadReq = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridRequest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLoadReq).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Riwayat;
            pictureBox1.Location = new Point(43, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(921, 642);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // GridRiwayat
            // 
            GridRiwayat.BackgroundColor = Color.CadetBlue;
            GridRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridRiwayat.GridColor = Color.Aqua;
            GridRiwayat.Location = new Point(91, 161);
            GridRiwayat.Name = "GridRiwayat";
            GridRiwayat.Size = new Size(839, 150);
            GridRiwayat.TabIndex = 1;
            GridRiwayat.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Image = (Image)resources.GetObject("btnRiwayat.Image");
            btnRiwayat.Location = new Point(830, 356);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(100, 25);
            btnRiwayat.TabIndex = 2;
            btnRiwayat.TabStop = false;
            btnRiwayat.Click += pictureBox2_Click;
            // 
            // gridRequest
            // 
            gridRequest.BackgroundColor = Color.CadetBlue;
            gridRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRequest.GridColor = Color.Aqua;
            gridRequest.Location = new Point(91, 424);
            gridRequest.Name = "gridRequest";
            gridRequest.Size = new Size(839, 150);
            gridRequest.TabIndex = 3;
            gridRequest.CellContentClick += gridRequest_CellContentClick;
            // 
            // btnLoadReq
            // 
            btnLoadReq.Image = (Image)resources.GetObject("btnLoadReq.Image");
            btnLoadReq.Location = new Point(830, 615);
            btnLoadReq.Name = "btnLoadReq";
            btnLoadReq.Size = new Size(100, 25);
            btnLoadReq.TabIndex = 4;
            btnLoadReq.TabStop = false;
            btnLoadReq.Click += btnLoadReq_Click;
            // 
            // UC_Riwayat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(btnLoadReq);
            Controls.Add(gridRequest);
            Controls.Add(btnRiwayat);
            Controls.Add(GridRiwayat);
            Controls.Add(pictureBox1);
            Name = "UC_Riwayat";
            Size = new Size(1035, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridRequest).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLoadReq).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView GridRiwayat;
        private PictureBox btnRiwayat;
        private DataGridView gridRequest;
        private PictureBox btnLoadReq;
    }
}
