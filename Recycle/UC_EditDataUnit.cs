using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISA.Recycle
{
    public partial class UC_EditDataUnit : UserControl
    {
        private Image kembaliDefaultImage;
        private Image kembaliHoverImage;
        private Image simpanDefaultImage;
        private Image simpanHoverImage;

        public UC_EditDataUnit()
        {
            InitializeComponent();

            // Inisialisasi gambar default dan hover untuk btnKembali
            kembaliDefaultImage = Properties.Resources.btnKembali; // Gambar default untuk btnKembali
            kembaliHoverImage = Properties.Resources.btnKembaliHover; // Gambar hover untuk btnKembali
            btnKembali.Image = kembaliDefaultImage;

            // Tambahkan event hover untuk btnKembali
            btnKembali.MouseEnter += BtnKembali_MouseEnter;
            btnKembali.MouseLeave += BtnKembali_MouseLeave;

            // Inisialisasi gambar default dan hover untuk btnSimpan
            simpanDefaultImage = Properties.Resources.btnSimpan; // Gambar default untuk btnSimpan
            simpanHoverImage = Properties.Resources.btnSimpanHover; // Gambar hover untuk btnSimpan
            btnSimpan.Image = simpanDefaultImage;

            // Tambahkan event hover untuk btnSimpan
            btnSimpan.MouseEnter += BtnSimpan_MouseEnter;
            btnSimpan.MouseLeave += BtnSimpan_MouseLeave;
        }

        private void BtnKembali_MouseEnter(object sender, EventArgs e)
        {
            btnKembali.Image = kembaliHoverImage;
        }

        private void BtnKembali_MouseLeave(object sender, EventArgs e)
        {
            btnKembali.Image = kembaliDefaultImage;
        }

        private void BtnSimpan_MouseEnter(object sender, EventArgs e)
        {
            btnSimpan.Image = simpanHoverImage;
        }

        private void BtnSimpan_MouseLeave(object sender, EventArgs e)
        {
            btnSimpan.Image = simpanDefaultImage;
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {

        }
    }
}
