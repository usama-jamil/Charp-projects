namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    partial class AddProductWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductWin));
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.DropDownSupplier = new System.Windows.Forms.ComboBox();
            this.DropDownCategory = new System.Windows.Forms.ComboBox();
            this.ButtonAddNewSupplier = new Bunifu.Framework.UI.BunifuImageButton();
            this.ButtonAddNewCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.ErrorName = new System.Windows.Forms.Label();
            this.ErrorDescription = new System.Windows.Forms.Label();
            this.ErrorSupplier = new System.Windows.Forms.Label();
            this.ErrorCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddNewSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddNewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(19, 315);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(80, 21);
            this.labelCategory.TabIndex = 10;
            this.labelCategory.Tag = "";
            this.labelCategory.Text = "Category :";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(19, 256);
            this.labelSupplier.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(75, 21);
            this.labelSupplier.TabIndex = 12;
            this.labelSupplier.Tag = "";
            this.labelSupplier.Text = "Supplier :";
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
            this.TextBoxDescription.Location = new System.Drawing.Point(123, 138);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(342, 91);
            this.TextBoxDescription.TabIndex = 1;
            this.TextBoxDescription.Tag = "Description...";
            this.TextBoxDescription.Text = "Description...";
            this.TextBoxDescription.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxDescription.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(19, 138);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(96, 21);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Tag = "";
            this.labelDescription.Text = "Description :";
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
            this.TextBoxName.Location = new System.Drawing.Point(123, 77);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(342, 26);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.Tag = "Product Name...";
            this.TextBoxName.Text = "Product Name...";
            this.TextBoxName.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 77);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 21);
            this.labelName.TabIndex = 15;
            this.labelName.Tag = "";
            this.labelName.Text = "Name :";
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Location = new System.Drawing.Point(38, 23);
            this.labelAddProduct.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(96, 21);
            this.labelAddProduct.TabIndex = 16;
            this.labelAddProduct.Tag = "";
            this.labelAddProduct.Text = "Add Product";
            // 
            // DropDownSupplier
            // 
            this.DropDownSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownSupplier.FormattingEnabled = true;
            this.DropDownSupplier.Location = new System.Drawing.Point(123, 256);
            this.DropDownSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DropDownSupplier.Name = "DropDownSupplier";
            this.DropDownSupplier.Size = new System.Drawing.Size(299, 28);
            this.DropDownSupplier.TabIndex = 3;
            // 
            // DropDownCategory
            // 
            this.DropDownCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownCategory.FormattingEnabled = true;
            this.DropDownCategory.Location = new System.Drawing.Point(123, 315);
            this.DropDownCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DropDownCategory.Name = "DropDownCategory";
            this.DropDownCategory.Size = new System.Drawing.Size(299, 28);
            this.DropDownCategory.TabIndex = 4;
            // 
            // ButtonAddNewSupplier
            // 
            this.ButtonAddNewSupplier.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonAddNewSupplier.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddNewSupplier.Image")));
            this.ButtonAddNewSupplier.ImageActive = null;
            this.ButtonAddNewSupplier.Location = new System.Drawing.Point(430, 256);
            this.ButtonAddNewSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAddNewSupplier.Name = "ButtonAddNewSupplier";
            this.ButtonAddNewSupplier.Size = new System.Drawing.Size(35, 29);
            this.ButtonAddNewSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAddNewSupplier.TabIndex = 18;
            this.ButtonAddNewSupplier.TabStop = false;
            this.ButtonAddNewSupplier.Zoom = 10;
            this.ButtonAddNewSupplier.Click += new System.EventHandler(this.ButtonAddNewSupplier_Click);
            // 
            // ButtonAddNewCategory
            // 
            this.ButtonAddNewCategory.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonAddNewCategory.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddNewCategory.Image")));
            this.ButtonAddNewCategory.ImageActive = null;
            this.ButtonAddNewCategory.Location = new System.Drawing.Point(430, 315);
            this.ButtonAddNewCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAddNewCategory.Name = "ButtonAddNewCategory";
            this.ButtonAddNewCategory.Size = new System.Drawing.Size(35, 28);
            this.ButtonAddNewCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAddNewCategory.TabIndex = 18;
            this.ButtonAddNewCategory.TabStop = false;
            this.ButtonAddNewCategory.Zoom = 10;
            this.ButtonAddNewCategory.Click += new System.EventHandler(this.ButtonAddNewCategory_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddProduct.Location = new System.Drawing.Point(176, 380);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(137, 37);
            this.buttonAddProduct.TabIndex = 5;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorName.ForeColor = System.Drawing.Color.Red;
            this.ErrorName.Location = new System.Drawing.Point(130, 106);
            this.ErrorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(15, 20);
            this.ErrorName.TabIndex = 27;
            this.ErrorName.Text = "*";
            this.ErrorName.Visible = false;
            // 
            // ErrorDescription
            // 
            this.ErrorDescription.AutoSize = true;
            this.ErrorDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorDescription.ForeColor = System.Drawing.Color.Red;
            this.ErrorDescription.Location = new System.Drawing.Point(130, 233);
            this.ErrorDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorDescription.Name = "ErrorDescription";
            this.ErrorDescription.Size = new System.Drawing.Size(15, 20);
            this.ErrorDescription.TabIndex = 27;
            this.ErrorDescription.Text = "*";
            this.ErrorDescription.Visible = false;
            // 
            // ErrorSupplier
            // 
            this.ErrorSupplier.AutoSize = true;
            this.ErrorSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorSupplier.ForeColor = System.Drawing.Color.Red;
            this.ErrorSupplier.Location = new System.Drawing.Point(130, 287);
            this.ErrorSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorSupplier.Name = "ErrorSupplier";
            this.ErrorSupplier.Size = new System.Drawing.Size(15, 20);
            this.ErrorSupplier.TabIndex = 27;
            this.ErrorSupplier.Text = "*";
            this.ErrorSupplier.Visible = false;
            // 
            // ErrorCategory
            // 
            this.ErrorCategory.AutoSize = true;
            this.ErrorCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorCategory.ForeColor = System.Drawing.Color.Red;
            this.ErrorCategory.Location = new System.Drawing.Point(130, 346);
            this.ErrorCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorCategory.Name = "ErrorCategory";
            this.ErrorCategory.Size = new System.Drawing.Size(15, 20);
            this.ErrorCategory.TabIndex = 27;
            this.ErrorCategory.Text = "*";
            this.ErrorCategory.Visible = false;
            // 
            // AddProductWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 437);
            this.Controls.Add(this.ErrorCategory);
            this.Controls.Add(this.ErrorSupplier);
            this.Controls.Add(this.ErrorDescription);
            this.Controls.Add(this.ErrorName);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.ButtonAddNewCategory);
            this.Controls.Add(this.ButtonAddNewSupplier);
            this.Controls.Add(this.DropDownCategory);
            this.Controls.Add(this.DropDownSupplier);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddProductWin";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddNewSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddNewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.ComboBox DropDownSupplier;
        private System.Windows.Forms.ComboBox DropDownCategory;
        private Bunifu.Framework.UI.BunifuImageButton ButtonAddNewSupplier;
        private Bunifu.Framework.UI.BunifuImageButton ButtonAddNewCategory;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label ErrorName;
        private System.Windows.Forms.Label ErrorDescription;
        private System.Windows.Forms.Label ErrorSupplier;
        private System.Windows.Forms.Label ErrorCategory;
    }
}