
namespace VineShop.Forms
{
    partial class UserForm
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
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.labelTotalToPay = new System.Windows.Forms.Label();
            this.labelTotalToPayValue = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonIncrese = new System.Windows.Forms.Button();
            this.buttonDecrase = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.userControlToBuy = new VineShop.UserControls.UserControlToBuy();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.Green;
            this.buttonAddToCart.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddToCart.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddToCart.Location = new System.Drawing.Point(611, 437);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(223, 86);
            this.buttonAddToCart.TabIndex = 2;
            this.buttonAddToCart.Text = "Add to cart";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(12, 547);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.RowTemplate.Height = 24;
            this.dataGridViewCart.Size = new System.Drawing.Size(1286, 150);
            this.dataGridViewCart.TabIndex = 3;
            // 
            // labelTotalToPay
            // 
            this.labelTotalToPay.AutoSize = true;
            this.labelTotalToPay.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalToPay.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotalToPay.Location = new System.Drawing.Point(285, 733);
            this.labelTotalToPay.Name = "labelTotalToPay";
            this.labelTotalToPay.Size = new System.Drawing.Size(182, 40);
            this.labelTotalToPay.TabIndex = 4;
            this.labelTotalToPay.Text = "Total to pay:";
            // 
            // labelTotalToPayValue
            // 
            this.labelTotalToPayValue.AutoSize = true;
            this.labelTotalToPayValue.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalToPayValue.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotalToPayValue.Location = new System.Drawing.Point(532, 733);
            this.labelTotalToPayValue.Name = "labelTotalToPayValue";
            this.labelTotalToPayValue.Size = new System.Drawing.Size(49, 40);
            this.labelTotalToPayValue.TabIndex = 5;
            this.labelTotalToPayValue.Text = "0$";
            // 
            // labelQuantity
            // 
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelQuantity.Location = new System.Drawing.Point(474, 447);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(52, 66);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "1";
            // 
            // buttonIncrese
            // 
            this.buttonIncrese.BackColor = System.Drawing.Color.Green;
            this.buttonIncrese.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIncrese.ForeColor = System.Drawing.Color.Transparent;
            this.buttonIncrese.Location = new System.Drawing.Point(532, 437);
            this.buttonIncrese.Name = "buttonIncrese";
            this.buttonIncrese.Size = new System.Drawing.Size(36, 36);
            this.buttonIncrese.TabIndex = 7;
            this.buttonIncrese.Text = "+";
            this.buttonIncrese.UseVisualStyleBackColor = false;
            this.buttonIncrese.Click += new System.EventHandler(this.buttonIncrese_Click);
            // 
            // buttonDecrase
            // 
            this.buttonDecrase.BackColor = System.Drawing.Color.Red;
            this.buttonDecrase.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecrase.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDecrase.Location = new System.Drawing.Point(532, 479);
            this.buttonDecrase.Name = "buttonDecrase";
            this.buttonDecrase.Size = new System.Drawing.Size(36, 36);
            this.buttonDecrase.TabIndex = 8;
            this.buttonDecrase.Text = "-";
            this.buttonDecrase.UseVisualStyleBackColor = false;
            this.buttonDecrase.Click += new System.EventHandler(this.buttonDecrase_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.Green;
            this.buttonBuy.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuy.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBuy.Location = new System.Drawing.Point(815, 718);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(152, 55);
            this.buttonBuy.TabIndex = 9;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Location = new System.Drawing.Point(985, 718);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 55);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // userControlToBuy
            // 
            this.userControlToBuy.BackColor = System.Drawing.Color.Transparent;
            this.userControlToBuy.Location = new System.Drawing.Point(60, 32);
            this.userControlToBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlToBuy.Name = "userControlToBuy";
            this.userControlToBuy.Size = new System.Drawing.Size(1210, 415);
            this.userControlToBuy.TabIndex = 1;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VineShop.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 795);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonDecrase);
            this.Controls.Add(this.buttonIncrese);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelTotalToPayValue);
            this.Controls.Add(this.labelTotalToPay);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.userControlToBuy);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UserControlToBuy userControlToBuy;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Label labelTotalToPay;
        private System.Windows.Forms.Label labelTotalToPayValue;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonIncrese;
        private System.Windows.Forms.Button buttonDecrase;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonDelete;
    }
}