using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISA.View._4TPAWindow
{
    public partial class UC_Dashboard : UserControl
    {
        private Image btnJemputDefault;
        private Image btnJemputHover;
        private Image btnSelesaiDefault;
        private Image btnSelesaiHover;
        private Image btnOlahSampahDefault;
        private Image btnOlahSampahHover;

        public event EventHandler BackButtonClicked;

        public UC_Dashboard()
        {
            InitializeComponent();

            // Inisialisasi gambar untuk btnJemput
            btnJemputDefault = Properties.Resources.btnJemput; // Ganti dengan nama gambar default di Resources
            btnJemputHover = Properties.Resources.btnJemputHover; // Ganti dengan nama gambar hover di Resources

            // Inisialisasi gambar untuk btnSelesai
            btnSelesaiDefault = Properties.Resources.btnSelesai;   // Ganti dengan nama gambar default di Resources
            btnSelesaiHover = Properties.Resources.btnSelesaiHover1;   // Ganti dengan nama gambar hover di Resources

            // Inisialisasi gambar untuk btnOlahSampah
            btnOlahSampahDefault = Properties.Resources.btnOlahSampah;   // Ganti dengan nama gambar default di Resources
            btnOlahSampahHover = Properties.Resources.btnOlahSampahHover;       // Ganti dengan nama gambar hover di Resources

            // Tambahkan event MouseEnter dan MouseLeave untuk btnJemput
            btnJemput.MouseEnter += BtnJemput_MouseEnter;
            btnJemput.MouseLeave += BtnJemput_MouseLeave;

            // Tambahkan event MouseEnter dan MouseLeave untuk btnSelesai
            btnSelesai.MouseEnter += BtnSelesai_MouseEnter;
            btnSelesai.MouseLeave += BtnSelesai_MouseLeave;

            // Tambahkan event MouseEnter dan MouseLeave untuk btnOlahSampah
            btnOlahSampah.MouseEnter += BtnOlahSampah_MouseEnter;
            btnOlahSampah.MouseLeave += BtnOlahSampah_MouseLeave;
        }

        private void BtnJemput_MouseEnter(object sender, EventArgs e)
        {
            // Ubah gambar ke hover saat kursor berada di atas btnJemput
            btnJemput.Image = btnJemputHover;
        }

        private void BtnJemput_MouseLeave(object sender, EventArgs e)
        {
            // Kembalikan gambar ke default saat kursor meninggalkan btnJemput
            btnJemput.Image = btnJemputDefault;
        }

        private void BtnSelesai_MouseEnter(object sender, EventArgs e)
        {
            // Ubah gambar ke hover saat kursor berada di atas btnDaftar
            btnSelesai.Image = btnSelesaiHover;
        }

        private void BtnSelesai_MouseLeave(object sender, EventArgs e)
        {
            // Kembalikan gambar ke default saat kursor meninggalkan btnDaftar
            btnSelesai.Image = btnSelesaiDefault;
        }

        private void BtnOlahSampah_MouseEnter(object sender, EventArgs e)
        {
            // Ubah gambar ke hover saat kursor berada di atas btnDaftar
            btnOlahSampah.Image = btnOlahSampahHover;
        }

        private void BtnOlahSampah_MouseLeave(object sender, EventArgs e)
        {
            // Kembalikan gambar ke default saat kursor meninggalkan btnDaftar
            btnOlahSampah.Image = btnOlahSampahDefault;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
