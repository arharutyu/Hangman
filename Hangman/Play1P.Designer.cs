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
            this.grpboxLetters = new System.Windows.Forms.GroupBox();
            this.btnLetterA = new System.Windows.Forms.Button();
            this.btnLetterB = new System.Windows.Forms.Button();
            this.btnLetterW = new System.Windows.Forms.Button();
            this.btnLetterX = new System.Windows.Forms.Button();
            this.btnLetterY = new System.Windows.Forms.Button();
            this.btnLetterZ = new System.Windows.Forms.Button();
            this.btnLetterV = new System.Windows.Forms.Button();
            this.btnLetterU = new System.Windows.Forms.Button();
            this.btnLetterT = new System.Windows.Forms.Button();
            this.btnLetterS = new System.Windows.Forms.Button();
            this.btnLetterJ = new System.Windows.Forms.Button();
            this.btnLetterK = new System.Windows.Forms.Button();
            this.btnLetterL = new System.Windows.Forms.Button();
            this.btnLetterM = new System.Windows.Forms.Button();
            this.btnLetterN = new System.Windows.Forms.Button();
            this.btnLetterD = new System.Windows.Forms.Button();
            this.btnLetterO = new System.Windows.Forms.Button();
            this.btnLetterP = new System.Windows.Forms.Button();
            this.btnLetterQ = new System.Windows.Forms.Button();
            this.btnLetterR = new System.Windows.Forms.Button();
            this.btnLetterI = new System.Windows.Forms.Button();
            this.btnLetterH = new System.Windows.Forms.Button();
            this.btnLetterG = new System.Windows.Forms.Button();
            this.btnLetterF = new System.Windows.Forms.Button();
            this.btnLetterE = new System.Windows.Forms.Button();
            this.btnLetterC = new System.Windows.Forms.Button();
            this.hangmanPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGuessesLeft = new System.Windows.Forms.Label();
            this.grpboxLetters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWordInPlay
            // 
            this.lblWordInPlay.AutoSize = true;
            this.lblWordInPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordInPlay.Location = new System.Drawing.Point(38, 44);
            this.lblWordInPlay.Name = "lblWordInPlay";
            this.lblWordInPlay.Size = new System.Drawing.Size(0, 26);
            this.lblWordInPlay.TabIndex = 0;
            this.lblWordInPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpboxLetters
            // 
            this.grpboxLetters.Controls.Add(this.btnLetterC);
            this.grpboxLetters.Controls.Add(this.btnLetterE);
            this.grpboxLetters.Controls.Add(this.btnLetterF);
            this.grpboxLetters.Controls.Add(this.btnLetterG);
            this.grpboxLetters.Controls.Add(this.btnLetterH);
            this.grpboxLetters.Controls.Add(this.btnLetterI);
            this.grpboxLetters.Controls.Add(this.btnLetterR);
            this.grpboxLetters.Controls.Add(this.btnLetterQ);
            this.grpboxLetters.Controls.Add(this.btnLetterP);
            this.grpboxLetters.Controls.Add(this.btnLetterO);
            this.grpboxLetters.Controls.Add(this.btnLetterD);
            this.grpboxLetters.Controls.Add(this.btnLetterN);
            this.grpboxLetters.Controls.Add(this.btnLetterM);
            this.grpboxLetters.Controls.Add(this.btnLetterL);
            this.grpboxLetters.Controls.Add(this.btnLetterK);
            this.grpboxLetters.Controls.Add(this.btnLetterJ);
            this.grpboxLetters.Controls.Add(this.btnLetterS);
            this.grpboxLetters.Controls.Add(this.btnLetterT);
            this.grpboxLetters.Controls.Add(this.btnLetterU);
            this.grpboxLetters.Controls.Add(this.btnLetterV);
            this.grpboxLetters.Controls.Add(this.btnLetterZ);
            this.grpboxLetters.Controls.Add(this.btnLetterY);
            this.grpboxLetters.Controls.Add(this.btnLetterX);
            this.grpboxLetters.Controls.Add(this.btnLetterW);
            this.grpboxLetters.Controls.Add(this.btnLetterB);
            this.grpboxLetters.Controls.Add(this.btnLetterA);
            this.grpboxLetters.Location = new System.Drawing.Point(43, 173);
            this.grpboxLetters.Name = "grpboxLetters";
            this.grpboxLetters.Size = new System.Drawing.Size(399, 110);
            this.grpboxLetters.TabIndex = 1;
            this.grpboxLetters.TabStop = false;
            this.grpboxLetters.Text = "Guess a letter!";
            // 
            // btnLetterA
            // 
            this.btnLetterA.Location = new System.Drawing.Point(6, 19);
            this.btnLetterA.Name = "btnLetterA";
            this.btnLetterA.Size = new System.Drawing.Size(36, 23);
            this.btnLetterA.TabIndex = 0;
            this.btnLetterA.Text = "A";
            this.btnLetterA.UseVisualStyleBackColor = true;
            this.btnLetterA.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterB
            // 
            this.btnLetterB.Location = new System.Drawing.Point(48, 19);
            this.btnLetterB.Name = "btnLetterB";
            this.btnLetterB.Size = new System.Drawing.Size(36, 23);
            this.btnLetterB.TabIndex = 1;
            this.btnLetterB.Text = "B";
            this.btnLetterB.UseVisualStyleBackColor = true;
            this.btnLetterB.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterW
            // 
            this.btnLetterW.Location = new System.Drawing.Point(174, 77);
            this.btnLetterW.Name = "btnLetterW";
            this.btnLetterW.Size = new System.Drawing.Size(36, 23);
            this.btnLetterW.TabIndex = 2;
            this.btnLetterW.Text = "W";
            this.btnLetterW.UseVisualStyleBackColor = true;
            this.btnLetterW.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterX
            // 
            this.btnLetterX.Location = new System.Drawing.Point(216, 77);
            this.btnLetterX.Name = "btnLetterX";
            this.btnLetterX.Size = new System.Drawing.Size(36, 23);
            this.btnLetterX.TabIndex = 3;
            this.btnLetterX.Text = "X";
            this.btnLetterX.UseVisualStyleBackColor = true;
            this.btnLetterX.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterY
            // 
            this.btnLetterY.Location = new System.Drawing.Point(258, 77);
            this.btnLetterY.Name = "btnLetterY";
            this.btnLetterY.Size = new System.Drawing.Size(36, 23);
            this.btnLetterY.TabIndex = 4;
            this.btnLetterY.Text = "Y";
            this.btnLetterY.UseVisualStyleBackColor = true;
            this.btnLetterY.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterZ
            // 
            this.btnLetterZ.Location = new System.Drawing.Point(300, 77);
            this.btnLetterZ.Name = "btnLetterZ";
            this.btnLetterZ.Size = new System.Drawing.Size(36, 23);
            this.btnLetterZ.TabIndex = 5;
            this.btnLetterZ.Text = "Z";
            this.btnLetterZ.UseVisualStyleBackColor = true;
            this.btnLetterZ.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterV
            // 
            this.btnLetterV.Location = new System.Drawing.Point(132, 77);
            this.btnLetterV.Name = "btnLetterV";
            this.btnLetterV.Size = new System.Drawing.Size(36, 23);
            this.btnLetterV.TabIndex = 7;
            this.btnLetterV.Text = "V";
            this.btnLetterV.UseVisualStyleBackColor = true;
            this.btnLetterV.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterU
            // 
            this.btnLetterU.Location = new System.Drawing.Point(90, 77);
            this.btnLetterU.Name = "btnLetterU";
            this.btnLetterU.Size = new System.Drawing.Size(36, 23);
            this.btnLetterU.TabIndex = 8;
            this.btnLetterU.Text = "U";
            this.btnLetterU.UseVisualStyleBackColor = true;
            this.btnLetterU.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterT
            // 
            this.btnLetterT.Location = new System.Drawing.Point(48, 77);
            this.btnLetterT.Name = "btnLetterT";
            this.btnLetterT.Size = new System.Drawing.Size(36, 23);
            this.btnLetterT.TabIndex = 9;
            this.btnLetterT.Text = "T";
            this.btnLetterT.UseVisualStyleBackColor = true;
            this.btnLetterT.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterS
            // 
            this.btnLetterS.Location = new System.Drawing.Point(6, 77);
            this.btnLetterS.Name = "btnLetterS";
            this.btnLetterS.Size = new System.Drawing.Size(36, 23);
            this.btnLetterS.TabIndex = 10;
            this.btnLetterS.Text = "S";
            this.btnLetterS.UseVisualStyleBackColor = true;
            this.btnLetterS.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterJ
            // 
            this.btnLetterJ.Location = new System.Drawing.Point(6, 48);
            this.btnLetterJ.Name = "btnLetterJ";
            this.btnLetterJ.Size = new System.Drawing.Size(36, 23);
            this.btnLetterJ.TabIndex = 11;
            this.btnLetterJ.Text = "J";
            this.btnLetterJ.UseVisualStyleBackColor = true;
            this.btnLetterJ.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterK
            // 
            this.btnLetterK.Location = new System.Drawing.Point(48, 48);
            this.btnLetterK.Name = "btnLetterK";
            this.btnLetterK.Size = new System.Drawing.Size(36, 23);
            this.btnLetterK.TabIndex = 12;
            this.btnLetterK.Text = "K";
            this.btnLetterK.UseVisualStyleBackColor = true;
            this.btnLetterK.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterL
            // 
            this.btnLetterL.Location = new System.Drawing.Point(90, 48);
            this.btnLetterL.Name = "btnLetterL";
            this.btnLetterL.Size = new System.Drawing.Size(36, 23);
            this.btnLetterL.TabIndex = 13;
            this.btnLetterL.Text = "L";
            this.btnLetterL.UseVisualStyleBackColor = true;
            this.btnLetterL.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterM
            // 
            this.btnLetterM.Location = new System.Drawing.Point(132, 48);
            this.btnLetterM.Name = "btnLetterM";
            this.btnLetterM.Size = new System.Drawing.Size(36, 23);
            this.btnLetterM.TabIndex = 14;
            this.btnLetterM.Text = "M";
            this.btnLetterM.UseVisualStyleBackColor = true;
            this.btnLetterM.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterN
            // 
            this.btnLetterN.Location = new System.Drawing.Point(174, 48);
            this.btnLetterN.Name = "btnLetterN";
            this.btnLetterN.Size = new System.Drawing.Size(36, 23);
            this.btnLetterN.TabIndex = 15;
            this.btnLetterN.Text = "N";
            this.btnLetterN.UseVisualStyleBackColor = true;
            this.btnLetterN.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterD
            // 
            this.btnLetterD.Location = new System.Drawing.Point(132, 19);
            this.btnLetterD.Name = "btnLetterD";
            this.btnLetterD.Size = new System.Drawing.Size(36, 23);
            this.btnLetterD.TabIndex = 16;
            this.btnLetterD.Text = "D";
            this.btnLetterD.UseVisualStyleBackColor = true;
            this.btnLetterD.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterO
            // 
            this.btnLetterO.Location = new System.Drawing.Point(216, 48);
            this.btnLetterO.Name = "btnLetterO";
            this.btnLetterO.Size = new System.Drawing.Size(36, 23);
            this.btnLetterO.TabIndex = 17;
            this.btnLetterO.Text = "O";
            this.btnLetterO.UseVisualStyleBackColor = true;
            this.btnLetterO.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterP
            // 
            this.btnLetterP.Location = new System.Drawing.Point(258, 48);
            this.btnLetterP.Name = "btnLetterP";
            this.btnLetterP.Size = new System.Drawing.Size(36, 23);
            this.btnLetterP.TabIndex = 18;
            this.btnLetterP.Text = "P";
            this.btnLetterP.UseVisualStyleBackColor = true;
            this.btnLetterP.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterQ
            // 
            this.btnLetterQ.Location = new System.Drawing.Point(300, 48);
            this.btnLetterQ.Name = "btnLetterQ";
            this.btnLetterQ.Size = new System.Drawing.Size(36, 23);
            this.btnLetterQ.TabIndex = 19;
            this.btnLetterQ.Text = "Q";
            this.btnLetterQ.UseVisualStyleBackColor = true;
            this.btnLetterQ.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterR
            // 
            this.btnLetterR.Location = new System.Drawing.Point(342, 48);
            this.btnLetterR.Name = "btnLetterR";
            this.btnLetterR.Size = new System.Drawing.Size(36, 23);
            this.btnLetterR.TabIndex = 20;
            this.btnLetterR.Text = "R";
            this.btnLetterR.UseVisualStyleBackColor = true;
            this.btnLetterR.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterI
            // 
            this.btnLetterI.Location = new System.Drawing.Point(342, 19);
            this.btnLetterI.Name = "btnLetterI";
            this.btnLetterI.Size = new System.Drawing.Size(36, 23);
            this.btnLetterI.TabIndex = 21;
            this.btnLetterI.Text = "I";
            this.btnLetterI.UseVisualStyleBackColor = true;
            this.btnLetterI.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterH
            // 
            this.btnLetterH.Location = new System.Drawing.Point(300, 19);
            this.btnLetterH.Name = "btnLetterH";
            this.btnLetterH.Size = new System.Drawing.Size(36, 23);
            this.btnLetterH.TabIndex = 22;
            this.btnLetterH.Text = "H";
            this.btnLetterH.UseVisualStyleBackColor = true;
            this.btnLetterH.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterG
            // 
            this.btnLetterG.Location = new System.Drawing.Point(258, 19);
            this.btnLetterG.Name = "btnLetterG";
            this.btnLetterG.Size = new System.Drawing.Size(36, 23);
            this.btnLetterG.TabIndex = 23;
            this.btnLetterG.Text = "G";
            this.btnLetterG.UseVisualStyleBackColor = true;
            this.btnLetterG.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterF
            // 
            this.btnLetterF.Location = new System.Drawing.Point(216, 19);
            this.btnLetterF.Name = "btnLetterF";
            this.btnLetterF.Size = new System.Drawing.Size(36, 23);
            this.btnLetterF.TabIndex = 24;
            this.btnLetterF.Text = "F";
            this.btnLetterF.UseVisualStyleBackColor = true;
            this.btnLetterF.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterE
            // 
            this.btnLetterE.Location = new System.Drawing.Point(174, 19);
            this.btnLetterE.Name = "btnLetterE";
            this.btnLetterE.Size = new System.Drawing.Size(36, 23);
            this.btnLetterE.TabIndex = 25;
            this.btnLetterE.Text = "E";
            this.btnLetterE.UseVisualStyleBackColor = true;
            this.btnLetterE.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // btnLetterC
            // 
            this.btnLetterC.Location = new System.Drawing.Point(90, 19);
            this.btnLetterC.Name = "btnLetterC";
            this.btnLetterC.Size = new System.Drawing.Size(36, 23);
            this.btnLetterC.TabIndex = 26;
            this.btnLetterC.Text = "C";
            this.btnLetterC.UseVisualStyleBackColor = true;
            this.btnLetterC.Click += new System.EventHandler(this.AlphabetButtonClick);
            // 
            // hangmanPicture
            // 
            this.hangmanPicture.Location = new System.Drawing.Point(472, 44);
            this.hangmanPicture.Name = "hangmanPicture";
            this.hangmanPicture.Size = new System.Drawing.Size(289, 239);
            this.hangmanPicture.TabIndex = 2;
            this.hangmanPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guesses left: ";
            // 
            // lblGuessesLeft
            // 
            this.lblGuessesLeft.AutoSize = true;
            this.lblGuessesLeft.Location = new System.Drawing.Point(107, 134);
            this.lblGuessesLeft.Name = "lblGuessesLeft";
            this.lblGuessesLeft.Size = new System.Drawing.Size(0, 13);
            this.lblGuessesLeft.TabIndex = 4;
            // 
            // Play1P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.lblGuessesLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hangmanPicture);
            this.Controls.Add(this.grpboxLetters);
            this.Controls.Add(this.lblWordInPlay);
            this.Name = "Play1P";
            this.Text = "Let\'s Play Hangman! - 1 Player";
            this.grpboxLetters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWordInPlay;
        private System.Windows.Forms.GroupBox grpboxLetters;
        private System.Windows.Forms.Button btnLetterC;
        private System.Windows.Forms.Button btnLetterE;
        private System.Windows.Forms.Button btnLetterF;
        private System.Windows.Forms.Button btnLetterG;
        private System.Windows.Forms.Button btnLetterH;
        private System.Windows.Forms.Button btnLetterI;
        private System.Windows.Forms.Button btnLetterR;
        private System.Windows.Forms.Button btnLetterQ;
        private System.Windows.Forms.Button btnLetterP;
        private System.Windows.Forms.Button btnLetterO;
        private System.Windows.Forms.Button btnLetterD;
        private System.Windows.Forms.Button btnLetterN;
        private System.Windows.Forms.Button btnLetterM;
        private System.Windows.Forms.Button btnLetterL;
        private System.Windows.Forms.Button btnLetterK;
        private System.Windows.Forms.Button btnLetterJ;
        private System.Windows.Forms.Button btnLetterS;
        private System.Windows.Forms.Button btnLetterT;
        private System.Windows.Forms.Button btnLetterU;
        private System.Windows.Forms.Button btnLetterV;
        private System.Windows.Forms.Button btnLetterZ;
        private System.Windows.Forms.Button btnLetterY;
        private System.Windows.Forms.Button btnLetterX;
        private System.Windows.Forms.Button btnLetterW;
        private System.Windows.Forms.Button btnLetterB;
        private System.Windows.Forms.Button btnLetterA;
        private System.Windows.Forms.PictureBox hangmanPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGuessesLeft;
    }
}