using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace BoxesDS
{
    public static class FileManager // Program Input/Ouput data lifecycle
    {
        public static string GetDataFilePath(string foulder, string fileName) // Allows specifying a folder inside the solution (deployment) and the file type within the folder.

        {
            // Get the base directory of the application
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the base directory with the relative path
            string dataDirectory = Path.Combine(baseDirectory, foulder);

            // Ensure the Data directory exists, and create it if it doesn't
            if (!Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
            }


            // Combine the Data directory path with the file name
            string dataFilePath = Path.Combine(dataDirectory, fileName);
            return dataFilePath;
        }

        //Neccessary because I have pairs KEY,VALUE
        static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            Converters = new List<JsonConverter> { new BoxKeyConverter() }
        };


        public static void SaveData(string folder, string fileName)
        {
            try // Here we define what is key and what is value for the successfull serialization
            {
                var keyValuePairs = StockManager.inventory.Select(kvp => new
                {
                    Key = kvp.Key,
                    Value = kvp.Value
                }).ToList();
                string jsonData = JsonConvert.SerializeObject(keyValuePairs, settings);
                File.WriteAllText(GetDataFilePath(folder, fileName), jsonData);
            }
            catch (Exception ex)
            {
                LogManager.AddLog(ex);
                Console.WriteLine($"An error occurred while saving data: {ex.Message}");
            }
        }


        public static void LoadData(string folder, string fileName)
        {
            try
            {
                string filePath = GetDataFilePath(folder, fileName);
                if (File.Exists(filePath))
                {
                    string jsonData = File.ReadAllText(filePath);
                    var keyValuePairs = JsonConvert.DeserializeObject<List<KeyValuePair<BoxKey, List<Box>>>>(jsonData, settings);
                    StockManager.inventory = new SortedDictionary<BoxKey, List<Box>>(keyValuePairs.ToDictionary(kvp => kvp.Key, kvp => kvp.Value));

                    TimeManager.PurchaseHistory.Clear();
                    foreach (var kvp in StockManager.inventory)
                    {
                        foreach (var box in kvp.Value)
                        {
                            if (box.LastUsed != default(DateTime))
                            {
                                TimeManager.PurchaseHistory.Add(box);
                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                LogManager.AddLog(ex);
                Console.WriteLine($"An error occurred while loading data: {ex.Message}");
            }
        }




        
    }
}
