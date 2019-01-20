namespace TournamentViewerForm
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBoxTournamentName = new System.Windows.Forms.TextBox();
            this.labelTournamentName = new System.Windows.Forms.Label();
            this.textBoxEntryFee = new System.Windows.Forms.TextBox();
            this.labelEntryFee = new System.Windows.Forms.Label();
            this.comboBoxSelectTeam = new System.Windows.Forms.ComboBox();
            this.labelSelectTeam = new System.Windows.Forms.Label();
            this.linkLabelCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonCreateTeam = new System.Windows.Forms.Button();
            this.listBoxTornamentTeams = new System.Windows.Forms.ListBox();
            this.labelTournametPlayers = new System.Windows.Forms.Label();
            this.buttonRemoveSelectedPlayers = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedPrize = new System.Windows.Forms.Button();
            this.labelprizes = new System.Windows.Forms.Label();
            this.listBoxPrizes = new System.Windows.Forms.ListBox();
            this.buttonCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(317, 50);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Create Tournament";
            // 
            // textBoxTournamentName
            // 
            this.textBoxTournamentName.Location = new System.Drawing.Point(36, 135);
            this.textBoxTournamentName.Name = "textBoxTournamentName";
            this.textBoxTournamentName.Size = new System.Drawing.Size(293, 35);
            this.textBoxTournamentName.TabIndex = 10;
            // 
            // labelTournamentName
            // 
            this.labelTournamentName.AutoSize = true;
            this.labelTournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTournamentName.Location = new System.Drawing.Point(29, 95);
            this.labelTournamentName.Name = "labelTournamentName";
            this.labelTournamentName.Size = new System.Drawing.Size(236, 37);
            this.labelTournamentName.TabIndex = 9;
            this.labelTournamentName.Text = "Tournament Name";
            // 
            // textBoxEntryFee
            // 
            this.textBoxEntryFee.Location = new System.Drawing.Point(160, 190);
            this.textBoxEntryFee.Name = "textBoxEntryFee";
            this.textBoxEntryFee.Size = new System.Drawing.Size(100, 35);
            this.textBoxEntryFee.TabIndex = 12;
            this.textBoxEntryFee.Text = "0";
            // 
            // labelEntryFee
            // 
            this.labelEntryFee.AutoSize = true;
            this.labelEntryFee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntryFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelEntryFee.Location = new System.Drawing.Point(29, 187);
            this.labelEntryFee.Name = "labelEntryFee";
            this.labelEntryFee.Size = new System.Drawing.Size(125, 37);
            this.labelEntryFee.TabIndex = 11;
            this.labelEntryFee.Text = "Entry Fee";
            // 
            // comboBoxSelectTeam
            // 
            this.comboBoxSelectTeam.FormattingEnabled = true;
            this.comboBoxSelectTeam.Location = new System.Drawing.Point(36, 345);
            this.comboBoxSelectTeam.Name = "comboBoxSelectTeam";
            this.comboBoxSelectTeam.Size = new System.Drawing.Size(293, 38);
            this.comboBoxSelectTeam.TabIndex = 14;
            // 
            // labelSelectTeam
            // 
            this.labelSelectTeam.AutoSize = true;
            this.labelSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelSelectTeam.Location = new System.Drawing.Point(29, 305);
            this.labelSelectTeam.Name = "labelSelectTeam";
            this.labelSelectTeam.Size = new System.Drawing.Size(156, 37);
            this.labelSelectTeam.TabIndex = 13;
            this.labelSelectTeam.Text = "Select Team";
            // 
            // linkLabelCreateNewTeam
            // 
            this.linkLabelCreateNewTeam.AutoSize = true;
            this.linkLabelCreateNewTeam.Location = new System.Drawing.Point(212, 312);
            this.linkLabelCreateNewTeam.Name = "linkLabelCreateNewTeam";
            this.linkLabelCreateNewTeam.Size = new System.Drawing.Size(117, 30);
            this.linkLabelCreateNewTeam.TabIndex = 15;
            this.linkLabelCreateNewTeam.TabStop = true;
            this.linkLabelCreateNewTeam.Text = "Create new";
            this.linkLabelCreateNewTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateNewTeam_LinkClicked);
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddTeam.Location = new System.Drawing.Point(113, 404);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(162, 36);
            this.buttonAddTeam.TabIndex = 16;
            this.buttonAddTeam.Text = "Add Team";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonCreateTeam
            // 
            this.buttonCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonCreateTeam.Location = new System.Drawing.Point(113, 461);
            this.buttonCreateTeam.Name = "buttonCreateTeam";
            this.buttonCreateTeam.Size = new System.Drawing.Size(162, 36);
            this.buttonCreateTeam.TabIndex = 17;
            this.buttonCreateTeam.Text = "Create Prize";
            this.buttonCreateTeam.UseVisualStyleBackColor = true;
            this.buttonCreateTeam.Click += new System.EventHandler(this.buttonCreateTeam_Click);
            // 
            // listBoxTornamentTeams
            // 
            this.listBoxTornamentTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTornamentTeams.FormattingEnabled = true;
            this.listBoxTornamentTeams.ItemHeight = 30;
            this.listBoxTornamentTeams.Location = new System.Drawing.Point(402, 130);
            this.listBoxTornamentTeams.Name = "listBoxTornamentTeams";
            this.listBoxTornamentTeams.Size = new System.Drawing.Size(319, 182);
            this.listBoxTornamentTeams.TabIndex = 18;
            // 
            // labelTournametPlayers
            // 
            this.labelTournametPlayers.AutoSize = true;
            this.labelTournametPlayers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournametPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTournametPlayers.Location = new System.Drawing.Point(395, 90);
            this.labelTournametPlayers.Name = "labelTournametPlayers";
            this.labelTournametPlayers.Size = new System.Drawing.Size(194, 37);
            this.labelTournametPlayers.TabIndex = 19;
            this.labelTournametPlayers.Text = " Team / Players";
            // 
            // buttonRemoveSelectedPlayers
            // 
            this.buttonRemoveSelectedPlayers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonRemoveSelectedPlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonRemoveSelectedPlayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonRemoveSelectedPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSelectedPlayers.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveSelectedPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonRemoveSelectedPlayers.Location = new System.Drawing.Point(730, 190);
            this.buttonRemoveSelectedPlayers.Name = "buttonRemoveSelectedPlayers";
            this.buttonRemoveSelectedPlayers.Size = new System.Drawing.Size(112, 80);
            this.buttonRemoveSelectedPlayers.TabIndex = 20;
            this.buttonRemoveSelectedPlayers.Text = "Remove Selected";
            this.buttonRemoveSelectedPlayers.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedPlayers.Click += new System.EventHandler(this.buttonRemoveSelectedPlayers_Click);
            // 
            // buttonRemoveSelectedPrize
            // 
            this.buttonRemoveSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonRemoveSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonRemoveSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonRemoveSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSelectedPrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveSelectedPrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonRemoveSelectedPrize.Location = new System.Drawing.Point(730, 404);
            this.buttonRemoveSelectedPrize.Name = "buttonRemoveSelectedPrize";
            this.buttonRemoveSelectedPrize.Size = new System.Drawing.Size(112, 76);
            this.buttonRemoveSelectedPrize.TabIndex = 23;
            this.buttonRemoveSelectedPrize.Text = "Reamove Selected";
            this.buttonRemoveSelectedPrize.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedPrize.Click += new System.EventHandler(this.buttonRemoveSelectedPrize_Click);
            // 
            // labelprizes
            // 
            this.labelprizes.AutoSize = true;
            this.labelprizes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelprizes.Location = new System.Drawing.Point(395, 326);
            this.labelprizes.Name = "labelprizes";
            this.labelprizes.Size = new System.Drawing.Size(85, 37);
            this.labelprizes.TabIndex = 22;
            this.labelprizes.Text = "Prizes";
            // 
            // listBoxPrizes
            // 
            this.listBoxPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPrizes.FormattingEnabled = true;
            this.listBoxPrizes.ItemHeight = 30;
            this.listBoxPrizes.Location = new System.Drawing.Point(402, 366);
            this.listBoxPrizes.Name = "listBoxPrizes";
            this.listBoxPrizes.Size = new System.Drawing.Size(319, 182);
            this.listBoxPrizes.TabIndex = 21;
            // 
            // buttonCreateTournament
            // 
            this.buttonCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonCreateTournament.Location = new System.Drawing.Point(352, 564);
            this.buttonCreateTournament.Name = "buttonCreateTournament";
            this.buttonCreateTournament.Size = new System.Drawing.Size(235, 42);
            this.buttonCreateTournament.TabIndex = 24;
            this.buttonCreateTournament.Text = "Create Tournament";
            this.buttonCreateTournament.UseVisualStyleBackColor = true;
            this.buttonCreateTournament.Click += new System.EventHandler(this.buttonCreateTournament_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 618);
            this.Controls.Add(this.buttonCreateTournament);
            this.Controls.Add(this.buttonRemoveSelectedPrize);
            this.Controls.Add(this.labelprizes);
            this.Controls.Add(this.listBoxPrizes);
            this.Controls.Add(this.buttonRemoveSelectedPlayers);
            this.Controls.Add(this.labelTournametPlayers);
            this.Controls.Add(this.listBoxTornamentTeams);
            this.Controls.Add(this.buttonCreateTeam);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.linkLabelCreateNewTeam);
            this.Controls.Add(this.comboBoxSelectTeam);
            this.Controls.Add(this.labelSelectTeam);
            this.Controls.Add(this.textBoxEntryFee);
            this.Controls.Add(this.labelEntryFee);
            this.Controls.Add(this.textBoxTournamentName);
            this.Controls.Add(this.labelTournamentName);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBoxTournamentName;
        private System.Windows.Forms.Label labelTournamentName;
        private System.Windows.Forms.TextBox textBoxEntryFee;
        private System.Windows.Forms.Label labelEntryFee;
        private System.Windows.Forms.ComboBox comboBoxSelectTeam;
        private System.Windows.Forms.Label labelSelectTeam;
        private System.Windows.Forms.LinkLabel linkLabelCreateNewTeam;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonCreateTeam;
        private System.Windows.Forms.ListBox listBoxTornamentTeams;
        private System.Windows.Forms.Label labelTournametPlayers;
        private System.Windows.Forms.Button buttonRemoveSelectedPlayers;
        private System.Windows.Forms.Button buttonRemoveSelectedPrize;
        private System.Windows.Forms.Label labelprizes;
        private System.Windows.Forms.ListBox listBoxPrizes;
        private System.Windows.Forms.Button buttonCreateTournament;
    }
}