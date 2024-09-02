using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA
{
    public class QualityCheck
    {
        public string CheckId { get; set; }
        public TPS Tps { get; set; }
        public bool IsValid { get; set; }

        public QualityCheck(TPS tps)
        {
            CheckId = Guid.NewGuid().ToString();
            Tps = tps;
            IsValid = false;
        }

        public void Validate()
        {
            // Logic to validate TPS
            IsValid = true;
        }
    }

}
