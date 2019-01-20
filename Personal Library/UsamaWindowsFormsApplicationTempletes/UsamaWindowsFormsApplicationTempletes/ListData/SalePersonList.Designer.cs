namespace UsamaWindowsFormsApplicationTempletes.ListData
{
    partial class SalePersonList
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
            this.buttonAddSalePerson = new System.Windows.Forms.Button();
            this.listBoxSalePerson = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAddSalePerson
            // 
            this.buttonAddSalePerson.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddSalePerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddSalePerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddSalePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSalePerson.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSalePerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddSalePerson.Location = new System.Drawing.Point(93, 411);
            this.buttonAddSalePerson.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonAddSalePerson.Name = "buttonAddSalePerson";
            this.buttonAddSalePerson.Size = new System.Drawing.Size(160, 37);
            this.buttonAddSalePerson.TabIndex = 8;
            this.buttonAddSalePerson.Text = "Add Sale Person";
            this.buttonAddSalePerson.UseVisualStyleBackColor = true;
            this.buttonAddSalePerson.Click += new System.EventHandler(this.buttonAddSalePerson_Click);
            // 
            // listBoxSalePerson
            // 
            this.listBoxSalePerson.FormattingEnabled = true;
            this.listBoxSalePerson.ItemHeight = 21;
            this.listBoxSalePerson.Location = new System.Drawing.Point(40, 48);
            this.listBoxSalePerson.Name = "listBoxSalePerson";
            this.listBoxSalePerson.Size = new System.Drawing.Size(266, 340);
            this.listBoxSalePerson.TabIndex = 7;
            // 
            // SalePersonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 458);
            this.Controls.Add(this.buttonAddSalePerson);
            this.Controls.Add(this.listBoxSalePerson);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SalePersonList";
            this.Text = "SalePersonList";
            this.Load += new System.EventHandler(this.SalePersonList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddSalePerson;
        private System.Windows.Forms.ListBox listBoxSalePerson;
    }
}