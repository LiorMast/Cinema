namespace eShop
{
    partial class Checkout
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
            this.grpCheckoutDetails = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblPayerName = new System.Windows.Forms.Label();
            this.lblPayerEmail = new System.Windows.Forms.Label();
            this.txtPayerName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpCheckoutDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCheckoutDetails
            // 
            this.grpCheckoutDetails.Controls.Add(this.textBox1);
            this.grpCheckoutDetails.Controls.Add(this.txtPayerName);
            this.grpCheckoutDetails.Controls.Add(this.lblPayerEmail);
            this.grpCheckoutDetails.Controls.Add(this.lblPayerName);
            this.grpCheckoutDetails.Location = new System.Drawing.Point(13, 13);
            this.grpCheckoutDetails.Name = "grpCheckoutDetails";
            this.grpCheckoutDetails.Size = new System.Drawing.Size(585, 187);
            this.grpCheckoutDetails.TabIndex = 0;
            this.grpCheckoutDetails.TabStop = false;
            this.grpCheckoutDetails.Text = "groupBox1";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(522, 302);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // lblPayerName
            // 
            this.lblPayerName.AutoSize = true;
            this.lblPayerName.Location = new System.Drawing.Point(7, 20);
            this.lblPayerName.Name = "lblPayerName";
            this.lblPayerName.Size = new System.Drawing.Size(75, 13);
            this.lblPayerName.TabIndex = 0;
            this.lblPayerName.Text = "Payer\'s Name:";
            // 
            // lblPayerEmail
            // 
            this.lblPayerEmail.AutoSize = true;
            this.lblPayerEmail.Location = new System.Drawing.Point(7, 49);
            this.lblPayerEmail.Name = "lblPayerEmail";
            this.lblPayerEmail.Size = new System.Drawing.Size(72, 13);
            this.lblPayerEmail.TabIndex = 1;
            this.lblPayerEmail.Text = "Payer\'s Email:";
            // 
            // txtPayerName
            // 
            this.txtPayerName.Location = new System.Drawing.Point(89, 20);
            this.txtPayerName.Name = "txtPayerName";
            this.txtPayerName.Size = new System.Drawing.Size(170, 20);
            this.txtPayerName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 337);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.grpCheckoutDetails);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.grpCheckoutDetails.ResumeLayout(false);
            this.grpCheckoutDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCheckoutDetails;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPayerName;
        private System.Windows.Forms.Label lblPayerEmail;
        private System.Windows.Forms.Label lblPayerName;
    }
}