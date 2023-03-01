namespace LupaISPrototype
{
    partial class IMStockManagementForm
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
            this.stockSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.stockUpdateIDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insertRadioButton = new System.Windows.Forms.RadioButton();
            this.updateRadioButton = new System.Windows.Forms.RadioButton();
            this.applyButton = new System.Windows.Forms.Button();
            this.stockQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stockSellingPTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stockPurchasePTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stockNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.stockSearchGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockSearchGroupBox
            // 
            this.stockSearchGroupBox.Controls.Add(this.stockUpdateIDTextBox);
            this.stockSearchGroupBox.Controls.Add(this.label7);
            this.stockSearchGroupBox.Controls.Add(this.searchButton);
            this.stockSearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockSearchGroupBox.Location = new System.Drawing.Point(16, 169);
            this.stockSearchGroupBox.Name = "stockSearchGroupBox";
            this.stockSearchGroupBox.Size = new System.Drawing.Size(487, 105);
            this.stockSearchGroupBox.TabIndex = 36;
            this.stockSearchGroupBox.TabStop = false;
            this.stockSearchGroupBox.Text = "Search For Stock ";
            // 
            // stockUpdateIDTextBox
            // 
            this.stockUpdateIDTextBox.Location = new System.Drawing.Point(265, 27);
            this.stockUpdateIDTextBox.Name = "stockUpdateIDTextBox";
            this.stockUpdateIDTextBox.Size = new System.Drawing.Size(216, 26);
            this.stockUpdateIDTextBox.TabIndex = 17;
            this.stockUpdateIDTextBox.TextChanged += new System.EventHandler(this.stockUpdateIDTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enter Stock ID to Update";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(265, 59);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(216, 34);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insertRadioButton);
            this.groupBox1.Controls.Add(this.updateRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 121);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // insertRadioButton
            // 
            this.insertRadioButton.AutoSize = true;
            this.insertRadioButton.Checked = true;
            this.insertRadioButton.Location = new System.Drawing.Point(9, 25);
            this.insertRadioButton.Name = "insertRadioButton";
            this.insertRadioButton.Size = new System.Drawing.Size(164, 24);
            this.insertRadioButton.TabIndex = 17;
            this.insertRadioButton.TabStop = true;
            this.insertRadioButton.Text = "Insert New Stock";
            this.insertRadioButton.UseVisualStyleBackColor = true;
            this.insertRadioButton.CheckedChanged += new System.EventHandler(this.insertRadioButton_CheckedChanged);
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(9, 68);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(198, 24);
            this.updateRadioButton.TabIndex = 18;
            this.updateRadioButton.Text = "Update Stock Details";
            this.updateRadioButton.UseVisualStyleBackColor = true;
            this.updateRadioButton.CheckedChanged += new System.EventHandler(this.updateRadioButton_CheckedChanged);
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(216, 494);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(290, 44);
            this.applyButton.TabIndex = 34;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // stockQuantityTextBox
            // 
            this.stockQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockQuantityTextBox.Location = new System.Drawing.Point(216, 449);
            this.stockQuantityTextBox.Name = "stockQuantityTextBox";
            this.stockQuantityTextBox.Size = new System.Drawing.Size(287, 26);
            this.stockQuantityTextBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Stock Quantity";
            // 
            // stockSellingPTextBox
            // 
            this.stockSellingPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockSellingPTextBox.Location = new System.Drawing.Point(216, 413);
            this.stockSellingPTextBox.Name = "stockSellingPTextBox";
            this.stockSellingPTextBox.Size = new System.Drawing.Size(287, 26);
            this.stockSellingPTextBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Stock Selling Price";
            // 
            // stockPurchasePTextBox
            // 
            this.stockPurchasePTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockPurchasePTextBox.Location = new System.Drawing.Point(216, 383);
            this.stockPurchasePTextBox.Name = "stockPurchasePTextBox";
            this.stockPurchasePTextBox.Size = new System.Drawing.Size(287, 26);
            this.stockPurchasePTextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Stock Purchase Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Stock Description";
            // 
            // stockNameTextBox
            // 
            this.stockNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameTextBox.Location = new System.Drawing.Point(216, 318);
            this.stockNameTextBox.Name = "stockNameTextBox";
            this.stockNameTextBox.Size = new System.Drawing.Size(287, 26);
            this.stockNameTextBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Stock Name";
            // 
            // stockDescriptionComboBox
            // 
            this.stockDescriptionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDescriptionComboBox.FormattingEnabled = true;
            this.stockDescriptionComboBox.Items.AddRange(new object[] {
            "Drink",
            "Wine",
            "Cocktail",
            "Mocktail",
            "Pizza",
            "Antipasti",
            "Secondi",
            "Dolce",
            "Pasta"});
            this.stockDescriptionComboBox.Location = new System.Drawing.Point(216, 348);
            this.stockDescriptionComboBox.Name = "stockDescriptionComboBox";
            this.stockDescriptionComboBox.Size = new System.Drawing.Size(121, 28);
            this.stockDescriptionComboBox.TabIndex = 37;
            // 
            // IMStockManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 546);
            this.Controls.Add(this.stockDescriptionComboBox);
            this.Controls.Add(this.stockSearchGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.stockQuantityTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stockSellingPTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stockPurchasePTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stockNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "IMStockManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IMStockManagementForm_FormClosed);
            this.Load += new System.EventHandler(this.IMStockManagementForm_Load);
            this.stockSearchGroupBox.ResumeLayout(false);
            this.stockSearchGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox stockSearchGroupBox;
        private System.Windows.Forms.TextBox stockUpdateIDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton insertRadioButton;
        private System.Windows.Forms.RadioButton updateRadioButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox stockQuantityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stockSellingPTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stockPurchasePTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stockNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stockDescriptionComboBox;
    }
}