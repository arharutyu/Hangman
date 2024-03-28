namespace Hangman
{
    partial class PvPEnterWord
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
            this.pvpWordTextbox = new System.Windows.Forms.TextBox();
            this.btnPvPEnterWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pvpDefinitionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pvpSynonymsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pvpWordTextbox
            // 
            this.pvpWordTextbox.Location = new System.Drawing.Point(12, 50);
            this.pvpWordTextbox.Name = "pvpWordTextbox";
            this.pvpWordTextbox.Size = new System.Drawing.Size(337, 22);
            this.pvpWordTextbox.TabIndex = 0;
            this.pvpWordTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.pvpWordTextbox_Validating);
            // 
            // btnPvPEnterWord
            // 
            this.btnPvPEnterWord.Location = new System.Drawing.Point(12, 194);
            this.btnPvPEnterWord.Name = "btnPvPEnterWord";
            this.btnPvPEnterWord.Size = new System.Drawing.Size(145, 23);
            this.btnPvPEnterWord.TabIndex = 1;
            this.btnPvPEnterWord.Text = "Let\'s Play!";
            this.btnPvPEnterWord.UseVisualStyleBackColor = true;
            this.btnPvPEnterWord.Click += new System.EventHandler(this.btnPvPEnterWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter word to guess:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter definition:";
            // 
            // pvpDefinitionTextBox
            // 
            this.pvpDefinitionTextBox.Location = new System.Drawing.Point(12, 103);
            this.pvpDefinitionTextBox.Name = "pvpDefinitionTextBox";
            this.pvpDefinitionTextBox.Size = new System.Drawing.Size(337, 22);
            this.pvpDefinitionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter synonym(s):";
            // 
            // pvpSynonymsTextBox
            // 
            this.pvpSynonymsTextBox.Location = new System.Drawing.Point(15, 157);
            this.pvpSynonymsTextBox.Name = "pvpSynonymsTextBox";
            this.pvpSynonymsTextBox.Size = new System.Drawing.Size(337, 22);
            this.pvpSynonymsTextBox.TabIndex = 5;
            // 
            // PvPEnterWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 229);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pvpSynonymsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pvpDefinitionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPvPEnterWord);
            this.Controls.Add(this.pvpWordTextbox);
            this.Name = "PvPEnterWord";
            this.Text = "PvPEnterWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pvpWordTextbox;
        private System.Windows.Forms.Button btnPvPEnterWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pvpDefinitionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pvpSynonymsTextBox;
    }
}