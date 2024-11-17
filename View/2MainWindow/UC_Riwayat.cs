using SISA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISA.View._2MainWindow
{
    public partial class UC_Riwayat : UserControl
    {
        private AuthService authService;
        public UC_Riwayat()
        {
            authService = new AuthService();
            InitializeComponent();
            InitializeButtonHoverEffects();
            LoadRiwayatData(); // Initial load of the data
        }

        //list buat button
        private Image muatDataNo;
        private Image muatDataHover;
        private void InitializeButtonHoverEffects()
        {
            muatDataNo = Properties.Resources.MuatDataNo;
            muatDataHover = Properties.Resources.MuatDataHover;
            btnRiwayat.Image = muatDataNo;
            btnLoadReq.Image = muatDataNo;

            btnRiwayat.MouseEnter += BtnRiwayat_MouseEnter;
            btnRiwayat.MouseLeave += BtnRiwayat_MouseLeave;
            btnLoadReq.MouseEnter += BtnLoadReq_MouseEnter;
            btnLoadReq.MouseLeave += BtnLoadReq_MouseLeave;
        }

        private void BtnRiwayat_MouseEnter(object sender, EventArgs e)
        {
            btnRiwayat.Image = muatDataHover;
        }

        private void BtnRiwayat_MouseLeave(object sender, EventArgs e)
        {
            btnRiwayat.Image = muatDataNo;
        }

        private void BtnLoadReq_MouseEnter(object sender, EventArgs e)
        {
            btnLoadReq.Image = muatDataHover;
        }

        private void BtnLoadReq_MouseLeave(object sender, EventArgs e)
        {
            btnLoadReq.Image = muatDataNo;
        }
        private void LoadRiwayatData()
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadRiwayatData();
        }

        private void gridRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid where we are going to show the request data
        }

        private void btnLoadReq_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadRequestData()
        {
            
        }
    }
}
