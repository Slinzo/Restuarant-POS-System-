namespace LupaISPrototype
{
    partial class SubSysFunctionsForm
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
            this.paymentHistoryButton = new System.Windows.Forms.Button();
            this.manageStaffButton = new System.Windows.Forms.Button();
            this.orderHistoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paymentHistoryButton
            // 
            this.paymentHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentHistoryButton.Location = new System.Drawing.Point(25, 244);
            this.paymentHistoryButton.Name = "paymentHistoryButton";
            this.paymentHistoryButton.Size = new System.Drawing.Size(249, 56);
            this.paymentHistoryButton.TabIndex = 3;
            this.paymentHistoryButton.Text = "View Payment History";
            this.paymentHistoryButton.UseVisualStyleBackColor = true;
            this.paymentHistoryButton.Click += new System.EventHandler(this.paymentHistoryButton_Click);
            // 
            // manageStaffButton
            // 
            this.manageStaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStaffButton.Location = new System.Drawing.Point(25, 80);
            this.manageStaffButton.Name = "manageStaffButton";
            this.manageStaffButton.Size = new System.Drawing.Size(249, 57);
            this.manageStaffButton.TabIndex = 2;
            this.manageStaffButton.Text = "Manage Staff Users Profiles";
            this.manageStaffButton.UseVisualStyleBackColor = true;
            this.manageStaffButton.Click += new System.EventHandler(this.manageStaffButton_Click);
            // 
            // orderHistoryButton
            // 
            this.orderHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHistoryButton.Location = new System.Drawing.Point(25, 166);
            this.orderHistoryButton.Name = "orderHistoryButton";
            this.orderHistoryButton.Size = new System.Drawing.Size(249, 56);
            this.orderHistoryButton.TabIndex = 5;
            this.orderHistoryButton.Text = "View Order History";
            this.orderHistoryButton.UseVisualStyleBackColor = true;
            this.orderHistoryButton.Click += new System.EventHandler(this.orderHistoryButton_Click);
            // 
            // SubSysFunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 444);
            this.Controls.Add(this.orderHistoryButton);
            this.Controls.Add(this.paymentHistoryButton);
            this.Controls.Add(this.manageStaffButton);
            this.Name = "SubSysFunctionsForm";
            this.Text = "Functions";
            this.Load += new System.EventHandler(this.SubSysFunctionsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button paymentHistoryButton;
        private System.Windows.Forms.Button manageStaffButton;
        private System.Windows.Forms.Button orderHistoryButton;
    }
}