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
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=sisa_juniorproject";
        private static int? _currentUserId = null;
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

        public DataTable GetUnitDataByUsername(string username)
        {
            DataTable unitData = new DataTable();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT u.unit_name, u.unit_type, u.location, u.capacity
                FROM users AS usr
                JOIN units AS u ON usr.unit_id = u.unit_id
                WHERE usr.username = @username";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(unitData);
                    }
                }
            }

            return unitData;
        }

        public bool RegisterUser(string name, string username, string password, int unitId)
        {
            // Tentukan role_id berdasarkan tipe unit
            int roleId;
            string unitType = "";

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Ambil unit_type berdasarkan unitId dari tabel units
                    string unitTypeQuery = "SELECT unit_type FROM units WHERE unit_id = @unitId";
                    using (var unitTypeCmd = new NpgsqlCommand(unitTypeQuery, conn))
                    {
                        unitTypeCmd.Parameters.AddWithValue("unitId", unitId);
                        var result = unitTypeCmd.ExecuteScalar();

                        if (result != null)
                        {
                            unitType = result.ToString();
                        }
                        else
                        {
                            Console.WriteLine("Unit ID tidak valid.");
                            return false;
                        }
                    }

                    // Tentukan role_id berdasarkan unit_type
                    if (unitType == "TPS")
                    {
                        roleId = 1; // Admin TPS
                    }
                    else if (unitType == "TPA")
                    {
                        roleId = 2; // Admin TPA
                    }
                    else
                    {
                        Console.WriteLine("Tipe unit tidak dikenal.");
                        return false;
                    }

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
        public DataTable GetTPSData()
        {
            DataTable dataTable = new DataTable();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                // Query to fetch data from the TPSData table
                string query = "SELECT entry_number, massa_sampah, tipe_sampah FROM TPSData ORDER BY entry_number";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable); // Fill the DataTable with the query results
                }
            }

            return dataTable;
        }

        public bool AddTPSData(float massaSampah, char tipeSampah)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO TPSData (massa_sampah, tipe_sampah) VALUES (@massaSampah, @tipeSampah)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("massaSampah", massaSampah);
                    cmd.Parameters.AddWithValue("tipeSampah", tipeSampah);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteUser(int userId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM users WHERE user_id = @userId";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("userId", userId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }


        public bool UpdateTPSData(int entryNumber, float massaSampah, char tipeSampah)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE TPSData SET massa_sampah = @massaSampah, tipe_sampah = @tipeSampah WHERE entry_number = @entryNumber";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("entryNumber", entryNumber);
                    cmd.Parameters.AddWithValue("massaSampah", massaSampah);
                    cmd.Parameters.AddWithValue("tipeSampah", tipeSampah);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool AddOrder(int entryNumber)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Orders (entry_number) VALUES (@entryNumber)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("entryNumber", entryNumber);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool TransferDataToRiwayat(int entryNumber)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Start a transaction for atomic operations
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Copy data to Riwayat
                        string insertQuery = @"
                    INSERT INTO Riwayat (massa_sampah, tipe_sampah, transferred_date)
                    SELECT massa_sampah, tipe_sampah, CURRENT_TIMESTAMP 
                    FROM TPSData WHERE entry_number = @entryNumber";
                        using (var insertCmd = new NpgsqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("entryNumber", entryNumber);
                            insertCmd.ExecuteNonQuery();
                        }

                        // Delete data from TPSData
                        string deleteQuery = "DELETE FROM TPSData WHERE entry_number = @entryNumber";
                        using (var deleteCmd = new NpgsqlCommand(deleteQuery, conn))
                        {
                            deleteCmd.Parameters.AddWithValue("entryNumber", entryNumber);
                            deleteCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }



        // New Method: Get Approved Users
        public DataTable GetApprovedUsers()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT user_id, nama, username, unit_id, role_id, created_at FROM users";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
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

        public string GetOrderProcessStatus(int entryNumber)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT process FROM Orders WHERE entry_number = @entryNumber";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("entryNumber", entryNumber);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public bool CreateOrder(int entryNumber, int units_Id)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Orders (entry_number, units_id, process) VALUES (@entryNumber, @units_Id, 'Pending')";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("entryNumber", entryNumber);
                    cmd.Parameters.AddWithValue("units_Id", units_Id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public bool TransferOrderToRiwayat(int entryNumber)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Start a transaction to ensure atomicity
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Insert into `Riwayat` based on `entryNumber`
                        var insertCmdText = @"
                    INSERT INTO Riwayat (entry_number, massa_sampah, tipe_sampah, transferred_date)
                    SELECT entry_number, massa_sampah, tipe_sampah, CURRENT_TIMESTAMP
                    FROM TPSData
                    WHERE entry_number = @entryNumber";

                        using (var insertCmd = new NpgsqlCommand(insertCmdText, conn, transaction))
                        {
                            insertCmd.Parameters.AddWithValue("@entryNumber", entryNumber);
                            int rowsInserted = insertCmd.ExecuteNonQuery();

                            if (rowsInserted == 0)
                            {
                                // If no rows were inserted, it means the entry wasn't found
                                transaction.Rollback();
                                return false;
                            }
                        }

                        // Step 2: Delete from `Orders` based on `entryNumber`
                        var deleteCmdText = "DELETE FROM Orders WHERE entry_number = @entryNumber";
                        using (var deleteCmd = new NpgsqlCommand(deleteCmdText, conn, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@entryNumber", entryNumber);
                            deleteCmd.ExecuteNonQuery();
                        }

                        // Commit transaction if all commands succeeded
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction if an error occurred
                        transaction.Rollback();
                        MessageBox.Show("Error during transfer: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public DataTable GetRequestData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Updated query to include units_id
                var query = @"
            SELECT 
                order_id, 
                entry_number, 
                order_date, 
                units_id, 
                process 
            FROM Orders";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable requestData = new DataTable();
                        adapter.Fill(requestData);
                        return requestData;
                    }
                }
            }
        }


        public DataTable GetRiwayatData()
        {
            DataTable dataTable = new DataTable();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT entry_number, massa_sampah, tipe_sampah, transferred_date FROM Riwayat ORDER BY transferred_date DESC";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public DataTable GetManagedUnitByUsername(string username)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Assuming you have a table that links TPS managers to the units they manage
                var query = @"SELECT unit_name, unit_type, location, capacity
                      FROM TPSData
                      WHERE manager_username = @username";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable unitData = new DataTable();
                        adapter.Fill(unitData);
                        return unitData;
                    }
                }
            }
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

        public List<UnitData> GetAllUnits()
        {
            List<UnitData> units = new List<UnitData>();
            string query = "SELECT unit_id, unit_name, unit_type, location, capacity FROM units";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            units.Add(new UnitData
                            {
                                UnitId = reader.GetInt32(0), // Ambil unit_id dari database
                                NamaUnit = reader["unit_name"].ToString(),
                                TipeUnit = reader["unit_type"].ToString(),
                                LokasiUnit = reader["location"].ToString(),
                                KapasitasUnit = reader["capacity"].ToString()
                            });
                        }
                    }
                }
            }

            return units;
        }


        public void UpdateUnit(int unitId, UnitData updatedUnit)
        {
            string query = "UPDATE units SET unit_name = @unitName, unit_type = @unitType, location = @location, capacity = @capacity WHERE unit_id = @unitId";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("unitId", unitId);
                    cmd.Parameters.AddWithValue("unitName", updatedUnit.NamaUnit);
                    cmd.Parameters.AddWithValue("unitType", updatedUnit.TipeUnit);
                    cmd.Parameters.AddWithValue("location", updatedUnit.LokasiUnit);

                    // Pastikan kapasitas dikonversi ke integer
                    int kapasitas;
                    if (int.TryParse(updatedUnit.KapasitasUnit, out kapasitas))
                    {
                        cmd.Parameters.AddWithValue("capacity", kapasitas);
                    }
                    else
                    {
                        throw new InvalidOperationException("Kapasitas harus berupa angka yang valid.");
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void DeleteUnit(int unitId)
        {
            string query = "DELETE FROM units WHERE unit_id = @unitId";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("unitId", unitId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddUnit(UnitData newUnit)
        {
            string query = "INSERT INTO units (unit_name, unit_type, location, capacity) VALUES (@unitName, @unitType, @location, @capacity)";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("unitName", newUnit.NamaUnit);
                    cmd.Parameters.AddWithValue("unitType", newUnit.TipeUnit);
                    cmd.Parameters.AddWithValue("location", newUnit.LokasiUnit);

                    // Pastikan capacity dikonversi ke tipe integer
                    int kapasitas;
                    if (int.TryParse(newUnit.KapasitasUnit, out kapasitas))
                    {
                        cmd.Parameters.AddWithValue("capacity", kapasitas);
                    }
                    else
                    {
                        throw new InvalidOperationException("Kapasitas harus berupa angka yang valid.");
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateUser(int userId, string name, string username, int roleId, int unitId)
        {
            string query = "UPDATE public.users SET nama = @name, username = @username, role_id = @roleId, unit_id = @unitId WHERE user_id = @userId";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("userId", userId);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("roleId", roleId);
                    cmd.Parameters.AddWithValue("unitId", unitId);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public int GetUnitIdByName(string unitName)
        {
            int unitId = -1;
            string query = "SELECT unit_id FROM public.units WHERE unit_name = @unitName";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("unitName", unitName);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            unitId = reader.GetInt32(0); // Mengambil unit_id dari hasil query
                        }
                    }
                }
            }
            return unitId;
        }

        public int GetTotalUsers()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
        }

        public int GetTotalAccountRequests()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM calonuser";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
        }

        public int GetTotalUnitsByType(string unitType)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM units WHERE unit_type = @unitType";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("unitType", unitType);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
        }


    }

}
