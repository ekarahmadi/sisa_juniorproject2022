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

namespace SISA.Recycle
{
    public partial class ReAuthentication : Form
    {
        private string currentUsername;
        private AuthService authService;

        private Image lanjutDefaultImage;
        private Image lanjutHoverImage;
        private Image eyeLockDefaultImage;
        private Image eyeUnlockHoverImage;


        // Properti untuk menyimpan hasil autentikasi
        public bool IsAuthenticated { get; private set; } = false;

        public ReAuthentication(string username)
        {
            InitializeComponent();
            currentUsername = username;
            authService = new AuthService();

            // Inisialisasi gambar default dan hover untuk btnLanjut
            lanjutDefaultImage = Properties.Resources.btnLanjutkan; // Gambar default untuk btnLanjut
            lanjutHoverImage = Properties.Resources.btnLanjutkanHover; // Gambar hover untuk btnLanjut
            btnLanjut.Image = lanjutDefaultImage;

            // Tambahkan event hover untuk btnLanjut
            btnLanjut.MouseEnter += BtnLanjut_MouseEnter;
            btnLanjut.MouseLeave += BtnLanjut_MouseLeave;

            // Inisialisasi gambar default dan hover untuk btnEyeLock
            eyeLockDefaultImage = Properties.Resources.btnEyeLock; // Gambar default (mata tertutup)
            eyeUnlockHoverImage = Properties.Resources.btnEyeUnlock; // Gambar hover (mata terbuka)
            btnEyeLock.Image = eyeLockDefaultImage;

            // Tambahkan event hover dan click untuk btnEyeLock
            btnEyeLock.MouseEnter += BtnEyeLock_MouseEnter;
            btnEyeLock.MouseLeave += BtnEyeLock_MouseLeave;
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            string password = tbPassword.Text;

            // Verifikasi password dengan AuthService
            if (authService.VerifyPassword(currentUsername, password))
            {
                IsAuthenticated = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Password salah. Silakan coba lagi.", "Autentikasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Clear();
                tbPassword.Focus();
            }
        }

        private void BtnLanjut_MouseEnter(object sender, EventArgs e)
        {
            btnLanjut.Image = lanjutHoverImage;
        }

        private void BtnLanjut_MouseLeave(object sender, EventArgs e)
        {
            btnLanjut.Image = lanjutDefaultImage;
        }

        // Event handler untuk btnEyeLock MouseEnter - Menampilkan password
        private void BtnEyeLock_MouseEnter(object sender, EventArgs e)
        {
            btnEyeLock.Image = eyeUnlockHoverImage;
            tbPassword.PasswordChar = '\0'; // Tampilkan password
        }

        // Event handler untuk btnEyeLock MouseLeave - Menyembunyikan password
        private void BtnEyeLock_MouseLeave(object sender, EventArgs e)
        {
            btnEyeLock.Image = eyeLockDefaultImage;
            tbPassword.PasswordChar = '*'; // Sembunyikan password
        }

    }
}
