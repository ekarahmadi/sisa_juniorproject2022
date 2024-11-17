using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA.Model
{
    public static class DatabaseConfig
    {
        public static string ConnectionString { get; set; } = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=sisa_juniorproject;";
    }
}
