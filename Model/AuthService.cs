using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SISA.Model
{
    internal class AuthService
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=root;Database=sisa_juniorproject";

        public bool Login(string username, string password, out int roleId)
        {
            roleId = -1;
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT role_id FROM users WHERE username = @username AND password = @password";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                roleId = reader.GetInt32(0); // Ambil role_id dari database
                                return true; // Login berhasil
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return false; // Login gagal
        }

        public bool IsUsernameUnique(string username)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Periksa username di tabel Calonuser dan users
                    string query = "SELECT COUNT(*) FROM (SELECT username FROM Calonuser UNION ALL SELECT username FROM users) AS all_users WHERE username = @username";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count == 0; // True jika tidak ada username yang sama
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false; // Anggap username tidak unik jika terjadi kesalahan
            }
        }

        // Metode untuk mengambil data unit kerja dari tabel units
        public DataTable GetUnitData()
        {
            DataTable unitsData = new DataTable();
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT unit_id, unit_name FROM units";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(unitsData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return unitsData;
        }

        public bool RegisterUser(string name, string username, string password, int unitId)
        {
            // Tentukan role_id berdasarkan unit_id
            int roleId;
            if (unitId == 1) // Misal 1 = TPS
            {
                roleId = 1; // Admin TPS
            }
            else if (unitId == 2) // Misal 2 = TPA
            {
                roleId = 2; // Admin TPA
            }
            else
            {
                // Jika unit_id tidak dikenali, kita bisa kembalikan false atau gunakan role default
                Console.WriteLine("Unit ID tidak valid.");
                return false;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Masukkan data ke dalam tabel calonUser dengan role_id yang sudah ditentukan
                    string query = "INSERT INTO calonUser (name, username, password, unit_id, role_id, date_registered) " +
                                   "VALUES (@name, @username, @password, @unitId, @roleId, NOW())";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.Parameters.AddWithValue("unitId", unitId);
                        cmd.Parameters.AddWithValue("roleId", roleId); // Tambahkan role_id ke parameter
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // New Method: Get Pending Users
        public DataTable GetCalonUsers()
        {
            DataTable dataTable = new DataTable();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT calonuser_id, name, username, password, unit_id, role_id, date_registered FROM calonUser ORDER BY date_registered";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
            
        }

        // New Method: Get Approved Users
        public DataTable GetApprovedUsers()
        {
            DataTable dtUsers = new DataTable();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT nama, username, unit_id, role_id,created_at FROM users";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dtUsers);
                }
            }

            return dtUsers;
        }

        public bool ApproveUser(int calonUserId, string name, string username, string password, int roleId, int unitId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    using (var transaction = conn.BeginTransaction())
                    {
                        string insertUserQuery = "INSERT INTO users (nama, username, password, role_id, created_at, unit_id) VALUES (@name, @username, @password, @roleId, NOW(), @unitId)";
                        using (var cmd = new NpgsqlCommand(insertUserQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("name", name);
                            cmd.Parameters.AddWithValue("username", username);
                            cmd.Parameters.AddWithValue("password", password);
                            cmd.Parameters.AddWithValue("roleId", roleId);
                            cmd.Parameters.AddWithValue("unitId", unitId);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteCalonUserQuery = "DELETE FROM calonUser WHERE calonuser_id = @calonUserId";
                        using (var cmd = new NpgsqlCommand(deleteCalonUserQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("calonUserId", calonUserId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool DeleteCalonUser(int calonUserId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM calonUser WHERE calonuser_id = @calonUserId";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("calonUserId", calonUserId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public string GetUnitNameById(int unitId)
        {
            string unitName = "";
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT unit_name FROM units WHERE unit_id = @unitId";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("unitId", unitId);
                        unitName = cmd.ExecuteScalar()?.ToString() ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return unitName;
        }

        public UserData GetUserDataByUsername(string username)
        {
            UserData user = null;
            string query = "SELECT user_id, nama, username, unit_id, password, role_id FROM users WHERE username = @username";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserData
                            {
                                UserId = reader.GetInt32(reader.GetOrdinal("user_id")),
                                Nama = reader["nama"].ToString(),
                                Username = reader["username"].ToString(),
                                Password = reader["password"].ToString(),
                                UnitKerja = reader["unit_id"].ToString(),
                                Role = reader["role_id"].ToString()
                            };
                        }
                    }
                }
            }

            if (user == null)
            {
                Console.WriteLine("No user found with the username: " + username);
            }

            return user;
        }

        public bool IsUsernameUniqueForUpdate(string username, int currentUserId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Query untuk memeriksa apakah username sudah digunakan oleh pengguna lain
                    string query = @"SELECT COUNT(*) FROM users WHERE username = @username AND user_id != @currentUserId";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("currentUserId", currentUserId); // Mengecualikan user_id pengguna yang sedang login
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count == 0; // True jika username unik (tidak digunakan oleh pengguna lain)
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false; // Anggap username tidak unik jika terjadi kesalahan
            }
        }

        public int GetUnitIdByUsername(string username)
        {
            int unitId = -1;
            string query = "SELECT unit_id FROM users WHERE username = @username";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            unitId = reader.GetInt32(0);  // Mengambil unit_id dari hasil query
                        }
                    }
                }
            }

            if (unitId == -1)
            {
                Console.WriteLine("No unit_id found for username: " + username);
            }

            return unitId;
        }


        public UnitData GetUnitDetailsById(int unitId)
        {
            UnitData unitData = null;
            string query = "SELECT unit_name, unit_type, location, capacity FROM units WHERE unit_id = @unitId";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("unitId", unitId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            unitData = new UnitData
                            {
                                NamaUnit = reader["unit_name"].ToString(),
                                TipeUnit = reader["unit_type"].ToString(),
                                LokasiUnit = reader["location"].ToString(),
                                KapasitasUnit = reader["capacity"].ToString()
                            };
                        }
                    }
                }
            }

            if (unitData == null)
            {
                Console.WriteLine("No unit found with the unit ID: " + unitId);
            }

            return unitData;
        }

        public bool VerifyPassword(string username, string password)
        {
            bool isValid = false;
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    isValid = count > 0;
                }
            }

            return isValid;
        }

        public bool UpdateUserData(int userId, string nama, string unitId, string password, string username)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Query untuk update data pengguna berdasarkan user_id
                    string query = @"UPDATE users SET nama = @nama, unit_id = @unitId, password = @password, username = @username WHERE user_id = @userId";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("userId", userId);
                        cmd.Parameters.AddWithValue("nama", nama);
                        cmd.Parameters.AddWithValue("unitId", unitId);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.Parameters.AddWithValue("username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0; // True jika ada data yang di-update
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false; // False jika terjadi kesalahan
            }
        }

        internal object GetCalonUserData()
        {
            throw new NotImplementedException();
        }

        internal object GetUserData()
        {
            throw new NotImplementedException();
        }

        internal bool UpdateUserData(int userId, string nama, int unitId, string password, string username)
        {
            string query = "UPDATE users SET nama = @nama, unit_id = @unitId, password = @password, username = @username WHERE user_id = @userId";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("unitId", unitId);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("userId", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        internal bool UpdateUserData(object userId, string nama, object unitId, string password, object username)
        {
            string query = "UPDATE users SET nama = @nama, unit_id = @unitId, password = @password, username = @username WHERE user_id = @userId";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("unitId", Convert.ToInt32(unitId)); // Pastikan unitId dikonversi ke integer
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("userId", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
