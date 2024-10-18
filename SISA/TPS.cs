using System;
using System.Collections.Generic;

namespace SISA
{
    public class TPS
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string WasteType { get; set; }
        public List<Request> Requests { get; private set; }  // Requests associated with this TPS

        public TPS(int id, string location, int capacity, string wasteType)
        {
            Id = id;
            Location = location;
            Capacity = capacity;
            WasteType = wasteType;
            Requests = new List<Request>();  // Initialize the list of requests
        }

        // Method to add a new request to the TPS
        public void AddRequest(Request newRequest)
        {
            Requests.Add(newRequest);
            Console.WriteLine($"New request with ID {newRequest.RequestId} added to TPS {Location}.");
        }

        // Method to view all requests for the TPS
        public void ViewAllRequests()
        {
            Console.WriteLine($"Requests for TPS {Location}:");
            foreach (var request in Requests)
            {
                request.DisplayRequestInfo();
            }
        }

        // Method to find a specific request by ID
        public Request FindRequestById(int requestId)
        {
            return Requests.Find(r => r.RequestId == requestId);
        }
    }
}
