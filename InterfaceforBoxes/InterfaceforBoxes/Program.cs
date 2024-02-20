using System;
using System.Windows.Forms;
using BoxesDS;

namespace InterfaceforBoxes
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load, if there is any, previous data from a JSON file.
            FileManager.LoadData("Data", "Items.json");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
