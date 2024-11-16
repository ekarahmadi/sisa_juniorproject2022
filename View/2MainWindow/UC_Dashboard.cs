using SISA.Model;
using System;
using System.Data;
using System.Security.Principal;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SISA.View._2MainWindow
{
    public partial class UC_Dashboard : UserControl
    {
        private AuthService authService;
        //Add authservice
        private string currentUsername;

        private int userId;

        public UC_Dashboard()
        {
            InitializeComponent();
            authService = new AuthService();
            InitializeButtonHoverEffects();
            //cmbTipeAdd.Items.AddRange(new object[] { "A", "B" });
            //cmbTipeMod.Items.AddRange(new object[] { "A", "B" });
        }

        // Gambar default dan hover untuk masing-masing button
        private Image addDataNo;
        private Image addDataHover;
        private Image editDataHover;
        private Image editDataNo;
        private Image muatDataNo;
        private Image muatDataHover;
        private Image buatHover1;
        private Image buatNoHover1;
        private Image BerhasilNoHover;
        private Image BerhasilHover;
        private Image RefreshDataHover;
        private Image RefreshDataNo;

        private void InitializeButtonHoverEffects()
        {
            // Inisialisasi gambar default dan hover untuk Dashboard
            muatDataNo = Properties.Resources.MuatDataNo;
            muatDataHover = Properties.Resources.MuatDataHover;
            btnMuatData.Image = muatDataNo;

            addDataNo = Properties.Resources.AddDataNo;
            addDataHover = Properties.Resources.AddDataHover;
            btnMuatData.Image = addDataNo;

            editDataNo = Properties.Resources.EditDataNo;
            editDataHover = Properties.Resources.EditDataHover;
            btnMuatData.Image = editDataNo;

            buatNoHover1 = Properties.Resources.BuatNoHover;
            buatHover1 = Properties.Resources.BuatHover;
            btnMuatData.Image = buatNoHover1;

            RefreshDataHover = Properties.Resources.RefreshHover;
            RefreshDataNo = Properties.Resources.RefreshNoHover;
            pictureBox3.Image = RefreshDataHover;

            BerhasilNoHover = Properties.Resources.BerhasilNoHover;
            BerhasilHover = Properties.Resources.BerhasilHover;
            pictureBox2.Image = BerhasilNoHover;


            // Tambahkan event MouseEnter dan MouseLeave untuk Dashboard
            btnMuatData.MouseEnter += BtnMuatData_MouseEnter;
            btnMuatData.MouseLeave += BtnMuatData_MouseLeave;

        }
        // Event handler untuk hover effect pada btnDashboard
        private void BtnMuatData_MouseEnter(object sender, EventArgs e)
        {
            btnMuatData.Image = muatDataHover;
        }

        private void BtnMuatData_MouseLeave(object sender, EventArgs e)
        {
            btnMuatData.Image = muatDataNo;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: You can add any code here if needed for label1 clicks.
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            // Load the data when pictureBox2 is clicked
            LoadTPSData();
        }
        private void LoadUnitDetails()
        {
            try
            {
                // Fetch unit data managed by the current user
                DataTable unitData = authService.GetManagedUnitByUsername(currentUsername);

                if (unitData.Rows.Count > 0)
                {
                    // Populate text fields with unit data
                    tbUnitID.Text = unitData.Rows[0]["unit_name"].ToString();
                    tbName.Text = unitData.Rows[0]["unit_type"].ToString();
                    tbCategory.Text = unitData.Rows[0]["location"].ToString();
                    tbLocation.Text = unitData.Rows[0]["capacity"].ToString();
                }
                else
                {
                    MessageBox.Show("No unit data found for the current user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading unit data: " + ex.Message);
            }
        }


        private void LoadTPSData()
        {
            try
            {
                // Retrieve the TPS data
                DataTable tpsData = authService.GetTPSData();

                // Bind the data to the DataGridView
                GridViewSampah.DataSource = tpsData;
            }
            catch (Exception ex)
            {
                // Display an error message if data loading fails
                MessageBox.Show("Error loading TPS data: " + ex.Message);
            }
        }

        private void GridViewSampah_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can handle cell clicks here if you need, e.g., for selecting or editing rows
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Optional: You can add code here for pictureBox1 click events
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Validate input for modification
            if (int.TryParse(txtNoMod.Text, out int entryNumber) &&
                float.TryParse(txtMassaMod.Text, out float massaSampah) &&
                txtTipeMod.Text.Length == 1)
            {
                char tipeSampah = txtTipeMod.Text[0];

                // Call UpdateTPSData from authService
                bool success = authService.UpdateTPSData(entryNumber, massaSampah, tipeSampah);

                if (success)
                {
                    MessageBox.Show("Data successfully updated.");
                    LoadTPSData(); // Refresh data grid view to show updated data
                }
                else
                {
                    MessageBox.Show("Failed to update data. Please check the entry number.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please check your entries.");
            }
        }

        private void txtMassaAdd_TextChanged(object sender, EventArgs e)
        {
            //textbox to add Mass
        }

        private void txtTipeAdd_TextChanged(object sender, EventArgs e)
        {
            //textbox to add Tipe
        }

        private void txtNoMod_TextChanged(object sender, EventArgs e)
        {
            //textbox to edit Entry Number
        }

        private void txtMassaMod_TextChanged(object sender, EventArgs e)
        {
            //textbox to edit massa
        }

        private void txtTipeMod_TextChanged(object sender, EventArgs e)
        {
            //textbox to edit tipe
        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            // Validate input
            if (float.TryParse(txtMassaAdd.Text, out float massaSampah) && txtTipeAdd.Text.Length == 1)
            {
                char tipeSampah = txtTipeAdd.Text[0];

                // Call AddTPSData from authService
                bool success = authService.AddTPSData(massaSampah, tipeSampah);

                if (success)
                {
                    MessageBox.Show("Data successfully added.");
                    LoadTPSData(); // Refresh data grid view to show new data
                }
                else
                {
                    MessageBox.Show("Failed to add data.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please check your entries.");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Refreshes the process status for the order based on the current data in tbOrderData
            if (int.TryParse(tbOrderData.Text, out int entryNumber))
            {
                string processStatus = authService.GetOrderProcessStatus(entryNumber);
                tbPesananProcess.Text = processStatus ?? "No order found for this entry.";
            }
            else
            {
                MessageBox.Show("Please enter a valid entry number.");
            }
        }

        private void tbOrderData_TextChanged(object sender, EventArgs e)
        {
            //textbox where the tpsData entry is typed to get sent to orders
        }

        private void tbPesananProcess_TextChanged(object sender, EventArgs e)
        {
            //textbox to show the process 
        }

        /*private void btnPesan_Click(object sender, EventArgs e)
        {
            // Create a new order based on the data entered in tbOrderData
            if (int.TryParse(tbOrderData.Text, out int entryNumber))
            {
                bool success = authService.CreateOrder(entryNumber);
                if (success)
                {
                    MessageBox.Show("Order created successfully.");
                    tbPesananProcess.Text = "Pending";  // Initial status for new orders
                }
                else
                {
                    MessageBox.Show("Failed to create order. Please ensure the entry exists in TPSData.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid entry number.");
            }
        }*/

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Mark order as completed and transfer to Riwayat if available
            if (int.TryParse(tbOrderData.Text, out int entryNumber))
            {
                // Call TransferDataToRiwayat instead of TransferOrderToRiwayat
                bool success = authService.TransferDataToRiwayat(entryNumber);
                if (success)
                {
                    MessageBox.Show("Order completed and transferred to Riwayat.");
                    tbPesananProcess.Text = "Completed";
                    LoadTPSData();  // Refresh data grid view to reflect changes
                }
                else
                {
                    MessageBox.Show("Failed to complete order. Please check the order details.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid entry number.");
            }
        }
    }
}
