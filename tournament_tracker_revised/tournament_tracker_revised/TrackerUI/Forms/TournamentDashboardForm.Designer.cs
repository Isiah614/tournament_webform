
namespace TrackerUI.Forms
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
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createTournamentFormLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.Location = new System.Drawing.Point(30, 331);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(430, 91);
            this.createTournamentButton.TabIndex = 17;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(430, 36);
            this.comboBox1.TabIndex = 19;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.Location = new System.Drawing.Point(129, 169);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(242, 33);
            this.selectTeamLabel.TabIndex = 18;
            this.selectTeamLabel.Text = "Load Existing Tournament";
            // 
            // createTournamentFormLabel
            // 
            this.createTournamentFormLabel.AutoSize = true;
            this.createTournamentFormLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentFormLabel.Location = new System.Drawing.Point(129, 22);
            this.createTournamentFormLabel.Name = "createTournamentFormLabel";
            this.createTournamentFormLabel.Size = new System.Drawing.Size(239, 130);
            this.createTournamentFormLabel.TabIndex = 20;
            this.createTournamentFormLabel.Text = "Tournament\r\nDashboard";
            this.createTournamentFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadTournamentButton.Location = new System.Drawing.Point(30, 268);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(430, 38);
            this.loadTournamentButton.TabIndex = 21;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 464);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.createTournamentFormLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.createTournamentButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.Label createTournamentFormLabel;
        private System.Windows.Forms.Button loadTournamentButton;
    }
}