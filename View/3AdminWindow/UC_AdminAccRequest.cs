using Npgsql;
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

namespace SISA.View._3AdminWindow
{
    public partial class UC_AdminAccRequest : UserControl
    {
        private AuthService authService;

        // Default and hover images for each button
        private Image terimaDefault;
        private Image terimaHover;
        private Image tolakDefault;
        private Image tolakHover;
        private Image editDefault;
        private Image editHover;

        public UC_AdminAccRequest()
        {
            InitializeComponent();
            InitializeButtonHoverEffects();

            authService = new AuthService();
            LoadDataGrids();
            LoadCalonUserData();
            LoadUserData();
            ConfigureDataGrids();
            LoadUnitData();

            // Membuat TextBox Role hanya untuk tampilan (tidak dapat diisi)
            tbRole.ReadOnly = true;

            // Sembunyikan btnHapusSeleksi pada awal
            btnHapusSeleksi.Visible = false;

            // Tambahkan event untuk memantau perubahan seleksi pada DataGridView
            dgvTerdaftar.SelectionChanged += DataGrid_SelectionChanged;
            dgvCalonUser.SelectionChanged += DataGrid_SelectionChanged;
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            // Tampilkan btnHapusSeleksi jika ada baris yang dipilih pada salah satu DataGridView
            btnHapusSeleksi.Visible = dgvCalonUser.SelectedRows.Count > 0 || dgvTerdaftar.SelectedRows.Count > 0;
        }

        private void LoadDataGrids()
        {
            // Load data into dgvCalonUser
            dgvCalonUser.DataSource = authService.GetCalonUsers();

            // Load data into dgvTerdaftar
            dgvTerdaftar.DataSource = authService.GetApprovedUsers();
        }

        private void LoadCalonUserData()
        {
            DataTable calonUserTable = authService.GetCalonUsers();
            dgvCalonUser.DataSource = calonUserTable;
        }

        private void LoadUserData()
        {
            DataTable userTable = authService.GetApprovedUsers();
            dgvTerdaftar.DataSource = userTable;
        }

