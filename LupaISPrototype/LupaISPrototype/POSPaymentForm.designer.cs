namespace LupaISPrototype
{
    partial class POSPaymentForm
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
            this.CashRadioButton = new System.Windows.Forms.RadioButton();
            this.CardRadioButton = new System.Windows.Forms.RadioButton();
            this.EnterAmountLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.PaidAmountTextBox = new System.Windows.Forms.TextBox();
            this.TotalDueTextBox = new System.Windows.Forms.TextBox();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CashRadioButton
            // 
            this.CashRadioButton.AutoSize = true;
            this.CashRadioButton.Checked = true;
            this.CashRadioButton.Location = new System.Drawing.Point(22, 31);
            this.CashRadioButton.Name = "CashRadioButton";
            this.CashRadioButton.Size = new System.Drawing.Size(68, 24);
            this.CashRadioButton.TabIndex = 27;
            this.CashRadioButton.TabStop = true;
            this.CashRadioButton.Text = "Cash";
            this.CashRadioButton.UseVisualStyleBackColor = true;
            this.CashRadioButton.CheckedChanged += new System.EventHandler(this.CashRadioButton_CheckedChanged);
            // 
            // CardRadioButton
            // 
            this.CardRadioButton.AutoSize = true;
            this.CardRadioButton.Location = new System.Drawing.Point(22, 71);
            this.CardRadioButton.Name = "CardRadioButton";
            this.CardRadioButton.Size = new System.Drawing.Size(65, 24);
            this.CardRadioButton.TabIndex = 28;
            this.CardRadioButton.Text = "Card";
            this.CardRadioButton.UseVisualStyleBackColor = true;
            this.CardRadioButton.CheckedChanged += new System.EventHandler(this.CardRadioButton_CheckedChanged);
            // 
            // EnterAmountLabel
            // 
            this.EnterAmountLabel.AutoSize = true;
            this.EnterAmountLabel.Location = new System.Drawing.Point(6, 38);
            this.EnterAmountLabel.Name = "EnterAmountLabel";
            this.EnterAmountLabel.Size = new System.Drawing.Size(160, 20);
            this.EnterAmountLabel.TabIndex = 29;
            this.EnterAmountLabel.Text = "Enter Paid Amount";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(6, 82);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(87, 20);
            this.TotalLabel.TabIndex = 30;
            this.TotalLabel.Text = "Total Due";
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Location = new System.Drawing.Point(6, 134);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(71, 20);
            this.ChangeLabel.TabIndex = 31;
            this.ChangeLabel.Text = "Change";
            // 
            // DoneButton
            // 
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(5, 382);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(210, 48);
            this.DoneButton.TabIndex = 32;
            this.DoneButton.Text = "APPLY PAYMENT";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // PaidAmountTextBox
            // 
            this.PaidAmountTextBox.Location = new System.Drawing.Point(198, 38);
            this.PaidAmountTextBox.Name = "PaidAmountTextBox";
            this.PaidAmountTextBox.Size = new System.Drawing.Size(170, 26);
            this.PaidAmountTextBox.TabIndex = 33;
            this.PaidAmountTextBox.TextChanged += new System.EventHandler(this.PaidAmountTextBox_TextChanged);
            // 
            // TotalDueTextBox
            // 
            this.TotalDueTextBox.Location = new System.Drawing.Point(198, 82);
            this.TotalDueTextBox.Name = "TotalDueTextBox";
            this.TotalDueTextBox.ReadOnly = true;
            this.TotalDueTextBox.Size = new System.Drawing.Size(170, 26);
            this.TotalDueTextBox.TabIndex = 34;
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.Location = new System.Drawing.Point(198, 129);
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.ReadOnly = true;
            this.ChangeTextBox.Size = new System.Drawing.Size(170, 26);
            this.ChangeTextBox.TabIndex = 35;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(221, 382);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(170, 48);
            this.cancelButton.TabIndex = 37;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EnterAmountLabel);
            this.groupBox1.Controls.Add(this.ChangeTextBox);
            this.groupBox1.Controls.Add(this.TotalDueTextBox);
            this.groupBox1.Controls.Add(this.PaidAmountTextBox);
            this.groupBox1.Controls.Add(this.TotalLabel);
            this.groupBox1.Controls.Add(this.ChangeLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 176);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CashRadioButton);
            this.groupBox2.Controls.Add(this.CardRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 101);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Working with Order Id";
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdTextBox.Location = new System.Drawing.Point(239, 47);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.ReadOnly = true;
            this.orderIdTextBox.Size = new System.Drawing.Size(152, 26);
            this.orderIdTextBox.TabIndex = 42;            
            // 
            // POSPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "POSPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Payment";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton CashRadioButton;
        private System.Windows.Forms.RadioButton CardRadioButton;
        private System.Windows.Forms.Label EnterAmountLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TextBox PaidAmountTextBox;
        private System.Windows.Forms.TextBox TotalDueTextBox;
        private System.Windows.Forms.TextBox ChangeTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderIdTextBox;       
    }
}