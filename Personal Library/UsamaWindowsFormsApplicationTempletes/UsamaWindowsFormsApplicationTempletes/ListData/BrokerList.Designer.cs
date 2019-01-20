namespace UsamaWindowsFormsApplicationTempletes.ListData
{
    partial class BrokerList
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
            this.listBoxBroker = new System.Windows.Forms.ListBox();
            this.buttonAddBroker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBroker
            // 
            this.listBoxBroker.FormattingEnabled = true;
            this.listBoxBroker.ItemHeight = 21;
            this.listBoxBroker.Location = new System.Drawing.Point(53, 52);
            this.listBoxBroker.Name = "listBoxBroker";
            this.listBoxBroker.Size = new System.Drawing.Size(266, 340);
            this.listBoxBroker.TabIndex = 1;
            // 
            // buttonAddBroker
            // 
            this.buttonAddBroker.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddBroker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddBroker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddBroker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBroker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBroker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddBroker.Location = new System.Drawing.Point(118, 421);
            this.buttonAddBroker.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonAddBroker.Name = "buttonAddBroker";
            this.buttonAddBroker.Size = new System.Drawing.Size(137, 37);
            this.buttonAddBroker.TabIndex = 6;
            this.buttonAddBroker.Text = "Add Broker";
            this.buttonAddBroker.UseVisualStyleBackColor = true;
            this.buttonAddBroker.Click += new System.EventHandler(this.buttonAddBroker_Click);
            // 
            // BrokerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 472);
            this.Controls.Add(this.buttonAddBroker);
            this.Controls.Add(this.listBoxBroker);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BrokerList";
            this.Text = "BrokerList";
            this.Load += new System.EventHandler(this.BrokerList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBroker;
        private System.Windows.Forms.Button buttonAddBroker;
    }
}