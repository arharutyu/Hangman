namespace Hangman
{
    partial class EntryForm
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
            this.btnPlayCp = new System.Windows.Forms.Button();
            this.btnPlayPvP = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayCp
            // 
            this.btnPlayCp.Location = new System.Drawing.Point(15, 14);
            this.btnPlayCp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayCp.Name = "btnPlayCp";
            this.btnPlayCp.Size = new System.Drawing.Size(120, 84);
            this.btnPlayCp.TabIndex = 0;
            this.btnPlayCp.Text = "1-Player";
            this.btnPlayCp.UseVisualStyleBackColor = true;
            this.btnPlayCp.Click += new System.EventHandler(this.btnPlayCp_Click);
            // 
            // btnPlayPvP
            // 
            this.btnPlayPvP.Location = new System.Drawing.Point(141, 14);
            this.btnPlayPvP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayPvP.Name = "btnPlayPvP";
            this.btnPlayPvP.Size = new System.Drawing.Size(120, 84);
            this.btnPlayPvP.TabIndex = 1;
            this.btnPlayPvP.Text = "2-Player";
            this.btnPlayPvP.UseVisualStyleBackColor = true;
            this.btnPlayPvP.Click += new System.EventHandler(this.btnPlayPvP_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(267, 14);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(120, 84);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 129);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnPlayPvP);
            this.Controls.Add(this.btnPlayCp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EntryForm";
            this.Text = "Hangman";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayCp;
        private System.Windows.Forms.Button btnPlayPvP;
        private System.Windows.Forms.Button btnSettings;
    }
}

