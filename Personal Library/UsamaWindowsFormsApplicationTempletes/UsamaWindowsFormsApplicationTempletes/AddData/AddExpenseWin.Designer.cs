namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    partial class AddExpenseWin
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
            this.ExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.TextBoxBillNo = new System.Windows.Forms.TextBox();
            this.labelBillNo = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.radioButtonChecque = new System.Windows.Forms.RadioButton();
            this.radioButtonCreditCard = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.labelPaymentMode = new System.Windows.Forms.Label();
            this.labelAddExpense = new System.Windows.Forms.Label();
            this.buttonAddExpense = new System.Windows.Forms.Button();
            this.ErrorTitle = new System.Windows.Forms.Label();
            this.ErrorBillNo = new System.Windows.Forms.Label();
            this.ErrorAmount = new System.Windows.Forms.Label();
            this.ErrorDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExpenseDate
            // 
            this.ExpenseDate.CustomFormat = "";
            this.ExpenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpenseDate.Location = new System.Drawing.Point(160, 419);
            this.ExpenseDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExpenseDate.Name = "ExpenseDate";
            this.ExpenseDate.ShowCheckBox = true;
            this.ExpenseDate.Size = new System.Drawing.Size(312, 29);
            this.ExpenseDate.TabIndex = 7;
            this.ExpenseDate.Value = new System.DateTime(2018, 5, 19, 0, 0, 0, 0);
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.TextBoxAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAmount.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxAmount.Location = new System.Drawing.Point(160, 362);
            this.TextBoxAmount.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(312, 26);
            this.TextBoxAmount.TabIndex = 6;
            this.TextBoxAmount.Tag = "Amount...";
            this.TextBoxAmount.Text = "Amount...";
            this.TextBoxAmount.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxAmount.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelDate.Location = new System.Drawing.Point(15, 425);
            this.labelDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(49, 21);
            this.labelDate.TabIndex = 9;
            this.labelDate.Tag = "";
            this.labelDate.Text = "Date :";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelAmount.Location = new System.Drawing.Point(15, 362);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(82, 21);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Tag = "";
            this.labelAmount.Text = "Amouont :";
            // 
            // TextBoxBillNo
            // 
            this.TextBoxBillNo.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.TextBoxBillNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBillNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxBillNo.Location = new System.Drawing.Point(160, 251);
            this.TextBoxBillNo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TextBoxBillNo.Name = "TextBoxBillNo";
            this.TextBoxBillNo.Size = new System.Drawing.Size(312, 26);
            this.TextBoxBillNo.TabIndex = 2;
            this.TextBoxBillNo.Tag = "Bill No...";
            this.TextBoxBillNo.Text = "Bill No...";
            this.TextBoxBillNo.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxBillNo.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelBillNo
            // 
            this.labelBillNo.AutoSize = true;
            this.labelBillNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelBillNo.Location = new System.Drawing.Point(15, 253);
            this.labelBillNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelBillNo.Name = "labelBillNo";
            this.labelBillNo.Size = new System.Drawing.Size(63, 21);
            this.labelBillNo.TabIndex = 13;
            this.labelBillNo.Tag = "";
            this.labelBillNo.Text = "Bill No :";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.TextBoxDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxDescription.Location = new System.Drawing.Point(160, 129);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(312, 86);
            this.TextBoxDescription.TabIndex = 1;
            this.TextBoxDescription.Tag = "Description...";
            this.TextBoxDescription.Text = "Description...";
            this.TextBoxDescription.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxDescription.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelDescription.Location = new System.Drawing.Point(15, 131);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(96, 21);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Tag = "";
            this.labelDescription.Text = "Description :";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.TextBoxTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTitle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxTitle.Location = new System.Drawing.Point(160, 77);
            this.TextBoxTitle.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(312, 26);
            this.TextBoxTitle.TabIndex = 0;
            this.TextBoxTitle.Tag = "Title...";
            this.TextBoxTitle.Text = "Title...";
            this.TextBoxTitle.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxTitle.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTitle.Location = new System.Drawing.Point(15, 79);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(46, 21);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Tag = "";
            this.labelTitle.Text = "Title :";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(-39, -45);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(110, 21);
            this.labelCategory.TabIndex = 16;
            this.labelCategory.Tag = "";
            this.labelCategory.Text = "Add Customer";
            // 
            // radioButtonChecque
            // 
            this.radioButtonChecque.AutoSize = true;
            this.radioButtonChecque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.radioButtonChecque.Location = new System.Drawing.Point(252, 306);
            this.radioButtonChecque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonChecque.Name = "radioButtonChecque";
            this.radioButtonChecque.Size = new System.Drawing.Size(88, 25);
            this.radioButtonChecque.TabIndex = 4;
            this.radioButtonChecque.Text = "Checque";
            this.radioButtonChecque.UseVisualStyleBackColor = true;
            this.radioButtonChecque.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // radioButtonCreditCard
            // 
            this.radioButtonCreditCard.AutoSize = true;
            this.radioButtonCreditCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.radioButtonCreditCard.Location = new System.Drawing.Point(356, 308);
            this.radioButtonCreditCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCreditCard.Name = "radioButtonCreditCard";
            this.radioButtonCreditCard.Size = new System.Drawing.Size(107, 25);
            this.radioButtonCreditCard.TabIndex = 5;
            this.radioButtonCreditCard.Text = "Credit Card";
            this.radioButtonCreditCard.UseVisualStyleBackColor = true;
            this.radioButtonCreditCard.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Checked = true;
            this.radioButtonCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.radioButtonCash.Location = new System.Drawing.Point(174, 306);
            this.radioButtonCash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(62, 25);
            this.radioButtonCash.TabIndex = 3;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            this.radioButtonCash.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // labelPaymentMode
            // 
            this.labelPaymentMode.AutoSize = true;
            this.labelPaymentMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelPaymentMode.Location = new System.Drawing.Point(15, 308);
            this.labelPaymentMode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPaymentMode.Name = "labelPaymentMode";
            this.labelPaymentMode.Size = new System.Drawing.Size(135, 21);
            this.labelPaymentMode.TabIndex = 22;
            this.labelPaymentMode.Tag = "";
            this.labelPaymentMode.Text = "Payment Method :";
            // 
            // labelAddExpense
            // 
            this.labelAddExpense.AutoSize = true;
            this.labelAddExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelAddExpense.Location = new System.Drawing.Point(31, 23);
            this.labelAddExpense.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddExpense.Name = "labelAddExpense";
            this.labelAddExpense.Size = new System.Drawing.Size(98, 21);
            this.labelAddExpense.TabIndex = 23;
            this.labelAddExpense.Tag = "";
            this.labelAddExpense.Text = "Add Expense";
            // 
            // buttonAddExpense
            // 
            this.buttonAddExpense.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddExpense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddExpense.Location = new System.Drawing.Point(200, 468);
            this.buttonAddExpense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddExpense.Name = "buttonAddExpense";
            this.buttonAddExpense.Size = new System.Drawing.Size(132, 33);
            this.buttonAddExpense.TabIndex = 8;
            this.buttonAddExpense.Text = "Add Expense";
            this.buttonAddExpense.UseVisualStyleBackColor = true;
            this.buttonAddExpense.Click += new System.EventHandler(this.buttonAddExpense_Click);
            // 
            // ErrorTitle
            // 
            this.ErrorTitle.AutoSize = true;
            this.ErrorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorTitle.ForeColor = System.Drawing.Color.Red;
            this.ErrorTitle.Location = new System.Drawing.Point(182, 106);
            this.ErrorTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorTitle.Name = "ErrorTitle";
            this.ErrorTitle.Size = new System.Drawing.Size(15, 20);
            this.ErrorTitle.TabIndex = 25;
            this.ErrorTitle.Text = "*";
            this.ErrorTitle.Visible = false;
            // 
            // ErrorBillNo
            // 
            this.ErrorBillNo.AutoSize = true;
            this.ErrorBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorBillNo.ForeColor = System.Drawing.Color.Red;
            this.ErrorBillNo.Location = new System.Drawing.Point(182, 280);
            this.ErrorBillNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorBillNo.Name = "ErrorBillNo";
            this.ErrorBillNo.Size = new System.Drawing.Size(15, 20);
            this.ErrorBillNo.TabIndex = 25;
            this.ErrorBillNo.Text = "*";
            this.ErrorBillNo.Visible = false;
            // 
            // ErrorAmount
            // 
            this.ErrorAmount.AutoSize = true;
            this.ErrorAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorAmount.ForeColor = System.Drawing.Color.Red;
            this.ErrorAmount.Location = new System.Drawing.Point(182, 391);
            this.ErrorAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorAmount.Name = "ErrorAmount";
            this.ErrorAmount.Size = new System.Drawing.Size(15, 20);
            this.ErrorAmount.TabIndex = 25;
            this.ErrorAmount.Text = "*";
            this.ErrorAmount.Visible = false;
            // 
            // ErrorDescription
            // 
            this.ErrorDescription.AutoSize = true;
            this.ErrorDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorDescription.ForeColor = System.Drawing.Color.Red;
            this.ErrorDescription.Location = new System.Drawing.Point(182, 219);
            this.ErrorDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorDescription.Name = "ErrorDescription";
            this.ErrorDescription.Size = new System.Drawing.Size(15, 20);
            this.ErrorDescription.TabIndex = 25;
            this.ErrorDescription.Text = "*";
            this.ErrorDescription.Visible = false;
            // 
            // AddExpenseWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 516);
            this.Controls.Add(this.ErrorAmount);
            this.Controls.Add(this.ErrorDescription);
            this.Controls.Add(this.ErrorBillNo);
            this.Controls.Add(this.ErrorTitle);
            this.Controls.Add(this.buttonAddExpense);
            this.Controls.Add(this.labelAddExpense);
            this.Controls.Add(this.labelPaymentMode);
            this.Controls.Add(this.radioButtonChecque);
            this.Controls.Add(this.radioButtonCreditCard);
            this.Controls.Add(this.radioButtonCash);
            this.Controls.Add(this.ExpenseDate);
            this.Controls.Add(this.TextBoxAmount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.TextBoxBillNo);
            this.Controls.Add(this.labelBillNo);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelCategory);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddExpenseWin";
            this.Text = "AddExpense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ExpenseDate;
        private System.Windows.Forms.TextBox TextBoxAmount;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox TextBoxBillNo;
        private System.Windows.Forms.Label labelBillNo;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.RadioButton radioButtonChecque;
        private System.Windows.Forms.RadioButton radioButtonCreditCard;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.Label labelPaymentMode;
        private System.Windows.Forms.Label labelAddExpense;
        private System.Windows.Forms.Button buttonAddExpense;
        private System.Windows.Forms.Label ErrorTitle;
        private System.Windows.Forms.Label ErrorBillNo;
        private System.Windows.Forms.Label ErrorAmount;
        private System.Windows.Forms.Label ErrorDescription;
    }
}