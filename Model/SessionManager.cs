using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA.Model
{
    internal class SessionManager
    {
        // Menyimpan ID peran pengguna yang login, atau null jika tidak ada yang login
        public static int? RoleId { get; set; }

        // Menyimpan username pengguna yang login, atau null jika tidak ada yang login
        public static string Username { get; set; }

        // Menyimpan nama lengkap pengguna
        public static string FullName { get; set; }

        // Menyimpan unit kerja pengguna
        public static string UnitKerja { get; set; }

        // Fungsi untuk menghapus informasi sesi login
        public static void ClearSession()
        {
            RoleId = null;       // Hapus informasi role
            Username = null;      // Hapus informasi username
            FullName = null;      // Hapus informasi nama lengkap
            UnitKerja = null;     // Hapus informasi unit kerja
        }

        // Fungsi untuk memperbarui informasi sesi login
        public static void UpdateSession(string username, string fullName, string unitKerja, int? roleId)
        {
            Username = username;
            FullName = fullName;
            UnitKerja = unitKerja;
            RoleId = roleId;
        }
    }
}
