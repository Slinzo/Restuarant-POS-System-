namespace LupaISPrototype
{
    partial class MainLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(98, 22);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(166, 20);
            this.usernametextBox.TabIndex = 0;
            this.usernametextBox.TextChanged += new System.EventHandler(this.usernametextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(98, 105);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(166, 43);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(125, 329);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(166, 43);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "LUPA Point Of Sale and Inventory Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordMaskedTextBox1);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.usernametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 218);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Details";
            // 
            // passwordMaskedTextBox1
            // 
            this.passwordMaskedTextBox1.Location = new System.Drawing.Point(98, 69);
            this.passwordMaskedTextBox1.Name = "passwordMaskedTextBox1";
            this.passwordMaskedTextBox1.Size = new System.Drawing.Size(166, 20);
            this.passwordMaskedTextBox1.TabIndex = 1;
            this.passwordMaskedTextBox1.UseSystemPasswordChar = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(98, 154);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(166, 43);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainLoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(693, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LUPA Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.MaskedTextBox passwordMaskedTextBox1;
    }
}