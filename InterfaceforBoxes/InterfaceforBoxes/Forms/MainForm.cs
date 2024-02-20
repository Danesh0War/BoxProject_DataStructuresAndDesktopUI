using System;


namespace InterfaceforBoxes
{
    public partial class MainForm : CustomForm
    {
        //Responsible for navigating user to the right section
        public MainForm()
        {
            InitializeComponent();

            // Hide the back button as this is the main form and there's nowhere to go back to
            ToggleBackButtonVisibility(false);

        }

        private void BuyMenu_Click(object sender, EventArgs e)
        {
            FindBoxForm findBoxForm = new FindBoxForm(this);
            findBoxForm.ShowDialog(); 
        }

        private void InventoryBut_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(this);
            inventoryForm.ShowDialog();

        }

        private void SettingsBut_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();

        }


        private void AddBut_Click(object sender, EventArgs e)
        {
            AddBoxForm addBoxForm = new AddBoxForm(this);
            addBoxForm.ShowDialog();
        }
    }
}
