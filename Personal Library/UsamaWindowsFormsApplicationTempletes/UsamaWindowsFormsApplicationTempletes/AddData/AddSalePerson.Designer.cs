namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    partial class AddSalePerson
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
            this.buttonAddBroker = new System.Windows.Forms.Button();
            this.ErrorName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddSalePerson = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.ErrorSalary = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.ErrorAddress = new System.Windows.Forms.Label();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.ErrorPhoneNo = new System.Windows.Forms.Label();
            this.labelCNIC = new System.Windows.Forms.Label();
            this.textBoxCNIC = new System.Windows.Forms.TextBox();
            this.ErrorCNIC = new System.Windows.Forms.Label();
            this.JoinningDate = new System.Windows.Forms.DateTimePicker();
            this.labelJoinningDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddBroker
            // 
            this.buttonAddBroker.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddBroker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddBroker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddBroker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBroker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBroker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddBroker.Location = new System.Drawing.Point(136, 436);
            this.buttonAddBroker.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.buttonAddBroker.Name = "buttonAddBroker";
            this.buttonAddBroker.Size = new System.Drawing.Size(157, 40);
            this.buttonAddBroker.TabIndex = 6;
            this.buttonAddBroker.Text = "Add SalePerson";
            this.buttonAddBroker.UseVisualStyleBackColor = true;
            this.buttonAddBroker.Click += new System.EventHandler(this.buttonAddSalePerson_Click);
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorName.ForeColor = System.Drawing.Color.Red;
            this.ErrorName.Location = new System.Drawing.Point(150, 122);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(15, 20);
            this.ErrorName.TabIndex = 25;
            this.ErrorName.Text = "*";
            this.ErrorName.Visible = false;
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
            this.TextBoxName.Location = new System.Drawing.Point(140, 93);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(293, 26);
            this.TextBoxName.TabIndex = 22;
            this.TextBoxName.Tag = "Your Name...";
            this.TextBoxName.Text = "Your Name...";
            this.TextBoxName.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelName.Location = new System.Drawing.Point(11, 96);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 21);
            this.labelName.TabIndex = 23;
            this.labelName.Tag = "";
            this.labelName.Text = "Name :";
            // 
            // labelAddSalePerson
            // 
            this.labelAddSalePerson.AutoSize = true;
            this.labelAddSalePerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelAddSalePerson.Location = new System.Drawing.Point(11, 20);
            this.labelAddSalePerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddSalePerson.Name = "labelAddSalePerson";
            this.labelAddSalePerson.Size = new System.Drawing.Size(122, 21);
            this.labelAddSalePerson.TabIndex = 24;
            this.labelAddSalePerson.Tag = "";
            this.labelAddSalePerson.Text = "Add Sale Person";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelSalary.Location = new System.Drawing.Point(11, 204);
            this.labelSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(60, 21);
            this.labelSalary.TabIndex = 23;
            this.labelSalary.Tag = "";
            this.labelSalary.Text = "Salary :";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.textBoxSalary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSalary.Location = new System.Drawing.Point(140, 201);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(293, 26);
            this.textBoxSalary.TabIndex = 22;
            this.textBoxSalary.Tag = "Your Salary...";
            this.textBoxSalary.Text = "Your Salary...";
            this.textBoxSalary.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxSalary.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // ErrorSalary
            // 
            this.ErrorSalary.AutoSize = true;
            this.ErrorSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorSalary.ForeColor = System.Drawing.Color.Red;
            this.ErrorSalary.Location = new System.Drawing.Point(150, 230);
            this.ErrorSalary.Name = "ErrorSalary";
            this.ErrorSalary.Size = new System.Drawing.Size(15, 20);
            this.ErrorSalary.TabIndex = 25;
            this.ErrorSalary.Text = "*";
            this.ErrorSalary.Visible = false;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelAddress.Location = new System.Drawing.Point(11, 150);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(73, 21);
            this.labelAddress.TabIndex = 23;
            this.labelAddress.Tag = "";
            this.labelAddress.Text = "Address :";
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
            this.textBoxAddress.Location = new System.Drawing.Point(140, 147);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(293, 26);
            this.textBoxAddress.TabIndex = 22;
            this.textBoxAddress.Tag = "Your Address...";
            this.textBoxAddress.Text = "Your Address...";
            this.textBoxAddress.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxAddress.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // ErrorAddress
            // 
            this.ErrorAddress.AutoSize = true;
            this.ErrorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorAddress.ForeColor = System.Drawing.Color.Red;
            this.ErrorAddress.Location = new System.Drawing.Point(150, 176);
            this.ErrorAddress.Name = "ErrorAddress";
            this.ErrorAddress.Size = new System.Drawing.Size(15, 20);
            this.ErrorAddress.TabIndex = 25;
            this.ErrorAddress.Text = "*";
            this.ErrorAddress.Visible = false;
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelPhoneNo.Location = new System.Drawing.Point(11, 312);
            this.labelPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(86, 21);
            this.labelPhoneNo.TabIndex = 23;
            this.labelPhoneNo.Tag = "";
            this.labelPhoneNo.Text = "Phone No :";
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.textBoxPhoneNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPhoneNo.Location = new System.Drawing.Point(140, 309);
            this.textBoxPhoneNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(293, 26);
            this.textBoxPhoneNo.TabIndex = 22;
            this.textBoxPhoneNo.Tag = "Your PhoneNo...";
            this.textBoxPhoneNo.Text = "Your PhoneNo...";
            this.textBoxPhoneNo.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxPhoneNo.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // ErrorPhoneNo
            // 
            this.ErrorPhoneNo.AutoSize = true;
            this.ErrorPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPhoneNo.ForeColor = System.Drawing.Color.Red;
            this.ErrorPhoneNo.Location = new System.Drawing.Point(150, 338);
            this.ErrorPhoneNo.Name = "ErrorPhoneNo";
            this.ErrorPhoneNo.Size = new System.Drawing.Size(15, 20);
            this.ErrorPhoneNo.TabIndex = 25;
            this.ErrorPhoneNo.Text = "*";
            this.ErrorPhoneNo.Visible = false;
            // 
            // labelCNIC
            // 
            this.labelCNIC.AutoSize = true;
            this.labelCNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelCNIC.Location = new System.Drawing.Point(11, 258);
            this.labelCNIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCNIC.Name = "labelCNIC";
            this.labelCNIC.Size = new System.Drawing.Size(53, 21);
            this.labelCNIC.TabIndex = 23;
            this.labelCNIC.Tag = "";
            this.labelCNIC.Text = "CNIC :";
            // 
            // textBoxCNIC
            // 
            this.textBoxCNIC.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.textBoxCNIC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCNIC.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCNIC.Location = new System.Drawing.Point(140, 255);
            this.textBoxCNIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCNIC.Name = "textBoxCNIC";
            this.textBoxCNIC.Size = new System.Drawing.Size(293, 26);
            this.textBoxCNIC.TabIndex = 22;
            this.textBoxCNIC.Tag = "Your CNIC...";
            this.textBoxCNIC.Text = "Your CNIC...";
            this.textBoxCNIC.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxCNIC.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // ErrorCNIC
            // 
            this.ErrorCNIC.AutoSize = true;
            this.ErrorCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorCNIC.ForeColor = System.Drawing.Color.Red;
            this.ErrorCNIC.Location = new System.Drawing.Point(150, 284);
            this.ErrorCNIC.Name = "ErrorCNIC";
            this.ErrorCNIC.Size = new System.Drawing.Size(15, 20);
            this.ErrorCNIC.TabIndex = 25;
            this.ErrorCNIC.Text = "*";
            this.ErrorCNIC.Visible = false;
            // 
            // JoinningDate
            // 
            this.JoinningDate.CustomFormat = "";
            this.JoinningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.JoinningDate.Location = new System.Drawing.Point(140, 363);
            this.JoinningDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JoinningDate.Name = "JoinningDate";
            this.JoinningDate.ShowCheckBox = true;
            this.JoinningDate.Size = new System.Drawing.Size(293, 29);
            this.JoinningDate.TabIndex = 27;
            this.JoinningDate.Value = new System.DateTime(2018, 5, 31, 0, 0, 0, 0);
            // 
            // labelJoinningDate
            // 
            this.labelJoinningDate.AutoSize = true;
            this.labelJoinningDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelJoinningDate.Location = new System.Drawing.Point(11, 368);
            this.labelJoinningDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJoinningDate.Name = "labelJoinningDate";
            this.labelJoinningDate.Size = new System.Drawing.Size(112, 21);
            this.labelJoinningDate.TabIndex = 26;
            this.labelJoinningDate.Tag = "";
            this.labelJoinningDate.Text = "Joinning Date :";
            // 
            // AddSalePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 498);
            this.Controls.Add(this.JoinningDate);
            this.Controls.Add(this.labelJoinningDate);
            this.Controls.Add(this.ErrorCNIC);
            this.Controls.Add(this.ErrorPhoneNo);
            this.Controls.Add(this.ErrorAddress);
            this.Controls.Add(this.ErrorSalary);
            this.Controls.Add(this.ErrorName);
            this.Controls.Add(this.textBoxCNIC);
            this.Controls.Add(this.labelCNIC);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddSalePerson);
            this.Controls.Add(this.buttonAddBroker);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddSalePerson";
            this.Text = "AddSalePerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddBroker;
        private System.Windows.Forms.Label ErrorName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddSalePerson;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label ErrorSalary;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label ErrorAddress;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label ErrorPhoneNo;
        private System.Windows.Forms.Label labelCNIC;
        private System.Windows.Forms.TextBox textBoxCNIC;
        private System.Windows.Forms.Label ErrorCNIC;
        private System.Windows.Forms.DateTimePicker JoinningDate;
        private System.Windows.Forms.Label labelJoinningDate;
    }
}