namespace LupaISPrototype
{
    partial class POSSlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSSlip));
            this.currentOrderLabel = new System.Windows.Forms.Label();
            this.slipListBox = new System.Windows.Forms.ListBox();
            this.printButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // currentOrderLabel
            // 
            this.currentOrderLabel.AutoSize = true;
            this.currentOrderLabel.Location = new System.Drawing.Point(10, 25);
            this.currentOrderLabel.Name = "currentOrderLabel";
            this.currentOrderLabel.Size = new System.Drawing.Size(69, 13);
            this.currentOrderLabel.TabIndex = 0;
            this.currentOrderLabel.Text = "current Order";
            this.currentOrderLabel.Visible = false;
            // 
            // slipListBox
            // 
            this.slipListBox.FormattingEnabled = true;
            this.slipListBox.Location = new System.Drawing.Point(13, 41);
            this.slipListBox.Name = "slipListBox";
            this.slipListBox.Size = new System.Drawing.Size(352, 342);
            this.slipListBox.TabIndex = 1;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(13, 396);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(149, 42);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Print Slip";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(216, 396);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(149, 42);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close Slip";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // POSSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.slipListBox);
            this.Controls.Add(this.currentOrderLabel);
            this.Name = "POSSlip";
            this.Text = "POSSlip";
            this.Load += new System.EventHandler(this.POSSlip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentOrderLabel;
        private System.Windows.Forms.ListBox slipListBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}