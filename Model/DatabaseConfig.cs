using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA.Model
{
    public static class DatabaseConfig
    {
        public static string ConnectionString { get; set; } = "Host=ep-wispy-pond-a1ytyuoa-pooler.ap-southeast-1.aws.neon.tech;Port=5432;Username=postgres;Password=SUs3p1zPDMKC;Database=sisa_juniorproject;";
    }
}
