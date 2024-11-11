using SISA.Model;
using SISA.Recycle;
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
    public partial class UC_Account : UserControl
    {
        private Image defaultImage;
        private Image hoverImage;
        private Image defaultImageUnit;
        private Image hoverImageUnit;
        private Image defaultImageReload;
        private Image hoverImageReload;

        private AuthService authService;
        private MainWindow mainWindow;

        // Event untuk memuat UC_EditDataUser
        public event Action ShowEditDataUser;

        // Event untuk memuat UC_EditDataUnit
        public event Action ShowEditDataUnit;

        public UC_Account()
        {
            InitializeComponent();// Inisialisasi gambar untuk PictureBox btnLogin
            authService = new AuthService();
            this.mainWindow = mainWindow;

            LoadUserData(); // Panggil LoadUserData setelah kontrol ini diinisialisasi
            LoadUnitData(); // Memuat data unit kerja

            // Inisialisasi gambar default dan hover untuk btnEditUser
            defaultImage = Properties.Resources.btnEditData1; // Ganti dengan nama gambar default di Resources
            hoverImage = Properties.Resources.btnEditData1Hover;     // Ganti dengan nama gambar hover di Resources
            btnEditUser.Image = defaultImage;

            // Tambahkan event MouseEnter dan MouseLeave ke btnLogin
            btnEditUser.MouseEnter += BtnEdit_MouseEnter;
            btnEditUser.MouseLeave += BtnEdit_MouseLeave;

            // Inisialisasi gambar default dan hover untuk btnEditUnit
            defaultImageUnit = Properties.Resources.btnEditData1; // Gambar default untuk btnEditUnit
            hoverImageUnit = Properties.Resources.btnEditData1Hover; // Gambar hover untuk btnEditUnit
            btnEditUnit.Image = defaultImageUnit;

            // Tambahkan event hover untuk btnEditUnit
            btnEditUnit.MouseEnter += BtnEditUnit_MouseEnter;
            btnEditUnit.MouseLeave += BtnEditUnit_MouseLeave;

            // Inisialisasi gambar default dan hover untuk btnReload
            defaultImageReload = Properties.Resources.btnReload; // Gambar default untuk btnEditUnit
            hoverImageReload = Properties.Resources.btnReloadHover; // Gambar hover untuk btnEditUnit
            btnReload.Image = defaultImageReload;

            // Tambahkan event hover untuk btnReload
            btnReload.MouseEnter += BtnReload_MouseEnter;
            btnReload.MouseLeave += BtnReload_MouseLeave;
        }

        private void BtnReload_MouseLeave(object? sender, EventArgs e)
        {
            btnReload.Image = defaultImageReload;
        }

        private void BtnReload_MouseEnter(object? sender, EventArgs e)
        {
            btnReload.Image = hoverImageReload;
        }

        public void LoadUserData()
        {
            // Ambil username dari SessionManager
            string currentUsername = SessionManager.Username;

            if (string.IsNullOrEmpty(currentUsername))
            {
                MessageBox.Show("Username is not set in the session. Please log in again.");
                return;
            }

            // Ambil data pengguna dari AuthService
            UserData userData = authService.GetUserDataByUsername(currentUsername);

            if (userData != null)
            {
                // Tampilkan data pada label atau kontrol UI
                lblNama.Text = userData.Nama;
                lblUsername.Text = userData.Username;
                lblUnit.Text = authService.GetUnitNameById(int.Parse(userData.UnitKerja));
                lblRole.Text = ConvertRoleIdToRoleName(int.Parse(userData.Role));

                Console.WriteLine("Data berhasil dimuat ulang di UC_Account");
            }
            else
            {
                MessageBox.Show("Failed to load user data from the database.");
            }
        }

        public void LoadUnitData()
        {
            // Asumsikan unit_id didapatkan dari SessionManager atau data pengguna
            int unitId = int.Parse(SessionManager.UnitKerja); // Sesuaikan jika unit_id disimpan di SessionManager

            // Panggil AuthService untuk mendapatkan data unit kerja
            UnitData unitData = authService.GetUnitDetailsById(unitId);

            if (unitData != null)
            {
                // Tampilkan data pada label atau kontrol UI
                lblNamaUnit.Text = unitData.NamaUnit;
                lblTipeUnit.Text = unitData.TipeUnit;
                lblLokasiUnit.Text = unitData.LokasiUnit;
                lblKapasitasUnit.Text = unitData.KapasitasUnit;

                // Logika penyesuaian UI berdasarkan tipe unit
                if (unitData.TipeUnit == "TPS")
                {
                    lblTipeUnit.Text = "Tempat Pembuangan Sementara";
                }
                else if (unitData.TipeUnit == "TPA")
                {
                    lblTipeUnit.Text = "Tempat Pemrosesan Akhir";
                }
                else
                {
                    lblTipeUnit.Text = "Tipe Unit Tidak Diketahui"; // Jika tipe unit tidak sesuai
                }
            }
            else
            {
                MessageBox.Show("Failed to load unit data from the database.");
            }
        }


        // Helper function to convert role ID to role name
        private string ConvertRoleIdToRoleName(int roleId)
        {
            switch (roleId)
            {
                case 1:
                    return "Admin TPS";
                case 2:
                    return "Admin TPA";
                case 3:
                    return "Admin App";
                default:
                    return "Unknown Role";
            }
        }

        private void BtnEdit_MouseEnter(object sender, EventArgs e)
        {
            // Ubah gambar ke hover saat kursor berada di atas btnLogin
            btnEditUser.Image = hoverImage;
        }

        private void BtnEdit_MouseLeave(object sender, EventArgs e)
        {
            // Kembalikan gambar ke default saat kursor meninggalkan btnLogin
            btnEditUser.Image = defaultImage;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            // Memunculkan form ReAuthentication untuk autentikasi ulang
            ReAuthentication reAuthForm = new ReAuthentication(SessionManager.Username);

            // Tampilkan ReAuthentication sebagai dialog
            if (reAuthForm.ShowDialog() == DialogResult.OK && reAuthForm.IsAuthenticated)
            {
                // Jika autentikasi berhasil, panggil event ShowEditDataUser
                ShowEditDataUser?.Invoke();
            }
            else
            {
                MessageBox.Show("Autentikasi gagal atau dibatalkan.");
            }
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            // Memunculkan form ReAuthentication untuk autentikasi ulang
            ReAuthentication reAuthForm = new ReAuthentication(SessionManager.Username);

            // Tampilkan ReAuthentication sebagai dialog
            if (reAuthForm.ShowDialog() == DialogResult.OK && reAuthForm.IsAuthenticated)
            {
                // Jika autentikasi berhasil, panggil event ShowEditDataUnit
                ShowEditDataUnit?.Invoke();
            }
            else
            {
                MessageBox.Show("Autentikasi gagal atau dibatalkan.");
            }
        }

        private void BtnEditUser_MouseEnter(object sender, EventArgs e)
        {
            btnEditUser.Image = hoverImage;
        }

        private void BtnEditUser_MouseLeave(object sender, EventArgs e)
        {
            btnEditUser.Image = defaultImage;
        }

        private void BtnEditUnit_MouseEnter(object sender, EventArgs e)
        {
            btnEditUnit.Image = hoverImageUnit;
        }

        private void BtnEditUnit_MouseLeave(object sender, EventArgs e)
        {
            btnEditUnit.Image = defaultImageUnit;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadUserData(); // Memuat ulang data terbaru ketika tombol ditekan
        }
    }
}
