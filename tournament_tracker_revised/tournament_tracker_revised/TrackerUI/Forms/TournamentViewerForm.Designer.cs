
namespace TrackerUI.Forms
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.TournamentLabel = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.roundBox = new System.Windows.Forms.ComboBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.TextBox();
            this.team1ScoreLabel = new System.Windows.Forms.Label();
            this.sampleTeam1Label = new System.Windows.Forms.Label();
            this.sampleTeam2Label = new System.Windows.Forms.Label();
            this.sampleTeamScore2Label = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.team1ScoreBox = new System.Windows.Forms.TextBox();
            this.team2ScoreBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TournamentLabel
            // 
            this.TournamentLabel.AutoSize = true;
            this.TournamentLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentLabel.Location = new System.Drawing.Point(23, 20);
            this.TournamentLabel.Name = "TournamentLabel";
            this.TournamentLabel.Size = new System.Drawing.Size(248, 65);
            this.TournamentLabel.TabIndex = 10;
            this.TournamentLabel.Text = "Tournament:";
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameLabel.Location = new System.Drawing.Point(277, 33);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(116, 48);
            this.TournamentNameLabel.TabIndex = 11;
            this.TournamentNameLabel.Text = "<name>";
            // 
            // roundBox
            // 
            this.roundBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundBox.FormattingEnabled = true;
            this.roundBox.Location = new System.Drawing.Point(37, 137);
            this.roundBox.Name = "roundBox";
            this.roundBox.Size = new System.Drawing.Size(372, 36);
            this.roundBox.TabIndex = 15;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.Location = new System.Drawing.Point(37, 105);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(63, 29);
            this.roundLabel.TabIndex = 14;
            this.roundLabel.Text = "Round";
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(285, 111);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(124, 24);
            this.unplayedOnlyCheckBox.TabIndex = 16;
            this.unplayedOnlyCheckBox.Text = "unplayed only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.Location = new System.Drawing.Point(37, 204);
            this.matchupListBox.Multiline = true;
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(371, 240);
            this.matchupListBox.TabIndex = 17;
            // 
            // team1ScoreLabel
            // 
            this.team1ScoreLabel.AutoSize = true;
            this.team1ScoreLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.team1ScoreLabel.Location = new System.Drawing.Point(471, 244);
            this.team1ScoreLabel.Name = "team1ScoreLabel";
            this.team1ScoreLabel.Size = new System.Drawing.Size(58, 29);
            this.team1ScoreLabel.TabIndex = 21;
            this.team1ScoreLabel.Text = "Score";
            // 
            // sampleTeam1Label
            // 
            this.sampleTeam1Label.AutoSize = true;
            this.sampleTeam1Label.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleTeam1Label.Location = new System.Drawing.Point(469, 202);
            this.sampleTeam1Label.Name = "sampleTeam1Label";
            this.sampleTeam1Label.Size = new System.Drawing.Size(147, 33);
            this.sampleTeam1Label.TabIndex = 24;
            this.sampleTeam1Label.Text = "Sample Team 1";
            // 
            // sampleTeam2Label
            // 
            this.sampleTeam2Label.AutoSize = true;
            this.sampleTeam2Label.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleTeam2Label.Location = new System.Drawing.Point(469, 360);
            this.sampleTeam2Label.Name = "sampleTeam2Label";
            this.sampleTeam2Label.Size = new System.Drawing.Size(151, 33);
            this.sampleTeam2Label.TabIndex = 27;
            this.sampleTeam2Label.Text = "Sample Team 2";
            // 
            // sampleTeamScore2Label
            // 
            this.sampleTeamScore2Label.AutoSize = true;
            this.sampleTeamScore2Label.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleTeamScore2Label.Location = new System.Drawing.Point(471, 402);
            this.sampleTeamScore2Label.Name = "sampleTeamScore2Label";
            this.sampleTeamScore2Label.Size = new System.Drawing.Size(58, 29);
            this.sampleTeamScore2Label.TabIndex = 26;
            this.sampleTeamScore2Label.Text = "Score";
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vsLabel.Location = new System.Drawing.Point(533, 309);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(33, 28);
            this.vsLabel.TabIndex = 28;
            this.vsLabel.Text = "vs.";
            // 
            // scoreButton
            // 
            this.scoreButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreButton.Location = new System.Drawing.Point(669, 293);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(94, 66);
            this.scoreButton.TabIndex = 29;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // team1ScoreBox
            // 
            this.team1ScoreBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.team1ScoreBox.Location = new System.Drawing.Point(535, 238);
            this.team1ScoreBox.Name = "team1ScoreBox";
            this.team1ScoreBox.Size = new System.Drawing.Size(125, 34);
            this.team1ScoreBox.TabIndex = 30;
            // 
            // team2ScoreBox
            // 
            this.team2ScoreBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.team2ScoreBox.Location = new System.Drawing.Point(535, 402);
            this.team2ScoreBox.Name = "team2ScoreBox";
            this.team2ScoreBox.Size = new System.Drawing.Size(125, 34);
            this.team2ScoreBox.TabIndex = 31;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.team2ScoreBox);
            this.Controls.Add(this.team1ScoreBox);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.sampleTeam2Label);
            this.Controls.Add(this.sampleTeamScore2Label);
            this.Controls.Add(this.sampleTeam1Label);
            this.Controls.Add(this.team1ScoreLabel);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.TournamentLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentViewerForm";
            this.Text = "TournamentViewerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentLabel;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.ComboBox roundBox;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.TextBox matchupListBox;
        private System.Windows.Forms.Label team1ScoreLabel;
        private System.Windows.Forms.Label sampleTeam1Label;
        private System.Windows.Forms.Label sampleTeam2Label;
        private System.Windows.Forms.Label sampleTeamScore2Label;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.TextBox team1ScoreBox;
        private System.Windows.Forms.TextBox team2ScoreBox;
    }
}