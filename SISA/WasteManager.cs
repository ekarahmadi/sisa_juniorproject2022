using System;
using System.Collections.Generic;

namespace SISA
{
    public class WasteManager : User
    {
        public WasteManager(string username, string password) : base(username, password)
        {
        }

        // View pickup history from the WasteManagement data
        public void ViewPickupHistory(List<WasteManagement> wasteHistory)
        {
            Console.WriteLine("Waste Pickup History:");
            foreach (var waste in wasteHistory)
            {
                Console.WriteLine($"Waste ID: {waste.WasteId}, Type: {waste.WasteType}, Quantity: {waste.Quantity}, Pickup Date: {waste.PickupDate}, Location: {waste.Location}");
            }
        }

        // Display statistics of waste managed within the system
        public void ViewWasteStatistics(List<WasteManagement> wasteData)
        {
            double totalWaste = 0;
            var groupedByType = new Dictionary<string, double>();

            // Calculate total waste and group by waste type
            foreach (var waste in wasteData)
            {
                totalWaste += waste.Quantity;

                if (groupedByType.ContainsKey(waste.WasteType))
                {
                    groupedByType[waste.WasteType] += waste.Quantity;
                }
                else
                {


