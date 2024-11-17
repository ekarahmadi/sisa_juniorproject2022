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
            btnTerimaHover = Properties.Resources.btnTerimaHover; // Nama file gambar hover

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

        }
    }
}
