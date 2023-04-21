namespace rental_convenience
{
    partial class AdminDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.adminLogoutBtn = new System.Windows.Forms.Button();
            this.addInventoryBtn = new System.Windows.Forms.Button();
            this.adminGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminLogoutBtn
            // 
            this.adminLogoutBtn.Location = new System.Drawing.Point(1005, 27);
            this.adminLogoutBtn.Name = "adminLogoutBtn";
            this.adminLogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.adminLogoutBtn.TabIndex = 1;
            this.adminLogoutBtn.Text = "Log out";
            this.adminLogoutBtn.UseVisualStyleBackColor = true;
            // 
            // addInventoryBtn
            // 
            this.addInventoryBtn.Location = new System.Drawing.Point(888, 27);
            this.addInventoryBtn.Name = "addInventoryBtn";
            this.addInventoryBtn.Size = new System.Drawing.Size(87, 23);
            this.addInventoryBtn.TabIndex = 2;
            this.addInventoryBtn.Text = "Add new item";
            this.addInventoryBtn.UseVisualStyleBackColor = true;
            // 
            // adminGridView
            // 
            this.adminGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminGridView.Location = new System.Drawing.Point(12, 93);
            this.adminGridView.Name = "adminGridView";
            this.adminGridView.Size = new System.Drawing.Size(1068, 345);
            this.adminGridView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Below is the full inventory list";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminGridView);
            this.Controls.Add(this.addInventoryBtn);
            this.Controls.Add(this.adminLogoutBtn);
            this.Controls.Add(this.label1);
            this.Name = "AdminDashboard";
            this.Text = "Admin dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminLogoutBtn;
        private System.Windows.Forms.Button addInventoryBtn;
        private System.Windows.Forms.DataGridView adminGridView;
        private System.Windows.Forms.Label label2;
    }
}