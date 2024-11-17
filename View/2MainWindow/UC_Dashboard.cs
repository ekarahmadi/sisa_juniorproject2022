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
        private TPSService tpsService;
        private AuthService authService;
        private ToolTip toolTipInfo;


        public UC_Dashboard()
        {
            InitializeComponent();

            // Tambahkan event handler untuk semua tombol
            btnTambahDataSampah.MouseEnter += btnTambahDataSampah_MouseEnter;
            btnTambahDataSampah.MouseLeave += btnTambahDataSampah_MouseLeave;

            btnBuatPermintaan.MouseEnter += btnBuatPermintaan_MouseEnter;
            btnBuatPermintaan.MouseLeave += btnBuatPermintaan_MouseLeave;

            btnHapusDataSampah.MouseEnter += btnHapusDataSampah_MouseEnter;
            btnHapusDataSampah.MouseLeave += btnHapusDataSampah_MouseLeave;

            btnUpdateStatus.MouseEnter += btnUpdateStatus_MouseEnter;
            btnUpdateStatus.MouseLeave += btnUpdateStatus_MouseLeave;

            btnBatalkanStatus.MouseEnter += btnBatalkanStatus_MouseEnter;
            btnBatalkanStatus.MouseLeave += btnBatalkanStatus_MouseLeave;

            tpsService = new TPSService();
            LoadDataToDataGridView();
            InitializeComboBox();

            cbKategori.DataSource = null; // Reset data source

            // Inisialisasi ToolTip
            toolTipInfo = new ToolTip
            {
                ToolTipTitle = "Informasi Unit",
                IsBalloon = true, // Membuat tampilan tooltip berbentuk balon
                AutoPopDelay = 5000, // Durasi tampilan tooltip (5 detik)
                InitialDelay = 500, // Waktu tunda sebelum tooltip muncul
                ReshowDelay = 200 // Waktu tunda sebelum tooltip muncul kembali
            };

            // Pasang ToolTip pada Button
            toolTipInfo.SetToolTip(btnInfo, GenerateUnitInfo());
        }

        private void ConfigureWasteDataGridView()
        {
            if (dgvDataSampah.Columns["status_sampah"] != null)
                dgvDataSampah.Columns["status_sampah"].Visible = false; // Sembunyikan kolom
        }


        private string GenerateUnitInfo()
        {
            // Pastikan data unit tersedia
            if (SessionManager.AllUnits == null || SessionManager.AllUnits.Count == 0)
            {
                return "Tidak ada data unit yang tersedia.";
            }

            // Bangun string informasi unit
            var infoBuilder = new System.Text.StringBuilder();
            foreach (var unit in SessionManager.AllUnits)
            {
                infoBuilder.AppendLine($"ID: {unit.UnitId}, Nama: {unit.NamaUnit}");
            }

            return infoBuilder.ToString();
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            // Perbarui isi tooltip saat kursor berada di atas button
            toolTipInfo.SetToolTip(btnInfo, GenerateUnitInfo());
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
            btnBuatPermintaan.Image = Properties.Resources.btnBuatPermintaan1; // Gambar normal
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

        private void LoadStatistics()
        {
            try
            {
                int unitId = int.Parse(SessionManager.UnitKerja); // Ambil unit_id dari akun yang login
                TPSService tpsService = new TPSService();

                // Query untuk lblBelumDiambil
                int belumDiambil = tpsService.CountWasteInventory(unitId, "belum_diambil");

                // Query untuk lblSudahDiambil
                int sudahDiambil = tpsService.CountWasteInventory(unitId, "sudah_diambil");

                // Query untuk lblTotalOrganik
                int totalOrganik = tpsService.CountWasteByCategory(unitId, "Organik", "belum_diambil");

                // Query untuk lblTotalAnorganik
                int totalAnorganik = tpsService.CountWasteByCategory(unitId, "Anorganik", "belum_diambil");

                // Query untuk lblTotalB3
                int totalB3 = tpsService.CountWasteByCategory(unitId, "B3", "belum_diambil");

                // Query untuk lblTotalHarian
                int totalHarian = tpsService.CountDailyWaste(unitId, DateTime.Now.Date);

                // Update label
                lblBelumDiambil.Text = belumDiambil.ToString();
                lblSudahDiambil.Text = sudahDiambil.ToString();
                lblTotalOrganik.Text = totalOrganik.ToString();
                lblTotalAnorganik.Text = totalAnorganik.ToString();
                lblTotalB3.Text = totalB3.ToString();
                lblTotalHarian.Text = (totalOrganik + totalAnorganik + totalB3).ToString();
                lblTotalHarian.Text = totalHarian.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat statistik: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            // Debugging: Log semua nilai SessionManager
            Console.WriteLine($"RoleId: {SessionManager.RoleId}");
            Console.WriteLine($"Username: {SessionManager.Username}");
            Console.WriteLine($"FullName: {SessionManager.FullName}");
            Console.WriteLine($"UnitKerja: {SessionManager.UnitKerja}");
        }

        private void AdjustDataGridViewColumns()
        {
            // Sesuaikan lebar kolom DataGridView Data Sampah TPS
            dgvDataSampah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Sesuaikan lebar kolom DataGridView Permintaan Penjemputan
            dgvPermintaan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigureDataGridViewColumns()
        {
            // Sembunyikan kolom yang tidak diperlukan pada dgvDataSampah
            if (dgvDataSampah.Columns["inventory_id"] != null)
                dgvDataSampah.Columns["inventory_id"].Visible = false;

            if (dgvDataSampah.Columns["unit_id"] != null)
                dgvDataSampah.Columns["unit_id"].Visible = false;

            // Sembunyikan kolom yang tidak diperlukan pada dgvPermintaan
            if (dgvPermintaan.Columns["request_id"] != null)
                dgvPermintaan.Columns["request_id"].Visible = false;

            if (dgvPermintaan.Columns["tps_id"] != null)
                dgvPermintaan.Columns["tps_id"].Visible = false;

            if (dgvPermintaan.Columns["tanggal_request"] != null)
                dgvPermintaan.Columns["tanggal_request"].Visible = false;

            if (dgvPermintaan.Columns["tanggal_jadwal"] != null)
                dgvPermintaan.Columns["tanggal_jadwal"].Visible = false;

            if (dgvPermintaan.Columns["tanggal_selesai"] != null)
                dgvPermintaan.Columns["tanggal_selesai"].Visible = false;

            if (dgvPermintaan.Columns["inventory_id"] != null)
                dgvPermintaan.Columns["inventory_id"].Visible = false;
        }


        private void LoadDataToDataGridView()
        {
            try
            {
                // Ambil username dari SessionManager
                string username = SessionManager.Username;

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Username tidak ditemukan di SessionManager. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ambil unit_id berdasarkan username
                AuthService authService = new AuthService();
                int unitId = authService.GetUnitIdByUsername(username);

                if (unitId == -1)
                {
                    MessageBox.Show("Unit ID tidak ditemukan untuk username: " + username, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Muat data sampah yang tersedia ke dgvDataSampah
                DataTable availableWaste = tpsService.GetAvailableWaste(unitId);
                dgvDataSampah.DataSource = availableWaste;

                // Muat data permintaan pickup ke dgvPermintaan
                DataTable pickupRequestData = tpsService.GetPickupRequestData(unitId);
                dgvPermintaan.DataSource = pickupRequestData;

                // Panggil fungsi konfigurasi lainnya
                AdjustDataGridViewColumns();
                ConfigureDataGridViewColumns();
                RenameColumns();
                LoadStatistics();
                UpdateUnitDetails(unitId);

                Console.WriteLine("Data berhasil dimuat ke DataGridView.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenameColumns()
        {
            if (dgvPermintaan.Columns["tpa_id"] != null)
            {
                dgvPermintaan.Columns["tpa_id"].HeaderText = "TPA Tujuan";
            }
        }

        private void UpdateUnitDetails(int unitId)
        {
            AuthService authService = new AuthService();
            UnitData unitData = authService.GetUnitDetailsById(unitId);

            if (unitData != null)
            {
                lblUnitID.Text = unitId.ToString();
                lblNamaUnit.Text = unitData.NamaUnit;
                lblTypeUnit.Text = unitData.TipeUnit;
            }
        }

        private void btnTambahDataSampah_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi ComboBox
                if (!ValidateComboBox())
                    return;

                // Validasi input berat
                if (!decimal.TryParse(tbBerat.Text, out decimal berat) || berat <= 0)
                {
                    MessageBox.Show("Masukkan berat sampah yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ambil unit_id dari SessionManager
                int unitId = int.Parse(SessionManager.UnitKerja);

                // Tambahkan data sampah ke database
                bool success = tpsService.AddWasteInventory(unitId, cbKategori.Text, berat);

                if (success)
                {
                    MessageBox.Show("Data sampah berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView
                    LoadDataToDataGridView();

                    // Reset form
                    cbKategori.SelectedIndex = 0; // Kembalikan ke default
                    tbBerat.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data sampah. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComboBox()
        {
            // Tambahkan item default ke ComboBox
            cbKategori.Items.Clear(); // Kosongkan daftar item
            cbKategori.Items.Add("Pilih Kategori");
            cbKategori.Items.Add("Organik");
            cbKategori.Items.Add("Anorganik");
            cbKategori.Items.Add("B3");

            // Set item default
            cbKategori.SelectedIndex = 0; // Pilih item pertama
        }

        // Validasi untuk memastikan user memilih kategori valid
        private bool ValidateComboBox()
        {
            if (cbKategori.SelectedIndex == 0) // Indeks 0 adalah "Pilih Kategori"
            {
                MessageBox.Show("Silakan pilih kategori sampah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnBuatPermintaan_Click(object sender, EventArgs e)
        {
            try
            {
                // Pastikan ada data sampah yang dipilih
                if (dgvDataSampah.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih data sampah terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ambil informasi dari baris yang dipilih
                DataGridViewRow selectedRow = dgvDataSampah.SelectedRows[0];
                int inventoryId = Convert.ToInt32(selectedRow.Cells["inventory_id"].Value);
                string kategori = selectedRow.Cells["kategori"].Value.ToString();
                decimal berat = Convert.ToDecimal(selectedRow.Cells["berat"].Value);
                int tpsId = int.Parse(SessionManager.UnitKerja);

                // Buka FormSelectTPA untuk memilih TPA
                using (FormSelectTPA formSelectTPA = new FormSelectTPA())
                {
                    if (formSelectTPA.ShowDialog() == DialogResult.OK)
                    {
                        int tpaId = formSelectTPA.SelectedTPAId;

                        // Buat permintaan penjemputan
                        bool success = tpsService.AddPickupRequest(tpsId, tpaId, kategori, berat, inventoryId);

                        if (success)
                        {
                            MessageBox.Show("Permintaan berhasil dibuat.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataToDataGridView(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Gagal membuat permintaan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                // Pastikan ada baris yang dipilih
                if (dgvPermintaan.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih permintaan yang ingin diperbarui.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ambil data baris yang dipilih
                DataGridViewRow selectedRow = dgvPermintaan.SelectedRows[0];
                string currentStatus = selectedRow.Cells["status"].Value.ToString();

                // Validasi status
                if (currentStatus != "Scheduled")
                {
                    MessageBox.Show("Hanya permintaan dengan status 'Scheduled' yang dapat diperbarui menjadi 'In Progress'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ambil request_id dari baris yang dipilih
                int requestId = Convert.ToInt32(selectedRow.Cells["request_id"].Value);

                // Panggil service untuk memperbarui status
                bool success = tpsService.UpdateRequestStatus(requestId, "In Progress");

                if (success)
                {
                    MessageBox.Show("Status berhasil diperbarui menjadi 'In Progress'.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToDataGridView(); // Refresh DataGridView
                    LoadStatistics();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui status. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatalkanStatus_Click(object sender, EventArgs e)
        {
            try
            {
                // Pastikan ada baris yang dipilih
                if (dgvPermintaan.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih permintaan yang ingin dibatalkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ambil data baris yang dipilih
                DataGridViewRow selectedRow = dgvPermintaan.SelectedRows[0];
                string currentStatus = selectedRow.Cells["status"].Value.ToString();

                // Validasi status
                if (currentStatus != "Pending")
                {
                    MessageBox.Show("Hanya permintaan dengan status 'Pending' yang dapat dibatalkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ambil request_id dari baris yang dipilih
                int requestId = Convert.ToInt32(selectedRow.Cells["request_id"].Value);

                // Panggil service untuk memperbarui status
                bool success = tpsService.UpdateRequestStatus(requestId, "Canceled");

                if (success)
                {
                    MessageBox.Show("Status berhasil diperbarui menjadi 'Canceled'.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToDataGridView(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Gagal membatalkan permintaan. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblNamaUnit_Click(object sender, EventArgs e)
        {

        }

        private bool CanDeleteWaste(int inventoryId)
        {
            // Periksa apakah inventory_id sudah dirujuk oleh tabel pickupprequest
            bool isReferenced = tpsService.IsWasteReferencedInRequest(inventoryId);

            if (isReferenced)
            {
                MessageBox.Show("Data sampah tidak dapat dihapus karena sudah masuk ke dalam permintaan penjemputan.",
                                "Peringatan",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btnHapusDataSampah_Click(object sender, EventArgs e)
        {
            try
            {
                // Dapatkan inventory_id dari DataGridView
                if (dgvDataSampah.SelectedRows.Count > 0)
                {
                    int inventoryId = Convert.ToInt32(dgvDataSampah.SelectedRows[0].Cells["inventory_id"].Value);

                    // Periksa apakah sampah bisa dihapus
                    if (!CanDeleteWaste(inventoryId))
                        return;

                    // Lakukan penghapusan data
                    bool success = tpsService.DeleteWasteInventory(inventoryId);

                    if (success)
                    {
                        MessageBox.Show("Data sampah berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data sampah. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Pilih data sampah yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
