namespace rental_convenience
{
    partial class CustomerDashboard
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
            this.customerGreeting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toCartBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerGreeting
            // 
            this.customerGreeting.AutoSize = true;
            this.customerGreeting.Location = new System.Drawing.Point(22, 28);
            this.customerGreeting.Name = "customerGreeting";
            this.customerGreeting.Size = new System.Drawing.Size(35, 13);
            this.customerGreeting.TabIndex = 0;
            this.customerGreeting.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Have a look at the appliances we offer";
            // 
            // toCartBtn
            // 
            this.toCartBtn.Location = new System.Drawing.Point(607, 28);
            this.toCartBtn.Name = "toCartBtn";
            this.toCartBtn.Size = new System.Drawing.Size(75, 23);
            this.toCartBtn.TabIndex = 2;
            this.toCartBtn.Text = "Cart";
            this.toCartBtn.UseVisualStyleBackColor = true;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(699, 28);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.toCartBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerGreeting);
            this.Name = "CustomerDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerGreeting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toCartBtn;
        private System.Windows.Forms.Button logOutBtn;
    }
}