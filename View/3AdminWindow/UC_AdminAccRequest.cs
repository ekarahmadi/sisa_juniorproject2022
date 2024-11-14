using Npgsql;
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
    public partial class UC_AdminAccRequest : UserControl
    {
        private AuthService authService;

        // Default and hover images for each button
        private Image terimaDefault;
        private Image terimaHover;
        private Image tolakDefault;
        private Image tolakHover;
        private Image editDefault;
        private Image editHover;

        public UC_AdminAccRequest()
        {
            InitializeComponent();
            InitializeButtonHoverEffects();

            authService = new AuthService();
            LoadDataGrids();
            LoadCalonUserData();
            LoadUserData();
        }

        private void LoadDataGrids()
        {
            // Load data into dgvCalonUser
            dgvCalonUser.DataSource = authService.GetCalonUsers();

            // Load data into dgvTerdaftar
            dgvTerdaftar.DataSource = authService.GetApprovedUsers();
        }

        private void LoadCalonUserData()
        {
            DataTable calonUserTable = authService.GetCalonUsers();
            dgvCalonUser.DataSource = calonUserTable;
        }

        private void LoadUserData()
        {
            DataTable userTable = authService.GetApprovedUsers();
            dgvTerdaftar.DataSource = userTable;
        }

        private void ConfigureDataGrids()
        {
            // Customize dgvCalonUser
            dgvCalonUser.Columns["name"].HeaderText = "Nama";
            dgvCalonUser.Columns["username"].HeaderText = "Username";
            dgvCalonUser.Columns["unit_id"].HeaderText = "Unit Kerja";
            dgvCalonUser.Columns["role_id"].HeaderText = "Role";
            dgvCalonUser.Columns["date_registered"].HeaderText = "Waktu Mendaftar";

            // Customize dgvTerdaftar
            dgvTerdaftar.Columns["nama"].HeaderText = "Nama";
            dgvTerdaftar.Columns["username"].HeaderText = "Username";
            dgvTerdaftar.Columns["role_id"].HeaderText = "Role";
            dgvTerdaftar.Columns["unit_id"].HeaderText = "Unit Kerja";
            dgvTerdaftar.Columns["created_at"].HeaderText = "Waktu Diterima";
        }

        private string ConvertRoleIdToText(int roleId)
        {
            switch (roleId)
            {
                case 1:
                    return "AdminTPS";
                case 2:
                    return "AdminTPA";
                case 3:
                    return "AdminApp";
                default:
                    return "Unknown Role";
            }
        }

        private void dgvCalonUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCalonUser.Rows[e.RowIndex];
                tbNama.Text = row.Cells["name"].Value.ToString();
                tbUsername.Text = row.Cells["username"].Value.ToString();

                // Ambil nama unit berdasarkan unit_id dan tampilkan di tbUnitKerja
                int unitId = Convert.ToInt32(row.Cells["unit_id"].Value);
                tbUnitKerja.Text = authService.GetUnitNameById(unitId);

                // Konversi role_id menjadi teks dan tampilkan di tbRole
                int roleId = Convert.ToInt32(row.Cells["role_id"].Value);
                tbRole.Text = ConvertRoleIdToText(roleId);

                tbWaktu.Text = row.Cells["date_registered"].Value.ToString();
            }
        }

        private void dgvTerdaftar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTerdaftar.Rows[e.RowIndex];
                tbNama.Text = row.Cells["nama"].Value.ToString();
                tbUsername.Text = row.Cells["username"].Value.ToString();

                // Ambil nama unit berdasarkan unit_id dan tampilkan di tbUnitKerja
                int unitId = Convert.ToInt32(row.Cells["unit_id"].Value);
                tbUnitKerja.Text = authService.GetUnitNameById(unitId);

                // Konversi role_id menjadi teks dan tampilkan di tbRole
                int roleId = Convert.ToInt32(row.Cells["role_id"].Value);
                tbRole.Text = ConvertRoleIdToText(roleId);

                tbWaktu.Text = row.Cells["created_at"].Value.ToString();
            }
        }

        private void InitializeButtonHoverEffects()
        {
            // Load images from resources
            terimaDefault = Properties.Resources.btnTerima; // Replace with your actual image resource
            terimaHover = Properties.Resources.btnTerimaHover;
            tolakDefault = Properties.Resources.btnTolak1;
            tolakHover = Properties.Resources.btnTolakHover1;
            editDefault = Properties.Resources.btnEditData;
            editHover = Properties.Resources.btnEditDataHover;

            // Set default images for buttons
            btnTerima.Image = terimaDefault;
            btnTolak.Image = tolakDefault;
            btnEdit.Image = editDefault;

            // Add hover events for btnTerima
            btnTerima.MouseEnter += (s, e) => btnTerima.Image = terimaHover;
            btnTerima.MouseLeave += (s, e) => btnTerima.Image = terimaDefault;

            // Add hover events for btnTolak
            btnTolak.MouseEnter += (s, e) => btnTolak.Image = tolakHover;
            btnTolak.MouseLeave += (s, e) => btnTolak.Image = tolakDefault;

            // Add hover events for btnEdit
            btnEdit.MouseEnter += (s, e) => btnEdit.Image = editHover;
            btnEdit.MouseLeave += (s, e) => btnEdit.Image = editDefault;
        }

        private void btnTerima_Click(object sender, EventArgs e)
        {
            if (dgvCalonUser.SelectedRows.Count > 0)
            {
                var row = dgvCalonUser.SelectedRows[0];
                int calonUserId = Convert.ToInt32(row.Cells["calonuser_id"].Value);
                string name = row.Cells["name"].Value.ToString();
                string username = row.Cells["username"].Value.ToString();
                string password = row.Cells["password"].Value.ToString();
                int unitId = Convert.ToInt32(row.Cells["unit_id"].Value);

                // Tentukan role_id berdasarkan unit_id
                int roleId = (unitId == 1) ? 1 : 2;

                bool isApproved = authService.ApproveUser(calonUserId, name, username, password, roleId, unitId);

                if (isApproved)
                {
                    MessageBox.Show("Pengguna diterima dan dipindahkan ke tabel users.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCalonUserData();
                    LoadUserData();
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan saat menerima pengguna.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih pengguna yang ingin diterima.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
            if (dgvCalonUser.SelectedRows.Count > 0)
            {
                var row = dgvCalonUser.SelectedRows[0];
                int calonUserId = Convert.ToInt32(row.Cells["calonuser_id"].Value);

                bool isDeleted = authService.DeleteCalonUser(calonUserId);

                if (isDeleted)
                {
                    MessageBox.Show("Pengguna ditolak dan dihapus dari daftar calon user.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCalonUserData();
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan saat menolak pengguna.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih pengguna yang ingin ditolak.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
