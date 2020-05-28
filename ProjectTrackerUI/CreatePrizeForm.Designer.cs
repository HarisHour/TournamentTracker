namespace ProjectTrackerUI
{
    partial class CreatePrizeForm
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
            this.headerLabel4 = new System.Windows.Forms.Label();
            this.placeNameValueTextbox = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.placeNumberValueTextbox = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.prizeAmountTextBox = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.orLabel1 = new System.Windows.Forms.Label();
            this.prizeChoiceGbox = new System.Windows.Forms.GroupBox();
            this.prizePercentageTbox = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.prizeChoiceGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel4
            // 
            this.headerLabel4.AutoSize = true;
            this.headerLabel4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.headerLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerLabel4.Location = new System.Drawing.Point(12, 9);
            this.headerLabel4.Name = "headerLabel4";
            this.headerLabel4.Size = new System.Drawing.Size(166, 38);
            this.headerLabel4.TabIndex = 3;
            this.headerLabel4.Text = "Create Prize";
            // 
            // placeNameValueTextbox
            // 
            this.placeNameValueTextbox.Location = new System.Drawing.Point(201, 142);
            this.placeNameValueTextbox.Name = "placeNameValueTextbox";
            this.placeNameValueTextbox.Size = new System.Drawing.Size(99, 25);
            this.placeNameValueTextbox.TabIndex = 16;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.placeNameLabel.Location = new System.Drawing.Point(31, 135);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(146, 32);
            this.placeNameLabel.TabIndex = 15;
            this.placeNameLabel.Text = "Place Name:";
            // 
            // placeNumberValueTextbox
            // 
            this.placeNumberValueTextbox.Location = new System.Drawing.Point(201, 90);
            this.placeNumberValueTextbox.Name = "placeNumberValueTextbox";
            this.placeNumberValueTextbox.Size = new System.Drawing.Size(99, 25);
            this.placeNumberValueTextbox.TabIndex = 14;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.placeNumberLabel.Location = new System.Drawing.Point(31, 83);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(170, 32);
            this.placeNumberLabel.TabIndex = 13;
            this.placeNumberLabel.Text = "Place Number:";
            // 
            // prizeAmountTextBox
            // 
            this.prizeAmountTextBox.Location = new System.Drawing.Point(214, 50);
            this.prizeAmountTextBox.Name = "prizeAmountTextBox";
            this.prizeAmountTextBox.Size = new System.Drawing.Size(99, 25);
            this.prizeAmountTextBox.TabIndex = 18;
            this.prizeAmountTextBox.Text = "0";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prizeAmountLabel.Location = new System.Drawing.Point(12, 42);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(164, 32);
            this.prizeAmountLabel.TabIndex = 17;
            this.prizeAmountLabel.Text = "Prize Amount:";
            // 
            // orLabel1
            // 
            this.orLabel1.AutoSize = true;
            this.orLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.orLabel1.ForeColor = System.Drawing.Color.Black;
            this.orLabel1.Location = new System.Drawing.Point(24, 84);
            this.orLabel1.Name = "orLabel1";
            this.orLabel1.Size = new System.Drawing.Size(77, 38);
            this.orLabel1.TabIndex = 19;
            this.orLabel1.Text = "-OR-";
            // 
            // prizeChoiceGbox
            // 
            this.prizeChoiceGbox.Controls.Add(this.prizePercentageTbox);
            this.prizeChoiceGbox.Controls.Add(this.prizePercentageLabel);
            this.prizeChoiceGbox.Controls.Add(this.orLabel1);
            this.prizeChoiceGbox.Controls.Add(this.prizeAmountTextBox);
            this.prizeChoiceGbox.Controls.Add(this.prizeAmountLabel);
            this.prizeChoiceGbox.Location = new System.Drawing.Point(19, 180);
            this.prizeChoiceGbox.Name = "prizeChoiceGbox";
            this.prizeChoiceGbox.Size = new System.Drawing.Size(324, 189);
            this.prizeChoiceGbox.TabIndex = 20;
            this.prizeChoiceGbox.TabStop = false;
            this.prizeChoiceGbox.Text = "Fixed or %";
            // 
            // prizePercentageTbox
            // 
            this.prizePercentageTbox.Location = new System.Drawing.Point(214, 145);
            this.prizePercentageTbox.Name = "prizePercentageTbox";
            this.prizePercentageTbox.Size = new System.Drawing.Size(99, 25);
            this.prizePercentageTbox.TabIndex = 21;
            this.prizePercentageTbox.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prizePercentageLabel.Location = new System.Drawing.Point(12, 138);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(196, 32);
            this.prizePercentageLabel.TabIndex = 20;
            this.prizePercentageLabel.Text = "Prize Percentage:";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createPrizeButton.Location = new System.Drawing.Point(69, 403);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(231, 83);
            this.createPrizeButton.TabIndex = 22;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 512);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizeChoiceGbox);
            this.Controls.Add(this.placeNameValueTextbox);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValueTextbox);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headerLabel4);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Name = "CreatePrizeForm";
            this.Text = "CreatePrize";
            this.prizeChoiceGbox.ResumeLayout(false);
            this.prizeChoiceGbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel4;
        private System.Windows.Forms.TextBox placeNameValueTextbox;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox placeNumberValueTextbox;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox prizeAmountTextBox;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.Label orLabel1;
        private System.Windows.Forms.GroupBox prizeChoiceGbox;
        private System.Windows.Forms.TextBox prizePercentageTbox;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}