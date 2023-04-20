namespace rental_convenience
{
    partial class AdminLogin
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
            this.adminLoginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminLoginPassword = new System.Windows.Forms.TextBox();
            this.adminLoginUsername = new System.Windows.Forms.TextBox();
            this.adminLoginToCustomerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.Location = new System.Drawing.Point(501, 207);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(134, 28);
            this.adminLoginBtn.TabIndex = 23;
            this.adminLoginBtn.Text = "Log in";
            this.adminLoginBtn.UseVisualStyleBackColor = true;
            this.adminLoginBtn.Click += new System.EventHandler(this.adminLoginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Username";
            // 
            // adminLoginPassword
            // 
            this.adminLoginPassword.Location = new System.Drawing.Point(501, 155);
            this.adminLoginPassword.Name = "adminLoginPassword";
            this.adminLoginPassword.Size = new System.Drawing.Size(134, 20);
            this.adminLoginPassword.TabIndex = 20;
            // 
            // adminLoginUsername
            // 
            this.adminLoginUsername.Location = new System.Drawing.Point(501, 104);
            this.adminLoginUsername.Name = "adminLoginUsername";
            this.adminLoginUsername.Size = new System.Drawing.Size(134, 20);
            this.adminLoginUsername.TabIndex = 19;
            // 
            // adminLoginToCustomerBtn
            // 
            this.adminLoginToCustomerBtn.Location = new System.Drawing.Point(501, 250);
            this.adminLoginToCustomerBtn.Name = "adminLoginToCustomerBtn";
            this.adminLoginToCustomerBtn.Size = new System.Drawing.Size(134, 28);
            this.adminLoginToCustomerBtn.TabIndex = 18;
            this.adminLoginToCustomerBtn.Text = "Back to customer portal";
            this.adminLoginToCustomerBtn.UseVisualStyleBackColor = true;
            this.adminLoginToCustomerBtn.Click += new System.EventHandler(this.adminLoginToCustomerBtn_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminLoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminLoginPassword);
            this.Controls.Add(this.adminLoginUsername);
            this.Controls.Add(this.adminLoginToCustomerBtn);
            this.Name = "AdminLogin";
            this.Text = "Admin login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button adminLoginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminLoginPassword;
        private System.Windows.Forms.TextBox adminLoginUsername;
        private System.Windows.Forms.Button adminLoginToCustomerBtn;
    }
}