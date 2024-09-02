using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA
{
    public class WasteManager : User
    {
        public WasteManager(string username, string password) : base(username, password)
        {
        }

        public void ReviewTPSData(TPS tps)
        {
            // Logic to review TPS data
        }

        public bool PerformQualityCheck(TPS tps)
        {
            // Logic to perform quality check
            return true;
        }

        public void ManageWasteReports()
        {
            // Logic to manage waste reports
        }
    }


}
