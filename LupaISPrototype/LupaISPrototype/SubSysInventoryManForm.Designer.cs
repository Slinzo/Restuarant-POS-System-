namespace LupaISPrototype
{
    partial class SubSysInventoryManForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dynamicSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.searchByIDRadioButton = new System.Windows.Forms.RadioButton();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchByNameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshDBButton = new System.Windows.Forms.Button();
            this.manageInventoryButton = new System.Windows.Forms.Button();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDiscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockPurchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockSellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst10ProtoDataSet = new LupaISPrototype.GroupWst10ProtoDataSet();
            this.editStockInventoryButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lowStockButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.stockTableAdapter = new LupaISPrototype.GroupWst10ProtoDataSetTableAdapters.StockTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst10ProtoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dynamicSearchCheckBox);
            this.groupBox1.Controls.Add(this.searchByIDRadioButton);
            this.groupBox1.Controls.Add(this.clearSearchButton);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.searchByNameRadioButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 125);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // dynamicSearchCheckBox
            // 
            this.dynamicSearchCheckBox.AutoSize = true;
            this.dynamicSearchCheckBox.Location = new System.Drawing.Point(467, 95);
            this.dynamicSearchCheckBox.Name = "dynamicSearchCheckBox";
            this.dynamicSearchCheckBox.Size = new System.Drawing.Size(222, 24);
            this.dynamicSearchCheckBox.TabIndex = 0;
            this.dynamicSearchCheckBox.Text = "Acivate Dynamic Search";
            this.dynamicSearchCheckBox.UseVisualStyleBackColor = true;
            this.dynamicSearchCheckBox.CheckedChanged += new System.EventHandler(this.dynamicSearchCheckBox_CheckedChanged);
            // 
            // searchByIDRadioButton
            // 
            this.searchByIDRadioButton.AutoSize = true;
            this.searchByIDRadioButton.Checked = true;
            this.searchByIDRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByIDRadioButton.Location = new System.Drawing.Point(30, 47);
            this.searchByIDRadioButton.Name = "searchByIDRadioButton";
            this.searchByIDRadioButton.Size = new System.Drawing.Size(170, 24);
            this.searchByIDRadioButton.TabIndex = 0;
            this.searchByIDRadioButton.TabStop = true;
            this.searchByIDRadioButton.Text = "Search by item ID";
            this.searchByIDRadioButton.UseVisualStyleBackColor = true;
            this.searchByIDRadioButton.CheckedChanged += new System.EventHandler(this.searchByIDRadioButton_CheckedChanged);
            this.searchByIDRadioButton.TextChanged += new System.EventHandler(this.searchByIDRadioButton_TextChanged);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchButton.Location = new System.Drawing.Point(678, 43);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(190, 32);
            this.clearSearchButton.TabIndex = 10;
            this.clearSearchButton.Text = "Clear Search";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(30, 83);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(402, 26);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchByNameRadioButton
            // 
            this.searchByNameRadioButton.AutoSize = true;
            this.searchByNameRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNameRadioButton.Location = new System.Drawing.Point(227, 43);
            this.searchByNameRadioButton.Name = "searchByNameRadioButton";
            this.searchByNameRadioButton.Size = new System.Drawing.Size(158, 24);
            this.searchByNameRadioButton.TabIndex = 3;
            this.searchByNameRadioButton.Text = "Search by Name";
            this.searchByNameRadioButton.UseVisualStyleBackColor = true;
            this.searchByNameRadioButton.CheckedChanged += new System.EventHandler(this.searchByNameRadioButton_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(467, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(190, 32);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshDBButton
            // 
            this.refreshDBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshDBButton.Location = new System.Drawing.Point(271, 589);
            this.refreshDBButton.Name = "refreshDBButton";
            this.refreshDBButton.Size = new System.Drawing.Size(255, 57);
            this.refreshDBButton.TabIndex = 15;
            this.refreshDBButton.Text = "Refresh/Reset Data";
            this.refreshDBButton.UseVisualStyleBackColor = true;
            this.refreshDBButton.Click += new System.EventHandler(this.refreshDBButton_Click);
            // 
            // manageInventoryButton
            // 
            this.manageInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageInventoryButton.Location = new System.Drawing.Point(18, 526);
            this.manageInventoryButton.Name = "manageInventoryButton";
            this.manageInventoryButton.Size = new System.Drawing.Size(251, 57);
            this.manageInventoryButton.TabIndex = 14;
            this.manageInventoryButton.Text = "Add/Update Stock Item";
            this.manageInventoryButton.UseVisualStyleBackColor = true;
            this.manageInventoryButton.Click += new System.EventHandler(this.manageInventoryButton_Click);
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AutoGenerateColumns = false;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.stockNameDataGridViewTextBoxColumn,
            this.stockDiscriptionDataGridViewTextBoxColumn,
            this.stockPurchasePriceDataGridViewTextBoxColumn,
            this.stockSellingPriceDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn,
            this.stockActiveDataGridViewTextBoxColumn});
            this.inventoryDataGridView.DataSource = this.stockBindingSource;
            this.inventoryDataGridView.Location = new System.Drawing.Point(18, 154);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.ReadOnly = true;
            this.inventoryDataGridView.Size = new System.Drawing.Size(1056, 366);
            this.inventoryDataGridView.TabIndex = 16;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "stock_ID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "stock_ID";
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockNameDataGridViewTextBoxColumn
            // 
            this.stockNameDataGridViewTextBoxColumn.DataPropertyName = "stock_Name";
            this.stockNameDataGridViewTextBoxColumn.HeaderText = "stock_Name";
            this.stockNameDataGridViewTextBoxColumn.Name = "stockNameDataGridViewTextBoxColumn";
            this.stockNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // stockDiscriptionDataGridViewTextBoxColumn
            // 
            this.stockDiscriptionDataGridViewTextBoxColumn.DataPropertyName = "stock_Discription";
            this.stockDiscriptionDataGridViewTextBoxColumn.HeaderText = "stock_Discription";
            this.stockDiscriptionDataGridViewTextBoxColumn.Name = "stockDiscriptionDataGridViewTextBoxColumn";
            this.stockDiscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockPurchasePriceDataGridViewTextBoxColumn
            // 
            this.stockPurchasePriceDataGridViewTextBoxColumn.DataPropertyName = "stock_Purchase_Price";
            this.stockPurchasePriceDataGridViewTextBoxColumn.HeaderText = "stock_Purchase_Price";
            this.stockPurchasePriceDataGridViewTextBoxColumn.Name = "stockPurchasePriceDataGridViewTextBoxColumn";
            this.stockPurchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockSellingPriceDataGridViewTextBoxColumn
            // 
            this.stockSellingPriceDataGridViewTextBoxColumn.DataPropertyName = "stock_Selling_Price";
            this.stockSellingPriceDataGridViewTextBoxColumn.HeaderText = "stock_Selling_Price";
            this.stockSellingPriceDataGridViewTextBoxColumn.Name = "stockSellingPriceDataGridViewTextBoxColumn";
            this.stockSellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "stock_Quantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "stock_Quantity";
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            this.stockQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockActiveDataGridViewTextBoxColumn
            // 
            this.stockActiveDataGridViewTextBoxColumn.DataPropertyName = "stock_Active";
            this.stockActiveDataGridViewTextBoxColumn.HeaderText = "stock_Active";
            this.stockActiveDataGridViewTextBoxColumn.Name = "stockActiveDataGridViewTextBoxColumn";
            this.stockActiveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.groupWst10ProtoDataSet;
            // 
            // groupWst10ProtoDataSet
            // 
            this.groupWst10ProtoDataSet.DataSetName = "GroupWst10ProtoDataSet";
            this.groupWst10ProtoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editStockInventoryButton
            // 
            this.editStockInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStockInventoryButton.Location = new System.Drawing.Point(18, 589);
            this.editStockInventoryButton.Name = "editStockInventoryButton";
            this.editStockInventoryButton.Size = new System.Drawing.Size(251, 57);
            this.editStockInventoryButton.TabIndex = 17;
            this.editStockInventoryButton.Text = "Update Stock Quantity";
            this.editStockInventoryButton.UseVisualStyleBackColor = true;
            this.editStockInventoryButton.Click += new System.EventHandler(this.editStockInventoryButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(275, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 57);
            this.button1.TabIndex = 18;
            this.button1.Text = "Activate/Deactivate Stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lowStockButton
            // 
            this.lowStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowStockButton.Location = new System.Drawing.Point(823, 526);
            this.lowStockButton.Name = "lowStockButton";
            this.lowStockButton.Size = new System.Drawing.Size(251, 57);
            this.lowStockButton.TabIndex = 19;
            this.lowStockButton.Text = "View Low Stock Items";
            this.lowStockButton.UseVisualStyleBackColor = true;
            this.lowStockButton.Click += new System.EventHandler(this.lowStockButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(974, 631);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(739, 637);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "LOW STOCK SET TO BE <";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(742, 603);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(318, 22);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "SET A CUSTOM LOW STOCK VALUE ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // SubSysInventoryManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 664);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lowStockButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editStockInventoryButton);
            this.Controls.Add(this.inventoryDataGridView);
            this.Controls.Add(this.refreshDBButton);
            this.Controls.Add(this.manageInventoryButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubSysInventoryManForm";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.SubSysInventoryManForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst10ProtoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox dynamicSearchCheckBox;
        private System.Windows.Forms.RadioButton searchByIDRadioButton;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton searchByNameRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button refreshDBButton;
        private System.Windows.Forms.Button manageInventoryButton;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private GroupWst10ProtoDataSet groupWst10ProtoDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private GroupWst10ProtoDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDiscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockPurchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockSellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button editStockInventoryButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lowStockButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}