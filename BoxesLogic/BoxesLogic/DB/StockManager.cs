using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxesDS
{
    public class StockManager
    {
        public static SortedDictionary<BoxKey, List<Box>> inventory = new SortedDictionary<BoxKey, List<Box>>();

        // Main Data Structure for organizing boxes based on their sizes. Effective solution based on balanced binary search (red-black tree).
        public static string FillInventory(double sizeX, double sizeY, int quantity) //Log(n)!
        {

            var settings = GlobalSettings.Instance;
            var sizeKey = new BoxKey(sizeX, sizeY);
            if (!inventory.ContainsKey(sizeKey))
            {
                inventory[sizeKey] = new List<Box>();
            }

            var existingBox = inventory[sizeKey].FirstOrDefault(box => box.Quantity < settings.MaxBoxQuantity);

            if (existingBox != null)
            {
                var spaceAvailable = settings.MaxBoxQuantity - existingBox.Quantity;
                if (spaceAvailable >= quantity)
                {
                    existingBox.Quantity += quantity;
                    return $"Successfully increased quantity by {quantity} for the existing box size: {existingBox}";
                }
                else
                {
                    existingBox.Quantity = settings.MaxBoxQuantity;
                    return $"Maximum quantity reached for box size: {existingBox}, box quantity was set to the maximum possible";
                }
            }
            else
            {
                var newBox = new Box(sizeX, sizeY);
                newBox.Quantity = Math.Min(quantity, settings.MaxBoxQuantity);
                inventory[sizeKey].Add(newBox);
                TimeManager.PurchaseHistory.Add(newBox); // Add to the Priority Queue

                if (newBox.Quantity >= settings.MaxBoxQuantity)
                {
                    return $"Maximum quantity reached for box size: {existingBox}, box quantity was set to the maximum possible";
                }
                else
                {
                    return $"Successfully added box size: {newBox} with quantity {newBox.Quantity}";
                }
            }
        }

    
        public static List<object> ConvertInventoryToList()
        {
            List<object> resultList = new List<object>();

            foreach (var entry in inventory)
            {
                foreach (var box in entry.Value)
                {
                    resultList.Add(new
                    {
                        SizeX = entry.Key.SizeX,
                        SizeY = entry.Key.SizeY,
                        Quantity = box.Quantity,
                        LastUsed = box.LastUsed
                    });
                }
            }

            return resultList;
        }



    }
}
