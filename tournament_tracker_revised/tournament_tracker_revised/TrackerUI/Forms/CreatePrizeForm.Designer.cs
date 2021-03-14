
namespace TrackerUI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.placeNumberTextBox = new System.Windows.Forms.TextBox();
            this.placeNameTextBox = new System.Windows.Forms.TextBox();
            this.prizeAmountTextBox = new System.Windows.Forms.TextBox();
            this.prizePercentageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPrizeLabel.Location = new System.Drawing.Point(23, 28);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(247, 65);
            this.createPrizeLabel.TabIndex = 11;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizePercentageLabel.Location = new System.Drawing.Point(37, 285);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(146, 29);
            this.prizePercentageLabel.TabIndex = 31;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeAmountLabel.Location = new System.Drawing.Point(37, 197);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(118, 29);
            this.prizeAmountLabel.TabIndex = 29;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameLabel.Location = new System.Drawing.Point(37, 159);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(107, 29);
            this.placeNameLabel.TabIndex = 27;
            this.placeNameLabel.Text = "Place Name";
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberLabel.Location = new System.Drawing.Point(37, 121);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(125, 29);
            this.placeNumberLabel.TabIndex = 25;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orLabel.Location = new System.Drawing.Point(37, 235);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(58, 29);
            this.orLabel.TabIndex = 32;
            this.orLabel.Text = "- or -";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.Location = new System.Drawing.Point(195, 344);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(189, 47);
            this.createPrizeButton.TabIndex = 33;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // placeNumberTextBox
            // 
            this.placeNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberTextBox.Location = new System.Drawing.Point(195, 122);
            this.placeNumberTextBox.Name = "placeNumberTextBox";
            this.placeNumberTextBox.Size = new System.Drawing.Size(189, 34);
            this.placeNumberTextBox.TabIndex = 34;
            this.placeNumberTextBox.TextChanged += new System.EventHandler(this.placeNumberTextBox_TextChanged);
            // 
            // placeNameTextBox
            // 
            this.placeNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameTextBox.Location = new System.Drawing.Point(195, 162);
            this.placeNameTextBox.Name = "placeNameTextBox";
            this.placeNameTextBox.Size = new System.Drawing.Size(189, 34);
            this.placeNameTextBox.TabIndex = 35;
            // 
            // prizeAmountTextBox
            // 
            this.prizeAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeAmountTextBox.Location = new System.Drawing.Point(195, 202);
            this.prizeAmountTextBox.Name = "prizeAmountTextBox";
            this.prizeAmountTextBox.Size = new System.Drawing.Size(189, 34);
            this.prizeAmountTextBox.TabIndex = 36;
            // 
            // prizePercentageTextBox
            // 
            this.prizePercentageTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizePercentageTextBox.Location = new System.Drawing.Point(195, 282);
            this.prizePercentageTextBox.Name = "prizePercentageTextBox";
            this.prizePercentageTextBox.Size = new System.Drawing.Size(189, 34);
            this.prizePercentageTextBox.TabIndex = 37;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.prizePercentageTextBox);
            this.Controls.Add(this.prizeAmountTextBox);
            this.Controls.Add(this.placeNameTextBox);
            this.Controls.Add(this.placeNumberTextBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePrizeForm";
            this.Text = "CreatePrizeForm";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.TextBox placeNumberTextBox;
        private System.Windows.Forms.TextBox placeNameTextBox;
        private System.Windows.Forms.TextBox prizeAmountTextBox;
        private System.Windows.Forms.TextBox prizePercentageTextBox;
    }
}