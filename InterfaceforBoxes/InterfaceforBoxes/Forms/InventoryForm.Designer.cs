namespace InterfaceforBoxes
{
    partial class InventoryForm
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
            this.AllBoxesGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpiredBoxesGrid = new System.Windows.Forms.DataGridView();
            this.ExpiredBoxesLab = new System.Windows.Forms.Label();
            this.DeleteExpiredBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllBoxesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiredBoxesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBoxesGrid
            // 
            this.AllBoxesGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.AllBoxesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBoxesGrid.Location = new System.Drawing.Point(12, 60);
            this.AllBoxesGrid.Name = "AllBoxesGrid";
            this.AllBoxesGrid.Size = new System.Drawing.Size(776, 92);
            this.AllBoxesGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "All the Existing Boxes ";
            // 
            // ExpiredBoxesGrid
            // 
            this.ExpiredBoxesGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExpiredBoxesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpiredBoxesGrid.Location = new System.Drawing.Point(12, 225);
            this.ExpiredBoxesGrid.Name = "ExpiredBoxesGrid";
            this.ExpiredBoxesGrid.Size = new System.Drawing.Size(776, 95);
            this.ExpiredBoxesGrid.TabIndex = 2;
            // 
            // ExpiredBoxesLab
            // 
            this.ExpiredBoxesLab.BackColor = System.Drawing.Color.Transparent;
            this.ExpiredBoxesLab.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiredBoxesLab.Location = new System.Drawing.Point(327, 182);
            this.ExpiredBoxesLab.Name = "ExpiredBoxesLab";
            this.ExpiredBoxesLab.Size = new System.Drawing.Size(173, 31);
            this.ExpiredBoxesLab.TabIndex = 3;
            this.ExpiredBoxesLab.Text = "ExpiredBoxes";
            // 
            // DeleteExpiredBut
            // 
            this.DeleteExpiredBut.BackColor = System.Drawing.Color.Transparent;
            this.DeleteExpiredBut.BackgroundImage = global::InterfaceforBoxes.Properties.Resources.BoxBackground;
            this.DeleteExpiredBut.Location = new System.Drawing.Point(333, 344);
            this.DeleteExpiredBut.Name = "DeleteExpiredBut";
            this.DeleteExpiredBut.Size = new System.Drawing.Size(146, 37);
            this.DeleteExpiredBut.TabIndex = 4;
            this.DeleteExpiredBut.Text = "Delete Expired Boxes";
            this.DeleteExpiredBut.UseVisualStyleBackColor = false;
            this.DeleteExpiredBut.Click += new System.EventHandler(this.DeleteExpiredBut_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteExpiredBut);
            this.Controls.Add(this.ExpiredBoxesLab);
            this.Controls.Add(this.ExpiredBoxesGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllBoxesGrid);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Controls.SetChildIndex(this.AllBoxesGrid, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ExpiredBoxesGrid, 0);
            this.Controls.SetChildIndex(this.ExpiredBoxesLab, 0);
            this.Controls.SetChildIndex(this.DeleteExpiredBut, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.AllBoxesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiredBoxesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllBoxesGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ExpiredBoxesGrid;
        private System.Windows.Forms.Label ExpiredBoxesLab;
        private System.Windows.Forms.Button DeleteExpiredBut;
    }
}