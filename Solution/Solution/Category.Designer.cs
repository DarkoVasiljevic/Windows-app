namespace Solution
{
    partial class Category
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
            this.btInsert = new System.Windows.Forms.Button();
            this.tbInsertPicture = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInsertDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInsertName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btShowAll = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btShowOne = new System.Windows.Forms.Button();
            this.tbDeleteOne = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUpdateName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUpdateDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.btBackToMain = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShowName = new System.Windows.Forms.ComboBox();
            this.cmbDeleteName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbShowId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbUpdateOldName = new System.Windows.Forms.ComboBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(160, 230);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(143, 41);
            this.btInsert.TabIndex = 1;
            this.btInsert.Text = "INSERT";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbInsertPicture
            // 
            this.tbInsertPicture.Location = new System.Drawing.Point(160, 173);
            this.tbInsertPicture.Name = "tbInsertPicture";
            this.tbInsertPicture.Size = new System.Drawing.Size(143, 22);
            this.tbInsertPicture.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Picture";
            // 
            // tbInsertDesc
            // 
            this.tbInsertDesc.Location = new System.Drawing.Point(160, 114);
            this.tbInsertDesc.Name = "tbInsertDesc";
            this.tbInsertDesc.Size = new System.Drawing.Size(143, 22);
            this.tbInsertDesc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // tbInsertName
            // 
            this.tbInsertName.Location = new System.Drawing.Point(160, 57);
            this.tbInsertName.Name = "tbInsertName";
            this.tbInsertName.Size = new System.Drawing.Size(143, 22);
            this.tbInsertName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "CategoryName";
            // 
            // btShowAll
            // 
            this.btShowAll.Location = new System.Drawing.Point(51, 697);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(143, 41);
            this.btShowAll.TabIndex = 11;
            this.btShowAll.Text = "SHOW ALL";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(463, 237);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(143, 41);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "DELETE ONE";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(1130, 230);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(143, 41);
            this.btUpdate.TabIndex = 13;
            this.btUpdate.Text = "UPDATE ONE";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btShowOne
            // 
            this.btShowOne.Location = new System.Drawing.Point(770, 238);
            this.btShowOne.Name = "btShowOne";
            this.btShowOne.Size = new System.Drawing.Size(143, 41);
            this.btShowOne.TabIndex = 14;
            this.btShowOne.Text = "SHOW ONE";
            this.btShowOne.UseVisualStyleBackColor = true;
            this.btShowOne.Click += new System.EventHandler(this.btShowOne_Click);
            // 
            // tbDeleteOne
            // 
            this.tbDeleteOne.Location = new System.Drawing.Point(463, 122);
            this.tbDeleteOne.Name = "tbDeleteOne";
            this.tbDeleteOne.Size = new System.Drawing.Size(143, 22);
            this.tbDeleteOne.TabIndex = 18;
            this.tbDeleteOne.TextChanged += new System.EventHandler(this.tbDeleteOne_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Category ID";
            // 
            // tbUpdateName
            // 
            this.tbUpdateName.Location = new System.Drawing.Point(1130, 114);
            this.tbUpdateName.Name = "tbUpdateName";
            this.tbUpdateName.Size = new System.Drawing.Size(143, 22);
            this.tbUpdateName.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(976, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "New Category Name";
            // 
            // tbUpdateDesc
            // 
            this.tbUpdateDesc.Location = new System.Drawing.Point(1130, 171);
            this.tbUpdateDesc.Name = "tbUpdateDesc";
            this.tbUpdateDesc.Size = new System.Drawing.Size(143, 22);
            this.tbUpdateDesc.TabIndex = 24;
            this.tbUpdateDesc.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(976, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "New Description";
            // 
            // rtbShow
            // 
            this.rtbShow.Location = new System.Drawing.Point(51, 340);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(553, 318);
            this.rtbShow.TabIndex = 27;
            this.rtbShow.Text = "";
            this.rtbShow.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btBackToMain
            // 
            this.btBackToMain.Location = new System.Drawing.Point(1132, 704);
            this.btBackToMain.Name = "btBackToMain";
            this.btBackToMain.Size = new System.Drawing.Size(143, 41);
            this.btBackToMain.TabIndex = 28;
            this.btBackToMain.Text = "BACK TO MAIN";
            this.btBackToMain.UseVisualStyleBackColor = true;
            this.btBackToMain.Click += new System.EventHandler(this.btBackToMain_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(461, 697);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(143, 41);
            this.btClear.TabIndex = 29;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(976, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Old Category Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Category Name";
            // 
            // cmbShowName
            // 
            this.cmbShowName.FormattingEnabled = true;
            this.cmbShowName.Location = new System.Drawing.Point(770, 62);
            this.cmbShowName.Name = "cmbShowName";
            this.cmbShowName.Size = new System.Drawing.Size(143, 24);
            this.cmbShowName.TabIndex = 31;
            this.cmbShowName.SelectedIndexChanged += new System.EventHandler(this.cmbShowName_SelectedIndexChanged);
            // 
            // cmbDeleteName
            // 
            this.cmbDeleteName.FormattingEnabled = true;
            this.cmbDeleteName.Location = new System.Drawing.Point(461, 63);
            this.cmbDeleteName.Name = "cmbDeleteName";
            this.cmbDeleteName.Size = new System.Drawing.Size(143, 24);
            this.cmbDeleteName.TabIndex = 33;
            this.cmbDeleteName.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Category Name";
            // 
            // tbShowId
            // 
            this.tbShowId.Location = new System.Drawing.Point(770, 122);
            this.tbShowId.Name = "tbShowId";
            this.tbShowId.Size = new System.Drawing.Size(143, 22);
            this.tbShowId.TabIndex = 35;
            this.tbShowId.TextChanged += new System.EventHandler(this.tbShowId_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(652, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Category ID";
            // 
            // cmbUpdateOldName
            // 
            this.cmbUpdateOldName.FormattingEnabled = true;
            this.cmbUpdateOldName.Location = new System.Drawing.Point(1130, 52);
            this.cmbUpdateOldName.Name = "cmbUpdateOldName";
            this.cmbUpdateOldName.Size = new System.Drawing.Size(143, 24);
            this.cmbUpdateOldName.TabIndex = 36;
            this.cmbUpdateOldName.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateOldName_SelectedIndexChanged);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(724, 340);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(234, 318);
            this.pbImage.TabIndex = 37;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 776);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.cmbUpdateOldName);
            this.Controls.Add(this.tbShowId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbDeleteName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbShowName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btBackToMain);
            this.Controls.Add(this.rtbShow);
            this.Controls.Add(this.tbUpdateName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbUpdateDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDeleteOne);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btShowOne);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btShowAll);
            this.Controls.Add(this.tbInsertName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbInsertDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbInsertPicture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btInsert);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbInsertPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInsertDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInsertName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btShowAll;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btShowOne;
        private System.Windows.Forms.TextBox tbDeleteOne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUpdateName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUpdateDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.Button btBackToMain;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShowName;
        private System.Windows.Forms.ComboBox cmbDeleteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbShowId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbUpdateOldName;
        private System.Windows.Forms.PictureBox pbImage;
    }
}