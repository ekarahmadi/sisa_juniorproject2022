using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA
{
    public class Request
    {
        public string RequestId { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public TPS Tps { get; set; }

        public Request(TPS tps)
        {
            RequestId = Guid.NewGuid().ToString();
            Tps = tps;
            Status = "Pending";
            Date = DateTime.Now;
        }

        public void UpdateRequestStatus(string newStatus)
        {
            Status = newStatus;
        }
    }


}
