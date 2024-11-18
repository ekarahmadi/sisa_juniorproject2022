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
using static SISA.Model.AuthService;

namespace SISA.View._1Starting
{
    public partial class UC_Login : UserControl
    {
        private Image defaultImage;
        private Image hoverImage;
        private Image eyeDefaultImage;
        private Image eyeHoverImage;
        private SessionManager sessionManager;

        private AuthService authService;

        // Event untuk memberi sinyal ke GetStart ketika login berhasil
        public event Action<int> LoginSuccessful;

        // Event untuk memberi sinyal ke form utama saat "Daftar Dulu" diklik
        public event EventHandler SignUpLinkClicked;

        // Event untuk memberi sinyal ke form utama bahwa login button diklik
        public event EventHandler LoginButtonClicked;

        public UC_Login()
        {
            InitializeComponent();
            authService = new AuthService();

            // Inisialisasi gambar untuk PictureBox btnLogin
            defaultImage = Properties.Resources.btnLogin; // Ganti dengan nama gambar default di Resources
            hoverImage = Properties.Resources.btnLoginClick; // Ganti dengan nama gambar hover di Resources
            eyeDefaultImage = Properties.Resources.btnEyeLock; // Ganti dengan nama gambar default di Resources
            eyeHoverImage = Properties.Resources.btnEyeUnlock; // Ganti dengan nama gambar hover di Resources

            // Set gambar awal pada btnLogin dan btnEyeLock
            btnLogin.Image = defaultImage;
            btnEyeLock.Image = eyeDefaultImage;

            // Tambahkan event MouseEnter dan MouseLeave
            btnLogin.MouseEnter += BtnLogin_MouseEnter;
            btnLogin.MouseLeave += BtnLogin_MouseLeave;
            btnEyeLock.MouseEnter += BtnEyeLock_MouseEnter;
            btnEyeLock.MouseLeave += BtnEyeLock_MouseLeave;

            // Set PasswordChar awal untuk menyamarkan password
            tbPassword.PasswordChar = '*';
        }

        // Event handler untuk btnLogin MouseEnter
        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.Image = hoverImage;
        }

        // Event handler untuk btnLogin MouseLeave
        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.Image = defaultImage;
        }

        // Event handler untuk btnEyeLock MouseEnter - Menampilkan password
        private void BtnEyeLock_MouseEnter(object sender, EventArgs e)
        {
            btnEyeLock.Image = eyeHoverImage;
            tbPassword.PasswordChar = '\0'; // Tampilkan password
        }

        // Event handler untuk btnEyeLock MouseLeave - Menyembunyikan password
        private void BtnEyeLock_MouseLeave(object sender, EventArgs e)
        {
            btnEyeLock.Image = eyeDefaultImage;
            tbPassword.PasswordChar = '*'; // Sembunyikan password
        }

        private void linkDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Memicu event untuk menginformasikan form utama
            SignUpLinkClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (authService.Login(username, password, out int roleId))
            {

                SessionManager.LoadAllUnits();

                authService.ConnectToDatabase();
                // Simpan informasi sesi ke dalam SessionManager
                SessionManager.Username = username; // Menyimpan username yang benar ke SessionManager
                SessionManager.RoleId = roleId;

                // Panggil metode untuk mendapatkan unit_id berdasarkan username dan simpan di SessionManager
                int unitId = authService.GetUnitIdByUsername(username);
                if (unitId != -1)
                {
                    SessionManager.UnitKerja = unitId.ToString(); // Simpan unit_id di SessionManager sebagai string
                }
                else
                {
                    MessageBox.Show("Failed to retrieve unit_id for the user.");
                }

                // Panggil event LoginSuccessful jika login berhasil
                LoginSuccessful?.Invoke(roleId);
            }
            else
            {
                MessageBox.Show("Username atau password salah.");
            }
        }

        private void btnEyeLock_Click(object sender, EventArgs e)
        {

        }
    }
}
