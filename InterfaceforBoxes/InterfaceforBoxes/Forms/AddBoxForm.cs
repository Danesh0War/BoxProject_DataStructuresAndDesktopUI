using System;
using System.Windows.Forms;
using BoxesDS;

namespace InterfaceforBoxes
{
    // Responsible for adding new boxes to the inventory.

    public partial class AddBoxForm : CustomForm
    {
        private MainForm mainForm;

        public AddBoxForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

        }

        // Event handler for the "Confirm Add Box" button click event.

        private void ConfirmAddBoxBut_Click(object sender, EventArgs e)
        {
            try
            {
                double sizeX = double.Parse(SizeXTxtBox.Text);
                double sizeY = double.Parse(SizeYTxtBox.Text);
                int quantity = (int)QuantityBoxUpDown.Value;

                // Attempt to add new boxes to the inventory and get the result message.
                string result = StockManager.FillInventory(sizeX, sizeY, quantity);

                // Show the operation result in a message box.
                MessageBox.Show(result, "Operation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Save updated inventory data (Will be reached only on success)
                FileManager.SaveData("Data", "Items.json");

            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

    }
}
