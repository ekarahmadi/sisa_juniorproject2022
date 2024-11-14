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
using System.Xml.Linq;

namespace SISA.View._1Starting
{
    public partial class UC_Signup : UserControl
    {
        // Gambar default dan hover untuk btnKembali dan btnDaftar
        private Image btnKembaliDefault;
        private Image btnKembaliHover;
        private Image btnDaftarDefault;
        private Image btnDaftarHover;

        private AuthService authService;

        public event EventHandler BackButtonClicked;

        public UC_Signup()
        {
            InitializeComponent();
            authService = new AuthService();

            // Inisialisasi gambar untuk btnKembali
            btnKembaliDefault = Properties.Resources.btnKembali; // Ganti dengan nama gambar default di Resources
            btnKembaliHover = Properties.Resources.btnKembaliHover;     // Ganti dengan nama gambar hover di Resources

            // Inisialisasi gambar untuk btnDaftar
            btnDaftarDefault = Properties.Resources.btnDaftar;   // Ganti dengan nama gambar default di Resources
            btnDaftarHover = Properties.Resources.btnDaftarClick;       // Ganti dengan nama gambar hover di Resources

            // Set gambar awal pada btnKembali dan btnDaftar
            btnKembali.Image = btnKembaliDefault;
            btnDaftar.Image = btnDaftarDefault;

            // Tambahkan event MouseEnter dan MouseLeave untuk btnKembali
            btnKembali.MouseEnter += BtnKembali_MouseEnter;
            btnKembali.MouseLeave += BtnKembali_MouseLeave;

            // Tambahkan event MouseEnter dan MouseLeave untuk btnDaftar
            btnDaftar.MouseEnter += BtnDaftar_MouseEnter;
            btnDaftar.MouseLeave += BtnDaftar_MouseLeave;
        }

        public void LoadUnitData(DataTable unitsData)
        {
            cbUnit.DisplayMember = "unit_name";
            cbUnit.ValueMember = "unit_id";
            cbUnit.DataSource = unitsData;
        }

        private void BtnKembali_MouseEnter(object sender, EventArgs e)
        {
            // Ubah gambar ke hover saat kursor berada di atas btnKembali
            btnKembali.Image = btnKembaliHover;
        }

        private void BtnKembali_MouseLeave(object sender, EventArgs e)
        {
            // Kembalikan gambar ke default saat kursor meninggalkan btnKembali
            btnKembali.Image = btnKembaliDefault;
        }

        private void BtnDaftar_MouseEnter(object sender, EventArgs e)
        {
            // Ubah gambar ke hover saat kursor berada di atas btnDaftar
            btnDaftar.Image = btnDaftarHover;
        }

        private void BtnDaftar_MouseLeave(object sender, EventArgs e)
        {
            // Kembalikan gambar ke default saat kursor meninggalkan btnDaftar
            btnDaftar.Image = btnDaftarDefault;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Memicu event untuk menginformasikan form utama
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
                string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) ||
                cbUnit.SelectedItem == null ||
                !cbKetentuan.Checked)
            {
                MessageBox.Show("Semua kolom harus diisi dan persetujuan harus dicentang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil data dari form
            string name = tbNama.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text; // Disarankan untuk hashing di AuthService
            int unitId = (int)cbUnit.SelectedValue;

            // Periksa apakah username unik
            if (!authService.IsUsernameUnique(username))
            {
                MessageBox.Show("Username sudah digunakan. Silakan pilih username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simpan data ke tabel Calonuser
            bool isRegistered = authService.RegisterUser(name, username, password, unitId);

            // Beri notifikasi kepada user berdasarkan hasil pendaftaran
            if (isRegistered)
            {
                MessageBox.Show("Pendaftaran berhasil. Menunggu persetujuan admin.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); // Reset form setelah pendaftaran sukses
            }
            else
            {
                MessageBox.Show("Pendaftaran gagal. Silakan coba lagi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metode untuk mereset form setelah pendaftaran
        private void ClearForm()
        {
            tbNama.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            cbUnit.SelectedIndex = -1;
            cbKetentuan.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
