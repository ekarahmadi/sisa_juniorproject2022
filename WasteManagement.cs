using System;

namespace SISA
{
    public class WasteManagement
    {
        public int WasteId { get; set; }
        public string WasteType { get; set; }
        public double Quantity { get; set; }
        public string Location { get; set; }
        public string ProcessingStatus { get; set; }
        public DateTime PickupDate { get; set; }
        public int TpsId { get; set; }  // Associated TPS ID

        public WasteManagement(int wasteId, string wasteType, double quantity, string location, string processingStatus, DateTime pickupDate, int tpsId)
        {
            WasteId = wasteId;
            WasteType = wasteType;
            Quantity = quantity;
            Location = location;
            ProcessingStatus = processingStatus;
            PickupDate = pickupDate;
            TpsId = tpsId;
        }
    }
}
