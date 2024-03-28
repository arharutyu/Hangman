namespace Hangman
{
    partial class Play1P
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
            this.lblWordInPlay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGuessesLeft = new System.Windows.Forms.Label();
            this.definitionButton = new System.Windows.Forms.Button();
            this.synonymsButton = new System.Windows.Forms.Button();
            this.hangmanPictureUC1 = new Hangman.HangmanPictureUC();
            this.keyboardUC1 = new Hangman.KeyboardUC();
            this.SuspendLayout();
            // 
            // lblWordInPlay
            // 
            this.lblWordInPlay.AutoSize = true;
            this.lblWordInPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordInPlay.Location = new System.Drawing.Point(51, 54);
            this.lblWordInPlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordInPlay.Name = "lblWordInPlay";
            this.lblWordInPlay.Size = new System.Drawing.Size(0, 31);
            this.lblWordInPlay.TabIndex = 0;
            this.lblWordInPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guesses left: ";
            // 
            // lblGuessesLeft
            // 
            this.lblGuessesLeft.AutoSize = true;
            this.lblGuessesLeft.Location = new System.Drawing.Point(143, 165);
            this.lblGuessesLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuessesLeft.Name = "lblGuessesLeft";
            this.lblGuessesLeft.Size = new System.Drawing.Size(0, 16);
            this.lblGuessesLeft.TabIndex = 4;
            // 
            // definitionButton
            // 
            this.definitionButton.Location = new System.Drawing.Point(43, 119);
            this.definitionButton.Name = "definitionButton";
            this.definitionButton.Size = new System.Drawing.Size(88, 32);
            this.definitionButton.TabIndex = 7;
            this.definitionButton.Text = "Definition";
            this.definitionButton.UseVisualStyleBackColor = true;
            this.definitionButton.Click += new System.EventHandler(this.definitionButton_Click);
            // 
            // synonymsButton
            // 
            this.synonymsButton.Location = new System.Drawing.Point(137, 119);
            this.synonymsButton.Name = "synonymsButton";
            this.synonymsButton.Size = new System.Drawing.Size(85, 32);
            this.synonymsButton.TabIndex = 8;
            this.synonymsButton.Text = "Synonyms";
            this.synonymsButton.UseVisualStyleBackColor = true;
            this.synonymsButton.Click += new System.EventHandler(this.synonymsButton_Click);
            // 
            // hangmanPictureUC1
            // 
            this.hangmanPictureUC1.HangmanImage = null;
            this.hangmanPictureUC1.Location = new System.Drawing.Point(629, 21);
            this.hangmanPictureUC1.Name = "hangmanPictureUC1";
            this.hangmanPictureUC1.Size = new System.Drawing.Size(417, 345);
            this.hangmanPictureUC1.TabIndex = 6;
            // 
            // keyboardUC1
            // 
            this.keyboardUC1.Location = new System.Drawing.Point(31, 184);
            this.keyboardUC1.Name = "keyboardUC1";
            this.keyboardUC1.Size = new System.Drawing.Size(569, 182);
            this.keyboardUC1.TabIndex = 5;
            // 
            // Play1P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 395);
            this.Controls.Add(this.synonymsButton);
            this.Controls.Add(this.definitionButton);
            this.Controls.Add(this.hangmanPictureUC1);
            this.Controls.Add(this.keyboardUC1);
            this.Controls.Add(this.lblGuessesLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWordInPlay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Play1P";
            this.Text = "Let\'s Play Hangman! - 1 Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWordInPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGuessesLeft;
        private KeyboardUC keyboardUC1;
        private HangmanPictureUC hangmanPictureUC1;
        private System.Windows.Forms.Button definitionButton;
        private System.Windows.Forms.Button synonymsButton;
    }
}