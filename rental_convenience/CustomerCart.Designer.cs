namespace rental_convenience
{
    partial class CustomerCart
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
            this.backToDashboard = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelCartTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // backToDashboard
            // 
            this.backToDashboard.Location = new System.Drawing.Point(775, 34);
            this.backToDashboard.Name = "backToDashboard";
            this.backToDashboard.Size = new System.Drawing.Size(114, 23);
            this.backToDashboard.TabIndex = 0;
            this.backToDashboard.Text = "Back to Dashboard";
            this.backToDashboard.UseVisualStyleBackColor = true;
            this.backToDashboard.Click += new System.EventHandler(this.backToDashboard_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(877, 249);
            this.dataGridView2.TabIndex = 1;
            // 
            // labelCartTotal
            // 
            this.labelCartTotal.AutoSize = true;
            this.labelCartTotal.Location = new System.Drawing.Point(13, 44);
            this.labelCartTotal.Name = "labelCartTotal";
            this.labelCartTotal.Size = new System.Drawing.Size(35, 13);
            this.labelCartTotal.TabIndex = 2;
            this.labelCartTotal.Text = "label1";
            // 
            // CustomerCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.labelCartTotal);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.backToDashboard);
            this.Name = "CustomerCart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.CustomerCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToDashboard;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelCartTotal;
    }
}