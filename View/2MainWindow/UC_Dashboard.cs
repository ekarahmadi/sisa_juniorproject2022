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

        public UC_Dashboard()
        {
            InitializeComponent();
            authService = new AuthService();
            InitializeButtonHoverEffects();
            cmbTipeAdd.Items.AddRange(new object[] { "A", "B" });
            cmbTipeMod.Items.AddRange(new object[] { "A", "B" });
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
            btnTambahData.MouseEnter += BtnTambahData_MouseEnter;
            btnTambahData.MouseLeave += BtnTambahData_MouseLeave;
            btnEditData.MouseEnter += BtnEditData_MouseEnter;
            btnEditData.MouseLeave += BtnEditData_MouseLeave;
            btnPesan.MouseEnter += BtnPesan_MouseEnter;
            btnPesan.MouseLeave += BtnPesan_MouseLeave;
            pictureBox3.MouseEnter += PictureBox3_MouseEnter;
            pictureBox3.MouseLeave += PictureBox3_MouseLeave;
            pictureBox2.MouseEnter += PictureBox2_MouseEnter;
            pictureBox2.MouseLeave += PictureBox2_MouseLeave;
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

        private void BtnTambahData_MouseEnter(object sender, EventArgs e)
        {
            btnTambahData.Image = addDataHover;
        }

        private void BtnTambahData_MouseLeave(object sender, EventArgs e)
        {
            btnTambahData.Image = addDataNo;
        }

        private void BtnEditData_MouseEnter(object sender, EventArgs e)
        {
            btnEditData.Image = editDataHover;
        }

        private void BtnEditData_MouseLeave(object sender, EventArgs e)
        {
            btnEditData.Image = editDataNo;
        }

        private void BtnPesan_MouseLeave(object sender, EventArgs e)
        {
            btnPesan.Image = buatNoHover1;
        }
        private void BtnPesan_MouseEnter(object sender, EventArgs e)
        {
            btnPesan.Image = buatHover1;
        }

        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = RefreshDataHover;
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = RefreshDataNo;
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = BerhasilHover;
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = BerhasilNoHover;
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
                cmbTipeMod.SelectedItem != null)  // Check that a type is selected
            {
                char tipeSampah = cmbTipeMod.SelectedItem.ToString()[0]; // Get selected type as char

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
            if (float.TryParse(txtMassaAdd.Text, out float massaSampah) &&
                cmbTipeAdd.SelectedItem != null)  // Check that a type is selected
            {
                char tipeSampah = cmbTipeAdd.SelectedItem.ToString()[0]; // Get selected type as char

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

        private void tbUnitID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLocation_TextChanged(object sender, EventArgs e)
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

        private void btnPesan_Click(object sender, EventArgs e)
        {
            // Get Units ID from the session
            if (!int.TryParse(SessionManager.UnitKerja, out int unitsId))
            {
                MessageBox.Show("Units ID is not set. Please log in again.");
                return;
            }

            // Create a new order based on the data entered in tbOrderData
            if (int.TryParse(tbOrderData.Text, out int entryNumber))
            {
                bool success = authService.CreateOrder(entryNumber, unitsId);  // Pass unitsId to CreateOrder
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
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Mark order as completed and transfer data to Riwayat if available
            if (int.TryParse(tbOrderData.Text, out int entryNumber))
            {
                // Call TransferDataToRiwayat instead of TransferOrderToRiwayat
                bool success = authService.TransferDataToRiwayat(entryNumber);
                if (success)
                {
                    MessageBox.Show("Order completed, transferred to Riwayat, and removed from TPSData.");
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
