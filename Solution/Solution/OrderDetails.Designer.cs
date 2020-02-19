namespace Solution
{
    partial class OrderDetails
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
            this.btBackToMain = new System.Windows.Forms.Button();
            this.lbProductId = new System.Windows.Forms.Label();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.lbOrders = new System.Windows.Forms.Label();
            this.cmbAllOrders = new System.Windows.Forms.ComboBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.cmbOrderId = new System.Windows.Forms.ComboBox();
            this.cmbProductId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btBackToMain
            // 
            this.btBackToMain.Location = new System.Drawing.Point(524, 416);
            this.btBackToMain.Name = "btBackToMain";
            this.btBackToMain.Size = new System.Drawing.Size(143, 41);
            this.btBackToMain.TabIndex = 30;
            this.btBackToMain.Text = "BACK TO MAIN";
            this.btBackToMain.UseVisualStyleBackColor = true;
            this.btBackToMain.Click += new System.EventHandler(this.btBackToMain_Click);
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(311, 125);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(72, 17);
            this.lbProductId.TabIndex = 51;
            this.lbProductId.Text = "Product Id";
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(431, 166);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(173, 22);
            this.tbUnitPrice.TabIndex = 50;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(311, 171);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(68, 17);
            this.lbUnitPrice.TabIndex = 49;
            this.lbUnitPrice.Text = "Unit price";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(431, 207);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(173, 22);
            this.tbQuantity.TabIndex = 48;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(311, 210);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(61, 17);
            this.lbQuantity.TabIndex = 47;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(311, 80);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(60, 17);
            this.lbOrderId.TabIndex = 45;
            this.lbOrderId.Text = "Order Id";
            // 
            // lbOrders
            // 
            this.lbOrders.AutoSize = true;
            this.lbOrders.Location = new System.Drawing.Point(12, 43);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(52, 17);
            this.lbOrders.TabIndex = 44;
            this.lbOrders.Text = "Orders";
            this.lbOrders.Click += new System.EventHandler(this.lbProducts_Click);
            // 
            // cmbAllOrders
            // 
            this.cmbAllOrders.FormattingEnabled = true;
            this.cmbAllOrders.Location = new System.Drawing.Point(12, 80);
            this.cmbAllOrders.Name = "cmbAllOrders";
            this.cmbAllOrders.Size = new System.Drawing.Size(221, 24);
            this.cmbAllOrders.TabIndex = 43;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(483, 269);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(121, 51);
            this.btInsert.TabIndex = 53;
            this.btInsert.Text = "INSERT";
            this.btInsert.UseVisualStyleBackColor = true;
            // 
            // cmbOrderId
            // 
            this.cmbOrderId.FormattingEnabled = true;
            this.cmbOrderId.Location = new System.Drawing.Point(431, 77);
            this.cmbOrderId.Name = "cmbOrderId";
            this.cmbOrderId.Size = new System.Drawing.Size(173, 24);
            this.cmbOrderId.TabIndex = 54;
            // 
            // cmbProductId
            // 
            this.cmbProductId.FormattingEnabled = true;
            this.cmbProductId.Location = new System.Drawing.Point(431, 122);
            this.cmbProductId.Name = "cmbProductId";
            this.cmbProductId.Size = new System.Drawing.Size(173, 24);
            this.cmbProductId.TabIndex = 55;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 493);
            this.Controls.Add(this.cmbProductId);
            this.Controls.Add(this.cmbOrderId);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbOrderId);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.cmbAllOrders);
            this.Controls.Add(this.btBackToMain);
            this.Name = "OrderDetails";
            this.Text = "OrderDetailscs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBackToMain;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.Label lbOrders;
        private System.Windows.Forms.ComboBox cmbAllOrders;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.ComboBox cmbOrderId;
        private System.Windows.Forms.ComboBox cmbProductId;
    }
}