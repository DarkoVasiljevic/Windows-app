namespace Solution
{
    partial class Customer
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
            this.btClear = new System.Windows.Forms.Button();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.btShowAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBackToMain
            // 
            this.btBackToMain.Location = new System.Drawing.Point(1132, 540);
            this.btBackToMain.Name = "btBackToMain";
            this.btBackToMain.Size = new System.Drawing.Size(143, 41);
            this.btBackToMain.TabIndex = 29;
            this.btBackToMain.Text = "BACK TO MAIN";
            this.btBackToMain.UseVisualStyleBackColor = true;
            this.btBackToMain.Click += new System.EventHandler(this.btBackToMain_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(560, 540);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(177, 41);
            this.btClear.TabIndex = 32;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // rtbShow
            // 
            this.rtbShow.Location = new System.Drawing.Point(29, 37);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(1100, 466);
            this.rtbShow.TabIndex = 31;
            this.rtbShow.Text = "";
            // 
            // btShowAll
            // 
            this.btShowAll.Location = new System.Drawing.Point(29, 540);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(177, 41);
            this.btShowAll.TabIndex = 30;
            this.btShowAll.Text = "SHOW ALL";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 609);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.rtbShow);
            this.Controls.Add(this.btShowAll);
            this.Controls.Add(this.btBackToMain);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBackToMain;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.Button btShowAll;
    }
}