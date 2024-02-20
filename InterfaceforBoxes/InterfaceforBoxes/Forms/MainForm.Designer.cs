namespace InterfaceforBoxes
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WelcomeLab = new System.Windows.Forms.Label();
            this.BuyBut = new System.Windows.Forms.Button();
            this.InventoryBut = new System.Windows.Forms.Button();
            this.SettingsBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLab
            // 
            this.WelcomeLab.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLab.ForeColor = System.Drawing.Color.Black;
            this.WelcomeLab.Location = new System.Drawing.Point(208, 26);
            this.WelcomeLab.Name = "WelcomeLab";
            this.WelcomeLab.Size = new System.Drawing.Size(422, 65);
            this.WelcomeLab.TabIndex = 0;
            this.WelcomeLab.Text = "Welcome to Boxfinder application";
            this.WelcomeLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyBut
            // 
            this.BuyBut.BackColor = System.Drawing.Color.Transparent;
            this.BuyBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuyBut.BackgroundImage")));
            this.BuyBut.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BuyBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BuyBut.FlatAppearance.BorderSize = 3;
            this.BuyBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BuyBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BuyBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyBut.ForeColor = System.Drawing.Color.Black;
            this.BuyBut.Location = new System.Drawing.Point(308, 94);
            this.BuyBut.Name = "BuyBut";
            this.BuyBut.Size = new System.Drawing.Size(181, 54);
            this.BuyBut.TabIndex = 1;
            this.BuyBut.Text = "Find the right box";
            this.BuyBut.UseVisualStyleBackColor = false;
            this.BuyBut.Click += new System.EventHandler(this.BuyMenu_Click);
            // 
            // InventoryBut
            // 
            this.InventoryBut.BackColor = System.Drawing.Color.Transparent;
            this.InventoryBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryBut.BackgroundImage")));
            this.InventoryBut.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.InventoryBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InventoryBut.FlatAppearance.BorderSize = 3;
            this.InventoryBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.InventoryBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.InventoryBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryBut.ForeColor = System.Drawing.Color.Black;
            this.InventoryBut.Location = new System.Drawing.Point(308, 271);
            this.InventoryBut.Name = "InventoryBut";
            this.InventoryBut.Size = new System.Drawing.Size(181, 54);
            this.InventoryBut.TabIndex = 3;
            this.InventoryBut.Text = "Inventory";
            this.InventoryBut.UseVisualStyleBackColor = false;
            this.InventoryBut.Click += new System.EventHandler(this.InventoryBut_Click);
            // 
            // SettingsBut
            // 
            this.SettingsBut.BackColor = System.Drawing.Color.Black;
            this.SettingsBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsBut.BackgroundImage")));
            this.SettingsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsBut.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.SettingsBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SettingsBut.FlatAppearance.BorderSize = 3;
            this.SettingsBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SettingsBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.SettingsBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBut.ForeColor = System.Drawing.Color.Black;
            this.SettingsBut.Location = new System.Drawing.Point(308, 367);
            this.SettingsBut.Name = "SettingsBut";
            this.SettingsBut.Size = new System.Drawing.Size(181, 54);
            this.SettingsBut.TabIndex = 4;
            this.SettingsBut.Text = "Settings";
            this.SettingsBut.UseVisualStyleBackColor = false;
            this.SettingsBut.Click += new System.EventHandler(this.SettingsBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.BackColor = System.Drawing.Color.Transparent;
            this.AddBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBut.BackgroundImage")));
            this.AddBut.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.AddBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddBut.FlatAppearance.BorderSize = 3;
            this.AddBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.AddBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBut.ForeColor = System.Drawing.Color.Black;
            this.AddBut.Location = new System.Drawing.Point(308, 182);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(181, 54);
            this.AddBut.TabIndex = 2;
            this.AddBut.Text = "Supply Box";
            this.AddBut.UseVisualStyleBackColor = false;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.SettingsBut);
            this.Controls.Add(this.InventoryBut);
            this.Controls.Add(this.BuyBut);
            this.Controls.Add(this.WelcomeLab);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.WelcomeLab, 0);
            this.Controls.SetChildIndex(this.BuyBut, 0);
            this.Controls.SetChildIndex(this.InventoryBut, 0);
            this.Controls.SetChildIndex(this.SettingsBut, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            this.Controls.SetChildIndex(this.AddBut, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLab;
        private System.Windows.Forms.Button BuyBut;
        private System.Windows.Forms.Button InventoryBut;
        private System.Windows.Forms.Button SettingsBut;
        private System.Windows.Forms.Button AddBut;
    }
}

