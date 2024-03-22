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
            this.SuspendLayout();
            // 
            // btnPlayCp
            // 
            this.btnPlayCp.Location = new System.Drawing.Point(11, 11);
            this.btnPlayCp.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayCp.Name = "btnPlayCp";
            this.btnPlayCp.Size = new System.Drawing.Size(90, 68);
            this.btnPlayCp.TabIndex = 0;
            this.btnPlayCp.Text = "1-Player";
            this.btnPlayCp.UseVisualStyleBackColor = true;
            this.btnPlayCp.Click += new System.EventHandler(this.btnPlayCp_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 105);
            this.Controls.Add(this.btnPlayCp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EntryForm";
            this.Text = "Hangman";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayCp;
    }
}

