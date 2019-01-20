namespace TournamentViewerForm
{
    partial class FormTournametViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTournametViewer));
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelTournamentName = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.comboBoxRound = new System.Windows.Forms.ComboBox();
            this.checkBoxUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.listBoxMatchup = new System.Windows.Forms.ListBox();
            this.labelTeamOne = new System.Windows.Forms.Label();
            this.labelTeamOneScore = new System.Windows.Forms.Label();
            this.textBoxTeamOneScore = new System.Windows.Forms.TextBox();
            this.textBoxTeamTwoScore = new System.Windows.Forms.TextBox();
            this.labelTeamTwoScore = new System.Windows.Forms.Label();
            this.labelTeamTwo = new System.Windows.Forms.Label();
            this.labelVersus = new System.Windows.Forms.Label();
            this.buttonScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelHeader.Location = new System.Drawing.Point(12, 29);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(214, 50);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Tournament:";
            // 
            // labelTournamentName
            // 
            this.labelTournamentName.AutoSize = true;
            this.labelTournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTournamentName.Location = new System.Drawing.Point(232, 29);
            this.labelTournamentName.Name = "labelTournamentName";
            this.labelTournamentName.Size = new System.Drawing.Size(150, 50);
            this.labelTournamentName.TabIndex = 1;
            this.labelTournamentName.Text = "<none>";
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelRound.Location = new System.Drawing.Point(14, 111);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(94, 37);
            this.labelRound.TabIndex = 2;
            this.labelRound.Text = "Round";
            // 
            // comboBoxRound
            // 
            this.comboBoxRound.FormattingEnabled = true;
            this.comboBoxRound.Location = new System.Drawing.Point(131, 110);
            this.comboBoxRound.Name = "comboBoxRound";
            this.comboBoxRound.Size = new System.Drawing.Size(209, 38);
            this.comboBoxRound.TabIndex = 3;
            this.comboBoxRound.SelectedIndexChanged += new System.EventHandler(this.comboBoxRound_SelectedIndexChanged);
            // 
            // checkBoxUnplayedOnly
            // 
            this.checkBoxUnplayedOnly.AutoSize = true;
            this.checkBoxUnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxUnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUnplayedOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.checkBoxUnplayedOnly.Location = new System.Drawing.Point(131, 168);
            this.checkBoxUnplayedOnly.Name = "checkBoxUnplayedOnly";
            this.checkBoxUnplayedOnly.Size = new System.Drawing.Size(209, 41);
            this.checkBoxUnplayedOnly.TabIndex = 4;
            this.checkBoxUnplayedOnly.Text = "Unplayed Only";
            this.checkBoxUnplayedOnly.UseVisualStyleBackColor = true;
            this.checkBoxUnplayedOnly.CheckedChanged += new System.EventHandler(this.checkBoxUnplayedOnly_CheckedChanged);
            // 
            // listBoxMatchup
            // 
            this.listBoxMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxMatchup.FormattingEnabled = true;
            this.listBoxMatchup.ItemHeight = 30;
            this.listBoxMatchup.Location = new System.Drawing.Point(21, 240);
            this.listBoxMatchup.Name = "listBoxMatchup";
            this.listBoxMatchup.Size = new System.Drawing.Size(319, 212);
            this.listBoxMatchup.TabIndex = 5;
            this.listBoxMatchup.SelectedIndexChanged += new System.EventHandler(this.listBoxMatchup_SelectedIndexChanged);
            // 
            // labelTeamOne
            // 
            this.labelTeamOne.AutoSize = true;
            this.labelTeamOne.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamOne.Location = new System.Drawing.Point(419, 240);
            this.labelTeamOne.Name = "labelTeamOne";
            this.labelTeamOne.Size = new System.Drawing.Size(179, 37);
            this.labelTeamOne.TabIndex = 6;
            this.labelTeamOne.Text = "< team one >";
            // 
            // labelTeamOneScore
            // 
            this.labelTeamOneScore.AutoSize = true;
            this.labelTeamOneScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamOneScore.Location = new System.Drawing.Point(419, 295);
            this.labelTeamOneScore.Name = "labelTeamOneScore";
            this.labelTeamOneScore.Size = new System.Drawing.Size(82, 37);
            this.labelTeamOneScore.TabIndex = 7;
            this.labelTeamOneScore.Text = "Score";
            // 
            // textBoxTeamOneScore
            // 
            this.textBoxTeamOneScore.Location = new System.Drawing.Point(507, 297);
            this.textBoxTeamOneScore.Name = "textBoxTeamOneScore";
            this.textBoxTeamOneScore.Size = new System.Drawing.Size(100, 35);
            this.textBoxTeamOneScore.TabIndex = 8;
            // 
            // textBoxTeamTwoScore
            // 
            this.textBoxTeamTwoScore.Location = new System.Drawing.Point(507, 453);
            this.textBoxTeamTwoScore.Name = "textBoxTeamTwoScore";
            this.textBoxTeamTwoScore.Size = new System.Drawing.Size(100, 35);
            this.textBoxTeamTwoScore.TabIndex = 11;
            // 
            // labelTeamTwoScore
            // 
            this.labelTeamTwoScore.AutoSize = true;
            this.labelTeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamTwoScore.Location = new System.Drawing.Point(419, 451);
            this.labelTeamTwoScore.Name = "labelTeamTwoScore";
            this.labelTeamTwoScore.Size = new System.Drawing.Size(82, 37);
            this.labelTeamTwoScore.TabIndex = 10;
            this.labelTeamTwoScore.Text = "Score";
            // 
            // labelTeamTwo
            // 
            this.labelTeamTwo.AutoSize = true;
            this.labelTeamTwo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamTwo.Location = new System.Drawing.Point(419, 396);
            this.labelTeamTwo.Name = "labelTeamTwo";
            this.labelTeamTwo.Size = new System.Drawing.Size(179, 37);
            this.labelTeamTwo.TabIndex = 9;
            this.labelTeamTwo.Text = "< team two >";
            // 
            // labelVersus
            // 
            this.labelVersus.AutoSize = true;
            this.labelVersus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelVersus.Location = new System.Drawing.Point(480, 355);
            this.labelVersus.Name = "labelVersus";
            this.labelVersus.Size = new System.Drawing.Size(70, 37);
            this.labelVersus.TabIndex = 12;
            this.labelVersus.Text = "-VS-";
            // 
            // buttonScore
            // 
            this.buttonScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonScore.Location = new System.Drawing.Point(648, 355);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(96, 48);
            this.buttonScore.TabIndex = 13;
            this.buttonScore.Text = "Score";
            this.buttonScore.UseVisualStyleBackColor = true;
            this.buttonScore.Click += new System.EventHandler(this.buttonScore_Click);
            // 
            // FormTournametViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 527);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.labelVersus);
            this.Controls.Add(this.textBoxTeamTwoScore);
            this.Controls.Add(this.labelTeamTwoScore);
            this.Controls.Add(this.labelTeamTwo);
            this.Controls.Add(this.textBoxTeamOneScore);
            this.Controls.Add(this.labelTeamOneScore);
            this.Controls.Add(this.labelTeamOne);
            this.Controls.Add(this.listBoxMatchup);
            this.Controls.Add(this.checkBoxUnplayedOnly);
            this.Controls.Add(this.comboBoxRound);
            this.Controls.Add(this.labelRound);
            this.Controls.Add(this.labelTournamentName);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormTournametViewer";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelTournamentName;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.ComboBox comboBoxRound;
        private System.Windows.Forms.CheckBox checkBoxUnplayedOnly;
        private System.Windows.Forms.ListBox listBoxMatchup;
        private System.Windows.Forms.Label labelTeamOne;
        private System.Windows.Forms.Label labelTeamOneScore;
        private System.Windows.Forms.TextBox textBoxTeamOneScore;
        private System.Windows.Forms.TextBox textBoxTeamTwoScore;
        private System.Windows.Forms.Label labelTeamTwoScore;
        private System.Windows.Forms.Label labelTeamTwo;
        private System.Windows.Forms.Label labelVersus;
        private System.Windows.Forms.Button buttonScore;
    }
}

