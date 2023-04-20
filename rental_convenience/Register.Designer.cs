namespace rental_convenience
{
    partial class Register
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
            this.regSignupBtn = new System.Windows.Forms.Button();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regConfirm = new System.Windows.Forms.TextBox();
            this.regToLoginBtn = new System.Windows.Forms.Button();
            this.regToAdminPortalBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regSignupBtn
            // 
            this.regSignupBtn.Location = new System.Drawing.Point(529, 238);
            this.regSignupBtn.Name = "regSignupBtn";
            this.regSignupBtn.Size = new System.Drawing.Size(100, 23);
            this.regSignupBtn.TabIndex = 0;
            this.regSignupBtn.Text = "Sign up";
            this.regSignupBtn.UseVisualStyleBackColor = true;
            this.regSignupBtn.Click += new System.EventHandler(this.regSignupBtn_Click);
            // 
            // regUsername
            // 
            this.regUsername.Location = new System.Drawing.Point(529, 75);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(100, 20);
            this.regUsername.TabIndex = 1;
            // 
            // regPassword
            // 
            this.regPassword.Location = new System.Drawing.Point(529, 128);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(100, 20);
            this.regPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm password";
            // 
            // regConfirm
            // 
            this.regConfirm.Location = new System.Drawing.Point(529, 185);
            this.regConfirm.Name = "regConfirm";
            this.regConfirm.Size = new System.Drawing.Size(100, 20);
            this.regConfirm.TabIndex = 6;
            // 
            // regToLoginBtn
            // 
            this.regToLoginBtn.Location = new System.Drawing.Point(529, 276);
            this.regToLoginBtn.Name = "regToLoginBtn";
            this.regToLoginBtn.Size = new System.Drawing.Size(100, 23);
            this.regToLoginBtn.TabIndex = 7;
            this.regToLoginBtn.Text = "Log in";
            this.regToLoginBtn.UseVisualStyleBackColor = true;
            this.regToLoginBtn.Click += new System.EventHandler(this.regToLoginBtn_Click);
            // 
            // regToAdminPortalBtn
            // 
            this.regToAdminPortalBtn.Location = new System.Drawing.Point(529, 315);
            this.regToAdminPortalBtn.Name = "regToAdminPortalBtn";
            this.regToAdminPortalBtn.Size = new System.Drawing.Size(100, 23);
            this.regToAdminPortalBtn.TabIndex = 8;
            this.regToAdminPortalBtn.Text = "Admin portal";
            this.regToAdminPortalBtn.UseVisualStyleBackColor = true;
            this.regToAdminPortalBtn.Click += new System.EventHandler(this.regToAdminPortalBtn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regToAdminPortalBtn);
            this.Controls.Add(this.regToLoginBtn);
            this.Controls.Add(this.regConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.regUsername);
            this.Controls.Add(this.regSignupBtn);
            this.Name = "Register";
            this.Text = "Customer registration";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regSignupBtn;
        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regConfirm;
        private System.Windows.Forms.Button regToLoginBtn;
        private System.Windows.Forms.Button regToAdminPortalBtn;
    }
}

