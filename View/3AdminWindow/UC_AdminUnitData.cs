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
                btnHapusSeleksi.Visible = true; // Tampilkan tombol Hapus Seleksi saat ada data yang dipilih
                isEditing = true;
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
            dgvUnit.Columns["UnitId"].FillWeight = 30;
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
            // Validasi bahwa semua field telah diisi
            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
                string.IsNullOrWhiteSpace(cbTipe.Text) ||
                string.IsNullOrWhiteSpace(tbLokasi.Text) ||
                string.IsNullOrWhiteSpace(tbKapasitas.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi bahwa kapasitas berisi angka
            if (!int.TryParse(tbKapasitas.Text, out int kapasitas))
            {
                MessageBox.Show("Kapasitas harus berupa angka yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEditing)
            {
                // Mode Edit - Update data yang dipilih
                int unitId = (int)dgvUnit.SelectedRows[0].Cells["UnitId"].Value;
                UnitData updatedUnit = new UnitData
                {
                    UnitId = unitId,
                    NamaUnit = tbNama.Text,
                    TipeUnit = cbTipe.Text,
                    LokasiUnit = tbLokasi.Text,
                    KapasitasUnit = kapasitas.ToString() // Menyimpan kapasitas dalam bentuk string
                };

                authService.UpdateUnit(unitId, updatedUnit);
                MessageBox.Show("Data berhasil diperbarui.", "Informasi");
            }
            else
            {
                // Mode Tambah - Tambahkan data baru
                UnitData newUnit = new UnitData
                {
                    NamaUnit = tbNama.Text,
                    TipeUnit = cbTipe.Text,
                    LokasiUnit = tbLokasi.Text,
                    KapasitasUnit = kapasitas.ToString() // Menyimpan kapasitas dalam bentuk string
                };

                authService.AddUnit(newUnit);
                MessageBox.Show("Data baru berhasil ditambahkan.", "Informasi");
            }

            LoadAllUnitData(); // Refresh data
            ClearTextBoxes();  // Kosongkan TextBox setelah operasi selesai
            isEditing = false; // Reset flag ke mode tambah
        }
    }
}
