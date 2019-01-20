namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    partial class AddCustomerWin
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
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.labelAddCustomer = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.TextBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.TextBoxProduct = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.TextBoxBalance = new System.Windows.Forms.TextBox();
            this.labelJoinningDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.ErrorName = new System.Windows.Forms.Label();
            this.ErrorAddress = new System.Windows.Forms.Label();
            this.ErrorPhone = new System.Windows.Forms.Label();
            this.ErrorProduct = new System.Windows.Forms.Label();
            this.ErrorBalance = new System.Windows.Forms.Label();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.JoinningDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.TextBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxName.Location = new System.Drawing.Point(124, 101);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(293, 26);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.Tag = "Your Name...";
            this.TextBoxName.Text = "Your Name...";
            this.TextBoxName.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelAddCustomer
            // 
            this.labelAddCustomer.AutoSize = true;
            this.labelAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelAddCustomer.Location = new System.Drawing.Point(35, 27);
            this.labelAddCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddCustomer.Name = "labelAddCustomer";
            this.labelAddCustomer.Size = new System.Drawing.Size(110, 21);
            this.labelAddCustomer.TabIndex = 3;
            this.labelAddCustomer.Tag = "";
            this.labelAddCustomer.Text = "Add Customer";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelAddress.Location = new System.Drawing.Point(8, 157);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(73, 21);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Tag = "";
            this.labelAddress.Text = "Address :";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.TextBoxAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAddress.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxAddress.Location = new System.Drawing.Point(124, 153);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(293, 26);
            this.TextBoxAddress.TabIndex = 1;
            this.TextBoxAddress.Tag = "Address... ";
            this.TextBoxAddress.Text = "Address... ";
            this.TextBoxAddress.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxAddress.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelPhoneNumber.Location = new System.Drawing.Point(8, 209);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(86, 21);
            this.labelPhoneNumber.TabIndex = 3;
            this.labelPhoneNumber.Tag = "";
            this.labelPhoneNumber.Text = "Phone No :";
            // 
            // TextBoxPhoneNo
            // 
            this.TextBoxPhoneNo.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.TextBoxPhoneNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhoneNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxPhoneNo.Location = new System.Drawing.Point(124, 206);
            this.TextBoxPhoneNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPhoneNo.Name = "TextBoxPhoneNo";
            this.TextBoxPhoneNo.Size = new System.Drawing.Size(293, 26);
            this.TextBoxPhoneNo.TabIndex = 2;
            this.TextBoxPhoneNo.Tag = "Phone Number";
            this.TextBoxPhoneNo.Text = "Phone Number";
            this.TextBoxPhoneNo.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxPhoneNo.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelProduct.Location = new System.Drawing.Point(8, 261);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(71, 21);
            this.labelProduct.TabIndex = 3;
            this.labelProduct.Tag = "";
            this.labelProduct.Text = "Product :";
            // 
            // TextBoxProduct
            // 
            this.TextBoxProduct.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.TextBoxProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxProduct.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxProduct.Location = new System.Drawing.Point(124, 257);
            this.TextBoxProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxProduct.Name = "TextBoxProduct";
            this.TextBoxProduct.Size = new System.Drawing.Size(293, 26);
            this.TextBoxProduct.TabIndex = 3;
            this.TextBoxProduct.Tag = "Product Name";
            this.TextBoxProduct.Text = "Product Name";
            this.TextBoxProduct.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxProduct.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelBalance.Location = new System.Drawing.Point(8, 313);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(70, 21);
            this.labelBalance.TabIndex = 3;
            this.labelBalance.Tag = "";
            this.labelBalance.Text = "Balance :";
            // 
            // TextBoxBalance
            // 
            this.TextBoxBalance.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.TextBoxBalance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBalance.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxBalance.Location = new System.Drawing.Point(124, 309);
            this.TextBoxBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxBalance.Name = "TextBoxBalance";
            this.TextBoxBalance.Size = new System.Drawing.Size(293, 26);
            this.TextBoxBalance.TabIndex = 4;
            this.TextBoxBalance.Tag = "Your Balance...";
            this.TextBoxBalance.Text = "Your Balance...";
            this.TextBoxBalance.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxBalance.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelJoinningDate
            // 
            this.labelJoinningDate.AutoSize = true;
            this.labelJoinningDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelJoinningDate.Location = new System.Drawing.Point(8, 370);
            this.labelJoinningDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJoinningDate.Name = "labelJoinningDate";
            this.labelJoinningDate.Size = new System.Drawing.Size(112, 21);
            this.labelJoinningDate.TabIndex = 3;
            this.labelJoinningDate.Tag = "";
            this.labelJoinningDate.Text = "Joinning Date :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelName.Location = new System.Drawing.Point(8, 104);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 21);
            this.labelName.TabIndex = 3;
            this.labelName.Tag = "";
            this.labelName.Text = "Name :";
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorName.ForeColor = System.Drawing.Color.Red;
            this.ErrorName.Location = new System.Drawing.Point(134, 130);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(15, 20);
            this.ErrorName.TabIndex = 21;
            this.ErrorName.Text = "*";
            this.ErrorName.Visible = false;
            // 
            // ErrorAddress
            // 
            this.ErrorAddress.AutoSize = true;
            this.ErrorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorAddress.ForeColor = System.Drawing.Color.Red;
            this.ErrorAddress.Location = new System.Drawing.Point(134, 182);
            this.ErrorAddress.Name = "ErrorAddress";
            this.ErrorAddress.Size = new System.Drawing.Size(15, 20);
            this.ErrorAddress.TabIndex = 21;
            this.ErrorAddress.Text = "*";
            this.ErrorAddress.Visible = false;
            // 
            // ErrorPhone
            // 
            this.ErrorPhone.AutoSize = true;
            this.ErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.ErrorPhone.Location = new System.Drawing.Point(134, 235);
            this.ErrorPhone.Name = "ErrorPhone";
            this.ErrorPhone.Size = new System.Drawing.Size(15, 20);
            this.ErrorPhone.TabIndex = 21;
            this.ErrorPhone.Text = "*";
            this.ErrorPhone.Visible = false;
            // 
            // ErrorProduct
            // 
            this.ErrorProduct.AutoSize = true;
            this.ErrorProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorProduct.ForeColor = System.Drawing.Color.Red;
            this.ErrorProduct.Location = new System.Drawing.Point(134, 286);
            this.ErrorProduct.Name = "ErrorProduct";
            this.ErrorProduct.Size = new System.Drawing.Size(15, 20);
            this.ErrorProduct.TabIndex = 21;
            this.ErrorProduct.Text = "*";
            this.ErrorProduct.Visible = false;
            // 
            // ErrorBalance
            // 
            this.ErrorBalance.AutoSize = true;
            this.ErrorBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorBalance.ForeColor = System.Drawing.Color.Red;
            this.ErrorBalance.Location = new System.Drawing.Point(134, 337);
            this.ErrorBalance.Name = "ErrorBalance";
            this.ErrorBalance.Size = new System.Drawing.Size(15, 20);
            this.ErrorBalance.TabIndex = 21;
            this.ErrorBalance.Text = "*";
            this.ErrorBalance.Visible = false;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddCustomer.Location = new System.Drawing.Point(154, 426);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(130, 34);
            this.buttonAddCustomer.TabIndex = 6;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // JoinningDate
            // 
            this.JoinningDate.CustomFormat = "";
            this.JoinningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.JoinningDate.Location = new System.Drawing.Point(124, 365);
            this.JoinningDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JoinningDate.Name = "JoinningDate";
            this.JoinningDate.ShowCheckBox = true;
            this.JoinningDate.Size = new System.Drawing.Size(293, 29);
            this.JoinningDate.TabIndex = 22;
            this.JoinningDate.Value = new System.DateTime(2018, 5, 31, 0, 0, 0, 0);
            // 
            // AddCustomerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 472);
            this.Controls.Add(this.JoinningDate);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.ErrorBalance);
            this.Controls.Add(this.ErrorProduct);
            this.Controls.Add(this.ErrorPhone);
            this.Controls.Add(this.ErrorAddress);
            this.Controls.Add(this.ErrorName);
            this.Controls.Add(this.TextBoxBalance);
            this.Controls.Add(this.labelJoinningDate);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.TextBoxProduct);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.TextBoxPhoneNo);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddCustomer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddCustomerWin";
            this.Text = "AddCustomer";
            this.Enter += new System.EventHandler(this.TextBox_Enter);
            this.Leave += new System.EventHandler(this.TextBox_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label labelAddCustomer;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxPhoneNo;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.TextBox TextBoxProduct;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox TextBoxBalance;
        private System.Windows.Forms.Label labelJoinningDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label ErrorName;
        private System.Windows.Forms.Label ErrorAddress;
        private System.Windows.Forms.Label ErrorPhone;
        private System.Windows.Forms.Label ErrorProduct;
        private System.Windows.Forms.Label ErrorBalance;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.DateTimePicker JoinningDate;
    }
}