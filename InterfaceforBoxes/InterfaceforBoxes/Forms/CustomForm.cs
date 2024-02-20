using System;
using System.Drawing;
using System.Windows.Forms;

namespace InterfaceforBoxes
{
    // CustomForm serves as a base class for all other forms in the application.
    // It sets a predefined pattern for background, window size, and includes a 'Back' button.

    public partial class CustomForm : Form 
    {
        // Declare backButton as a class-level field for all derived forms to use.
        protected Button backButton;

        public CustomForm()
        {
            InitializeComponent();
            // Setting the background image

            // Configure the background image and layout for the form. Using the binded resx for external resourses reuse

            this.BackgroundImage = InterfaceforBoxes.Resources.Resources.BoxBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Setting the form to be fixed in size
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Setting the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Creating the backButton and configure it
            backButton = new Button();
            backButton.Name = "backButton"; // Set the name
            backButton.Text = "Back";
            backButton.BackgroundImage = Resources.Resources.BoxBackground;
            backButton.Location = new Point(10, 10);
            backButton.Click += BackButton_Click;

            // Adding the backButton to the controls collection
            this.Controls.Add(backButton);
        }

        public void ToggleBackButtonVisibility(bool isVisible) //  Visibility will be defined in the deriving classes
        {
            if (backButton != null)
            {
                backButton.Visible = isVisible;
            }
        }


        protected virtual void BackButton_Click(object sender, EventArgs e) // Functionality will be defined in the deriving classes
        {
        }
    }
}
