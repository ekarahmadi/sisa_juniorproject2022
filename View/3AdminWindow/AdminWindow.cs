using SISA.Model;
using SISA.Recycle;
using SISA.View._1Starting;
using SISA.View._2MainWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISA.View._3AdminWindow
{
    public partial class AdminWindow : Form
    {
        // Gambar default dan hover untuk setiap button dan logo
        private Image dashboardDefault;
        private Image dashboardHover;
        private Image requestDefault;
        private Image requestHover;
        private Image unitDataDefault;
        private Image unitDataHover;
        private Image accountDefault;
        private Image accountHover;
        private Image keluarDefault;
        private Image keluarHover;
        private Image logoAppDefault;
        private Image logoAppHover;

        // Buat Instance UserControl untuk Setiap Tampilan
        private UC_AdminDashboard ucAdminDashboard;
        private UC_AdminAccRequest ucAdminAccRequest;
        private UC_AdminAccount ucAdminAccount;
        private UC_AdminUnitData ucAdminUnitData;

        public AdminWindow()
        {
            InitializeComponent();
            InitializeButtonHoverEffects();

            // Inisialisasi setiap UserControl
            ucAdminDashboard = new UC_AdminDashboard();
            ucAdminAccRequest = new UC_AdminAccRequest();
            ucAdminAccount = new UC_AdminAccount();
            ucAdminUnitData = new UC_AdminUnitData();

            // Set tampilan awal
            LoadUserControl(ucAdminDashboard);

           // Memanggil fungsi untuk memuat UC_Account saat form diinisialisasi

        }

        private void LoadUserControl(UserControl userControl)
        {
            // Hapus kontrol yang ada di dalam panelContent
            panelAdminContent.Controls.Clear();

            // Set agar userControl memenuhi panelContent
            userControl.Dock = DockStyle.Fill;

            // Tambahkan userControl ke panelContent
            panelAdminContent.Controls.Add(userControl);
        }

        private void InitializeButtonHoverEffects()
        {
            // Inisialisasi gambar untuk setiap tombol dan logo
            dashboardDefault = Properties.Resources.nvAdminDashboard;
            dashboardHover = Properties.Resources.nvAdminDashboardHover;
            requestDefault = Properties.Resources.nvAdminRequest;
            requestHover = Properties.Resources.nvAdminRequestHover;
            unitDataDefault = Properties.Resources.nvAdminUnitData;
            unitDataHover = Properties.Resources.nvAdminUnitDataHover;
            accountDefault = Properties.Resources.nvAdminAccount;
            accountHover = Properties.Resources.nvAdminAccountHover;
            keluarDefault = Properties.Resources.nvAdminKeluar;
            keluarHover = Properties.Resources.nvAdminKeluarHover;
            logoAppDefault = Properties.Resources.nvAdminLogo;
            logoAppHover = Properties.Resources.nvAdminLogoHover;

            // Set gambar default ke masing-masing tombol dan logo
            btnAdminDashboard.Image = dashboardDefault;
            btnAdminRequest.Image = requestDefault;
            btnAdminUnitData.Image = unitDataDefault;
            btnAdminAccount.Image = accountDefault;
            btnAdminKeluar.Image = keluarDefault;
            btnHome.Image = logoAppDefault;

            // Tambahkan event hover untuk Dashboard
            btnAdminDashboard.MouseEnter += (s, e) => btnAdminDashboard.Image = dashboardHover;
            btnAdminDashboard.MouseLeave += (s, e) => btnAdminDashboard.Image = dashboardDefault;

            // Tambahkan event hover untuk Request
            btnAdminRequest.MouseEnter += (s, e) => btnAdminRequest.Image = requestHover;
            btnAdminRequest.MouseLeave += (s, e) => btnAdminRequest.Image = requestDefault;

            // Tambahkan event hover untuk Unit Data
            btnAdminUnitData.MouseEnter += (s, e) => btnAdminUnitData.Image = unitDataHover;
            btnAdminUnitData.MouseLeave += (s, e) => btnAdminUnitData.Image = unitDataDefault;

            // Tambahkan event hover untuk Account
            btnAdminAccount.MouseEnter += (s, e) => btnAdminAccount.Image = accountHover;
            btnAdminAccount.MouseLeave += (s, e) => btnAdminAccount.Image = accountDefault;

            // Tambahkan event hover untuk Keluar
            btnAdminKeluar.MouseEnter += (s, e) => btnAdminKeluar.Image = keluarHover;
            btnAdminKeluar.MouseLeave += (s, e) => btnAdminKeluar.Image = keluarDefault;

            // Tambahkan event hover untuk Logo (Home)
            btnHome.MouseEnter += (s, e) => btnHome.Image = logoAppHover;
            btnHome.MouseLeave += (s, e) => btnHome.Image = logoAppDefault;
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucAdminDashboard);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucAdminDashboard);
        }

        private void btnAdminRequest_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucAdminAccRequest);
        }

        private void btnAdminUnitData_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucAdminUnitData);
        }

        private void btnAdminAccount_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucAdminAccount);
        }

        private void btnAdminKeluar_Click(object sender, EventArgs e)
        {
            // Hapus sesi login
            SessionManager.ClearSession();

            // Membuka kembali GetStart
            GetStart getStart = new GetStart();
            getStart.Show();

            // Tutup MainWindow atau AdminWindow saat ini
            this.Close();
        }
    }
}
