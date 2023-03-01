namespace LupaISPrototype
{
    partial class IMSActDeactStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMSActDeactStockForm));
            this.groupWst10ProtoDataSet = new LupaISPrototype.GroupWst10ProtoDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new LupaISPrototype.GroupWst10ProtoDataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new LupaISPrototype.GroupWst10ProtoDataSetTableAdapters.TableAdapterManager();
            this.stockBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stockBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.radioButtonShowInactive = new System.Windows.Forms.RadioButton();
            this.radioButtonShowActive = new System.Windows.Forms.RadioButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst10ProtoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingNavigator)).BeginInit();
            this.stockBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.groupBoxProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupWst10ProtoDataSet
            // 
            this.groupWst10ProtoDataSet.DataSetName = "GroupWst10ProtoDataSet";
            this.groupWst10ProtoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.groupWst10ProtoDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.Order_ItemTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.tblOrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LupaISPrototype.GroupWst10ProtoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stockBindingNavigator
            // 
            this.stockBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stockBindingNavigator.BindingSource = this.stockBindingSource;
            this.stockBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stockBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stockBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.stockBindingNavigatorSaveItem});
            this.stockBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stockBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stockBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stockBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stockBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stockBindingNavigator.Name = "stockBindingNavigator";
            this.stockBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stockBindingNavigator.Size = new System.Drawing.Size(843, 25);
            this.stockBindingNavigator.TabIndex = 0;
            this.stockBindingNavigator.Text = "bindingNavigator1";
            this.stockBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // stockBindingNavigatorSaveItem
            // 
            this.stockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stockBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stockBindingNavigatorSaveItem.Image")));
            this.stockBindingNavigatorSaveItem.Name = "stockBindingNavigatorSaveItem";
            this.stockBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stockBindingNavigatorSaveItem.Text = "Save Data";
            this.stockBindingNavigatorSaveItem.Click += new System.EventHandler(this.stockBindingNavigatorSaveItem_Click);
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AutoGenerateColumns = false;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.stockDataGridView.DataSource = this.stockBindingSource;
            this.stockDataGridView.Location = new System.Drawing.Point(12, 104);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.ReadOnly = true;
            this.stockDataGridView.Size = new System.Drawing.Size(784, 243);
            this.stockDataGridView.TabIndex = 1;
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(516, 61);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(278, 37);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Deactivate Product";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.radioButtonShowInactive);
            this.groupBoxProducts.Controls.Add(this.radioButtonShowActive);
            this.groupBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProducts.Location = new System.Drawing.Point(12, 30);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(465, 68);
            this.groupBoxProducts.TabIndex = 2;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Show Products";
            this.groupBoxProducts.Enter += new System.EventHandler(this.groupBoxProducts_Enter);
            // 
            // radioButtonShowInactive
            // 
            this.radioButtonShowInactive.AutoSize = true;
            this.radioButtonShowInactive.Location = new System.Drawing.Point(244, 22);
            this.radioButtonShowInactive.Name = "radioButtonShowInactive";
            this.radioButtonShowInactive.Size = new System.Drawing.Size(215, 24);
            this.radioButtonShowInactive.TabIndex = 1;
            this.radioButtonShowInactive.Text = "Show Inactive Products";
            this.radioButtonShowInactive.UseVisualStyleBackColor = true;
            this.radioButtonShowInactive.CheckedChanged += new System.EventHandler(this.radioButtonShowInactive_CheckedChanged);
            // 
            // radioButtonShowActive
            // 
            this.radioButtonShowActive.AutoSize = true;
            this.radioButtonShowActive.Checked = true;
            this.radioButtonShowActive.Location = new System.Drawing.Point(16, 25);
            this.radioButtonShowActive.Name = "radioButtonShowActive";
            this.radioButtonShowActive.Size = new System.Drawing.Size(201, 24);
            this.radioButtonShowActive.TabIndex = 0;
            this.radioButtonShowActive.TabStop = true;
            this.radioButtonShowActive.Text = "Show Active Products";
            this.radioButtonShowActive.UseVisualStyleBackColor = true;
            this.radioButtonShowActive.CheckedChanged += new System.EventHandler(this.radioButtonShowActive_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stock_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Stock ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "stock_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Stock Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "stock_Discription";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stock_Purchase_Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Purchase Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "stock_Selling_Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Selling Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "stock_Quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity On Hand";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // IMSActDeactStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 359);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.stockDataGridView);
            this.Controls.Add(this.stockBindingNavigator);
            this.Name = "IMSActDeactStockForm";
            this.Text = "IMSActDeactStockForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IMSActDeactStockForm_FormClosed);
            this.Load += new System.EventHandler(this.IMSActDeactStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupWst10ProtoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingNavigator)).EndInit();
            this.stockBindingNavigator.ResumeLayout(false);
            this.stockBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBoxProducts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupWst10ProtoDataSet groupWst10ProtoDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private GroupWst10ProtoDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private GroupWst10ProtoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stockBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton stockBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.RadioButton radioButtonShowInactive;
        private System.Windows.Forms.RadioButton radioButtonShowActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}