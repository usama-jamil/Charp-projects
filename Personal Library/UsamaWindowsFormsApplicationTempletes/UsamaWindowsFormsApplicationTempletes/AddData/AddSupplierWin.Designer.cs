namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    partial class AddSupplierWin
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
            this.JoinningDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.LabelJoinningDate = new System.Windows.Forms.Label();
            this.LabelBalance = new System.Windows.Forms.Label();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.LabelProduct = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.LabelCompany = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.ErrorName = new System.Windows.Forms.Label();
            this.ErrorCompany = new System.Windows.Forms.Label();
            this.ErrorAddress = new System.Windows.Forms.Label();
            this.ErrorPhone = new System.Windows.Forms.Label();
            this.ErrorProduct = new System.Windows.Forms.Label();
            this.ErrorBalance = new System.Windows.Forms.Label();
            this.LabelAddSupplier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JoinningDate
            // 
            this.JoinningDate.Location = new System.Drawing.Point(119, 395);
            this.JoinningDate.Name = "JoinningDate";
            this.JoinningDate.ShowCheckBox = true;
            this.JoinningDate.Size = new System.Drawing.Size(286, 22);
            this.JoinningDate.TabIndex = 6;
            this.JoinningDate.Value = new System.DateTime(2018, 5, 30, 0, 0, 0, 0);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.textBoxBalance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBalance.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxBalance.Location = new System.Drawing.Point(119, 342);
            this.textBoxBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(286, 26);
            this.textBoxBalance.TabIndex = 5;
            this.textBoxBalance.Tag = "Supplier Balance...";
            this.textBoxBalance.Text = "Supplier Balance...";
            this.textBoxBalance.Enter += new System.EventHandler(this.SupplierTextBox_Enter);
            this.textBoxBalance.Leave += new System.EventHandler(this.SupplierTextBox_Leave);
            // 
            // LabelJoinningDate
            // 
            this.LabelJoinningDate.AutoSize = true;
            this.LabelJoinningDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelJoinningDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LabelJoinningDate.Location = new System.Drawing.Point(5, 397);
            this.LabelJoinningDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJoinningDate.Name = "LabelJoinningDate";
            this.LabelJoinningDate.Size = new System.Drawing.Size(112, 21);
            this.LabelJoinningDate.TabIndex = 9;
            this.LabelJoinningDate.Tag = "";
            this.LabelJoinningDate.Text = "Joinning Date :";
            // 
            // LabelBalance
            // 
            this.LabelBalance.AutoSize = true;
            this.LabelBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LabelBalance.Location = new System.Drawing.Point(5, 344);
            this.LabelBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBalance.Name = "LabelBalance";
            this.LabelBalance.Size = new System.Drawing.Size(70, 21);
            this.LabelBalance.TabIndex = 10;
            this.LabelBalance.Tag = "";
            this.LabelBalance.Text = "Balance :";
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.textBoxProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProduct.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxProduct.Location = new System.Drawing.Point(119, 289);
            this.textBoxProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(286, 26);
            this.textBoxProduct.TabIndex = 4;
            this.textBoxProduct.Tag = "Product Name";
            this.textBoxProduct.Text = "Product Name";
            this.textBoxProduct.Enter += new System.EventHandler(this.SupplierTextBox_Enter);
            this.textBoxProduct.Leave += new System.EventHandler(this.SupplierTextBox_Leave);
            // 
            // LabelProduct
            // 
            this.LabelProduct.AutoSize = true;
            this.LabelProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LabelProduct.Location = new System.Drawing.Point(5, 291);
            this.LabelProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelProduct.Name = "LabelProduct";
            this.LabelProduct.Size = new System.Drawing.Size(71, 21);
            this.LabelProduct.TabIndex = 12;
            this.LabelProduct.Tag = "";
            this.LabelProduct.Text = "Product :";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.textBoxPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPhone.Location = new System.Drawing.Point(119, 236);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(286, 26);
            this.textBoxPhone.TabIndex = 3;
            this.textBoxPhone.Tag = "Phone Number";
            this.textBoxPhone.Text = "Phone Number";
            this.textBoxPhone.Enter += new System.EventHandler(this.SupplierTextBox_Enter);
            this.textBoxPhone.Leave += new System.EventHandler(this.SupplierTextBox_Leave);
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LabelPhone.Location = new System.Drawing.Point(5, 238);
            this.LabelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(86, 21);
            this.LabelPhone.TabIndex = 13;
            this.LabelPhone.Tag = "";
            this.LabelPhone.Text = "Phone No :";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.textBoxCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompany.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCompany.Location = new System.Drawing.Point(119, 130);
            this.textBoxCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(286, 26);
            this.textBoxCompany.TabIndex = 1;
            this.textBoxCompany.Tag = "Company Name...";
            this.textBoxCompany.Text = "Company Name...";
            this.textBoxCompany.Enter += new System.EventHandler(this.SupplierTextBox_Enter);
            this.textBoxCompany.Leave += new System.EventHandler(this.SupplierTextBox_Leave);
            // 
            // LabelCompany
            // 
            this.LabelCompany.AutoSize = true;
            this.LabelCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LabelCompany.Location = new System.Drawing.Point(5, 132);
            this.LabelCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCompany.Name = "LabelCompany";
            this.LabelCompany.Size = new System.Drawing.Size(84, 21);
            this.LabelCompany.TabIndex = 14;
            this.LabelCompany.Tag = "";
            this.LabelCompany.Text = "Company :";
            // 
            // textBoxName
            // 
            this.textBoxName.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.textBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxName.Location = new System.Drawing.Point(119, 77);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(286, 26);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Tag = "Supplier Name...";
            this.textBoxName.Text = "Supplier Name...";
            this.textBoxName.Enter += new System.EventHandler(this.SupplierTextBox_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.SupplierTextBox_Leave);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LabelName.Location = new System.Drawing.Point(5, 79);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(59, 21);
            this.LabelName.TabIndex = 15;
            this.LabelName.Tag = "";
            this.LabelName.Text = "Name :";
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LabelAddress.Location = new System.Drawing.Point(5, 185);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(73, 21);
            this.LabelAddress.TabIndex = 14;
            this.LabelAddress.Tag = "";
            this.LabelAddress.Text = "Address :";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.textBoxAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAddress.Location = new System.Drawing.Point(119, 183);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(286, 26);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxAddress.Tag = "Address... ";
            this.textBoxAddress.Text = "Address... ";
            this.textBoxAddress.Enter += new System.EventHandler(this.SupplierTextBox_Enter);
            this.textBoxAddress.Leave += new System.EventHandler(this.SupplierTextBox_Leave);
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddSupplier.Location = new System.Drawing.Point(155, 444);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(130, 34);
            this.buttonAddSupplier.TabIndex = 7;
            this.buttonAddSupplier.Text = "Add Supplier";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorName.ForeColor = System.Drawing.Color.Red;
            this.ErrorName.Location = new System.Drawing.Point(127, 106);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(15, 20);
            this.ErrorName.TabIndex = 20;
            this.ErrorName.Text = "*";
            this.ErrorName.Visible = false;
            // 
            // ErrorCompany
            // 
            this.ErrorCompany.AutoSize = true;
            this.ErrorCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorCompany.ForeColor = System.Drawing.Color.Red;
            this.ErrorCompany.Location = new System.Drawing.Point(127, 159);
            this.ErrorCompany.Name = "ErrorCompany";
            this.ErrorCompany.Size = new System.Drawing.Size(15, 20);
            this.ErrorCompany.TabIndex = 20;
            this.ErrorCompany.Text = "*";
            this.ErrorCompany.Visible = false;
            // 
            // ErrorAddress
            // 
            this.ErrorAddress.AutoSize = true;
            this.ErrorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorAddress.ForeColor = System.Drawing.Color.Red;
            this.ErrorAddress.Location = new System.Drawing.Point(127, 212);
            this.ErrorAddress.Name = "ErrorAddress";
            this.ErrorAddress.Size = new System.Drawing.Size(15, 20);
            this.ErrorAddress.TabIndex = 20;
            this.ErrorAddress.Text = "*";
            this.ErrorAddress.Visible = false;
            // 
            // ErrorPhone
            // 
            this.ErrorPhone.AutoSize = true;
            this.ErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.ErrorPhone.Location = new System.Drawing.Point(126, 265);
            this.ErrorPhone.Name = "ErrorPhone";
            this.ErrorPhone.Size = new System.Drawing.Size(15, 20);
            this.ErrorPhone.TabIndex = 20;
            this.ErrorPhone.Text = "*";
            this.ErrorPhone.Visible = false;
            // 
            // ErrorProduct
            // 
            this.ErrorProduct.AutoSize = true;
            this.ErrorProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorProduct.ForeColor = System.Drawing.Color.Red;
            this.ErrorProduct.Location = new System.Drawing.Point(127, 318);
            this.ErrorProduct.Name = "ErrorProduct";
            this.ErrorProduct.Size = new System.Drawing.Size(15, 20);
            this.ErrorProduct.TabIndex = 20;
            this.ErrorProduct.Text = "*";
            this.ErrorProduct.Visible = false;
            // 
            // ErrorBalance
            // 
            this.ErrorBalance.AutoSize = true;
            this.ErrorBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorBalance.ForeColor = System.Drawing.Color.Red;
            this.ErrorBalance.Location = new System.Drawing.Point(127, 371);
            this.ErrorBalance.Name = "ErrorBalance";
            this.ErrorBalance.Size = new System.Drawing.Size(15, 20);
            this.ErrorBalance.TabIndex = 20;
            this.ErrorBalance.Text = "*";
            this.ErrorBalance.Visible = false;
            // 
            // LabelAddSupplier
            // 
            this.LabelAddSupplier.AutoSize = true;
            this.LabelAddSupplier.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LabelAddSupplier.Location = new System.Drawing.Point(26, 18);
            this.LabelAddSupplier.Name = "LabelAddSupplier";
            this.LabelAddSupplier.Size = new System.Drawing.Size(144, 32);
            this.LabelAddSupplier.TabIndex = 29;
            this.LabelAddSupplier.Text = "Add Supplier";
            // 
            // AddSupplierWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 484);
            this.Controls.Add(this.LabelAddSupplier);
            this.Controls.Add(this.ErrorBalance);
            this.Controls.Add(this.ErrorProduct);
            this.Controls.Add(this.ErrorPhone);
            this.Controls.Add(this.ErrorAddress);
            this.Controls.Add(this.ErrorCompany);
            this.Controls.Add(this.ErrorName);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.JoinningDate);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.LabelJoinningDate);
            this.Controls.Add(this.LabelBalance);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.LabelProduct);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.LabelPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.LabelCompany);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.LabelName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddSupplierWin";
            this.Text = "AddSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker JoinningDate;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label LabelJoinningDate;
        private System.Windows.Forms.Label LabelBalance;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.Label LabelProduct;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label LabelCompany;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Label ErrorName;
        private System.Windows.Forms.Label ErrorCompany;
        private System.Windows.Forms.Label ErrorAddress;
        private System.Windows.Forms.Label ErrorPhone;
        private System.Windows.Forms.Label ErrorProduct;
        private System.Windows.Forms.Label ErrorBalance;
        private System.Windows.Forms.Label LabelAddSupplier;
    }
}