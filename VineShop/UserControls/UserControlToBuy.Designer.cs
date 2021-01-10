
namespace VineShop.UserControls
{
    partial class UserControlToBuy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewToBuy = new System.Windows.Forms.DataGridView();
            this.pictureBoxVine = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelSweetness = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVine)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewToBuy
            // 
            this.dataGridViewToBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToBuy.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewToBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewToBuy.Name = "dataGridViewToBuy";
            this.dataGridViewToBuy.RowHeadersWidth = 51;
            this.dataGridViewToBuy.RowTemplate.Height = 24;
            this.dataGridViewToBuy.Size = new System.Drawing.Size(1207, 199);
            this.dataGridViewToBuy.TabIndex = 0;
            this.dataGridViewToBuy.SelectionChanged += new System.EventHandler(this.dataGridViewToBuy_SelectionChanged);
            // 
            // pictureBoxVine
            // 
            this.pictureBoxVine.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxVine.Location = new System.Drawing.Point(3, 205);
            this.pictureBoxVine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxVine.Name = "pictureBoxVine";
            this.pictureBoxVine.Size = new System.Drawing.Size(161, 199);
            this.pictureBoxVine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVine.TabIndex = 1;
            this.pictureBoxVine.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(184, 248);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 40);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBrand.Location = new System.Drawing.Point(179, 319);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(96, 40);
            this.labelBrand.TabIndex = 3;
            this.labelBrand.Text = "Brand";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelType.Location = new System.Drawing.Point(530, 248);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(77, 40);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "Type";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYear.Location = new System.Drawing.Point(945, 283);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(74, 40);
            this.labelYear.TabIndex = 6;
            this.labelYear.Text = "Year";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSize.Location = new System.Drawing.Point(811, 257);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(70, 40);
            this.labelSize.TabIndex = 7;
            this.labelSize.Text = "Size";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.Location = new System.Drawing.Point(811, 319);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(80, 40);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSweetness
            // 
            this.labelSweetness.AutoSize = true;
            this.labelSweetness.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSweetness.Location = new System.Drawing.Point(530, 319);
            this.labelSweetness.Name = "labelSweetness";
            this.labelSweetness.Size = new System.Drawing.Size(144, 40);
            this.labelSweetness.TabIndex = 9;
            this.labelSweetness.Text = "Sweetness";
            // 
            // UserControlToBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelSweetness);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxVine);
            this.Controls.Add(this.dataGridViewToBuy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlToBuy";
            this.Size = new System.Drawing.Size(1213, 422);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewToBuy;
        private System.Windows.Forms.PictureBox pictureBoxVine;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelSweetness;
    }
}
