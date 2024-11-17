using SISA.View._2MainWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISA.View._3AdminWindow;
using SISA.View._4TPAWindow;
using SISA.Model;
using Npgsql;

namespace SISA.View._1Starting
{
    public partial class GetStart : Form
    {
        private UC_Start ucStart;
        private UC_Login ucLogin;
        private UC_Signup ucSignup;
        private string? connectionString;
        private AuthService authService;

        public GetStart()
        {
            InitializeComponent();

            // Inisialisasi AuthService untuk koneksi database
            authService = new AuthService();

            InitializeUserControls();
            LoadUserControl(ucStart);       // Tampilkan UC_Start sebagai tampilan awal
        }

        private void InitializeUserControls()
        {
            // Inisialisasi UC_Start dan UC_Login
            ucStart = new UC_Start();
            ucLogin = new UC_Login();
            ucSignup = new UC_Signup();

            // Tambahkan event handler untuk tombol Start di UC_Start
            ucStart.StartButtonClicked += UcStart_StartButtonClicked;
            ucLogin.SignUpLinkClicked += UcLogin_SignUpLinkClicked;
            ucSignup.BackButtonClicked += UcSignup_BackButtonClicked;
            ucLogin.LoginButtonClicked += UcLogin_LoginButtonClicked;

            // Tampilkan UC_Start di dalam panelContainer secara default
            LoadUserControl(ucStart);
        }

        private void UcLogin_SignUpLinkClicked(object sender, EventArgs e)
        {
            ShowSignUpControl();
        }

        private void UcStart_StartButtonClicked(object sender, EventArgs e)
        {
            // Saat tombol Start di UC_Start diklik, tampilkan UC_Login
            LoadLoginControl();
        }

        private void LoadLoginControl()
        {
            // Hapus event handler untuk memastikan tidak ada multiple subscription
            ucLogin.LoginSuccessful -= OnLoginSuccessful;

            // Berlangganan ke event login sukses
            ucLogin.LoginSuccessful += OnLoginSuccessful;

            // Tampilkan ucLogin di panelContainer
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(ucLogin);
            ucLogin.Dock = DockStyle.Fill;
        }

        private void OnLoginSuccessful(int roleId)
        {

            // Navigasi berdasarkan roleId
            Form nextForm;
            switch (roleId)
            {
                case 1: // Admin TPS
                    nextForm = new MainWindow(); // Form untuk Admin TPS/TPA
                    break;
                case 2: // Admin TPA
                    nextForm = new AdminTPAWindow(); // Form untuk Admin TPS/TPA
                    break;
                case 3: // Admin Aplikasi
                    nextForm = new AdminWindow(); // Form untuk Admin Aplikasi
                    break;

                default:
                    MessageBox.Show("Role tidak dikenal.");
                    return;
            }

            // Buka form berikutnya dan tutup GetStart
            nextForm.Show();
            this.Hide();
        }

        private void UcSignup_BackButtonClicked(object sender, EventArgs e)
        {
            // Pindah kembali ke UC_Login
            LoadUserControl(ucLogin);
        }

        private void UcLogin_LoginButtonClicked(object sender, EventArgs e)
        {

        }

        private void LoadUserControl(UserControl control)
        {
            // Bersihkan kontrol yang ada dalam panelContainer
            panelContainer.Controls.Clear();

            // Tambahkan kontrol baru yang akan ditampilkan di panelContainer
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control);
        }

        private void GetStart_Load(object sender, EventArgs e)
        {

        }

        private void ShowSignUpControl()
        {
            // Buat instance UC_SignUp
            UC_Signup ucSignUp = new UC_Signup();

            // Mengambil data unit kerja dari AuthService
            DataTable unitsData = authService.GetUnitData();

            // Memanggil metode LoadUnitData di UC_SignUp untuk mengisi ComboBox
            ucSignup.LoadUnitData(unitsData);

            // Menampilkan UC_SignUp di panelContainer
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(ucSignup);
            ucSignup.Dock = DockStyle.Fill;
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
