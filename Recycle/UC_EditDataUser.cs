using Microsoft.VisualBasic.ApplicationServices;
using SISA.Model;
using SISA.View._2MainWindow;
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
    public partial class UC_EditDataUser : UserControl
    {

        private Image kembaliDefaultImage;
        private Image kembaliHoverImage;
        private Image simpanDefaultImage;
        private Image simpanHoverImage;
        private UC_Account ucAccount;

        private AuthService authService;
        private UserData? userData;
        private int? userId;
        private MainWindow mainWindow;

        // Event untuk tombol Kembali
        public event EventHandler BackButtonClicked;

        // Event untuk indikasi edit data berhasil
        public event Action DataEditSuccessful;
        public UserData CurrentUserData { get; set; }

        private string originalUsername; // Untuk menyimpan username asli

        public UC_EditDataUser()
        {
            InitializeComponent();
            authService = new AuthService(); // Inisialisasi authService
            CurrentUserData = userData;
            ucAccount = new UC_Account();

            LoadUserData(); // Panggil fungsi untuk memuat data pengguna
            LoadUnitData(); // Memuat data unit kerja dari database
            mainWindow = mainWindow;

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

        // Konstruktor yang menerima referensi MainWindow
        public UC_EditDataUser(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Pastikan mainWindow tidak null sebelum memanggil method
            if (mainWindow != null)
            {
                mainWindow.ShowAccountControl();
            }
            else
            {
                MessageBox.Show("MainWindow reference is null.");
            }
        }

        private void LoadUserData()
        {
            // Ambil username dari SessionManager
            string currentUsername = SessionManager.Username;

            if (!string.IsNullOrEmpty(currentUsername))
            {
                AuthService authService = new AuthService();
                UserData currentUserData = authService.GetUserDataByUsername(currentUsername);

                if (currentUserData != null)
                {
                    // Isi field dengan data pengguna
                    tbNamaPengguna.Text = currentUserData.Nama;
                    tbUsername.Text = currentUserData.Username;
                    tbPassword.Text = currentUserData.Password;
                    cbUnit.SelectedValue = currentUserData.UnitKerja; // Jika cbUnit menggunakan unit_id sebagai ValueMember
                    userId = (int?)currentUserData.UserId;

                    // Simpan username asli
                    originalUsername = currentUserData.Username;
                }
                else
                {
                    MessageBox.Show("Data pengguna tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username tidak ditemukan di sesi. Silakan login kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUnitData()
        {
            // Pastikan AuthService memiliki metode untuk mengambil data unit kerja
            DataTable unitsData = authService.GetUnitData();

            cbUnit.DataSource = unitsData;
            cbUnit.DisplayMember = "unit_name";  // Nama kolom yang ingin ditampilkan
            cbUnit.ValueMember = "unit_id";      // Nama kolom yang digunakan sebagai nilai
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = tbNamaPengguna.Text;
            string unitId = cbUnit.SelectedValue.ToString();
            string password = tbPassword.Text;
            string username = tbUsername.Text;

            // Cek apakah username berubah
            if (username != originalUsername)
            {
                // Validasi apakah username sudah digunakan oleh pengguna lain
                if (!authService.IsUsernameUniqueForUpdate(username, this.userId.Value))
                {
                    MessageBox.Show("Username sudah digunakan oleh pengguna lain. Silakan pilih username yang berbeda.");
                    return; // Keluarkan dari fungsi jika username tidak valid
                }
            }

            // Update data pengguna di database
            bool isUpdated = authService.UpdateUserData(this.userId, nama, unitId, password, username);

            if (isUpdated)
            {

                // Perbarui data di SessionManager dengan informasi terbaru
                SessionManager.Username = username;

                // Memastikan event dipanggil
                LoadUserData();
                DataEditSuccessful?.Invoke();
                Console.WriteLine("Event DataEditSuccessful dipanggil.");

                MessageBox.Show("Data berhasil diperbarui.");
            }
            else
            {
                MessageBox.Show("Terjadi kesalahan saat memperbarui data.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbNamaPengguna_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
