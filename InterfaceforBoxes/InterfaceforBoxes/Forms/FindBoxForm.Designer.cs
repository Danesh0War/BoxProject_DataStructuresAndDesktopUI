namespace InterfaceforBoxes
{
    partial class FindBoxForm
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
            this.FindBoxLab = new System.Windows.Forms.Label();
            this.SizeXTxtBox = new System.Windows.Forms.TextBox();
            this.SizeXLab = new System.Windows.Forms.Label();
            this.SizeYLab = new System.Windows.Forms.Label();
            this.SizeYTxtBox = new System.Windows.Forms.TextBox();
            this.QuantityLab = new System.Windows.Forms.Label();
            this.QuantityBoxUpDown = new System.Windows.Forms.NumericUpDown();
            this.SuitableBoxesGrid = new System.Windows.Forms.DataGridView();
            this.FindBoxBut = new System.Windows.Forms.Button();
            this.SuitableBoxesLab = new System.Windows.Forms.Label();
            this.ApplyBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBoxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuitableBoxesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FindBoxLab
            // 
            this.FindBoxLab.AutoSize = true;
            this.FindBoxLab.BackColor = System.Drawing.Color.Transparent;
            this.FindBoxLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBoxLab.Location = new System.Drawing.Point(225, 30);
            this.FindBoxLab.Name = "FindBoxLab";
            this.FindBoxLab.Size = new System.Drawing.Size(345, 31);
            this.FindBoxLab.TabIndex = 1;
            this.FindBoxLab.Text = "Find The Most Suitable Box";
            // 
            // SizeXTxtBox
            // 
            this.SizeXTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeXTxtBox.Location = new System.Drawing.Point(184, 119);
            this.SizeXTxtBox.Name = "SizeXTxtBox";
            this.SizeXTxtBox.Size = new System.Drawing.Size(100, 38);
            this.SizeXTxtBox.TabIndex = 1;
            // 
            // SizeXLab
            // 
            this.SizeXLab.AutoSize = true;
            this.SizeXLab.BackColor = System.Drawing.Color.Transparent;
            this.SizeXLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeXLab.Location = new System.Drawing.Point(30, 122);
            this.SizeXLab.Name = "SizeXLab";
            this.SizeXLab.Size = new System.Drawing.Size(148, 31);
            this.SizeXLab.TabIndex = 4;
            this.SizeXLab.Text = "Base (X*X)";
            // 
            // SizeYLab
            // 
            this.SizeYLab.AutoSize = true;
            this.SizeYLab.BackColor = System.Drawing.Color.Transparent;
            this.SizeYLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeYLab.Location = new System.Drawing.Point(30, 205);
            this.SizeYLab.Name = "SizeYLab";
            this.SizeYLab.Size = new System.Drawing.Size(136, 31);
            this.SizeYLab.TabIndex = 5;
            this.SizeYLab.Text = "Height (Y)";
            // 
            // SizeYTxtBox
            // 
            this.SizeYTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeYTxtBox.Location = new System.Drawing.Point(184, 205);
            this.SizeYTxtBox.Name = "SizeYTxtBox";
            this.SizeYTxtBox.Size = new System.Drawing.Size(100, 38);
            this.SizeYTxtBox.TabIndex = 2;
            // 
            // QuantityLab
            // 
            this.QuantityLab.AutoSize = true;
            this.QuantityLab.BackColor = System.Drawing.Color.Transparent;
            this.QuantityLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLab.Location = new System.Drawing.Point(30, 288);
            this.QuantityLab.Name = "QuantityLab";
            this.QuantityLab.Size = new System.Drawing.Size(116, 31);
            this.QuantityLab.TabIndex = 7;
            this.QuantityLab.Text = "Quantity";
            // 
            // QuantityBoxUpDown
            // 
            this.QuantityBoxUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityBoxUpDown.Location = new System.Drawing.Point(184, 288);
            this.QuantityBoxUpDown.Name = "QuantityBoxUpDown";
            this.QuantityBoxUpDown.Size = new System.Drawing.Size(100, 38);
            this.QuantityBoxUpDown.TabIndex = 3;
            // 
            // SuitableBoxesGrid
            // 
            this.SuitableBoxesGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SuitableBoxesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuitableBoxesGrid.Location = new System.Drawing.Point(368, 98);
            this.SuitableBoxesGrid.Name = "SuitableBoxesGrid";
            this.SuitableBoxesGrid.Size = new System.Drawing.Size(381, 306);
            this.SuitableBoxesGrid.TabIndex = 9;
            // 
            // FindBoxBut
            // 
            this.FindBoxBut.BackColor = System.Drawing.Color.Transparent;
            this.FindBoxBut.BackgroundImage = global::InterfaceforBoxes.Properties.Resources.BoxBackground;
            this.FindBoxBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBoxBut.Location = new System.Drawing.Point(32, 367);
            this.FindBoxBut.Name = "FindBoxBut";
            this.FindBoxBut.Size = new System.Drawing.Size(114, 37);
            this.FindBoxBut.TabIndex = 4;
            this.FindBoxBut.Text = "Find";
            this.FindBoxBut.UseVisualStyleBackColor = false;
            this.FindBoxBut.Click += new System.EventHandler(this.FindBoxBut_Click);
            // 
            // SuitableBoxesLab
            // 
            this.SuitableBoxesLab.AutoSize = true;
            this.SuitableBoxesLab.BackColor = System.Drawing.Color.Transparent;
            this.SuitableBoxesLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuitableBoxesLab.Location = new System.Drawing.Point(395, 69);
            this.SuitableBoxesLab.Name = "SuitableBoxesLab";
            this.SuitableBoxesLab.Size = new System.Drawing.Size(318, 26);
            this.SuitableBoxesLab.TabIndex = 12;
            this.SuitableBoxesLab.Text = "Within-Dispersion Boxes Result";
            // 
            // ApplyBut
            // 
            this.ApplyBut.BackColor = System.Drawing.Color.Transparent;
            this.ApplyBut.BackgroundImage = global::InterfaceforBoxes.Properties.Resources.BoxBackground;
            this.ApplyBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyBut.Location = new System.Drawing.Point(170, 367);
            this.ApplyBut.Name = "ApplyBut";
            this.ApplyBut.Size = new System.Drawing.Size(114, 37);
            this.ApplyBut.TabIndex = 14;
            this.ApplyBut.Text = "Apply";
            this.ApplyBut.UseVisualStyleBackColor = false;
            this.ApplyBut.Click += new System.EventHandler(this.ApplyBut_Click);
            // 
            // FindBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ApplyBut);
            this.Controls.Add(this.SuitableBoxesLab);
            this.Controls.Add(this.FindBoxBut);
            this.Controls.Add(this.SuitableBoxesGrid);
            this.Controls.Add(this.QuantityBoxUpDown);
            this.Controls.Add(this.QuantityLab);
            this.Controls.Add(this.SizeYTxtBox);
            this.Controls.Add(this.SizeYLab);
            this.Controls.Add(this.SizeXLab);
            this.Controls.Add(this.SizeXTxtBox);
            this.Controls.Add(this.FindBoxLab);
            this.Name = "FindBoxForm";
            this.Text = "FindBoxForm";
            this.Controls.SetChildIndex(this.FindBoxLab, 0);
            this.Controls.SetChildIndex(this.SizeXTxtBox, 0);
            this.Controls.SetChildIndex(this.SizeXLab, 0);
            this.Controls.SetChildIndex(this.SizeYLab, 0);
            this.Controls.SetChildIndex(this.SizeYTxtBox, 0);
            this.Controls.SetChildIndex(this.QuantityLab, 0);
            this.Controls.SetChildIndex(this.QuantityBoxUpDown, 0);
            this.Controls.SetChildIndex(this.SuitableBoxesGrid, 0);
            this.Controls.SetChildIndex(this.FindBoxBut, 0);
            this.Controls.SetChildIndex(this.SuitableBoxesLab, 0);
            this.Controls.SetChildIndex(this.ApplyBut, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBoxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuitableBoxesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FindBoxLab;
        private System.Windows.Forms.TextBox SizeXTxtBox;
        private System.Windows.Forms.Label SizeXLab;
        private System.Windows.Forms.Label SizeYLab;
        private System.Windows.Forms.TextBox SizeYTxtBox;
        private System.Windows.Forms.Label QuantityLab;
        private System.Windows.Forms.NumericUpDown QuantityBoxUpDown;
        private System.Windows.Forms.DataGridView SuitableBoxesGrid;
        private System.Windows.Forms.Button FindBoxBut;
        private System.Windows.Forms.Label SuitableBoxesLab;
        private System.Windows.Forms.Button ApplyBut;
    }
}