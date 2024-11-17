using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA.Model
{
    public static class DataHelper
    {
        public static int SafeConvertToInt(object value)
        {
            return value != DBNull.Value ? Convert.ToInt32(value) : 0;
        }

        public static string SafeConvertToString(object value)
        {
            return value != DBNull.Value ? value.ToString() : string.Empty;
        }
    }
}
