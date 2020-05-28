namespace ProjectTrackerUI
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
            this.headerLabel3 = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameVallueTextbox = new System.Windows.Forms.TextBox();
            this.selectTeamMembersDropDownBox = new System.Windows.Forms.ComboBox();
            this.selectTeamMembersLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.createNewMemberGbox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellphoneValueTbox = new System.Windows.Forms.TextBox();
            this.cellPhoneValueLabel = new System.Windows.Forms.Label();
            this.emailValueTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValueTextbox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValueTextbox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListbox = new System.Windows.Forms.ListBox();
            this.removeMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.createNewMemberGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel3
            // 
            this.headerLabel3.AutoSize = true;
            this.headerLabel3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.headerLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerLabel3.Location = new System.Drawing.Point(38, 20);
            this.headerLabel3.Name = "headerLabel3";
            this.headerLabel3.Size = new System.Drawing.Size(170, 38);
            this.headerLabel3.TabIndex = 2;
            this.headerLabel3.Text = "Create Team";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.teamNameLabel.Location = new System.Drawing.Point(39, 80);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(143, 32);
            this.teamNameLabel.TabIndex = 10;
            this.teamNameLabel.Text = "Team Name";
            // 
            // teamNameVallueTextbox
            // 
            this.teamNameVallueTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.teamNameVallueTextbox.Location = new System.Drawing.Point(45, 115);
            this.teamNameVallueTextbox.Name = "teamNameVallueTextbox";
            this.teamNameVallueTextbox.Size = new System.Drawing.Size(245, 30);
            this.teamNameVallueTextbox.TabIndex = 11;
            // 
            // selectTeamMembersDropDownBox
            // 
            this.selectTeamMembersDropDownBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.selectTeamMembersDropDownBox.FormattingEnabled = true;
            this.selectTeamMembersDropDownBox.Location = new System.Drawing.Point(45, 200);
            this.selectTeamMembersDropDownBox.Name = "selectTeamMembersDropDownBox";
            this.selectTeamMembersDropDownBox.Size = new System.Drawing.Size(245, 31);
            this.selectTeamMembersDropDownBox.TabIndex = 16;
            // 
            // selectTeamMembersLabel
            // 
            this.selectTeamMembersLabel.AutoSize = true;
            this.selectTeamMembersLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.selectTeamMembersLabel.Location = new System.Drawing.Point(39, 165);
            this.selectTeamMembersLabel.Name = "selectTeamMembersLabel";
            this.selectTeamMembersLabel.Size = new System.Drawing.Size(251, 32);
            this.selectTeamMembersLabel.TabIndex = 15;
            this.selectTeamMembersLabel.Text = "Select Team Members";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addMemberButton.Location = new System.Drawing.Point(45, 231);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(137, 38);
            this.addMemberButton.TabIndex = 17;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // createNewMemberGbox
            // 
            this.createNewMemberGbox.Controls.Add(this.createMemberButton);
            this.createNewMemberGbox.Controls.Add(this.cellphoneValueTbox);
            this.createNewMemberGbox.Controls.Add(this.cellPhoneValueLabel);
            this.createNewMemberGbox.Controls.Add(this.emailValueTextbox);
            this.createNewMemberGbox.Controls.Add(this.emailLabel);
            this.createNewMemberGbox.Controls.Add(this.lastNameValueTextbox);
            this.createNewMemberGbox.Controls.Add(this.lastNameLabel);
            this.createNewMemberGbox.Controls.Add(this.firstNameValueTextbox);
            this.createNewMemberGbox.Controls.Add(this.firstNameLabel);
            this.createNewMemberGbox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createNewMemberGbox.Location = new System.Drawing.Point(45, 297);
            this.createNewMemberGbox.Name = "createNewMemberGbox";
            this.createNewMemberGbox.Size = new System.Drawing.Size(245, 282);
            this.createNewMemberGbox.TabIndex = 18;
            this.createNewMemberGbox.TabStop = false;
            this.createNewMemberGbox.Text = "Create New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createMemberButton.Location = new System.Drawing.Point(69, 231);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(137, 36);
            this.createMemberButton.TabIndex = 19;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // cellphoneValueTbox
            // 
            this.cellphoneValueTbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cellphoneValueTbox.Location = new System.Drawing.Point(95, 186);
            this.cellphoneValueTbox.Name = "cellphoneValueTbox";
            this.cellphoneValueTbox.Size = new System.Drawing.Size(102, 27);
            this.cellphoneValueTbox.TabIndex = 18;
            // 
            // cellPhoneValueLabel
            // 
            this.cellPhoneValueLabel.AutoSize = true;
            this.cellPhoneValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cellPhoneValueLabel.Location = new System.Drawing.Point(6, 189);
            this.cellPhoneValueLabel.Name = "cellPhoneValueLabel";
            this.cellPhoneValueLabel.Size = new System.Drawing.Size(79, 20);
            this.cellPhoneValueLabel.TabIndex = 17;
            this.cellPhoneValueLabel.Text = "Cellphone:";
            // 
            // emailValueTextbox
            // 
            this.emailValueTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailValueTextbox.Location = new System.Drawing.Point(95, 141);
            this.emailValueTextbox.Name = "emailValueTextbox";
            this.emailValueTextbox.Size = new System.Drawing.Size(102, 27);
            this.emailValueTextbox.TabIndex = 16;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailLabel.Location = new System.Drawing.Point(6, 144);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(49, 20);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email:";
            // 
            // lastNameValueTextbox
            // 
            this.lastNameValueTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastNameValueTextbox.Location = new System.Drawing.Point(95, 93);
            this.lastNameValueTextbox.Name = "lastNameValueTextbox";
            this.lastNameValueTextbox.Size = new System.Drawing.Size(102, 27);
            this.lastNameValueTextbox.TabIndex = 14;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 96);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(82, 20);
            this.lastNameLabel.TabIndex = 13;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameValueTextbox
            // 
            this.firstNameValueTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstNameValueTextbox.Location = new System.Drawing.Point(95, 47);
            this.firstNameValueTextbox.Name = "firstNameValueTextbox";
            this.firstNameValueTextbox.Size = new System.Drawing.Size(102, 27);
            this.firstNameValueTextbox.TabIndex = 12;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 50);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(83, 20);
            this.firstNameLabel.TabIndex = 11;
            this.firstNameLabel.Text = "First Name:";
            // 
            // teamMembersListbox
            // 
            this.teamMembersListbox.AccessibleName = "";
            this.teamMembersListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.teamMembersListbox.FormattingEnabled = true;
            this.teamMembersListbox.ItemHeight = 23;
            this.teamMembersListbox.Location = new System.Drawing.Point(342, 42);
            this.teamMembersListbox.Name = "teamMembersListbox";
            this.teamMembersListbox.Size = new System.Drawing.Size(308, 324);
            this.teamMembersListbox.TabIndex = 19;
            // 
            // removeMemberButton
            // 
            this.removeMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeMemberButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.removeMemberButton.Location = new System.Drawing.Point(423, 393);
            this.removeMemberButton.Name = "removeMemberButton";
            this.removeMemberButton.Size = new System.Drawing.Size(137, 38);
            this.removeMemberButton.TabIndex = 20;
            this.removeMemberButton.Text = "Remove";
            this.removeMemberButton.UseVisualStyleBackColor = true;
            this.removeMemberButton.Click += new System.EventHandler(this.removeMemberButton_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createTeamButton.Location = new System.Drawing.Point(419, 481);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(231, 83);
            this.createTeamButton.TabIndex = 21;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 591);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeMemberButton);
            this.Controls.Add(this.teamMembersListbox);
            this.Controls.Add(this.createNewMemberGbox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMembersDropDownBox);
            this.Controls.Add(this.selectTeamMembersLabel);
            this.Controls.Add(this.teamNameVallueTextbox);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel3);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeam";
            this.createNewMemberGbox.ResumeLayout(false);
            this.createNewMemberGbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel3;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameVallueTextbox;
        private System.Windows.Forms.ComboBox selectTeamMembersDropDownBox;
        private System.Windows.Forms.Label selectTeamMembersLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox createNewMemberGbox;
        private System.Windows.Forms.TextBox cellphoneValueTbox;
        private System.Windows.Forms.Label cellPhoneValueLabel;
        private System.Windows.Forms.TextBox emailValueTextbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValueTextbox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValueTextbox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMembersListbox;
        private System.Windows.Forms.Button removeMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}