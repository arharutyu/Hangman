namespace Hangman
{
    partial class HangmanPictureUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hangmanPictureUC1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureUC1)).BeginInit();
            this.SuspendLayout();
            // 
            // hangmanPictureUC1
            // 
            this.hangmanPictureUC1.Location = new System.Drawing.Point(16, 25);
            this.hangmanPictureUC1.Margin = new System.Windows.Forms.Padding(4);
            this.hangmanPictureUC1.Name = "hangmanPictureUC1";
            this.hangmanPictureUC1.Size = new System.Drawing.Size(385, 294);
            this.hangmanPictureUC1.TabIndex = 3;
            this.hangmanPictureUC1.TabStop = false;
            // 
            // HangmanPictureUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hangmanPictureUC1);
            this.Name = "HangmanPictureUC";
            this.Size = new System.Drawing.Size(417, 345);
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureUC1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox hangmanPictureUC1;
    }
}
