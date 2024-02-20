using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BoxesDS;
using BoxesLogic.Functionality;

namespace InterfaceforBoxes
{
    // Provides the UI functionalities for finding suitable boxes based on user input.

    public partial class FindBoxForm : CustomForm
    {
        private MainForm mainForm;
        private List<(Box, int)> foundBoxes = new List<(Box, int)>();    // to store the found boxes, either single or multiple


        public FindBoxForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

        }

        protected override void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        // Event handler for the "Find Box" button.

        private void FindBoxBut_Click(object sender, EventArgs e)
        {
            double giftSizeX, giftSizeY;
            int desiredQuantity = (int)QuantityBoxUpDown.Value;

            if (double.TryParse(SizeXTxtBox.Text, out giftSizeX) &&
                double.TryParse(SizeYTxtBox.Text, out giftSizeY))
            {

                // Call FindSuitableBox
                var multipleBoxResult = StockServises.FindSuitableBoxes(giftSizeX, giftSizeY, desiredQuantity);

                if (multipleBoxResult.IsComplete)
                {
                    foundBoxes.AddRange(multipleBoxResult.Result);
                    // Update the data source for SuitableBoxesGrid.
                    SuitableBoxesGrid.DataSource = null;
                    SuitableBoxesGrid.DataSource = multipleBoxResult.Result.Select(x => x.Item1).ToList();

                }

                MessageBox.Show(multipleBoxResult.Message, multipleBoxResult.IsComplete ? "Action Completed" : "Action Failed", MessageBoxButtons.OK, multipleBoxResult.IsComplete ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Please enter valid numbers for gift sizes and desired quantity.", "Action Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Event handler for the "Apply" button.
        private void ApplyBut_Click(object sender, EventArgs e)
        {
            if (foundBoxes.Count > 0)
            {
                var applyChangesResult = new StockServisesResult(foundBoxes, "Selected boxes", true);
                var applyMessage = applyChangesResult.ApplyChanges();

                MessageBox.Show(applyMessage, applyChangesResult.IsComplete ? "Action Completed" : "Action Failed", MessageBoxButtons.OK, applyChangesResult.IsComplete ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No boxes found or selected.", "Action Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Save the updated data (Will be reached only on success)

            FileManager.SaveData("Data", "Items.json");
            foundBoxes.Clear();
        }
    }
}
