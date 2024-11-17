using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA.Model
{
    public class TPSService
    {
        private string connectionString = DatabaseConfig.ConnectionString;

        public int GetUnitIdByUsername(string username)
        {
            int unitId = -1;
            string query = "SELECT unit_id FROM users WHERE username = @username";

            using (var conn = new NpgsqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            unitId = reader.GetInt32(0); // Ambil unit_id dari hasil query
                        }
                    }
                }
            }

            if (unitId == -1)
            {
                Console.WriteLine($"Tidak ada unit_id yang ditemukan untuk username: {username}");
            }

            return unitId;
        }

        public string GetUnitNameById(int unitId)
        {
            string unitName = null;
            string query = "SELECT unit_name FROM units WHERE unit_id = @UnitId AND unit_type = 'TPA'";

            using (var conn = new NpgsqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UnitId", unitId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            unitName = reader["unit_name"].ToString();
                            Console.WriteLine($"Unit ID: {unitId}, Unit Name: {unitName}"); // Debugging
                        }
                        else
                        {
                            Console.WriteLine($"Unit ID {unitId} tidak ditemukan sebagai TPA.");
                        }
                    }
                }
            }

            return unitName;
        }

        public DataTable GetAvailableWaste(int unitId)
        {
            string query = "SELECT * FROM wasteinventory WHERE unit_id = @unitId AND status_sampah = 'TPS'";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("unitId", unitId);
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        public DataTable GetWasteInventoryData(int unitId)
        {
            using (var conn = new NpgsqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM wasteinventory WHERE unit_id = @UnitId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UnitId", unitId);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetPickupRequestData(int tpsId)
        {
            using (var conn = new NpgsqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM pickuprequest WHERE tps_id = @TpsId AND status != 'Completed'";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TpsId", tpsId);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public Dictionary<string, int> GetStatistics(int unitId)
        {
            Dictionary<string, int> stats = new Dictionary<string, int>
    {
        { "BelumDiambil", 0 },
        { "SudahDiambil", 0 },
        { "TotalOrganik", 0 },
        { "TotalAnorganik", 0 },
        { "TotalB3", 0 },
        { "TotalHarian", 0 }
    };

            using (var conn = new NpgsqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                // Hitung data berdasarkan kategori
                string query = @"
            SELECT 
                SUM(CASE WHEN status = 'Pending' THEN berat ELSE 0 END) AS BelumDiambil,
                SUM(CASE WHEN status = 'Completed' THEN berat ELSE 0 END) AS SudahDiambil,
                SUM(CASE WHEN kategori = 'Organik' THEN berat ELSE 0 END) AS TotalOrganik,
                SUM(CASE WHEN kategori = 'Anorganik' THEN berat ELSE 0 END) AS TotalAnorganik,
                SUM(CASE WHEN kategori = 'B3' THEN berat ELSE 0 END) AS TotalB3,
                SUM(berat) AS TotalHarian
            FROM pickuprequest
            WHERE tps_id = @UnitId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UnitId", unitId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            stats["BelumDiambil"] = reader.GetInt32(0);
                            stats["SudahDiambil"] = reader.GetInt32(1);
                            stats["TotalOrganik"] = reader.GetInt32(2);
                            stats["TotalAnorganik"] = reader.GetInt32(3);
                            stats["TotalB3"] = reader.GetInt32(4);
                            stats["TotalHarian"] = reader.GetInt32(5);
                        }
                    }
                }
            }

            return stats;
        }

        public bool CreatePickupRequest(int tpsId, int tpaId, int inventoryId)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Masukkan data ke tabel PickupRequest
                        string insertPickupQuery = "INSERT INTO pickuprequest (tps_id, tpa_id, inventory_id, status) VALUES (@tpsId, @tpaId, @inventoryId, 'Pending')";
                        var cmdInsertPickup = new NpgsqlCommand(insertPickupQuery, conn);
                        cmdInsertPickup.Parameters.AddWithValue("tpsId", tpsId);
                        cmdInsertPickup.Parameters.AddWithValue("tpaId", tpaId);
                        cmdInsertPickup.Parameters.AddWithValue("inventoryId", inventoryId);
                        cmdInsertPickup.ExecuteNonQuery();

                        // Update status sampah di WasteInventory
                        string updateWasteQuery = "UPDATE wasteinventory SET status_sampah = 'Dalam Perjalanan' WHERE inventory_id = @inventoryId";
                        var cmdUpdateWaste = new NpgsqlCommand(updateWasteQuery, conn);
                        cmdUpdateWaste.Parameters.AddWithValue("inventoryId", inventoryId);
                        cmdUpdateWaste.ExecuteNonQuery();

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

        public bool AddWasteInventory(int unitId, string kategori, decimal berat)
        {
            string query = "INSERT INTO wasteinventory (unit_id, kategori, berat, tanggal_pembaruan) VALUES (@unitId, @kategori, @berat, CURRENT_TIMESTAMP)";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("unitId", unitId);
                    cmd.Parameters.AddWithValue("kategori", kategori);
                    cmd.Parameters.AddWithValue("berat", berat);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool AddPickupRequest(int tpsId, int tpaId, string kategori, decimal berat, int inventoryId)
        {
            string query = "INSERT INTO pickuprequest (tps_id, tpa_id, kategori, berat, status, tanggal_request, inventory_id) " +
                           "VALUES (@tpsId, @tpaId, @kategori, @berat, 'Pending', CURRENT_TIMESTAMP, @inventoryId)";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("tpsId", tpsId);
                    cmd.Parameters.AddWithValue("tpaId", tpaId);
                    cmd.Parameters.AddWithValue("kategori", kategori);
                    cmd.Parameters.AddWithValue("berat", berat);
                    cmd.Parameters.AddWithValue("inventoryId", inventoryId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateRequestStatus(int requestId, string newStatus)
        {
            string query = "UPDATE pickuprequest SET status = @newStatus WHERE request_id = @requestId";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("newStatus", newStatus);
                    cmd.Parameters.AddWithValue("requestId", requestId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteWasteInventory(int inventoryId)
        {
            string query = "DELETE FROM wasteinventory WHERE inventory_id = @inventoryId";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@inventoryId", inventoryId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        public bool IsWasteReferencedInRequest(int inventoryId)
        {
            string query = "SELECT COUNT(*) FROM pickuprequest WHERE inventory_id = @inventoryId";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@inventoryId", inventoryId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // True jika ada referensi
                }
            }
        }


        public DataTable GetTPAData()
        {
            DataTable tpaData = new DataTable();
            string query = "SELECT unit_id, unit_name, location, capacity FROM units WHERE unit_type = 'TPA'";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(tpaData);
                    }
                }
            }

            return tpaData;
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
                                UnitId = reader.GetInt32(0),
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


    }
}
