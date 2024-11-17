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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SISA.View._4TPAWindow
{
    public partial class UC_DashboardTPA : UserControl
    {
        private Image btnTerimaDefault;
        private Image btnTerimaHover;
        private Image btnTolakDefault;
        private Image btnTolakHover;
        private Image btnSelesaikanDefault;
        private Image btnSelesaikanHover;
        private Image btnBatalkanDefault;
        private Image btnBatalkanHover;
        private Image btnSudahDiolahDefault;
        private Image btnSudahDiolahHover;
        private TPSService tpsService;

        public UC_DashboardTPA()
        {
            InitializeComponent();
            tpsService = new TPSService();

            // Inisialisasi gambar untuk tombol
            btnTerimaDefault = Properties.Resources.btnTerimaPermintaan; // Nama file gambar default
            btnTerimaHover = Properties.Resources.btnTerimaPermintaanHover; // Nama file gambar hover

            btnTolakDefault = Properties.Resources.btnTolakPermintaan;
            btnTolakHover = Properties.Resources.btnTolakPermintaanHover;

            btnSelesaikanDefault = Properties.Resources.btnSelesaikanPermintaan;
            btnSelesaikanHover = Properties.Resources.btnSelesaikanPermintaanHover;

            btnBatalkanDefault = Properties.Resources.btnBatalkanPenjemputan;
            btnBatalkanHover = Properties.Resources.btnBatalkanPenjemputanHover;

            btnSudahDiolahDefault = Properties.Resources.btnSudahDiolah;
            btnSudahDiolahHover = Properties.Resources.btnSudahDiolahHover;

            // Tambahkan event hover untuk setiap tombol
            AddButtonHoverEffects();

            // Load data untuk setiap DataGridView
            LoadPendingRequests();
            LoadInProgressRequests();
            LoadCompletedRequests();

            // Ambil unit ID dari SessionManager dan perbarui label
            // Ambil unit_id berdasarkan username

            // Ambil username dari SessionManager
            string username = SessionManager.Username; AuthService authService = new AuthService();

            int unitId = authService.GetUnitIdByUsername(username);

            if (unitId == -1)
            {
                MessageBox.Show("Unit ID tidak ditemukan untuk username: " + username, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdateUnitDetails(unitId);
        }

        private void AddButtonHoverEffects()
        {
            // Event hover untuk btnTerimaPermintaan
            btnTerimaPermintaan.MouseEnter += (s, e) => btnTerimaPermintaan.Image = btnTerimaHover;
            btnTerimaPermintaan.MouseLeave += (s, e) => btnTerimaPermintaan.Image = btnTerimaDefault;

            // Event hover untuk btnTolakPermintaan
            btnTolakPermintaan.MouseEnter += (s, e) => btnTolakPermintaan.Image = btnTolakHover;
            btnTolakPermintaan.MouseLeave += (s, e) => btnTolakPermintaan.Image = btnTolakDefault;

            // Event hover untuk btnSelesaikanPermintaan
            btnSelesaikanPermintaan.MouseEnter += (s, e) => btnSelesaikanPermintaan.Image = btnSelesaikanHover;
            btnSelesaikanPermintaan.MouseLeave += (s, e) => btnSelesaikanPermintaan.Image = btnSelesaikanDefault;

            // Event hover untuk btnBatalkanPenjemputan
            btnBatalkanPenjemputan.MouseEnter += (s, e) => btnBatalkanPenjemputan.Image = btnBatalkanHover;
            btnBatalkanPenjemputan.MouseLeave += (s, e) => btnBatalkanPenjemputan.Image = btnBatalkanDefault;

            // Event hover untuk btnSudahDiolah
            btnSudahDiolah.MouseEnter += (s, e) => btnSudahDiolah.Image = btnSudahDiolahHover;
            btnSudahDiolah.MouseLeave += (s, e) => btnSudahDiolah.Image = btnSudahDiolahDefault;
        }

        private void LoadPendingRequests()
        {
            int unitId = int.Parse(SessionManager.UnitKerja);
            DataTable pendingRequests = tpsService.GetPendingRequests(unitId);
            dgvPermintaan.DataSource = pendingRequests;
        }

        private void LoadInProgressRequests()
        {
            int unitId = int.Parse(SessionManager.UnitKerja);
            DataTable inProgressRequests = tpsService.GetInProgressRequests(unitId);
            dgvPenjemputan.DataSource = inProgressRequests;
        }

        private void LoadCompletedRequests()
        {
            int unitId = int.Parse(SessionManager.UnitKerja);
            DataTable completedRequests = tpsService.GetCompletedRequests(unitId);
            dgvDataMasuk.DataSource = completedRequests;
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

        private void btnTerimaPermintaan_Click(object sender, EventArgs e)
        {
            if (dgvPermintaan.SelectedRows.Count > 0)
            {
                int requestId = Convert.ToInt32(dgvPermintaan.SelectedRows[0].Cells["request_id"].Value);

                bool success = tpsService.UpdateRequestStatus(requestId, "Scheduled");
                if (success)
                {
                    MessageBox.Show("Permintaan telah diterima.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPendingRequests();
                    LoadInProgressRequests();
                }
                else
                {
                    MessageBox.Show("Gagal menerima permintaan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih permintaan yang ingin diterima.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTolakPermintaan_Click(object sender, EventArgs e)
        {
            if (dgvPermintaan.SelectedRows.Count > 0)
            {
                int requestId = Convert.ToInt32(dgvPermintaan.SelectedRows[0].Cells["request_id"].Value);

                bool success = tpsService.UpdateRequestStatus(requestId, "Canceled");
                if (success)
                {
                    MessageBox.Show("Permintaan telah ditolak.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPendingRequests();
                }
                else
                {
                    MessageBox.Show("Gagal menolak permintaan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih permintaan yang ingin ditolak.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSelesaikanPermintaan_Click(object sender, EventArgs e)
        {
            if (dgvPenjemputan.SelectedRows.Count > 0)
            {
                int requestId = Convert.ToInt32(dgvPenjemputan.SelectedRows[0].Cells["request_id"].Value);
                string kategori = dgvPenjemputan.SelectedRows[0].Cells["kategori"].Value.ToString();
                decimal berat = Convert.ToDecimal(dgvPenjemputan.SelectedRows[0].Cells["berat"].Value);

                bool success = tpsService.UpdateRequestStatus(requestId, "Completed");
                if (success)
                {
                    // Tambahkan data ke WasteInventory
                    int unitId = int.Parse(SessionManager.UnitKerja);
                    bool inventorySuccess = tpsService.AddWasteInventory(unitId, kategori, berat);

                    if (inventorySuccess)
                    {
                        MessageBox.Show("Permintaan telah diselesaikan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInProgressRequests();
                        LoadCompletedRequests();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan data ke WasteInventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Gagal menyelesaikan permintaan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih permintaan yang ingin diselesaikan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBatalkanPenjemputan_Click(object sender, EventArgs e)
        {
            if (dgvPenjemputan.SelectedRows.Count > 0)
            {
                int requestId = Convert.ToInt32(dgvPenjemputan.SelectedRows[0].Cells["request_id"].Value);

                bool success = tpsService.UpdateRequestStatus(requestId, "Canceled");
                if (success)
                {
                    MessageBox.Show("Penjemputan telah dibatalkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInProgressRequests();
                }
                else
                {
                    MessageBox.Show("Gagal membatalkan penjemputan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih penjemputan yang ingin dibatalkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadDgvPenjemputan()
        {
            int tpaId = Convert.ToInt32(SessionManager.UnitKerja);
            DataTable activeRequests = tpsService.GetActiveRequests(tpaId);
            dgvPenjemputan.DataSource = activeRequests;
        }

        private void LoadDgvDataMasuk()
        {
            int tpaId = Convert.ToInt32(SessionManager.UnitKerja);
            DataTable completedRequests = tpsService.GetCompletedRequests(tpaId);
            dgvDataMasuk.DataSource = completedRequests;
        }

        private void btnSudahDiolah_Click(object sender, EventArgs e)
        {
            try
            {
                // Pastikan baris dipilih di DataGridView
                if (dgvDataMasuk.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih permintaan yang ingin diselesaikan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Ambil request_id dari baris yang dipilih
                int requestId = Convert.ToInt32(dgvDataMasuk.SelectedRows[0].Cells["request_id"].Value);
                int tpaId = Convert.ToInt32(SessionManager.UnitKerja);

                // Update status ke Completed
                bool isCompleted = tpsService.UpdateRequestStatus(requestId, "Completed");

                if (isCompleted)
                {
                    // Pindahkan data ke wasteinventory
                    bool isAddedToInventory = tpsService.AddCompletedWasteToInventory(requestId, tpaId);

                    if (isAddedToInventory)
                    {
                        MessageBox.Show("Permintaan berhasil diselesaikan dan data sampah ditambahkan ke inventory.",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh DataGridView
                        LoadDgvPenjemputan(); // Memuat ulang data penjemputan
                        LoadDgvDataMasuk();  // Memuat ulang data inventory
                    }
                    else
                    {
                        MessageBox.Show("Permintaan berhasil diselesaikan, tetapi data sampah gagal dipindahkan ke inventory.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Gagal menyelesaikan permintaan. Silakan coba lagi.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
