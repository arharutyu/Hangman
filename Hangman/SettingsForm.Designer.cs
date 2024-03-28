namespace Hangman
{
    partial class SettingsForm
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
            this.difficultyNormalRB = new System.Windows.Forms.RadioButton();
            this.difficultyHardRB = new System.Windows.Forms.RadioButton();
            this.settingsDifficultyGroupBox = new System.Windows.Forms.GroupBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.cancelSettingsButton = new System.Windows.Forms.Button();
            this.settingsDifficultyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // difficultyNormalRB
            // 
            this.difficultyNormalRB.AutoSize = true;
            this.difficultyNormalRB.Location = new System.Drawing.Point(6, 26);
            this.difficultyNormalRB.Name = "difficultyNormalRB";
            this.difficultyNormalRB.Size = new System.Drawing.Size(72, 20);
            this.difficultyNormalRB.TabIndex = 0;
            this.difficultyNormalRB.TabStop = true;
            this.difficultyNormalRB.Text = "Normal";
            this.difficultyNormalRB.UseVisualStyleBackColor = true;
            // 
            // difficultyHardRB
            // 
            this.difficultyHardRB.AutoSize = true;
            this.difficultyHardRB.Location = new System.Drawing.Point(6, 52);
            this.difficultyHardRB.Name = "difficultyHardRB";
            this.difficultyHardRB.Size = new System.Drawing.Size(58, 20);
            this.difficultyHardRB.TabIndex = 1;
            this.difficultyHardRB.TabStop = true;
            this.difficultyHardRB.Text = "Hard";
            this.difficultyHardRB.UseVisualStyleBackColor = true;
            // 
            // settingsDifficultyGroupBox
            // 
            this.settingsDifficultyGroupBox.Controls.Add(this.difficultyNormalRB);
            this.settingsDifficultyGroupBox.Controls.Add(this.difficultyHardRB);
            this.settingsDifficultyGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsDifficultyGroupBox.Name = "settingsDifficultyGroupBox";
            this.settingsDifficultyGroupBox.Size = new System.Drawing.Size(200, 86);
            this.settingsDifficultyGroupBox.TabIndex = 3;
            this.settingsDifficultyGroupBox.TabStop = false;
            this.settingsDifficultyGroupBox.Text = "Difficulty";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(12, 180);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 28);
            this.saveSettingsButton.TabIndex = 4;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // cancelSettingsButton
            // 
            this.cancelSettingsButton.Location = new System.Drawing.Point(93, 180);
            this.cancelSettingsButton.Name = "cancelSettingsButton";
            this.cancelSettingsButton.Size = new System.Drawing.Size(75, 28);
            this.cancelSettingsButton.TabIndex = 5;
            this.cancelSettingsButton.Text = "Cancel";
            this.cancelSettingsButton.UseVisualStyleBackColor = true;
            this.cancelSettingsButton.Click += new System.EventHandler(this.cancelSettingsButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 220);
            this.Controls.Add(this.cancelSettingsButton);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.settingsDifficultyGroupBox);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.settingsDifficultyGroupBox.ResumeLayout(false);
            this.settingsDifficultyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton difficultyNormalRB;
        private System.Windows.Forms.RadioButton difficultyHardRB;
        private System.Windows.Forms.GroupBox settingsDifficultyGroupBox;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button cancelSettingsButton;
    }
}