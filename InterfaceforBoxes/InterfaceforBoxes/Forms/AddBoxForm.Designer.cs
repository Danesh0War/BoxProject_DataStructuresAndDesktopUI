namespace InterfaceforBoxes
{
    partial class AddBoxForm
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
            this.SizeXTxtBox = new System.Windows.Forms.TextBox();
            this.AddBoxLab = new System.Windows.Forms.Label();
            this.SizeXLab = new System.Windows.Forms.Label();
            this.SizeYLab = new System.Windows.Forms.Label();
            this.SizeYTxtBox = new System.Windows.Forms.TextBox();
            this.QuantityBoxUpDown = new System.Windows.Forms.NumericUpDown();
            this.QuantityLab = new System.Windows.Forms.Label();
            this.ConfirmAddBoxBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBoxUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SizeXTxtBox
            // 
            this.SizeXTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeXTxtBox.Location = new System.Drawing.Point(235, 146);
            this.SizeXTxtBox.Name = "SizeXTxtBox";
            this.SizeXTxtBox.Size = new System.Drawing.Size(100, 38);
            this.SizeXTxtBox.TabIndex = 1;
            // 
            // AddBoxLab
            // 
            this.AddBoxLab.AutoSize = true;
            this.AddBoxLab.BackColor = System.Drawing.Color.Transparent;
            this.AddBoxLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBoxLab.Location = new System.Drawing.Point(228, 56);
            this.AddBoxLab.Name = "AddBoxLab";
            this.AddBoxLab.Size = new System.Drawing.Size(384, 39);
            this.AddBoxLab.TabIndex = 2;
            this.AddBoxLab.Text = "Supply Of The New Box";
            // 
            // SizeXLab
            // 
            this.SizeXLab.AutoSize = true;
            this.SizeXLab.BackColor = System.Drawing.Color.Transparent;
            this.SizeXLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeXLab.Location = new System.Drawing.Point(81, 149);
            this.SizeXLab.Name = "SizeXLab";
            this.SizeXLab.Size = new System.Drawing.Size(148, 31);
            this.SizeXLab.TabIndex = 3;
            this.SizeXLab.Text = "Base (X*X)";
            // 
            // SizeYLab
            // 
            this.SizeYLab.AutoSize = true;
            this.SizeYLab.BackColor = System.Drawing.Color.Transparent;
            this.SizeYLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeYLab.Location = new System.Drawing.Point(81, 217);
            this.SizeYLab.Name = "SizeYLab";
            this.SizeYLab.Size = new System.Drawing.Size(136, 31);
            this.SizeYLab.TabIndex = 4;
            this.SizeYLab.Text = "Height (Y)";
            // 
            // SizeYTxtBox
            // 
            this.SizeYTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeYTxtBox.Location = new System.Drawing.Point(235, 214);
            this.SizeYTxtBox.Name = "SizeYTxtBox";
            this.SizeYTxtBox.Size = new System.Drawing.Size(100, 38);
            this.SizeYTxtBox.TabIndex = 5;
            // 
            // QuantityBoxUpDown
            // 
            this.QuantityBoxUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityBoxUpDown.Location = new System.Drawing.Point(235, 287);
            this.QuantityBoxUpDown.Name = "QuantityBoxUpDown";
            this.QuantityBoxUpDown.Size = new System.Drawing.Size(100, 38);
            this.QuantityBoxUpDown.TabIndex = 6;
            // 
            // QuantityLab
            // 
            this.QuantityLab.AutoSize = true;
            this.QuantityLab.BackColor = System.Drawing.Color.Transparent;
            this.QuantityLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLab.Location = new System.Drawing.Point(81, 289);
            this.QuantityLab.Name = "QuantityLab";
            this.QuantityLab.Size = new System.Drawing.Size(116, 31);
            this.QuantityLab.TabIndex = 7;
            this.QuantityLab.Text = "Quantity";
            // 
            // ConfirmAddBoxBut
            // 
            this.ConfirmAddBoxBut.BackgroundImage = global::InterfaceforBoxes.Properties.Resources.BoxBackground;
            this.ConfirmAddBoxBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmAddBoxBut.Location = new System.Drawing.Point(397, 146);
            this.ConfirmAddBoxBut.Name = "ConfirmAddBoxBut";
            this.ConfirmAddBoxBut.Size = new System.Drawing.Size(252, 179);
            this.ConfirmAddBoxBut.TabIndex = 8;
            this.ConfirmAddBoxBut.Text = "Confirm";
            this.ConfirmAddBoxBut.UseVisualStyleBackColor = true;
            this.ConfirmAddBoxBut.Click += new System.EventHandler(this.ConfirmAddBoxBut_Click);
            // 
            // AddBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmAddBoxBut);
            this.Controls.Add(this.QuantityLab);
            this.Controls.Add(this.QuantityBoxUpDown);
            this.Controls.Add(this.SizeYTxtBox);
            this.Controls.Add(this.SizeYLab);
            this.Controls.Add(this.SizeXLab);
            this.Controls.Add(this.AddBoxLab);
            this.Controls.Add(this.SizeXTxtBox);
            this.Name = "AddBoxForm";
            this.Text = "AddBoxForm";
            this.Controls.SetChildIndex(this.backButton, 0);
            this.Controls.SetChildIndex(this.SizeXTxtBox, 0);
            this.Controls.SetChildIndex(this.AddBoxLab, 0);
            this.Controls.SetChildIndex(this.SizeXLab, 0);
            this.Controls.SetChildIndex(this.SizeYLab, 0);
            this.Controls.SetChildIndex(this.SizeYTxtBox, 0);
            this.Controls.SetChildIndex(this.QuantityBoxUpDown, 0);
            this.Controls.SetChildIndex(this.QuantityLab, 0);
            this.Controls.SetChildIndex(this.ConfirmAddBoxBut, 0);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBoxUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SizeXTxtBox;
        private System.Windows.Forms.Label AddBoxLab;
        private System.Windows.Forms.Label SizeXLab;
        private System.Windows.Forms.Label SizeYLab;
        private System.Windows.Forms.TextBox SizeYTxtBox;
        private System.Windows.Forms.NumericUpDown QuantityBoxUpDown;
        private System.Windows.Forms.Label QuantityLab;
        private System.Windows.Forms.Button ConfirmAddBoxBut;
    }
}