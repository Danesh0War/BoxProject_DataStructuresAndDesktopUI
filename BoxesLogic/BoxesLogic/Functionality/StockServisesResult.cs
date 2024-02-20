
using System.Collections.Generic;
using System.Linq;
using BoxesDS;

namespace BoxesLogic.Functionality
{
    public class StockServisesResult // Main handling output. Used custom data output type to save the used quantity for each box and return more information on function processes for UI!
    {
        public List<(Box, int)> Result { get; set; }
        public string Message { get; set; }
        public bool IsComplete { get; set; }


        public StockServisesResult(List<(Box, int)> result, string message, bool isComplete)
        {
            Result = result;
            Message = message;
            IsComplete = isComplete;
        }


        public string ApplyChanges() // This function has been separeted from the findfunction for single-responsibility prencipe. Function is binded to apply button to a
        {
            string message = string.Empty;
            var settings = GlobalSettings.Instance;

            if (Result != null && Result.Count > 0 && IsComplete)
            {
                foreach (var (box, quantity) in Result)
                {
                    var key = new BoxKey(box.SizeX, box.SizeY);
                    var inventoryBox = StockManager.inventory[key].FirstOrDefault(b => b.SizeX == box.SizeX && b.SizeY == box.SizeY);

                    if (inventoryBox != null)
                    {
                        // Check if decrementing will drop the quantity below the minimum limit
                        if (inventoryBox.Quantity - quantity < settings.MinBoxQuantity)
                        {
                            return "Cannot apply changes. Decrementing will drop the quantity below minimum limit.";
                        }

                        // Decrement the quantity
                        inventoryBox.Quantity -= quantity;

                        // If the quantity reaches zero, remove the box from the list
                        if (inventoryBox.Quantity <= 0)
                        {
                            StockManager.inventory[key].Remove(inventoryBox);

                            // If the list for this key is empty, optionally remove the key from the dictionary
                            if (!StockManager.inventory[key].Any())
                            {
                                StockManager.inventory.Remove(key);
                            }
                        }

                        // Update the purchase history
                        TimeManager.UpdatePurcahseHistory(inventoryBox);
                    }
                }

                return "Changes successfully applied.";
            }
            else
            {
                return "Cannot apply changes. List is either null or incomplete.";
            }
        }


    }
}
