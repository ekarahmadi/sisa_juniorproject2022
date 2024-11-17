using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA.Model
{
    public class UserData
    {
        public string UserID { get; set; }
        public object UserId { get; internal set; }
        public string Nama { get; set; }
        public string Username { get; set; }
        public string UnitKerja { get; set; }
        public string Role { get; set; }
        public string Password { get; internal set; }
    }
}
