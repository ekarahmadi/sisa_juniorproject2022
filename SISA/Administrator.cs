using System;
using System.Collections.Generic;

namespace SISA
{
    public class Administrator : User
    {
        // Store multiple TPS locations and waste partners
        private List<TPS> tpsList;
        private List<WasteManagement> partnerList;

        public Administrator(string username, string password) : base(username, password)
        {
            tpsList = new List<TPS>();
            partnerList = new List<WasteManagement>();
        }

        public override void ProcessWasteReport()
        {
            Console.WriteLine($"Administrator {Username} is reviewing the overall waste reports.");
        }

        // Add TPS Location
        public void AddTPS(TPS newTps)
        {
            tpsList.Add(newTps);
            Console.WriteLine($"TPS at {newTps.Location} has been added.");
        }

        // View all TPS Locations
        public void ViewAllTPS()
        {
            Console.WriteLine("List of TPS Locations:");
            foreach (var tps in tpsList)
            {
                Console.WriteLine($"ID: {tps.Id}, Location: {tps.Location}, Capacity: {tps.Capacity}, Waste Type: {tps.WasteType}");
            }
        }

        // Add a Waste Management Partner
        public void AddWasteManagementPartner(WasteManagement newPartner)
        {
            partnerList.Add(newPartner);
            Console.WriteLine($"Partner {newPartner.Name} has been added.");
        }

        // View all Waste Management Partners
        public void ViewAllPartners()
        {
            Console.WriteLine("List of Waste Management Partners:");
            foreach (var partner in partnerList)
            {
                Console.WriteLine($"ID: {partner.Id}, Name: {partner.Name}, Details: {partner.Details}");
            }
        }

        // Check Data Inside a Specific TPS Location
        public void CheckTPSData(int tpsId)
        {
            var tps = tpsList.Find(t => t.Id == tpsId);
            if (tps != null)
            {
                Console.WriteLine($"TPS Data: ID: {tps.Id}, Location: {tps.Location}, Capacity: {tps.Capacity}, Waste Type: {tps.WasteType}");
            }
            else
            {
                Console.WriteLine("TPS not found.");
            }
        }
    }
}
