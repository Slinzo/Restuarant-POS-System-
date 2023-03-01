namespace LupaISPrototype
{
    partial class IMStockQuantitManForm
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
            this.newSearchButton = new System.Windows.Forms.Button();
            this.subRadioButton = new System.Windows.Forms.RadioButton();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.stockUpdateIDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.stockQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stockNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.offsetTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.stockSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockSearchGroupBox
            // 
            this.stockSearchGroupBox.Controls.Add(this.newSearchButton);
            this.stockSearchGroupBox.Controls.Add(this.subRadioButton);
            this.stockSearchGroupBox.Controls.Add(this.addRadioButton);
            this.stockSearchGroupBox.Controls.Add(this.stockUpdateIDTextBox);
            this.stockSearchGroupBox.Controls.Add(this.label7);
            this.stockSearchGroupBox.Controls.Add(this.searchButton);
            this.stockSearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockSearchGroupBox.Location = new System.Drawing.Point(12, 36);
            this.stockSearchGroupBox.Name = "stockSearchGroupBox";
            this.stockSearchGroupBox.Size = new System.Drawing.Size(497, 144);
            this.stockSearchGroupBox.TabIndex = 37;
            this.stockSearchGroupBox.TabStop = false;
            this.stockSearchGroupBox.Text = "Search For Stock ";
            // 
            // newSearchButton
            // 
            this.newSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSearchButton.Location = new System.Drawing.Point(10, 99);
            this.newSearchButton.Name = "newSearchButton";
            this.newSearchButton.Size = new System.Drawing.Size(216, 34);
            this.newSearchButton.TabIndex = 20;
            this.newSearchButton.Text = "New Search";
            this.newSearchButton.UseVisualStyleBackColor = true;
            this.newSearchButton.Click += new System.EventHandler(this.newSearchButton_Click);
            // 
            // subRadioButton
            // 
            this.subRadioButton.AutoSize = true;
            this.subRadioButton.Location = new System.Drawing.Point(200, 25);
            this.subRadioButton.Name = "subRadioButton";
            this.subRadioButton.Size = new System.Drawing.Size(173, 24);
            this.subRadioButton.TabIndex = 19;
            this.subRadioButton.Text = "decrease Quantity";
            this.subRadioButton.UseVisualStyleBackColor = true;
            this.subRadioButton.CheckedChanged += new System.EventHandler(this.subRadioButton_CheckedChanged);
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Checked = true;
            this.addRadioButton.Location = new System.Drawing.Point(10, 25);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(131, 24);
            this.addRadioButton.TabIndex = 18;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "Add Quantity";
            this.addRadioButton.UseVisualStyleBackColor = true;
            this.addRadioButton.CheckedChanged += new System.EventHandler(this.addRadioButton_CheckedChanged);
            // 
            // stockUpdateIDTextBox
            // 
            this.stockUpdateIDTextBox.Location = new System.Drawing.Point(265, 67);
            this.stockUpdateIDTextBox.Name = "stockUpdateIDTextBox";
            this.stockUpdateIDTextBox.Size = new System.Drawing.Size(216, 26);
            this.stockUpdateIDTextBox.TabIndex = 17;
            this.stockUpdateIDTextBox.TextChanged += new System.EventHandler(this.stockUpdateIDTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enter Stock ID to Update";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(265, 99);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(216, 34);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // stockQuantityTextBox
            // 
            this.stockQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockQuantityTextBox.Location = new System.Drawing.Point(222, 269);
            this.stockQuantityTextBox.Name = "stockQuantityTextBox";
            this.stockQuantityTextBox.ReadOnly = true;
            this.stockQuantityTextBox.Size = new System.Drawing.Size(287, 26);
            this.stockQuantityTextBox.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Current Stock Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Stock Description";
            // 
            // stockNameTextBox
            // 
            this.stockNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameTextBox.Location = new System.Drawing.Point(222, 200);
            this.stockNameTextBox.Name = "stockNameTextBox";
            this.stockNameTextBox.ReadOnly = true;
            this.stockNameTextBox.Size = new System.Drawing.Size(287, 26);
            this.stockNameTextBox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Stock Name";
            // 
            // stockDescriptionTextBox
            // 
            this.stockDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDescriptionTextBox.Location = new System.Drawing.Point(222, 237);
            this.stockDescriptionTextBox.Name = "stockDescriptionTextBox";
            this.stockDescriptionTextBox.ReadOnly = true;
            this.stockDescriptionTextBox.Size = new System.Drawing.Size(287, 26);
            this.stockDescriptionTextBox.TabIndex = 44;
            // 
            // offsetTextBox
            // 
            this.offsetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offsetTextBox.Location = new System.Drawing.Point(222, 307);
            this.offsetTextBox.Name = "offsetTextBox";
            this.offsetTextBox.Size = new System.Drawing.Size(180, 26);
            this.offsetTextBox.TabIndex = 45;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(8, 313);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(82, 20);
            this.inputLabel.TabIndex = 46;
            this.inputLabel.Text = "Offset by";
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(222, 339);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(216, 40);
            this.changeButton.TabIndex = 47;
            this.changeButton.Text = "Increment Stock";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // IMStockQuantitManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 413);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.offsetTextBox);
            this.Controls.Add(this.stockDescriptionTextBox);
            this.Controls.Add(this.stockQuantityTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stockNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockSearchGroupBox);
            this.Name = "IMStockQuantitManForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Quantity Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IMStockQuantitManForm_FormClosed);
            this.Load += new System.EventHandler(this.IMStockQuantitManForm_Load);
            this.stockSearchGroupBox.ResumeLayout(false);
            this.stockSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox stockSearchGroupBox;
        private System.Windows.Forms.TextBox stockUpdateIDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox stockQuantityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stockNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton subRadioButton;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.TextBox stockDescriptionTextBox;
        private System.Windows.Forms.TextBox offsetTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button newSearchButton;
    }
}