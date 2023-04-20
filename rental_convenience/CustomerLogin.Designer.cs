namespace rental_convenience
{
    partial class CustomerLogin
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
            this.loginToAdminPortalBtn = new System.Windows.Forms.Button();
            this.customerLoginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginToSignupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginToAdminPortalBtn
            // 
            this.loginToAdminPortalBtn.Location = new System.Drawing.Point(512, 284);
            this.loginToAdminPortalBtn.Name = "loginToAdminPortalBtn";
            this.loginToAdminPortalBtn.Size = new System.Drawing.Size(100, 28);
            this.loginToAdminPortalBtn.TabIndex = 17;
            this.loginToAdminPortalBtn.Text = "Admin portal";
            this.loginToAdminPortalBtn.UseVisualStyleBackColor = true;
            this.loginToAdminPortalBtn.Click += new System.EventHandler(this.loginToAdminPortalBtn_Click);
            // 
            // customerLoginBtn
            // 
            this.customerLoginBtn.Location = new System.Drawing.Point(512, 193);
            this.customerLoginBtn.Name = "customerLoginBtn";
            this.customerLoginBtn.Size = new System.Drawing.Size(100, 28);
            this.customerLoginBtn.TabIndex = 16;
            this.customerLoginBtn.Text = "Log in";
            this.customerLoginBtn.UseVisualStyleBackColor = true;
            this.customerLoginBtn.Click += new System.EventHandler(this.customerLoginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(512, 150);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(100, 20);
            this.loginPassword.TabIndex = 11;
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(512, 98);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(100, 20);
            this.loginUsername.TabIndex = 10;
            // 
            // loginToSignupBtn
            // 
            this.loginToSignupBtn.Location = new System.Drawing.Point(512, 239);
            this.loginToSignupBtn.Name = "loginToSignupBtn";
            this.loginToSignupBtn.Size = new System.Drawing.Size(100, 28);
            this.loginToSignupBtn.TabIndex = 9;
            this.loginToSignupBtn.Text = "Sign up";
            this.loginToSignupBtn.UseVisualStyleBackColor = true;
            this.loginToSignupBtn.Click += new System.EventHandler(this.loginToSignupBtn_Click);
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginToAdminPortalBtn);
            this.Controls.Add(this.customerLoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.loginToSignupBtn);
            this.Name = "CustomerLogin";
            this.Text = "Customer login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginToAdminPortalBtn;
        private System.Windows.Forms.Button customerLoginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.Button loginToSignupBtn;
    }
}