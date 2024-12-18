﻿using SISA.Model;
using SISA.Recycle;
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
    public partial class UC_AdminAccount : UserControl
    {
        private AuthService authService;

        public UC_AdminAccount()
        {
            InitializeComponent();// Inisialisasi gambar untuk PictureBox btnLogin
            authService = new AuthService();

            // Panggil LoadUserData setelah kontrol ini diinisialisasi
            LoadUserData();

        }

        private void LoadUserData()
        {
            // Ambil username dari SessionManager
            string currentUsername = SessionManager.Username;

            if (string.IsNullOrEmpty(currentUsername))
            {
                MessageBox.Show("Username is not set in the session. Please log in again.");
                return;
            }

            // Ambil data pengguna dari AuthService
            UserData userData = authService.GetUserDataByUsername(currentUsername);

            if (userData != null)
            {
                // Tampilkan data pada label atau kontrol UI
                lblNama.Text = userData.Nama;
                lblUsername.Text = userData.Username;
                lblUnit.Text = authService.GetUnitNameById(int.Parse(userData.UnitKerja));
                lblRole.Text = ConvertRoleIdToRoleName(int.Parse(userData.Role));
            }
            else
            {
                MessageBox.Show("Failed to load user data from the database.");
            }
        }

        // Helper function to convert role ID to role name
        private string ConvertRoleIdToRoleName(int roleId)
        {
            switch (roleId)
            {
                case 1:
                    return "Admin TPS";
                case 2:
                    return "Admin TPA";
                case 3:
                    return "Admin App";
                default:
                    return "Unknown Role";
            }
        }

        private void UC_AdminAccount_Load(object sender, EventArgs e)
        {

        }

        private void rE_Account1_Load(object sender, EventArgs e)
        {

        }

        private void rE_Account1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Ambil username dari SessionManager
            string currentUsername = SessionManager.Username;

            if (string.IsNullOrEmpty(currentUsername))
            {
                MessageBox.Show("Username is not set in the session. Please log in again.");
            }
            else
            {
                // Tampilkan nilai currentUsername untuk verifikasi
                MessageBox.Show("Current Username: " + currentUsername);
                Console.WriteLine("Current Username: " + currentUsername);

                // Alternatif: jika Anda memiliki label di UI, Anda bisa menampilkan di sana
                lblUsername.Text = "Current Username: " + currentUsername;
            }
        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
