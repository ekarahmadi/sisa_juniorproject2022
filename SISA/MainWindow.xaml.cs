using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SISA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Database connection variables
        private NpgsqlConnection conn;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=;Database=SisaProjectDB";

        public static NpgsqlCommand cmd;
        private DataTable dt;
        private string sql = null;

        // Method to open the connection
        private void OpenConnection()
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                MessageBox.Show("Connection to database successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect: {ex.Message}");
            }
        }

        // Method to close the connection
        private void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // Example method to load data from TPS table
        private void LoadData()
        {
            try
            {
                OpenConnection();
                sql = "SELECT * FROM \"TPS\"";  // Query to fetch all TPS data
                cmd = new NpgsqlCommand(sql, conn);

                dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);

                // Bind data to DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }

        // Event handler for button click to load data
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
