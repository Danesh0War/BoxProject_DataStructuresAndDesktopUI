using System;
using System.Windows.Forms;
using BoxesDS;

namespace InterfaceforBoxes
{
    //Responsible for displaying and managing the global settings
    public partial class SettingsForm : CustomForm
    {
        private MainForm mainForm;

        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            InitializeFormFields();
            this.mainForm = mainForm;

        }

        private void InitializeFormFields()
        {
            // Setting up text fields with current global settings
            maxBoxQTXTField.Text = GlobalSettings.Instance.MaxBoxQuantity.ToString();
            minBoxQTXTField.Text = GlobalSettings.Instance.MinBoxQuantity.ToString();
            DispLimTXTField.Text = GlobalSettings.Instance.DispersionLimitPercent.ToString();

            // And For the ComboBox
            TimeUnitsComboB.DropDownStyle = ComboBoxStyle.DropDownList;
            TimeUnitsComboB.Items.Add("Minutes");
            TimeUnitsComboB.Items.Add("Hours");
            TimeUnitsComboB.Items.Add("Days");
            TimeUnitsComboB.SelectedIndex = 2; // By default set to "Days"

        }

        // Event handler for the Save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalSettings.Instance.MaxBoxQuantity = int.Parse(maxBoxQTXTField.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                GlobalSettings.Instance.MinBoxQuantity = int.Parse(minBoxQTXTField.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                GlobalSettings.Instance.DispersionLimitPercent = double.Parse(DispLimTXTField.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double timeValue;
            if (!double.TryParse(BestB4TXTField.Text, out timeValue))
            {
                MessageBox.Show("Invalid time value", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Determine the time unit and set the corresponding TimeSpan

                switch (TimeUnitsComboB.SelectedItem.ToString())
                {
                    case "Minutes":
                        GlobalSettings.Instance.BestBeforeDuration = TimeSpan.FromMinutes(timeValue);
                        break;
                    case "Hours":
                        GlobalSettings.Instance.BestBeforeDuration = TimeSpan.FromHours(timeValue);
                        break;
                    case "Days":
                        GlobalSettings.Instance.BestBeforeDuration = TimeSpan.FromDays(timeValue);
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Close the form if saving is successful
            this.Close();
        }


        protected override void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }


    }
}
