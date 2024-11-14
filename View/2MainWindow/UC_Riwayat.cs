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
    public partial class UC_Riwayat : UserControl
    {
        private AuthService authService;
        public UC_Riwayat()
        {
            authService = new AuthService();
            InitializeComponent();
            LoadRiwayatData(); // Initial load of the data
        }
        private void LoadRiwayatData()
        {
            try
            {
                // Retrieve the Riwayat data
                DataTable riwayatData = authService.GetRiwayatData();

                // Bind the data to the DataGridView
                GridRiwayat.DataSource = riwayatData;
            }
            catch (Exception ex)
            {
                // Display an error message if data loading fails
                MessageBox.Show("Error loading Riwayat data: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadRiwayatData();
        }

        private void gridRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid where we are going to show the request data
        }

        private void btnLoadReq_Click(object sender, EventArgs e)
        {
            LoadRequestData();
        }

        private void LoadRequestData()
        {
            try
            {
                // Fetch the request data from the AuthService
                DataTable requestData = authService.GetRequestData();

                // Bind the data to gridRequest
                gridRequest.DataSource = requestData;
            }
            catch (Exception ex)
            {
                // Display an error message if data loading fails
                MessageBox.Show("Error loading request data: " + ex.Message);
            }
        }
    }
}
