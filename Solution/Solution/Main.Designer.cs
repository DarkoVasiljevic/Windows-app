namespace Solution
{
    partial class Main
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
            this.cmbox = new System.Windows.Forms.ComboBox();
            this.lbSelect = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbox
            // 
            this.cmbox.FormattingEnabled = true;
            this.cmbox.Items.AddRange(new object[] {
            "Categories",
            "Customers",
            "Products",
            "Orders",
            "OrderDetails",
            "Suppliers"});
            this.cmbox.Location = new System.Drawing.Point(34, 75);
            this.cmbox.Name = "cmbox";
            this.cmbox.Size = new System.Drawing.Size(192, 24);
            this.cmbox.TabIndex = 0;
            this.cmbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelect.Location = new System.Drawing.Point(30, 40);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(93, 20);
            this.lbSelect.TabIndex = 1;
            this.lbSelect.Text = "Select Item";
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(265, 75);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(118, 51);
            this.btConfirm.TabIndex = 8;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 341);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.cmbox);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbox;
        private System.Windows.Forms.Label lbSelect;
        private System.Windows.Forms.Button btConfirm;
    }
}

