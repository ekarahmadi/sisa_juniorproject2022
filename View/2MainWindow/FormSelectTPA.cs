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

namespace SISA.View._2MainWindow
{
    public partial class FormSelectTPA : Form
    {
        private TPSService tpsService;
        public int SelectedTPAId { get; private set; }

        public FormSelectTPA()
        {
            InitializeComponent();
            tpsService = new TPSService();

            // Tambahkan event handler secara manual jika perlu
            btnConfirm.MouseEnter += btnConfirm_MouseEnter;
            btnConfirm.MouseLeave += btnConfirm_MouseLeave;

            btnCancel.MouseEnter += btnCancel_MouseEnter;
            btnCancel.MouseLeave += btnCancel_MouseLeave;
        }

        // Event handler untuk btnConfirm
        private void btnConfirm_MouseEnter(object sender, EventArgs e)
        {
            btnConfirm.Image = Properties.Resources.btnKonfirmasiHover; // Gambar hover
        }

        private void btnConfirm_MouseLeave(object sender, EventArgs e)
        {
            btnConfirm.Image = Properties.Resources.btnKonfirmasi; // Gambar normal
        }

        // Event handler untuk btnCancel
        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.Image = Properties.Resources.btnGaJadiHover; // Gambar hover
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.Image = Properties.Resources.btnGaJadi; // Gambar normal
        }

        private void FormSelectTPA_Load(object sender, EventArgs e)
        {
            try
            {
                TPSService tpsService = new TPSService();

                // Ambil semua unit dengan tipe TPA
                DataTable tpaData = tpsService.GetTPAData();

                // Bind data ke DataGridView
                dgvTPA.DataSource = tpaData;

                // Sesuaikan kolom DataGridView
                dgvTPA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data TPA: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvTPA.SelectedRows.Count > 0)
            {
                SelectedTPAId = Convert.ToInt32(dgvTPA.SelectedRows[0].Cells["unit_id"].Value);
                DialogResult = DialogResult.OK; // Tutup form dengan sukses
            }
            else
            {
                MessageBox.Show("Pilih TPA tujuan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Batalkan dan tutup form
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
