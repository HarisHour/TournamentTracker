namespace ProjectTrackerUI
{
    partial class TournamentDashBoardForm
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
            this.headerLabel5 = new System.Windows.Forms.Label();
            this.loadTournLabel = new System.Windows.Forms.Label();
            this.loadExTournDropDownBox = new System.Windows.Forms.ComboBox();
            this.loadTournButton = new System.Windows.Forms.Button();
            this.loadCrTourFormButton = new System.Windows.Forms.Button();
            this.orLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel5
            // 
            this.headerLabel5.AutoSize = true;
            this.headerLabel5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.headerLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerLabel5.Location = new System.Drawing.Point(27, 9);
            this.headerLabel5.Name = "headerLabel5";
            this.headerLabel5.Size = new System.Drawing.Size(397, 46);
            this.headerLabel5.TabIndex = 4;
            this.headerLabel5.Text = "Tournament Dashboard";
            // 
            // loadTournLabel
            // 
            this.loadTournLabel.AutoSize = true;
            this.loadTournLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loadTournLabel.Location = new System.Drawing.Point(29, 68);
            this.loadTournLabel.Name = "loadTournLabel";
            this.loadTournLabel.Size = new System.Drawing.Size(290, 32);
            this.loadTournLabel.TabIndex = 11;
            this.loadTournLabel.Text = "Load Existing Tournament";
            // 
            // loadExTournDropDownBox
            // 
            this.loadExTournDropDownBox.FormattingEnabled = true;
            this.loadExTournDropDownBox.Location = new System.Drawing.Point(35, 103);
            this.loadExTournDropDownBox.Name = "loadExTournDropDownBox";
            this.loadExTournDropDownBox.Size = new System.Drawing.Size(284, 25);
            this.loadExTournDropDownBox.TabIndex = 17;
            // 
            // loadTournButton
            // 
            this.loadTournButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loadTournButton.Location = new System.Drawing.Point(35, 134);
            this.loadTournButton.Name = "loadTournButton";
            this.loadTournButton.Size = new System.Drawing.Size(109, 29);
            this.loadTournButton.TabIndex = 18;
            this.loadTournButton.Text = "Load";
            this.loadTournButton.UseVisualStyleBackColor = true;
            // 
            // loadCrTourFormButton
            // 
            this.loadCrTourFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadCrTourFormButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loadCrTourFormButton.Location = new System.Drawing.Point(35, 247);
            this.loadCrTourFormButton.Name = "loadCrTourFormButton";
            this.loadCrTourFormButton.Size = new System.Drawing.Size(231, 83);
            this.loadCrTourFormButton.TabIndex = 23;
            this.loadCrTourFormButton.Text = "Create Tournament";
            this.loadCrTourFormButton.UseVisualStyleBackColor = true;
            // 
            // orLabel2
            // 
            this.orLabel2.AutoSize = true;
            this.orLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.orLabel2.ForeColor = System.Drawing.Color.Black;
            this.orLabel2.Location = new System.Drawing.Point(46, 186);
            this.orLabel2.Name = "orLabel2";
            this.orLabel2.Size = new System.Drawing.Size(77, 38);
            this.orLabel2.TabIndex = 24;
            this.orLabel2.Text = "-OR-";
            // 
            // TournamentDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 388);
            this.Controls.Add(this.orLabel2);
            this.Controls.Add(this.loadCrTourFormButton);
            this.Controls.Add(this.loadTournButton);
            this.Controls.Add(this.loadExTournDropDownBox);
            this.Controls.Add(this.loadTournLabel);
            this.Controls.Add(this.headerLabel5);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TournamentDashBoardForm";
            this.Text = "TournamentDashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel5;
        private System.Windows.Forms.Label loadTournLabel;
        private System.Windows.Forms.ComboBox loadExTournDropDownBox;
        private System.Windows.Forms.Button loadTournButton;
        private System.Windows.Forms.Button loadCrTourFormButton;
        private System.Windows.Forms.Label orLabel2;
    }
}