        private void ConfigureDataGrids()
        {
            // Konfigurasi pengaturan untuk dgvCalonUser
            dgvCalonUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCalonUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Set AutoSizeMode untuk kolom tertentu di dgvCalonUser
            dgvCalonUser.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCalonUser.Columns["username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCalonUser.Columns["unit_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCalonUser.Columns["role_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Konfigurasi pengaturan untuk dgvTerdaftar
            dgvTerdaftar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTerdaftar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Set AutoSizeMode untuk kolom tertentu di dgvTerdaftar
            dgvTerdaftar.Columns["user_id"].Visible = false;
            dgvTerdaftar.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTerdaftar.Columns["username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTerdaftar.Columns["unit_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTerdaftar.Columns["role_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private string ConvertRoleIdToText(int roleId)
        {
            return roleId switch
            {
                1 => "AdminTPS",
                2 => "AdminTPA",
                3 => "AdminApp",
                _ => "Unknown Role"
            };
        }

        private int ConvertRoleTextToId(string roleText)
        {
            return roleText switch
            {
                "AdminTPS" => 1,
                "AdminTPA" => 2,
                "AdminApp" => 3,
                _ => 0
            };
        }

        private void dgvCalonUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCalonUser.Rows[e.RowIndex];
                tbNama.Text = row.Cells["name"].Value.ToString();
                tbUsername.Text = row.Cells["username"].Value.ToString();

                int unitId = Convert.ToInt32(row.Cells["unit_id"].Value);
                tbUnitKerja.Text = authService.GetUnitNameById(unitId);

                int roleId = Convert.ToInt32(row.Cells["role_id"].Value);
                tbRole.Text = ConvertRoleIdToText(roleId);

                tbWaktu.Text = row.Cells["date_registered"].Value.ToString();
            }
        }

        private void dgvTerdaftar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTerdaftar.Rows[e.RowIndex];
                tbNama.Text = row.Cells["nama"].Value.ToString();
                tbUsername.Text = row.Cells["username"].Value.ToString();

                int unitId = Convert.ToInt32(row.Cells["unit_id"].Value);
                tbUnitKerja.Text = authService.GetUnitNameById(unitId);

                int roleId = Convert.ToInt32(row.Cells["role_id"].Value);
                tbRole.Text = ConvertRoleIdToText(roleId);

                tbWaktu.Text = row.Cells["created_at"].Value.ToString();
            }
        }

        private void InitializeButtonHoverEffects()
        {
            terimaDefault = Properties.Resources.btnTerima;
            terimaHover = Properties.Resources.btnTerimaHover;
            tolakDefault = Properties.Resources.btnTolak1;
            tolakHover = Properties.Resources.btnTolakHover1;
            editDefault = Properties.Resources.btnEditData;
            editHover = Properties.Resources.btnEditDataHover;
            Image HapusSeleksiDefault = Properties.Resources.btnHapusDataTerseleksi;
            Image HapusSeleksiHover = Properties.Resources.btnHapusDataTerseleksiHover;
            Image HapusDataDefault = Properties.Resources.btnHapusDataUser1;
            Image HapusDataHover = Properties.Resources.btnHapusDataUserHover1;

            btnTerima.Image = terimaDefault;
            btnTolak.Image = tolakDefault;
            btnEdit.Image = editDefault;
            btnHapusSeleksi.Image = HapusSeleksiDefault;

            btnTerima.MouseEnter += (s, e) => btnTerima.Image = terimaHover;
            btnTerima.MouseLeave += (s, e) => btnTerima.Image = terimaDefault;

            btnTolak.MouseEnter += (s, e) => btnTolak.Image = tolakHover;
            btnTolak.MouseLeave += (s, e) => btnTolak.Image = tolakDefault;

            btnEdit.MouseEnter += (s, e) => btnEdit.Image = editHover;
            btnEdit.MouseLeave += (s, e) => btnEdit.Image = editDefault;

            // Add hover events for btnHapusSeleksi
            btnHapusSeleksi.MouseEnter += (s, e) => btnHapusSeleksi.Image = HapusSeleksiHover;
            btnHapusSeleksi.MouseLeave += (s, e) => btnHapusSeleksi.Image = HapusSeleksiDefault;

            // Add hover events for btnHapusSeleksi
            btnHapusUser.MouseEnter += (s, e) => btnHapusUser.Image = HapusDataHover;
            btnHapusUser.MouseLeave += (s, e) => btnHapusUser.Image = HapusDataDefault;
        }

        private void btnTerima_Click(object sender, EventArgs e)
        {
            if (dgvCalonUser.SelectedRows.Count > 0)
            {
                var row = dgvCalonUser.SelectedRows[0];
                int calonUserId = Convert.ToInt32(row.Cells["calonuser_id"].Value);
                string name = row.Cells["name"].Value.ToString();
                string username = row.Cells["username"].Value.ToString();
                string password = row.Cells["password"].Value.ToString();
                int unitId = Convert.ToInt32(row.Cells["unit_id"].Value);

                AuthService authService = new AuthService();

                // Tentukan role berdasarkan unit_type
                string unitType = authService.GetUnitTypeByUnitId(unitId);
                int roleId;

                if (unitType == "TPS")
                {
                    roleId = 1; // Role TPS
                }
                else if (unitType == "TPA")
                {
                    roleId = 2; // Role TPA
                }
                else
                {
                    MessageBox.Show("Unit type tidak valid untuk unit_id: " + unitId, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Batalkan proses
                }

                // Proses penerimaan pengguna
                bool isApproved = authService.ApproveUser(calonUserId, name, username, password, roleId, unitId);

                if (isApproved)
                {
                    MessageBox.Show("Pengguna diterima dan dipindahkan ke tabel users.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCalonUserData();
                    LoadUserData();
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan saat menerima pengguna.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih pengguna yang ingin diterima.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int DetermineRoleId(int unitId)
        {
            // Gunakan logika validasi yang lebih lengkap
            if (unitId == 1)
                return 1; // TPS
            else if (unitId == 2)
                return 2; // TPA
            else
                throw new ArgumentException("Unit ID tidak valid untuk menentukan role.");
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
            if (dgvCalonUser.SelectedRows.Count > 0)
            {
                var row = dgvCalonUser.SelectedRows[0];
                int calonUserId = Convert.ToInt32(row.Cells["calonuser_id"].Value);

                bool isDeleted = authService.DeleteCalonUser(calonUserId);

                if (isDeleted)
                {
                    MessageBox.Show("Pengguna ditolak dan dihapus dari daftar calon user.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCalonUserData();
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan saat menolak pengguna.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih pengguna yang ingin ditolak.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTerdaftar.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvTerdaftar.SelectedRows[0].Cells["user_id"].Value);

                string name = tbNama.Text;
                string username = tbUsername.Text;
                int roleId = ConvertRoleTextToId(tbRole.Text);
                int unitId = authService.GetUnitIdByName(tbUnitKerja.Text);

                authService.UpdateUser(userId, name, username, roleId, unitId);

                MessageBox.Show("Data pengguna berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserData();
            }
            else
            {
                MessageBox.Show("Pilih pengguna yang ingin diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadUnitData()
        {
            // Ambil data unit dari AuthService
            DataTable unitsData = authService.GetUnitData();

            // Atur data source, display member, dan value member
            tbUnitKerja.DataSource = unitsData;
            tbUnitKerja.DisplayMember = "unit_name";  // Nama kolom yang ingin ditampilkan
            tbUnitKerja.ValueMember = "unit_id";      // Nama kolom yang digunakan sebagai nilai

            // Mengatur agar tidak ada item yang terpilih pada tampilan awal
            tbUnitKerja.SelectedIndex = -1;  // Menampilkan ComboBox kosong
        }

        private void btnHapusSeleksi_Click(object sender, EventArgs e)
        {
            // Kosongkan semua TextBox dan ComboBox
            tbNama.Clear();
            tbUsername.Clear();
            tbRole.Clear();
            tbUnitKerja.SelectedIndex = -1;
            tbWaktu.Clear();

            // Hapus seleksi pada kedua DataGridView
            dgvTerdaftar.ClearSelection();
            dgvCalonUser.ClearSelection();

            // Sembunyikan tombol Hapus Seleksi setelah semua seleksi dihilangkan
            btnHapusSeleksi.Visible = false;
        }

        private void btnHapusUser_Click(object sender, EventArgs e)
        {
            if (dgvTerdaftar.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvTerdaftar.SelectedRows[0].Cells["user_id"].Value);

                DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus pengguna ini?",
                                                            "Konfirmasi Hapus",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    bool isDeleted = authService.DeleteUser(userId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Pengguna berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUserData(); // Memuat ulang data setelah penghapusan
                    }
                    else
                    {
                        MessageBox.Show("Terjadi kesalahan saat menghapus pengguna.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih pengguna yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
