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

namespace SISA.View._4TPAWindow
{
    public partial class UC_Riwayat : UserControl
    {
        private TPSService tpsService;
        private AuthService authService;
        private UnitData unitData;
        private int unitId; // ID unit pengguna yang login
        private string unitType; // Tipe unit (TPS atau TPA)

        public UC_Riwayat()
        {
            InitializeComponent();
            tpsService = new TPSService();

            InitializeComboBox();
            // Atur properti default DataGridView
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void LoadUserDetails()
        {
            string username = SessionManager.Username; // Ambil username dari sesi
            AuthService authService = new AuthService();

            // Ambil unitId berdasarkan username
            int unitId = authService.GetUnitIdByUsername(username);

            if (unitId != -1)
            {
                // Ambil detail unit
                UnitData unitData = authService.GetUnitDetailsById(unitId);

                lblUnitID.Text = unitId.ToString();
                lblNamaUnit.Text = unitData.NamaUnit;
                lblTypeUnit.Text = unitData.TipeUnit;
            }
            else
            {
                MessageBox.Show("Unit ID tidak ditemukan untuk user: " + username, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComboBox()
        {
            comboBoxRiwayat.Items.Add("Pilih Riwayat");
            comboBoxRiwayat.Items.Add("Riwayat Layanan Penjemputan");
            comboBoxRiwayat.Items.Add("Riwayat Data Masuk");
            comboBoxRiwayat.SelectedIndex = 0; // Default

            comboBoxRiwayat.SelectedIndexChanged += CmbRiwayat_SelectedIndexChanged;
        }

        private void CmbRiwayat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dapatkan unitId dan unitType langsung melalui LoadUserDetails
            string username = SessionManager.Username;
            AuthService authService = new AuthService();
            int unitId = authService.GetUnitIdByUsername(username);
            UnitData unitData = authService.GetUnitDetailsById(unitId);

            if (comboBoxRiwayat.SelectedIndex == 1) // Riwayat Layanan Penjemputan
            {
                LoadPickupHistory(unitId, unitData.TipeUnit);
            }
            else if (comboBoxRiwayat.SelectedIndex == 2) // Riwayat Data Masuk
            {
                LoadWasteEntryHistory(unitId);
            }
            else
            {
                dgvRiwayat.DataSource = null; // Kosongkan DataGridView
            }
        }

        private void LoadPickupHistory(int unitId, string unitType)
        {
            if (unitType == "TPS")
            {
                DataTable pickupHistory = tpsService.GetPickupRequestsByTPS(unitId);
                if (pickupHistory.Rows.Count > 0)
                {
                    dgvRiwayat.DataSource = pickupHistory;
                    dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Atur lebar kolom dinamis
                }
                else
                {
                    MessageBox.Show("Tidak ada riwayat layanan penjemputan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (unitType == "TPA")
            {
                DataTable pickupHistory = tpsService.GetPickupRequestsByTPA(unitId);
                if (pickupHistory.Rows.Count > 0)
                {
                    dgvRiwayat.DataSource = pickupHistory;
                    dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Atur lebar kolom dinamis
                }
                else
                {
                    MessageBox.Show("Tidak ada riwayat layanan penjemputan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tipe unit tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadWasteEntryHistory(int unitId)
        {
            DataTable wasteEntryHistory = tpsService.GetWasteEntriesByUnit(unitId);
            if (wasteEntryHistory.Rows.Count > 0)
            {
                dgvRiwayat.DataSource = wasteEntryHistory;
                dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Atur lebar kolom dinamis
            }
            else
            {
                MessageBox.Show("Tidak ada riwayat data masuk.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
