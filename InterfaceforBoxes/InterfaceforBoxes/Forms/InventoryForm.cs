using System;
using System.Drawing;
using System.Windows.Forms;
using BoxesDS;

namespace InterfaceforBoxes
{
    // Responsible for Inventory status display
    public partial class InventoryForm : CustomForm // In this form we dynamically adjust Y position of the items based on the grid height (number of items in collections)
    {
        private MainForm mainForm;

        public InventoryForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            // Initial setups for UI components
            SetupAllBoxesGrid();
            SetupLabel();
            SetupExpiredBoxesGrid();
            SetupDeleteButton();
        }

        // Configure the DataGridView for displaying all boxes
        private void SetupAllBoxesGrid()
        {
            AllBoxesGrid.DataSource = StockManager.ConvertInventoryToList();
            AllBoxesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Calculate and set the height of the DataGridView based on the number of rows

            int rowHeight = AllBoxesGrid.RowTemplate.Height;
            int totalRowHeight = AllBoxesGrid.RowCount * rowHeight;

            AllBoxesGrid.Height = totalRowHeight + AllBoxesGrid.ColumnHeadersHeight + 2;
        }

        // Position the label for Expired Boxes section

        private void SetupLabel()
        {
            int labelY = AllBoxesGrid.Bottom + 10;
            ExpiredBoxesLab.Location = new Point(ExpiredBoxesLab.Location.X, labelY);
        }

        // Configure the DataGridView for displaying expired boxes

        private void SetupExpiredBoxesGrid()
        {
            ExpiredBoxesGrid.DataSource = TimeManager.GetExpiredBoxes();
            ExpiredBoxesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Calculate and set the height and position of the DataGridView

            int rowHeight = ExpiredBoxesGrid.RowTemplate.Height;
            int totalRowHeight = ExpiredBoxesGrid.RowCount * rowHeight;

            int labelBottom = ExpiredBoxesLab.Bottom;
            int distanceBetweenLabelAndGrid = 10;

            ExpiredBoxesGrid.Location = new Point(ExpiredBoxesGrid.Location.X, labelBottom + distanceBetweenLabelAndGrid);
            ExpiredBoxesGrid.Height = totalRowHeight + ExpiredBoxesGrid.ColumnHeadersHeight + 2;
        }

        // Position the button for deleting expired boxes

        private void SetupDeleteButton()
        {
            int centerX = (this.Width - DeleteExpiredBut.Width) / 2;
            DeleteExpiredBut.Location = new Point(centerX, ExpiredBoxesGrid.Bottom + 10);

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SetupAllBoxesGrid();
            SetupLabel();
            SetupExpiredBoxesGrid();
        }

        protected override void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        // Delete expired boxes and save the data when DeleteExpiredBut is clicked
        private void DeleteExpiredBut_Click(object sender, EventArgs e)
        {
            TimeManager.ActionCompleted += TimeManager_ActionCompleted;
            TimeManager.DeleteExpiredBoxes();
            FileManager.SaveData("Data", "Items.json");
        }

        // Update the UI and display a message upon completion of time-sensitive actions

        private void TimeManager_ActionCompleted(object sender, TimeManager.ActionCompletedEventArgs e)
        {
            MessageBox.Show(e.Message, e.IsSuccess ? "Action Completed" : "Action Failed", MessageBoxButtons.OK, e.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            // Refresh the data in the grids after the action
            SetupAllBoxesGrid();
            SetupLabel();
            SetupExpiredBoxesGrid();
            TimeManager.ActionCompleted -= TimeManager_ActionCompleted;
        }


    }
}
