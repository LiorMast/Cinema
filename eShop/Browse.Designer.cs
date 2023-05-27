namespace eShop
{
    partial class Browse
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
            this.components = new System.ComponentModel.Container();
            this.picFeatured = new System.Windows.Forms.PictureBox();
            this.tFeatured = new System.Windows.Forms.Timer(this.components);
            this.lblFeatured = new System.Windows.Forms.Label();
            this.cmbMovies = new System.Windows.Forms.ComboBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.lblUsrInfo = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFeatured)).BeginInit();
            this.SuspendLayout();
            // 
            // picFeatured
            // 
            this.picFeatured.Location = new System.Drawing.Point(8, 81);
            this.picFeatured.Name = "picFeatured";
            this.picFeatured.Size = new System.Drawing.Size(215, 357);
            this.picFeatured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFeatured.TabIndex = 0;
            this.picFeatured.TabStop = false;
            // 
            // tFeatured
            // 
            this.tFeatured.Enabled = true;
            this.tFeatured.Interval = 5000;
            this.tFeatured.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFeatured
            // 
            this.lblFeatured.AutoSize = true;
            this.lblFeatured.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFeatured.Location = new System.Drawing.Point(9, 37);
            this.lblFeatured.Name = "lblFeatured";
            this.lblFeatured.Size = new System.Drawing.Size(214, 25);
            this.lblFeatured.TabIndex = 1;
            this.lblFeatured.Text = "Our Featured Movies";
            // 
            // cmbMovies
            // 
            this.cmbMovies.FormattingEnabled = true;
            this.cmbMovies.Location = new System.Drawing.Point(399, 125);
            this.cmbMovies.Name = "cmbMovies";
            this.cmbMovies.Size = new System.Drawing.Size(121, 21);
            this.cmbMovies.TabIndex = 2;
            this.cmbMovies.SelectedIndexChanged += new System.EventHandler(this.cmbMovies_SelectedIndexChanged);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.Location = new System.Drawing.Point(296, 204);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(127, 32);
            this.btnShowInfo.TabIndex = 3;
            this.btnShowInfo.Text = "Show Movie Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lblUsrInfo
            // 
            this.lblUsrInfo.AutoSize = true;
            this.lblUsrInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsrInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUsrInfo.Location = new System.Drawing.Point(734, 0);
            this.lblUsrInfo.Name = "lblUsrInfo";
            this.lblUsrInfo.Size = new System.Drawing.Size(66, 24);
            this.lblUsrInfo.TabIndex = 4;
            this.lblUsrInfo.Text = "label1";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(434, 204);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(127, 32);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // Browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblUsrInfo);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.cmbMovies);
            this.Controls.Add(this.lblFeatured);
            this.Controls.Add(this.picFeatured);
            this.Name = "Browse";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFeatured)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFeatured;
        private System.Windows.Forms.Timer tFeatured;
        private System.Windows.Forms.Label lblFeatured;
        private System.Windows.Forms.ComboBox cmbMovies;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Label lblUsrInfo;
        private System.Windows.Forms.Button btnAddToCart;
    }
}