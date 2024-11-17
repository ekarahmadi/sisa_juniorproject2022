using SISA.Model;
using SISA.Recycle;
using SISA.View._1Starting;
using SISA.View._2MainWindow;
using SISA.View._3AdminWindow;
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

namespace SISA.View._4TPAWindow
{
    public partial class AdminTPAWindow : Form
    {
        // Gambar default dan hover untuk masing-masing button
        private Image dashboardDefault;
        private Image dashboardHover;
        private Image riwayatDefault;
        private Image riwayatHover;
        private Image accountDefault;
        private Image accountHover;
        private Image keluarDefault;
        private Image keluarHover;
        private Image homeDafault;
        private Bitmap homeDefault;
        private Image homeHover;

        // Buat Instance UserControl untuk Setiap Tampilan
        private UC_Dashboard ucDashboard;
        private UC_Riwayat ucRiwayat;
        private SISA.View._2MainWindow.UC_Account ucAccount;
        private UC_AppDetail ucAppDetail;
        private UC_EditDataUser ucEditDataUser;
        private AuthService authService;

        public AdminTPAWindow()
        {
            InitializeComponent();
            InitializeButtonHoverEffects();
            authService = new AuthService(); // Inisialisasi authService

            // Inisialisasi setiap UserControl
            ucDashboard = new UC_Dashboard();
            ucRiwayat = new UC_Riwayat();
            ucAccount = new SISA.View._2MainWindow.UC_Account();
            ucEditDataUser = new UC_EditDataUser();

            // Set tampilan awal
            LoadUserControl(ucDashboard);

            // Tambahkan handler untuk event ShowEditDataUser dan ShowEditDataUnit di UC_Account
            ucAccount.ShowEditDataUser += MainWindow_ShowEditDataUser;
        }

        private void MainWindow_ShowEditDataUser()
        {
            // Ambil username dari SessionManager
            string currentUsername = SessionManager.Username;

            UC_EditDataUser editDataUser = new UC_EditDataUser();
            LoadUserControl(editDataUser);
        }

        public void ShowEditDataUser()
        {
            UC_EditDataUser editDataUser = new UC_EditDataUser();
            LoadUserControl(editDataUser);
        }

        private void OnDataEditSuccessful()
        {
            Console.WriteLine("Event DataEditSuccessful diterima di MainWindow.");

            // Kembali ke UC_Account setelah data berhasil diedit
            UC_Account uC_Account = new UC_Account();
            LoadUserControl(ucAccount);

            // Panggil LoadUserData di UC_Account untuk memuat data terbaru
            ucAccount.LoadUserData();
        }

        public void LoadUserControl(UserControl userControl)
        {
            // Hapus kontrol yang ada di dalam panelContent
            panelContent.Controls.Clear();

            // Set agar userControl memenuhi panelContent
            userControl.Dock = DockStyle.Fill;

            // Tambahkan userControl ke panelContent
            panelContent.Controls.Add(userControl);
        }

        private void InitializeButtonHoverEffects()
        {
            // Inisialisasi gambar default dan hover untuk Dashboard
            dashboardDefault = Properties.Resources.nvDashboard;
            dashboardHover = Properties.Resources.nvDashboardHover;
            btnDashboard.Image = dashboardDefault;

            // Inisialisasi gambar default dan hover untuk Riwayat
            riwayatDefault = Properties.Resources.nvRiwayat;
            riwayatHover = Properties.Resources.nvRiwayatHover;
            btnRiwayat.Image = riwayatDefault;

            // Inisialisasi gambar default dan hover untuk Account
            accountDefault = Properties.Resources.nvAccount;
            accountHover = Properties.Resources.nvAccountHover;
            btnAccount.Image = accountDefault;

            // Inisialisasi gambar default dan hover untuk Keluar
            keluarDefault = Properties.Resources.nvKeluar;
            keluarHover = Properties.Resources.nvKeluarHover;
            btnKeluar.Image = keluarDefault;

            // Inisialisasi gambar default dan hover untuk Home
            homeDefault = Properties.Resources.nvLogo;
            homeHover = Properties.Resources.nvLogoHover;
            btnHome.Image = homeDefault;

            // Tambahkan event MouseEnter dan MouseLeave untuk Dashboard
            btnDashboard.MouseEnter += BtnDashboard_MouseEnter;
            btnDashboard.MouseLeave += BtnDashboard_MouseLeave;

            // Tambahkan event MouseEnter dan MouseLeave untuk Riwayat
            btnRiwayat.MouseEnter += BtnRiwayat_MouseEnter;
            btnRiwayat.MouseLeave += BtnRiwayat_MouseLeave;

            // Tambahkan event MouseEnter dan MouseLeave untuk Account
            btnAccount.MouseEnter += BtnAccount_MouseEnter;
            btnAccount.MouseLeave += BtnAccount_MouseLeave;

            // Tambahkan event MouseEnter dan MouseLeave untuk Keluar
            btnKeluar.MouseEnter += BtnKeluar_MouseEnter;
            btnKeluar.MouseLeave += BtnKeluar_MouseLeave;

            // Tambahkan event MouseEnter dan MouseLeave untuk Home
            btnHome.MouseEnter += BtnHome_MouseEnter;
            btnHome.MouseLeave += BtnHome_MouseLeave;
        }

        // Event handler untuk hover effect pada btnDashboard
        private void BtnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.Image = dashboardHover;
        }

        private void BtnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.Image = dashboardDefault;
        }

        // Event handler untuk hover effect pada btnRiwayat
        private void BtnRiwayat_MouseEnter(object sender, EventArgs e)
        {
            btnRiwayat.Image = riwayatHover;
        }

        private void BtnRiwayat_MouseLeave(object sender, EventArgs e)
        {
            btnRiwayat.Image = riwayatDefault;
        }

        // Event handler untuk hover effect pada btnAccount
        private void BtnAccount_MouseEnter(object sender, EventArgs e)
        {
            btnAccount.Image = accountHover;
        }

        private void BtnAccount_MouseLeave(object sender, EventArgs e)
        {
            btnAccount.Image = accountDefault;
        }

        // Event handler untuk hover effect pada btnKeluar
        private void BtnKeluar_MouseEnter(object sender, EventArgs e)
        {
            btnKeluar.Image = keluarHover;
        }

        private void BtnKeluar_MouseLeave(object sender, EventArgs e)
        {
            btnKeluar.Image = keluarDefault;
        }

        // Event handler untuk hover effect pada btnHome
        private void BtnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.Image = homeHover;
        }

        private void BtnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.Image = homeDefault;
        }

        private void AdminTPAWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucDashboard);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucDashboard);
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucRiwayat);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucAccount);
        }

        private void btnKeluar_Click(object sender, EventArgs e)
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
