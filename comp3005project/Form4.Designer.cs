namespace comp3005project
{
    partial class completeOrder
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
            this.billingText = new System.Windows.Forms.TextBox();
            this.shippingText = new System.Windows.Forms.TextBox();
            this.billingAddressLabel = new System.Windows.Forms.Label();
            this.shippingAddressLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.orderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // billingText
            // 
            this.billingText.Location = new System.Drawing.Point(364, 154);
            this.billingText.Name = "billingText";
            this.billingText.Size = new System.Drawing.Size(100, 20);
            this.billingText.TabIndex = 6;
            // 
            // shippingText
            // 
            this.shippingText.Location = new System.Drawing.Point(364, 202);
            this.shippingText.Name = "shippingText";
            this.shippingText.Size = new System.Drawing.Size(100, 20);
            this.shippingText.TabIndex = 7;
            // 
            // billingAddressLabel
            // 
            this.billingAddressLabel.Location = new System.Drawing.Point(262, 145);
            this.billingAddressLabel.Name = "billingAddressLabel";
            this.billingAddressLabel.Size = new System.Drawing.Size(83, 36);
            this.billingAddressLabel.TabIndex = 4;
            this.billingAddressLabel.Text = "Billing Address";
            this.billingAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shippingAddressLabel
            // 
            this.shippingAddressLabel.Location = new System.Drawing.Point(239, 193);
            this.shippingAddressLabel.Name = "shippingAddressLabel";
            this.shippingAddressLabel.Size = new System.Drawing.Size(106, 36);
            this.shippingAddressLabel.TabIndex = 5;
            this.shippingAddressLabel.Text = "Shipping Address";
            this.shippingAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(323, 247);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.Location = new System.Drawing.Point(278, 92);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(172, 36);
            this.orderLabel.TabIndex = 4;
            this.orderLabel.Text = "Finalize Order:";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.billingText);
            this.Controls.Add(this.shippingText);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.billingAddressLabel);
            this.Controls.Add(this.shippingAddressLabel);
            this.Name = "completeOrder";
            this.Text = "Complete Order";
            this.Load += new System.EventHandler(this.completeOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox billingText;
        private System.Windows.Forms.TextBox shippingText;
        private System.Windows.Forms.Label billingAddressLabel;
        private System.Windows.Forms.Label shippingAddressLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label orderLabel;
    }
}