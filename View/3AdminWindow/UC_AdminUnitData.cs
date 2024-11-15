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
    public partial class UC_AdminUnitData : UserControl
    {

        private AuthService authService = new AuthService();
        private bool isEditing = false;

        public UC_AdminUnitData()
        {
            InitializeComponent();
            LoadAllUnitData();
            dgvUnit.SelectionChanged += dgvUnit_SelectionChanged;
            InitializeButtonHoverEffects();
            ClearTextBoxes();

            // Isi ComboBox tipe unit
            cbTipe.Items.Clear();
            cbTipe.Items.Add("TPS");
            cbTipe.Items.Add("TPA");
            cbTipe.DropDownStyle = ComboBoxStyle.DropDownList;

            // Sembunyikan btnHapusSeleksi pada awal
            btnHapusSeleksi.Visible = false;
        }

        private void InitializeButtonHoverEffects()
        {
            // Load images from resources
            Image editDefault = Properties.Resources.btnEditDataUnit;
            Image editHover = Properties.Resources.btnEditDataUnitHover;
            Image hapusDefault = Properties.Resources.btnHapusUnit;
            Image hapusHover = Properties.Resources.btnHapusUnitHover;
            Image tambahDefault = Properties.Resources.btnTambahUnit1;
            Image tambahHover = Properties.Resources.btnTambahUnitHover;
            Image HapusSeleksiDefault = Properties.Resources.btnHapusDataTerseleksi;
            Image HapusSeleksiHover = Properties.Resources.btnHapusDataTerseleksiHover;

            // Set default images for buttons
            btnEditUnit.Image = editDefault;
            btnHapusUnit.Image = hapusDefault;
            btnTambahUnit.Image = tambahDefault;
            btnHapusSeleksi.Image = HapusSeleksiDefault;

            // Add hover events for btnEditUnit
            btnEditUnit.MouseEnter += (s, e) => btnEditUnit.Image = editHover;
            btnEditUnit.MouseLeave += (s, e) => btnEditUnit.Image = editDefault;

            // Add hover events for btnHapusUnit
            btnHapusUnit.MouseEnter += (s, e) => btnHapusUnit.Image = hapusHover;
            btnHapusUnit.MouseLeave += (s, e) => btnHapusUnit.Image = hapusDefault;

            // Add hover events for btnTambahUnit
            btnTambahUnit.MouseEnter += (s, e) => btnTambahUnit.Image = tambahHover;
            btnTambahUnit.MouseLeave += (s, e) => btnTambahUnit.Image = tambahDefault;

            // Add hover events for btnHapusSeleksi
            btnHapusSeleksi.MouseEnter += (s, e) => btnHapusSeleksi.Image = HapusSeleksiHover;
            btnHapusSeleksi.MouseLeave += (s, e) => btnHapusSeleksi.Image = HapusSeleksiDefault;
        }

        private void AdminUnitDataForm_Load(object sender, EventArgs e)
        {
            // Isi ComboBox tipe unit
            cbTipe.Items.Clear();
            cbTipe.Items.Add("TPS");
            cbTipe.Items.Add("TPA");
            cbTipe.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadAllUnitData(); // Memuat data unit ke DataGridView
        }

        private void dgvUnit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUnit.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUnit.SelectedRows[0];
                tbNama.Text = selectedRow.Cells["NamaUnit"].Value?.ToString() ?? "";
                cbTipe.Text = selectedRow.Cells["TipeUnit"].Value?.ToString() ?? "";
                tbLokasi.Text = selectedRow.Cells["LokasiUnit"].Value?.ToString() ?? "";
                tbKapasitas.Text = selectedRow.Cells["KapasitasUnit"].Value?.ToString() ?? "";

                isEditing = true;
                btnHapusSeleksi.Visible = true; // Tampilkan tombol Hapus Seleksi saat ada data yang dipilih
            }
            else
            {
                // Jika tidak ada baris yang dipilih, sembunyikan tombol dan reset kontrol
                ClearTextBoxes();
                btnHapusSeleksi.Visible = false; // Sembunyikan tombol Hapus Seleksi
                isEditing = false; // Setel ke mode tambah
            }
        }

        private void btnHapusSeleksi_Click(object sender, EventArgs e)
        {
            // Bersihkan pilihan dan kontrol input
            ClearTextBoxes();
            dgvUnit.ClearSelection(); // Menghilangkan pilihan dari DataGridView
            btnHapusSeleksi.Visible = false; // Sembunyikan tombol setelah membersihkan data
            isEditing = false; // Reset flag ke mode tambah
        }

        private void ClearTextBoxes()
        {
            tbNama.Clear();
            cbTipe.SelectedIndex = -1; // Kosongkan ComboBox
            tbLokasi.Clear();
            tbKapasitas.Clear();
        }

        private void LoadAllUnitData()
        {
            List<UnitData> units = authService.GetAllUnits();
            dgvUnit.DataSource = units;
            dgvUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnit.Columns["NamaUnit"].FillWeight = 30;
            dgvUnit.Columns["TipeUnit"].FillWeight = 20;
            dgvUnit.Columns["LokasiUnit"].FillWeight = 30;
            dgvUnit.Columns["KapasitasUnit"].FillWeight = 20;
            dgvUnit.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            if (dgvUnit.SelectedRows.Count > 0)
            {
                int unitId = (int)dgvUnit.SelectedRows[0].Cells["UnitId"].Value;
                UnitData updatedUnit = new UnitData
                {
                    UnitId = unitId,
                    NamaUnit = tbNama.Text,
                    TipeUnit = cbTipe.Text,
                    LokasiUnit = tbLokasi.Text,
                    KapasitasUnit = tbKapasitas.Text
                };

                authService.UpdateUnit(unitId, updatedUnit);
                ClearTextBoxes();
                LoadAllUnitData();
            }
        }

        private void btnHapusUnit_Click(object sender, EventArgs e)
        {
            if (dgvUnit.SelectedRows.Count > 0)
            {
                int unitId = (int)dgvUnit.SelectedRows[0].Cells["UnitId"].Value;
                authService.DeleteUnit(unitId);
                ClearTextBoxes();
                LoadAllUnitData();
            }
        }

        private void btnTambahUnit_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                int unitId = (int)dgvUnit.SelectedRows[0].Cells["UnitId"].Value;
                UnitData updatedUnit = new UnitData
                {
                    NamaUnit = tbNama.Text,
                    TipeUnit = cbTipe.Text,
                    LokasiUnit = tbLokasi.Text,
                    KapasitasUnit = tbKapasitas.Text
                };

                authService.UpdateUnit(unitId, updatedUnit);
                MessageBox.Show("Data berhasil diperbarui.", "Informasi");
            }
            else
            {
                UnitData newUnit = new UnitData
                {
                    NamaUnit = tbNama.Text,
                    TipeUnit = cbTipe.Text,
                    LokasiUnit = tbLokasi.Text,
                    KapasitasUnit = tbKapasitas.Text
                };

                authService.AddUnit(newUnit);
                MessageBox.Show("Data baru berhasil ditambahkan.", "Informasi");
            }

            LoadAllUnitData();
            ClearTextBoxes();
            isEditing = false;
        }
    }
}
