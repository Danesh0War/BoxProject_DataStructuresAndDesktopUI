using System;
using System.Collections.Generic;
using System.Linq;
using BoxesLogic.Functionality;

namespace BoxesDS
{
    public class StockServises // Finding the suitable box
    {

        public static StockServisesResult FindSuitableBoxes(double giftSizeX, double giftSizeY, int desiredQuantity) // Function effectively returns THE MOST suitable boxes as well as their quantities - already the final needed list which satisfy the general quantity requirements
        {
            try
            {
                var settings = GlobalSettings.Instance;

                Box validationBox = new Box(giftSizeX, giftSizeY);
                validationBox.SizeX = giftSizeX;
                validationBox.SizeY = giftSizeY;
                validationBox.Quantity = desiredQuantity-1;

                //Create a subset of all boxes that are available and bigger
                var allSuitableBoxes = StockManager.inventory.Where(kv => kv.Value.Any(box => box.Quantity > 0 && box.SizeX >= giftSizeX && box.SizeY >= giftSizeY))
                                              .SelectMany(kv => kv.Value).ToList();

                var selectedBoxes = new List<(Box, int)>();
                // Order subset by Euclidean distance and start fulfilling the requirement only from the most suitable boxes!
                foreach (var box in allSuitableBoxes.OrderBy(box => Math.Sqrt(Math.Pow(box.SizeX - giftSizeX, 2) + Math.Pow(box.SizeY - giftSizeY, 2))))
                {
                    if (desiredQuantity <= 0)
                    {
                        break;
                    }
                    // If we have defined dispersion limit, check the box before adding it to the result list
                    if ((box.SizeX <= giftSizeX + giftSizeX * (1 + settings.DispersionLimitPercent / 100)) &&
                        (box.SizeY <= giftSizeY + giftSizeY * (1 + settings.DispersionLimitPercent / 100)))
                    {
                        var takeQuantity = Math.Min(box.Quantity, desiredQuantity);
                        selectedBoxes.Add((box, takeQuantity));
                        desiredQuantity -= takeQuantity;
                    }
                }

                if (selectedBoxes.Count > 0 && desiredQuantity <= 0)
                {
                    return new StockServisesResult(selectedBoxes, "Suitable boxes found.", true);
                }

                return new StockServisesResult(null, "No suitable boxes found.", false);
            }
            catch (ArgumentException e)
            {
               return new StockServisesResult(null, e.Message, false);
            }
        }



    }



}

