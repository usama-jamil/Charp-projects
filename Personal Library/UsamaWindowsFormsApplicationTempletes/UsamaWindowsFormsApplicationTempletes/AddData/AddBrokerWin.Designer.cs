namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    partial class AddBrokerWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBrokerWin));
            this.JoinningDate = new System.Windows.Forms.DateTimePicker();
            this.labelJoinningDate = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.TextBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddBroker = new System.Windows.Forms.Label();
            this.buttonAddBroker = new System.Windows.Forms.Button();
            this.ErrorName = new System.Windows.Forms.Label();
            this.ErrorAddress = new System.Windows.Forms.Label();
            this.ErrorSupplier = new System.Windows.Forms.Label();
            this.ErrorPhone = new System.Windows.Forms.Label();
            this.DropDownSupplier = new System.Windows.Forms.ComboBox();
            this.ButtonAddSupplier = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // JoinningDate
            // 
            this.JoinningDate.Location = new System.Drawing.Point(139, 303);
            this.JoinningDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JoinningDate.Name = "JoinningDate";
            this.JoinningDate.ShowCheckBox = true;
            this.JoinningDate.Size = new System.Drawing.Size(295, 29);
            this.JoinningDate.TabIndex = 4;
            // 
            // labelJoinningDate
            // 
            this.labelJoinningDate.AutoSize = true;
            this.labelJoinningDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelJoinningDate.Location = new System.Drawing.Point(9, 307);
            this.labelJoinningDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelJoinningDate.Name = "labelJoinningDate";
            this.labelJoinningDate.Size = new System.Drawing.Size(112, 21);
            this.labelJoinningDate.TabIndex = 9;
            this.labelJoinningDate.Tag = "";
            this.labelJoinningDate.Text = "Joinning Date :";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelSupplier.Location = new System.Drawing.Point(9, 248);
            this.labelSupplier.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(75, 21);
            this.labelSupplier.TabIndex = 10;
            this.labelSupplier.Tag = "";
            this.labelSupplier.Text = "Supplier :";
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
            this.TextBoxPhoneNo.Location = new System.Drawing.Point(139, 187);
            this.TextBoxPhoneNo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TextBoxPhoneNo.Name = "TextBoxPhoneNo";
            this.TextBoxPhoneNo.Size = new System.Drawing.Size(295, 26);
            this.TextBoxPhoneNo.TabIndex = 2;
            this.TextBoxPhoneNo.Tag = "Phone Number";
            this.TextBoxPhoneNo.Text = "Phone Number";
            this.TextBoxPhoneNo.Enter += new System.EventHandler(this.Textbox_Enter);
            this.TextBoxPhoneNo.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelPhoneNo.Location = new System.Drawing.Point(9, 189);
            this.labelPhoneNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(86, 21);
            this.labelPhoneNo.TabIndex = 13;
            this.labelPhoneNo.Tag = "";
            this.labelPhoneNo.Text = "Phone No :";
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
            this.TextBoxAddress.Location = new System.Drawing.Point(139, 129);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(295, 26);
            this.TextBoxAddress.TabIndex = 1;
            this.TextBoxAddress.Tag = "Address... ";
            this.TextBoxAddress.Text = "Address... ";
            this.TextBoxAddress.Enter += new System.EventHandler(this.Textbox_Enter);
            this.TextBoxAddress.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelAddress.Location = new System.Drawing.Point(9, 130);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(73, 21);
            this.labelAddress.TabIndex = 14;
            this.labelAddress.Tag = "";
            this.labelAddress.Text = "Address :";
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
            this.TextBoxName.Location = new System.Drawing.Point(139, 71);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(295, 26);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.Tag = "Broker Name...";
            this.TextBoxName.Text = "Broker Name...";
            this.TextBoxName.Enter += new System.EventHandler(this.Textbox_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelName.Location = new System.Drawing.Point(9, 71);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 21);
            this.labelName.TabIndex = 15;
            this.labelName.Tag = "";
            this.labelName.Text = "Name :";
            // 
            // labelAddBroker
            // 
            this.labelAddBroker.AutoSize = true;
            this.labelAddBroker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelAddBroker.Location = new System.Drawing.Point(9, 20);
            this.labelAddBroker.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddBroker.Name = "labelAddBroker";
            this.labelAddBroker.Size = new System.Drawing.Size(88, 21);
            this.labelAddBroker.TabIndex = 16;
            this.labelAddBroker.Tag = "";
            this.labelAddBroker.Text = "Add Broker";
            // 
            // buttonAddBroker
            // 
            this.buttonAddBroker.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddBroker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddBroker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddBroker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBroker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBroker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddBroker.Location = new System.Drawing.Point(156, 363);
            this.buttonAddBroker.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonAddBroker.Name = "buttonAddBroker";
            this.buttonAddBroker.Size = new System.Drawing.Size(137, 37);
            this.buttonAddBroker.TabIndex = 5;
            this.buttonAddBroker.Text = "Add Broker";
            this.buttonAddBroker.UseVisualStyleBackColor = true;
            this.buttonAddBroker.Click += new System.EventHandler(this.buttonAddBroker_Click);
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorName.ForeColor = System.Drawing.Color.Red;
            this.ErrorName.Location = new System.Drawing.Point(144, 98);
            this.ErrorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(15, 20);
            this.ErrorName.TabIndex = 26;
            this.ErrorName.Text = "*";
            this.ErrorName.Visible = false;
            // 
            // ErrorAddress
            // 
            this.ErrorAddress.AutoSize = true;
            this.ErrorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorAddress.ForeColor = System.Drawing.Color.Red;
            this.ErrorAddress.Location = new System.Drawing.Point(144, 157);
            this.ErrorAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorAddress.Name = "ErrorAddress";
            this.ErrorAddress.Size = new System.Drawing.Size(15, 20);
            this.ErrorAddress.TabIndex = 26;
            this.ErrorAddress.Text = "*";
            this.ErrorAddress.Visible = false;
            // 
            // ErrorSupplier
            // 
            this.ErrorSupplier.AutoSize = true;
            this.ErrorSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorSupplier.ForeColor = System.Drawing.Color.Red;
            this.ErrorSupplier.Location = new System.Drawing.Point(144, 270);
            this.ErrorSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorSupplier.Name = "ErrorSupplier";
            this.ErrorSupplier.Size = new System.Drawing.Size(15, 20);
            this.ErrorSupplier.TabIndex = 26;
            this.ErrorSupplier.Text = "*";
            this.ErrorSupplier.Visible = false;
            // 
            // ErrorPhone
            // 
            this.ErrorPhone.AutoSize = true;
            this.ErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.ErrorPhone.Location = new System.Drawing.Point(144, 215);
            this.ErrorPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorPhone.Name = "ErrorPhone";
            this.ErrorPhone.Size = new System.Drawing.Size(15, 20);
            this.ErrorPhone.TabIndex = 26;
            this.ErrorPhone.Text = "*";
            this.ErrorPhone.Visible = false;
            // 
            // DropDownSupplier
            // 
            this.DropDownSupplier.FormattingEnabled = true;
            this.DropDownSupplier.Location = new System.Drawing.Point(139, 238);
            this.DropDownSupplier.Name = "DropDownSupplier";
            this.DropDownSupplier.Size = new System.Drawing.Size(260, 29);
            this.DropDownSupplier.TabIndex = 3;
            // 
            // ButtonAddSupplier
            // 
            this.ButtonAddSupplier.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonAddSupplier.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddSupplier.Image")));
            this.ButtonAddSupplier.ImageActive = null;
            this.ButtonAddSupplier.Location = new System.Drawing.Point(405, 237);
            this.ButtonAddSupplier.Name = "ButtonAddSupplier";
            this.ButtonAddSupplier.Size = new System.Drawing.Size(29, 30);
            this.ButtonAddSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAddSupplier.TabIndex = 28;
            this.ButtonAddSupplier.TabStop = false;
            this.ButtonAddSupplier.Zoom = 10;
            // 
            // AddBrokerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 412);
            this.Controls.Add(this.ButtonAddSupplier);
            this.Controls.Add(this.DropDownSupplier);
            this.Controls.Add(this.ErrorSupplier);
            this.Controls.Add(this.ErrorPhone);
            this.Controls.Add(this.ErrorAddress);
            this.Controls.Add(this.ErrorName);
            this.Controls.Add(this.buttonAddBroker);
            this.Controls.Add(this.JoinningDate);
            this.Controls.Add(this.labelJoinningDate);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.TextBoxPhoneNo);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddBroker);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddBrokerWin";
            this.Text = "Broker";
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker JoinningDate;
        private System.Windows.Forms.Label labelJoinningDate;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.TextBox TextBoxPhoneNo;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddBroker;
        private System.Windows.Forms.Button buttonAddBroker;
        private System.Windows.Forms.Label ErrorName;
        private System.Windows.Forms.Label ErrorAddress;
        private System.Windows.Forms.Label ErrorSupplier;
        private System.Windows.Forms.Label ErrorPhone;
        private System.Windows.Forms.ComboBox DropDownSupplier;
        private Bunifu.Framework.UI.BunifuImageButton ButtonAddSupplier;
    }
}