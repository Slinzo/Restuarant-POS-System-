namespace LupaISPrototype
{
    partial class FunctionsOrderHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionsOrderHistoryForm));
            this.tblOrderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst10ProtoDataSet = new LupaISPrototype.GroupWst10ProtoDataSet();
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
            this.tblOrderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.tblOrderTableAdapter = new LupaISPrototype.GroupWst10ProtoDataSetTableAdapters.tblOrderTableAdapter();
            this.tableAdapterManager = new LupaISPrototype.GroupWst10ProtoDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingNavigator)).BeginInit();
            this.tblOrderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst10ProtoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblOrderBindingNavigator
            // 
            this.tblOrderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblOrderBindingNavigator.BindingSource = this.tblOrderBindingSource;
            this.tblOrderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblOrderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblOrderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblOrderBindingNavigatorSaveItem});
            this.tblOrderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblOrderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblOrderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblOrderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblOrderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblOrderBindingNavigator.Name = "tblOrderBindingNavigator";
            this.tblOrderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblOrderBindingNavigator.Size = new System.Drawing.Size(803, 25);
            this.tblOrderBindingNavigator.TabIndex = 0;
            this.tblOrderBindingNavigator.Text = "bindingNavigator1";
            this.tblOrderBindingNavigator.Visible = false;
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
            // tblOrderBindingSource
            // 
            this.tblOrderBindingSource.DataMember = "tblOrder";
            this.tblOrderBindingSource.DataSource = this.groupWst10ProtoDataSet;
            // 
            // groupWst10ProtoDataSet
            // 
            this.groupWst10ProtoDataSet.DataSetName = "GroupWst10ProtoDataSet";
            this.groupWst10ProtoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tblOrderBindingNavigatorSaveItem
            // 
            this.tblOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblOrderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblOrderBindingNavigatorSaveItem.Image")));
            this.tblOrderBindingNavigatorSaveItem.Name = "tblOrderBindingNavigatorSaveItem";
            this.tblOrderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblOrderBindingNavigatorSaveItem.Text = "Save Data";
            this.tblOrderBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblOrderBindingNavigatorSaveItem_Click);
            // 
            // tblOrderDataGridView
            // 
            this.tblOrderDataGridView.AutoGenerateColumns = false;
            this.tblOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Order_Payment});
            this.tblOrderDataGridView.DataSource = this.tblOrderBindingSource;
            this.tblOrderDataGridView.Location = new System.Drawing.Point(12, 55);
            this.tblOrderDataGridView.Name = "tblOrderDataGridView";
            this.tblOrderDataGridView.ReadOnly = true;
            this.tblOrderDataGridView.Size = new System.Drawing.Size(750, 198);
            this.tblOrderDataGridView.TabIndex = 1;
            this.tblOrderDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblOrderDataGridView_CellClick);
            // 
            // tblOrderTableAdapter
            // 
            this.tblOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.Order_ItemTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.tblOrderTableAdapter = this.tblOrderTableAdapter;
            this.tableAdapterManager.UpdateOrder = LupaISPrototype.GroupWst10ProtoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 282);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Order_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Order ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Staff_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Staff ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Payment_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Payment ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date_Time";
            this.dataGridViewTextBoxColumn6.HeaderText = "Order Date-Time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Order_Amount";
            this.dataGridViewTextBoxColumn7.HeaderText = "Order Amount Due";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // Order_Payment
            // 
            this.Order_Payment.DataPropertyName = "Order_Payment";
            this.Order_Payment.HeaderText = "Order Amount Paid";
            this.Order_Payment.Name = "Order_Payment";
            this.Order_Payment.ReadOnly = true;
            this.Order_Payment.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ORDER ITEM LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ORDERS ";
            // 
            // FunctionsOrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tblOrderDataGridView);
            this.Controls.Add(this.tblOrderBindingNavigator);
            this.Name = "FunctionsOrderHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order History ";
            this.Load += new System.EventHandler(this.FunctionsOrderHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingNavigator)).EndInit();
            this.tblOrderBindingNavigator.ResumeLayout(false);
            this.tblOrderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst10ProtoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupWst10ProtoDataSet groupWst10ProtoDataSet;
        private System.Windows.Forms.BindingSource tblOrderBindingSource;
        private GroupWst10ProtoDataSetTableAdapters.tblOrderTableAdapter tblOrderTableAdapter;
        private GroupWst10ProtoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblOrderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblOrderBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblOrderDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}