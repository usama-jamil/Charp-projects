namespace UsamaWindowsFormsApplicationTempletes.UControl
{
    partial class UPaymentMethod
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPaymentMode = new System.Windows.Forms.Label();
            this.radioButtonChecque = new System.Windows.Forms.RadioButton();
            this.radioButtonCreditCard = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelPaymentMode
            // 
            this.labelPaymentMode.AutoSize = true;
            this.labelPaymentMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelPaymentMode.Location = new System.Drawing.Point(3, 4);
            this.labelPaymentMode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPaymentMode.Name = "labelPaymentMode";
            this.labelPaymentMode.Size = new System.Drawing.Size(128, 21);
            this.labelPaymentMode.TabIndex = 26;
            this.labelPaymentMode.Tag = "";
            this.labelPaymentMode.Text = "Payment Method";
            // 
            // radioButtonChecque
            // 
            this.radioButtonChecque.AutoSize = true;
            this.radioButtonChecque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.radioButtonChecque.Location = new System.Drawing.Point(97, 39);
            this.radioButtonChecque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonChecque.Name = "radioButtonChecque";
            this.radioButtonChecque.Size = new System.Drawing.Size(88, 25);
            this.radioButtonChecque.TabIndex = 24;
            this.radioButtonChecque.Text = "Checque";
            this.radioButtonChecque.UseVisualStyleBackColor = true;
            this.radioButtonChecque.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // radioButtonCreditCard
            // 
            this.radioButtonCreditCard.AutoSize = true;
            this.radioButtonCreditCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.radioButtonCreditCard.Location = new System.Drawing.Point(201, 41);
            this.radioButtonCreditCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCreditCard.Name = "radioButtonCreditCard";
            this.radioButtonCreditCard.Size = new System.Drawing.Size(107, 25);
            this.radioButtonCreditCard.TabIndex = 25;
            this.radioButtonCreditCard.Text = "Credit Card";
            this.radioButtonCreditCard.UseVisualStyleBackColor = true;
            this.radioButtonCreditCard.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.radioButtonCash.Location = new System.Drawing.Point(19, 39);
            this.radioButtonCash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(62, 25);
            this.radioButtonCash.TabIndex = 23;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            this.radioButtonCash.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // UPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelPaymentMode);
            this.Controls.Add(this.radioButtonChecque);
            this.Controls.Add(this.radioButtonCreditCard);
            this.Controls.Add(this.radioButtonCash);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UPaymentMethod";
            this.Size = new System.Drawing.Size(313, 78);
            this.Load += new System.EventHandler(this.UPaymentMethod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPaymentMode;
        private System.Windows.Forms.RadioButton radioButtonChecque;
        private System.Windows.Forms.RadioButton radioButtonCreditCard;
        private System.Windows.Forms.RadioButton radioButtonCash;
    }
}
