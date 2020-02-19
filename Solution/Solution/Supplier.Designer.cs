namespace Solution
{
    partial class Supplier
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
            this.SuspendLayout();
            // 
            // btBackToMain
            // 
            this.btBackToMain.Location = new System.Drawing.Point(69, 134);
            this.btBackToMain.Name = "btBackToMain";
            this.btBackToMain.Size = new System.Drawing.Size(143, 41);
            this.btBackToMain.TabIndex = 29;
            this.btBackToMain.Text = "BACK TO MAIN";
            this.btBackToMain.UseVisualStyleBackColor = true;
            this.btBackToMain.Click += new System.EventHandler(this.btBackToMain_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btBackToMain);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBackToMain;
    }
}