namespace TournamentViewerForm
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.labelHeader = new System.Windows.Forms.Label();
            this.comboBoxLoadExistingTournament = new System.Windows.Forms.ComboBox();
            this.labelLoadExistingTournament = new System.Windows.Forms.Label();
            this.buttonCreateTournament = new System.Windows.Forms.Button();
            this.buttonLoadTournament = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelHeader.Location = new System.Drawing.Point(92, 49);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(385, 50);
            this.labelHeader.TabIndex = 29;
            this.labelHeader.Text = "Tournament Dashboard";
            // 
            // comboBoxLoadExistingTournament
            // 
            this.comboBoxLoadExistingTournament.FormattingEnabled = true;
            this.comboBoxLoadExistingTournament.Location = new System.Drawing.Point(100, 191);
            this.comboBoxLoadExistingTournament.Name = "comboBoxLoadExistingTournament";
            this.comboBoxLoadExistingTournament.Size = new System.Drawing.Size(369, 38);
            this.comboBoxLoadExistingTournament.TabIndex = 31;
            // 
            // labelLoadExistingTournament
            // 
            this.labelLoadExistingTournament.AutoSize = true;
            this.labelLoadExistingTournament.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadExistingTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelLoadExistingTournament.Location = new System.Drawing.Point(123, 151);
            this.labelLoadExistingTournament.Name = "labelLoadExistingTournament";
            this.labelLoadExistingTournament.Size = new System.Drawing.Size(322, 37);
            this.labelLoadExistingTournament.TabIndex = 30;
            this.labelLoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // buttonCreateTournament
            // 
            this.buttonCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonCreateTournament.Location = new System.Drawing.Point(167, 305);
            this.buttonCreateTournament.Name = "buttonCreateTournament";
            this.buttonCreateTournament.Size = new System.Drawing.Size(235, 42);
            this.buttonCreateTournament.TabIndex = 32;
            this.buttonCreateTournament.Text = "Create Tournament";
            this.buttonCreateTournament.UseVisualStyleBackColor = true;
            this.buttonCreateTournament.Click += new System.EventHandler(this.buttonCreateTournament_Click);
            // 
            // buttonLoadTournament
            // 
            this.buttonLoadTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonLoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonLoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonLoadTournament.Location = new System.Drawing.Point(185, 235);
            this.buttonLoadTournament.Name = "buttonLoadTournament";
            this.buttonLoadTournament.Size = new System.Drawing.Size(199, 36);
            this.buttonLoadTournament.TabIndex = 33;
            this.buttonLoadTournament.Text = "Load Tournament";
            this.buttonLoadTournament.UseVisualStyleBackColor = true;
            this.buttonLoadTournament.Click += new System.EventHandler(this.buttonLoadTournament_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 11);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 28);
            this.panel2.TabIndex = 35;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLoadTournament);
            this.Controls.Add(this.buttonCreateTournament);
            this.Controls.Add(this.comboBoxLoadExistingTournament);
            this.Controls.Add(this.labelLoadExistingTournament);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ComboBox comboBoxLoadExistingTournament;
        private System.Windows.Forms.Label labelLoadExistingTournament;
        private System.Windows.Forms.Button buttonCreateTournament;
        private System.Windows.Forms.Button buttonLoadTournament;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}