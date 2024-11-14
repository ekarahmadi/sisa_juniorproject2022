using SISA.Model;
using SISA.Recycle;
using SISA.View._1Starting;
using SISA.View._3AdminWindow;
using SISA.View._4TPSWindow;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SISA.View._2MainWindow
{
    public partial class MainWindow : Form
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
        private UC_Account ucAccount;
        private UC_AppDetail ucAppDetail;
        private UC_EditDataUser ucEditDataUser;
        private AuthService authService;

        public MainWindow()
        {
            InitializeComponent();
            InitializeButtonHoverEffects();
            authService = new AuthService(); // Inisialisasi authService

            // Inisialisasi setiap UserControl
            ucDashboard = new UC_Dashboard();
            ucRiwayat = new UC_Riwayat();
            ucAccount = new UC_Account();
            ucAppDetail = new UC_AppDetail();
            ucEditDataUser = new UC_EditDataUser(this); // Kirim referensi MainWindow

            // Tambahkan handler untuk event ShowEditDataUser dan ShowEditDataUnit di UC_Account
            ucAccount.ShowEditDataUser += MainWindow_ShowEditDataUser;
            ucAccount.ShowEditDataUnit += MainWindow_ShowEditDataUnit;

            // Tambahkan listener untuk BackButtonClicked dari UC_EditDataUser
            ucEditDataUser.BackButtonClicked += UcEditDataUser_BackButtonClicked;

            // Memulai tampilan awal di UC_Account
            ShowAccountControl();

            // Menambahkan listener pada event DataEditSuccessful
            ucEditDataUser.DataEditSuccessful += OnDataEditSuccessful;

            // Set tampilan awal
            LoadUserControl(ucDashboard);
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucDashboard);

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

        private void btnAccount_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucAccount);
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucRiwayat);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadUserControl(ucAppDetail);
        }

        private void MainWindow_ShowEditDataUser()
        {
            // Ambil username dari SessionManager
            string currentUsername = SessionManager.Username;

            UC_EditDataUser editDataUser = new UC_EditDataUser();
            LoadUserControl(editDataUser);
        }

        private void MainWindow_ShowEditDataUnit()
        {
            UC_EditDataUnit editDataUnit = new UC_EditDataUnit();
            LoadUserControl(editDataUnit);
        }

        public void ShowEditDataUser()
        {
            UC_EditDataUser editDataUser = new UC_EditDataUser();
            LoadUserControl(editDataUser);
        }

        private void ShowAccountView()
        {
            // Memuat UC_Account
            LoadUserControl(ucAccount);
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

        // Listener untuk event BackButtonClicked di UC_EditDataUser
        private void UcEditDataUser_BackButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Event BackButtonClicked diterima di MainWindow."); // Debugging
            MessageBox.Show("Kembali ke UC_Account"); // Debugging

            ShowAccountControl(); // Kembali ke UC_Account
        }

        public void ShowAccountControl()
        {
            Console.WriteLine("Memuat UC_Account..."); // Debugging

            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucAccount);
            ucAccount.Dock = DockStyle.Fill;

            Console.WriteLine("UC_Account telah dimuat.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
