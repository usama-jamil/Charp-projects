namespace Grocery_Store_mangement_System
{
    partial class FormPriceChecker
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
            this.labelBarCode = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelNetPrice = new System.Windows.Forms.Label();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.textBoxNetPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelBarCode
            // 
            this.labelBarCode.AutoSize = true;
            this.labelBarCode.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarCode.Location = new System.Drawing.Point(111, 130);
            this.labelBarCode.Name = "labelBarCode";
            this.labelBarCode.Size = new System.Drawing.Size(128, 25);
            this.labelBarCode.TabIndex = 0;
            this.labelBarCode.Text = "Product Code";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(111, 180);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(136, 25);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Product Name";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(114, 230);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 25);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(111, 280);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(88, 25);
            this.labelDiscount.TabIndex = 3;
            this.labelDiscount.Text = "Discount";
            // 
            // labelNetPrice
            // 
            this.labelNetPrice.AutoSize = true;
            this.labelNetPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetPrice.Location = new System.Drawing.Point(114, 338);
            this.labelNetPrice.Name = "labelNetPrice";
            this.labelNetPrice.Size = new System.Drawing.Size(91, 25);
            this.labelNetPrice.TabIndex = 4;
            this.labelNetPrice.Text = "Net Price";
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Location = new System.Drawing.Point(320, 136);
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(302, 22);
            this.textBoxBarCode.TabIndex = 5;
            this.textBoxBarCode.Text = "12345";
            this.textBoxBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(320, 186);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(302, 22);
            this.textBoxProductName.TabIndex = 6;
            this.textBoxProductName.Text = "aloo wala naan";
            this.textBoxProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(320, 236);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(302, 22);
            this.textBoxPrice.TabIndex = 7;
            this.textBoxPrice.Text = "50";
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(320, 286);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.ReadOnly = true;
            this.textBoxDiscount.Size = new System.Drawing.Size(302, 22);
            this.textBoxDiscount.TabIndex = 8;
            this.textBoxDiscount.Text = "4";
            this.textBoxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNetPrice
            // 
            this.textBoxNetPrice.Location = new System.Drawing.Point(320, 344);
            this.textBoxNetPrice.Name = "textBoxNetPrice";
            this.textBoxNetPrice.ReadOnly = true;
            this.textBoxNetPrice.Size = new System.Drawing.Size(302, 22);
            this.textBoxNetPrice.TabIndex = 9;
            this.textBoxNetPrice.Text = "46";
            this.textBoxNetPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormPriceChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 593);
            this.Controls.Add(this.textBoxNetPrice);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxBarCode);
            this.Controls.Add(this.labelNetPrice);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelBarCode);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPriceChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Checker";
            this.Load += new System.EventHandler(this.FormPriceChecker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBarCode;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelNetPrice;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.TextBox textBoxNetPrice;
    }
}

