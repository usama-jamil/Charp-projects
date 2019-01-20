namespace tutorial
{
    partial class mainform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sheri carpet Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Carpeting Cost";
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(213, 149);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(75, 23);
            this.area.TabIndex = 6;
            this.area.Text = "Area";
            this.area.UseVisualStyleBackColor = true;
            this.area.Click += new System.EventHandler(this.area_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(436, 343);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(213, 255);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(75, 23);
            this.cost.TabIndex = 8;
            this.cost.Text = "Room Cost";
            this.cost.UseVisualStyleBackColor = true;
            this.cost.Click += new System.EventHandler(this.cost_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(132, 90);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 9;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(183, 206);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(100, 20);
            this.txtcost.TabIndex = 10;
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(378, 89);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(100, 20);
            this.txtlength.TabIndex = 11;
            // 
            // lblarea
            // 
            this.lblarea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblarea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblarea.Location = new System.Drawing.Point(149, 299);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(100, 24);
            this.lblarea.TabIndex = 12;
            // 
            // lblcost
            // 
            this.lblcost.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblcost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcost.Location = new System.Drawing.Point(149, 350);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(100, 24);
            this.lblcost.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price per square inch";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 410);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.txtlength);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainform";
            this.Text = "program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button area;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button cost;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label label6;
    }
}

