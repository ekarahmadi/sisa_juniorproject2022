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
    public partial class UC_AdminDashboard : UserControl
    {
        public UC_AdminDashboard()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private AuthService authService = new AuthService();

        private void LoadDashboardData()
        {
            // Mengambil jumlah total user
            int totalUsers = authService.GetTotalUsers();
            lblTotalUser.Text = totalUsers.ToString();

            // Mengambil jumlah total akun request
            int totalRequests = authService.GetTotalAccountRequests();
            lblTotalRequest.Text = totalRequests.ToString();

            // Mengambil jumlah unit kerja TPS
            int totalTPS = authService.GetTotalUnitsByType("TPS");
            lblTotalTPS.Text = totalTPS.ToString();

            // Mengambil jumlah unit kerja TPA
            int totalTPA = authService.GetTotalUnitsByType("TPA");
            lblTotalTPA.Text = totalTPA.ToString();
        }

        private void lblTotalUser_Click(object sender, EventArgs e)
        {

        }
    }
}
