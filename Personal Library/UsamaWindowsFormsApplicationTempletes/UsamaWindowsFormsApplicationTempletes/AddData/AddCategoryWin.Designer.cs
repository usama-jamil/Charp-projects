namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    partial class AddCategoryWin
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
            this.labelCategory = new System.Windows.Forms.Label();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.ErrorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(15, 87);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(80, 21);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Tag = "";
            this.labelCategory.Text = "Category :";
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "ali",
            "manu",
            "muna",
            "pakistan",
            "jamil",
            "usama",
            "india"});
            this.TextBoxCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCategory.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxCategory.Location = new System.Drawing.Point(102, 85);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(183, 26);
            this.TextBoxCategory.TabIndex = 2;
            this.TextBoxCategory.Tag = "Category Name...";
            this.TextBoxCategory.Text = "Category Name...";
            this.TextBoxCategory.Enter += new System.EventHandler(this.CategoryTextBox_Enter);
            this.TextBoxCategory.Leave += new System.EventHandler(this.CategoryTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 1;
            this.label1.Tag = "";
            this.label1.Text = "Add Category";
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddCategory.Location = new System.Drawing.Point(94, 161);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(108, 29);
            this.buttonAddCategory.TabIndex = 26;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorName.ForeColor = System.Drawing.Color.Red;
            this.ErrorName.Location = new System.Drawing.Point(102, 114);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(15, 20);
            this.ErrorName.TabIndex = 27;
            this.ErrorName.Text = "*";
            this.ErrorName.Visible = false;
            // 
            // AddCategoryWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 200);
            this.Controls.Add(this.ErrorName);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.TextBoxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCategory);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCategoryWin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "AddCategory";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Label ErrorName;
    }
}