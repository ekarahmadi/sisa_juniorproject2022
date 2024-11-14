using Microsoft.VisualBasic.Logging;
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

namespace SISA.View._1Starting
{
    public partial class UC_Start : UserControl
    {
        private Image defaultImage;
        private Image hoverImage;

        // Event untuk memberi sinyal kepada form utama
        public event EventHandler StartButtonClicked;

        public UC_Start()
        {
            InitializeComponent();

            // Inisialisasi gambar untuk PictureBox btnStart
            defaultImage = Properties.Resources.btnStart; // Ganti dengan path gambar default
            hoverImage = Properties.Resources.btnStartClick;     // Ganti dengan path gambar hover

            // Set gambar awal pada btnStart
            btnStart.Image = defaultImage;

            // Tambahkan event MouseEnter dan MouseLeave ke btnStart
            btnStart.MouseEnter += BtnStart_MouseEnter;
            btnStart.MouseLeave += BtnStart_MouseLeave; // Tambahkan event MouseLeave di sini
            btnStart.Click += BtnStart_Click;

            btnStart.Click += BtnStart_Click;
        }

        private void BtnStart_MouseEnter(object sender, EventArgs e)
        {
            // Ubah gambar ke hover saat kursor berada di atas btnStart
            btnStart.Image = hoverImage;
        }

        private void BtnStart_MouseLeave(object sender, EventArgs e)
        {
            // Kembalikan gambar ke default saat kursor meninggalkan btnStart
            btnStart.Image = defaultImage;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
