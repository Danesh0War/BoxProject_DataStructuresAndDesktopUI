using System;
using System.IO;

namespace BoxesDS
{
    public class LogManager
    {

        public static void AddLog(Exception ex) // readable way for saving occured exceptions for code maintenance
        {
            string logsPath = FileManager.GetDataFilePath("Logs", "log.txt"); // Same path as program deployment folder, separate folder for logs.


            // Creating a formatted log entry with a timestamp and the exception details
            string logEntry = $"Timestamp: {DateTime.Now}\r\nException Type: {ex.GetType()}\r\nMessage: {ex.Message}\r\nStackTrace: {ex.StackTrace}\r\n---------------------------------------------------\r\n";

            // Appending the log entry to the existing log file
            File.AppendAllText(logsPath, logEntry);

        }


    }
}
