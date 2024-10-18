using System;

namespace SISA
{
    public class Request
    {
        public int RequestId { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string WasteType { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }  // ID of the user who created the request

        public Request(int requestId, string status, DateTime date, string wasteType, int quantity, int userId)
        {
            RequestId = requestId;
            Status = status;
            Date = date;
            WasteType = wasteType;
            Quantity = quantity;
            UserId = userId;
        }

        public void DisplayRequestInfo()
        {
            Console.WriteLine($"Request ID: {RequestId}, Status: {Status}, Date: {Date}, Waste Type: {WasteType}, Quantity: {Quantity}");
        }
    }
}
