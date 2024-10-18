using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA
{
    public class TPSManager : User
    {
        public TPSManager(string username, string password) : base(username, password)
        {
        }

        public void AddTPS(string location, int capacity, string wasteType)
        {
            // Logic to add TPS
        }

        public void EditTPS(string id, string newLocation, int newCapacity, string newWasteType)
        {
            // Logic to edit TPS
        }
    }

}

