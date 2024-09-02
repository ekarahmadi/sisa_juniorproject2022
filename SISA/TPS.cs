using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA
{
    public class TPS
    {
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string WasteType { get; set; }

        public TPS(string location, int capacity, string wasteType)
        {
            Location = location;
            Capacity = capacity;
            WasteType = wasteType;
        }
    }

}
