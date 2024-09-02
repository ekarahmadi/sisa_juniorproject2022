using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA
{
    public class Administrator : User
    {
        public Administrator(string username, string password) : base(username, password)
        {
        }

        public void AddWasteManagementPartner(string partnerName, string partnerDetails)
        {
            // Logic to add waste management partner
        }

        public void EditWasteManagementPartner(string partnerId, string newDetails)
        {
            // Logic to edit waste management partner details
        }
    }

}
