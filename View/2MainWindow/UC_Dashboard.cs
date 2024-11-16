using SISA.Model;
using System;
using System.Data;
using System.Security.Principal;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SISA.View._2MainWindow
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();

            // Tambahkan event handler untuk semua tombol
            btnTambahDataSampah.MouseEnter += btnTambahDataSampah_MouseEnter;
            btnTambahDataSampah.MouseLeave += btnTambahDataSampah_MouseLeave;

            btnBuatPermintaan.MouseEnter += btnBuatPermintaan_MouseEnter;
            btnBuatPermintaan.MouseLeave += btnBuatPermintaan_MouseLeave;

            btnEditDataSampah.MouseEnter += btnEditDataSampah_MouseEnter;
            btnEditDataSampah.MouseLeave += btnEditDataSampah_MouseLeave;

            btnHapusDataSampah.MouseEnter += btnHapusDataSampah_MouseEnter;
            btnHapusDataSampah.MouseLeave += btnHapusDataSampah_MouseLeave;

            btnUpdateStatus.MouseEnter += btnUpdateStatus_MouseEnter;
            btnUpdateStatus.MouseLeave += btnUpdateStatus_MouseLeave;

            btnBatalkanStatus.MouseEnter += btnBatalkanStatus_MouseEnter;
            btnBatalkanStatus.MouseLeave += btnBatalkanStatus_MouseLeave;
        }

        private void btnTambahDataSampah_MouseEnter(object sender, EventArgs e)
        {
            btnTambahDataSampah.Image = Properties.Resources.btnTambahDataSampahHover; // Gambar hover
        }

        private void btnTambahDataSampah_MouseLeave(object sender, EventArgs e)
        {
            btnTambahDataSampah.Image = Properties.Resources.btnTambahDataSampah; // Gambar normal
        }

        private void btnBuatPermintaan_MouseEnter(object sender, EventArgs e)
        {
            btnBuatPermintaan.Image = Properties.Resources.btnBuatPermintaanHover; // Gambar hover
        }

        private void btnBuatPermintaan_MouseLeave(object sender, EventArgs e)
        {
            btnBuatPermintaan.Image = Properties.Resources.btnBuatPermintaan; // Gambar normal
        }

        private void btnEditDataSampah_MouseEnter(object sender, EventArgs e)
        {
            btnEditDataSampah.Image = Properties.Resources.btnEditDataSampahHover; // Gambar hover
        }

        private void btnEditDataSampah_MouseLeave(object sender, EventArgs e)
        {
            btnEditDataSampah.Image = Properties.Resources.btnEditDataSampah; // Gambar normal
        }

        private void btnHapusDataSampah_MouseEnter(object sender, EventArgs e)
        {
            btnHapusDataSampah.Image = Properties.Resources.btnHapusDataSampahHover; // Gambar hover
        }

        private void btnHapusDataSampah_MouseLeave(object sender, EventArgs e)
        {
            btnHapusDataSampah.Image = Properties.Resources.btnHapusDataSampah; // Gambar normal
        }

        private void btnUpdateStatus_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateStatus.Image = Properties.Resources.btnUpdateStatusSampahHover; // Gambar hover
        }

        private void btnUpdateStatus_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateStatus.Image = Properties.Resources.btnUpdateStatusSampah; // Gambar normal
        }

        private void btnBatalkanStatus_MouseEnter(object sender, EventArgs e)
        {
            btnBatalkanStatus.Image = Properties.Resources.btnBatalkanStatusHover; // Gambar hover
        }

        private void btnBatalkanStatus_MouseLeave(object sender, EventArgs e)
        {
            btnBatalkanStatus.Image = Properties.Resources.btnBatalkanStatus; // Gambar normal
        }


        private void btnTambahDataSampah_Click(object sender, EventArgs e)
        {

        }
    }
}
