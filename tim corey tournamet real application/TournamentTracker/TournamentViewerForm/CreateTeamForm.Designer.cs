namespace TournamentViewerForm
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.comboBoxSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.labelSelectTeamMember = new System.Windows.Forms.Label();
            this.groupBoxAddNewMember = new System.Windows.Forms.GroupBox();
            this.buttonCreateMember = new System.Windows.Forms.Button();
            this.textBoxCellPhone = new System.Windows.Forms.TextBox();
            this.labelCellPhone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.listBoxTeamMembers = new System.Windows.Forms.ListBox();
            this.buttonRemoveSelectedMembers = new System.Windows.Forms.Button();
            this.buttonCreateTeam = new System.Windows.Forms.Button();
            this.groupBoxAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(36, 130);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(369, 35);
            this.textBoxTeamName.TabIndex = 5;
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamName.Location = new System.Drawing.Point(29, 90);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(157, 37);
            this.labelTeamName.TabIndex = 12;
            this.labelTeamName.Text = "Team Name";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelHeader.Location = new System.Drawing.Point(12, 4);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(213, 50);
            this.labelHeader.TabIndex = 11;
            this.labelHeader.Text = "Create Team";
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddMember.Location = new System.Drawing.Point(125, 321);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(190, 36);
            this.buttonAddMember.TabIndex = 1;
            this.buttonAddMember.Text = "Add Member";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // comboBoxSelectTeamMember
            // 
            this.comboBoxSelectTeamMember.FormattingEnabled = true;
            this.comboBoxSelectTeamMember.Location = new System.Drawing.Point(36, 258);
            this.comboBoxSelectTeamMember.Name = "comboBoxSelectTeamMember";
            this.comboBoxSelectTeamMember.Size = new System.Drawing.Size(369, 38);
            this.comboBoxSelectTeamMember.TabIndex = 0;
            // 
            // labelSelectTeamMember
            // 
            this.labelSelectTeamMember.AutoSize = true;
            this.labelSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelSelectTeamMember.Location = new System.Drawing.Point(29, 218);
            this.labelSelectTeamMember.Name = "labelSelectTeamMember";
            this.labelSelectTeamMember.Size = new System.Drawing.Size(263, 37);
            this.labelSelectTeamMember.TabIndex = 17;
            this.labelSelectTeamMember.Text = "Select Team Member";
            // 
            // groupBoxAddNewMember
            // 
            this.groupBoxAddNewMember.Controls.Add(this.buttonCreateMember);
            this.groupBoxAddNewMember.Controls.Add(this.textBoxCellPhone);
            this.groupBoxAddNewMember.Controls.Add(this.labelCellPhone);
            this.groupBoxAddNewMember.Controls.Add(this.textBoxEmail);
            this.groupBoxAddNewMember.Controls.Add(this.labelEmail);
            this.groupBoxAddNewMember.Controls.Add(this.textBoxLastName);
            this.groupBoxAddNewMember.Controls.Add(this.labelLastName);
            this.groupBoxAddNewMember.Controls.Add(this.textBoxFirstName);
            this.groupBoxAddNewMember.Controls.Add(this.labelFirstName);
            this.groupBoxAddNewMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddNewMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.groupBoxAddNewMember.Location = new System.Drawing.Point(36, 383);
            this.groupBoxAddNewMember.Name = "groupBoxAddNewMember";
            this.groupBoxAddNewMember.Size = new System.Drawing.Size(369, 309);
            this.groupBoxAddNewMember.TabIndex = 2;
            this.groupBoxAddNewMember.TabStop = false;
            this.groupBoxAddNewMember.Text = "Add New Member";
            // 
            // buttonCreateMember
            // 
            this.buttonCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonCreateMember.Location = new System.Drawing.Point(89, 246);
            this.buttonCreateMember.Name = "buttonCreateMember";
            this.buttonCreateMember.Size = new System.Drawing.Size(190, 36);
            this.buttonCreateMember.TabIndex = 4;
            this.buttonCreateMember.Text = "Create Member";
            this.buttonCreateMember.UseVisualStyleBackColor = true;
            this.buttonCreateMember.Click += new System.EventHandler(this.buttonCreateMember_Click);
            // 
            // textBoxCellPhone
            // 
            this.textBoxCellPhone.Location = new System.Drawing.Point(169, 192);
            this.textBoxCellPhone.Name = "textBoxCellPhone";
            this.textBoxCellPhone.Size = new System.Drawing.Size(178, 43);
            this.textBoxCellPhone.TabIndex = 3;
            // 
            // labelCellPhone
            // 
            this.labelCellPhone.AutoSize = true;
            this.labelCellPhone.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCellPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelCellPhone.Location = new System.Drawing.Point(19, 189);
            this.labelCellPhone.Name = "labelCellPhone";
            this.labelCellPhone.Size = new System.Drawing.Size(138, 37);
            this.labelCellPhone.TabIndex = 15;
            this.labelCellPhone.Text = "Cellphone";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(169, 141);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(178, 43);
            this.textBoxEmail.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelEmail.Location = new System.Drawing.Point(19, 138);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(82, 37);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(169, 90);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(178, 43);
            this.textBoxLastName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelLastName.Location = new System.Drawing.Point(19, 87);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(142, 37);
            this.labelLastName.TabIndex = 11;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(171, 39);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(178, 43);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelFirstName.Location = new System.Drawing.Point(21, 36);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(144, 37);
            this.labelFirstName.TabIndex = 9;
            this.labelFirstName.Text = "First Name";
            // 
            // listBoxTeamMembers
            // 
            this.listBoxTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTeamMembers.FormattingEnabled = true;
            this.listBoxTeamMembers.ItemHeight = 30;
            this.listBoxTeamMembers.Location = new System.Drawing.Point(434, 90);
            this.listBoxTeamMembers.Name = "listBoxTeamMembers";
            this.listBoxTeamMembers.Size = new System.Drawing.Size(319, 542);
            this.listBoxTeamMembers.TabIndex = 3;
            // 
            // buttonRemoveSelectedMembers
            // 
            this.buttonRemoveSelectedMembers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonRemoveSelectedMembers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonRemoveSelectedMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonRemoveSelectedMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSelectedMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveSelectedMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonRemoveSelectedMembers.Location = new System.Drawing.Point(512, 638);
            this.buttonRemoveSelectedMembers.Name = "buttonRemoveSelectedMembers";
            this.buttonRemoveSelectedMembers.Size = new System.Drawing.Size(187, 54);
            this.buttonRemoveSelectedMembers.TabIndex = 4;
            this.buttonRemoveSelectedMembers.Text = "Remove Selected";
            this.buttonRemoveSelectedMembers.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedMembers.Click += new System.EventHandler(this.buttonRemoveSelectedMembers_Click);
            // 
            // buttonCreateTeam
            // 
            this.buttonCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonCreateTeam.Location = new System.Drawing.Point(289, 709);
            this.buttonCreateTeam.Name = "buttonCreateTeam";
            this.buttonCreateTeam.Size = new System.Drawing.Size(235, 42);
            this.buttonCreateTeam.TabIndex = 6;
            this.buttonCreateTeam.Text = "Create Team";
            this.buttonCreateTeam.UseVisualStyleBackColor = true;
            this.buttonCreateTeam.Click += new System.EventHandler(this.buttonCreateTeam_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 764);
            this.Controls.Add(this.buttonCreateTeam);
            this.Controls.Add(this.buttonRemoveSelectedMembers);
            this.Controls.Add(this.listBoxTeamMembers);
            this.Controls.Add(this.groupBoxAddNewMember);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.comboBoxSelectTeamMember);
            this.Controls.Add(this.labelSelectTeamMember);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBoxAddNewMember.ResumeLayout(false);
            this.groupBoxAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.ComboBox comboBoxSelectTeamMember;
        private System.Windows.Forms.Label labelSelectTeamMember;
        private System.Windows.Forms.GroupBox groupBoxAddNewMember;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonCreateMember;
        private System.Windows.Forms.TextBox textBoxCellPhone;
        private System.Windows.Forms.Label labelCellPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.ListBox listBoxTeamMembers;
        private System.Windows.Forms.Button buttonRemoveSelectedMembers;
        private System.Windows.Forms.Button buttonCreateTeam;
    }
}