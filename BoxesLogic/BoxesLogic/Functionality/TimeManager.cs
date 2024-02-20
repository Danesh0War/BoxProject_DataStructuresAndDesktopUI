using System;
using System.Collections.Generic;

namespace BoxesDS
{
    // Serves as a separate structure for organizing boxes based on their 'LastUsed' property.
    // Combining the effectiveness of balanced search trees with query principles offers a straightforward solution for retrieving objects based on their usage history.

    public static class TimeManager  
    {
        public static SortedSet<Box> PurchaseHistory = new SortedSet<Box>(new BoxTimeComparer());

        // Event triggered when a time-sensitive action is completed.

        public static event EventHandler<ActionCompletedEventArgs> ActionCompleted;

        // Arguments for the ActionCompleted event.

        public class ActionCompletedEventArgs : EventArgs
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
        }



        public static List<Box> GetExpiredBoxes() 
        {
            List<Box> expiredBoxes = new List<Box>();
            var settings = GlobalSettings.Instance;

            foreach (var box in PurchaseHistory)
            {
                if (DateTime.Now - box.LastUsed > settings.BestBeforeDuration)
                {
                    expiredBoxes.Add(box);
                }
                else
                {
                    // As the set is sorted, I can break early.
                    break;
                }
            }
            return expiredBoxes;
        }

        public static void DeleteExpiredBoxes() 
        {
            var settings = GlobalSettings.Instance;
            List<Box> expiredBoxes = GetExpiredBoxes();

            string message;
            bool isSuccess = false;

            try
            {
                if (expiredBoxes == null || expiredBoxes.Count == 0)
                {
                    message = "No expired boxes to delete.";
                }
                else
                {
                    // Remove boxes from the PurchaseHistory set

                    foreach (var expiredBox in expiredBoxes) 
                    {
                        PurchaseHistory.Remove(expiredBox);
                    }

                    // Remove boxes from the main inventory.

                    foreach (var keyValuePair in StockManager.inventory)
                    {
                        var boxes = keyValuePair.Value;
                        boxes.RemoveAll(box => expiredBoxes.Contains(box));
                    }


                    isSuccess = true;
                    message = "Deletion of expired boxes complete.";
                }

            }
            catch (Exception ex)
            {
                LogManager.AddLog(ex);
                isSuccess = false;
                message = "An error occurred in the process.";
            }

            // Invoke the event.

            ActionCompleted?.Invoke(null, new ActionCompletedEventArgs
            {
                IsSuccess = isSuccess,
                Message = message
            });
        }


        // Updates the LastUsed property of a box and adjusts its position in PurchaseHistory.
        public static void UpdatePurcahseHistory(Box box)
        {
            // Create a temporary box with the old LastUsed date for accurate removal.
            var tempBox = box.Copy();  
            tempBox.LastUsed = box.LastUsed;

            // Remove old box
            TimeManager.PurchaseHistory.Remove(tempBox);

            // Update LastUsed and re-add the box.
            box.LastUsed = DateTime.Now;
            TimeManager.PurchaseHistory.Add(box);
        }


        // Custom comparer class for sorting boxes based on LastUsed property.

        public class BoxTimeComparer : IComparer<Box>
        {
            public int Compare(Box x, Box y)
            {
                return x.LastUsed.CompareTo(y.LastUsed);
            }
        }



    }
}
