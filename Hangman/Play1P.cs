using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{

    public partial class Play1P : Form
    {
        private Play game;
        string displayWord = "";
        Play.WordInPlay[] wordArray;
        string word;

        public Play1P()
        {
            InitializeComponent();
            game = new Play();
            StartNewGame();
        }

        private void StartNewGame()
        {
            // Get a random word from the Play class
            word = game.GetWord();
            Console.WriteLine(word);

            wordArray = game.GetWordInPlayArray(word);

            for (int i = 0; i < word.Length; i++)
            {
                displayWord += "_ ";
            }
            lblGuessesLeft.Text = game.incorrectGuessesLeft.ToString();

            lblWordInPlay.Text = displayWord;
        }

        private void AlphabetButtonClick(object sender, EventArgs e)
        {
            // Cast the sender object to a Button
            Button clickedButton = (Button)sender;
            clickedButton.Enabled = false;

            // Get the text of the clicked button
            string letter = clickedButton.Text.ToLower();
            Console.WriteLine(letter);

            int letterGuessed = 0;

            foreach (Play.WordInPlay letterInWordInPlay in wordArray)
            {
                if (letterInWordInPlay.Letter == letter[0])
                {
                    letterInWordInPlay.Guessed = true;
                    game.lettersLeftToGuess -= 1;
                    letterGuessed += 1;
                }
            }

            if (letterGuessed == 0)
            {
                game.incorrectGuessesLeft -= 1;
                lblGuessesLeft.Text = game.incorrectGuessesLeft.ToString();
                switch (game.incorrectGuessesLeft)
                {
                    case 9:
                        hangmanPicture.Image = Properties.Resources._9;
                        break;
                    case 8:
                        hangmanPicture.Image = Properties.Resources._8;
                        break;
                    case 7:
                        hangmanPicture.Image = Properties.Resources._7;
                        break;
                    case 6:
                        hangmanPicture.Image = Properties.Resources._6;
                        break;
                    case 5:
                        hangmanPicture.Image = Properties.Resources._5;
                        break;
                    case 4:
                        hangmanPicture.Image = Properties.Resources._4;
                        break;
                    case 3:
                        hangmanPicture.Image = Properties.Resources._3;
                        break;
                    case 2:
                        hangmanPicture.Image = Properties.Resources._2;
                        break;
                    case 1:
                        hangmanPicture.Image = Properties.Resources._1;
                        break;
                    case 0:
                        hangmanPicture.Image = Properties.Resources._0;
                        break;

                }
                
            }
            RefreshDisplayWord();
        }

        private void RefreshDisplayWord()
        {
            displayWord = "";
            foreach (Play.WordInPlay letter in wordArray)
            {
                if (letter.Guessed)
                {
                    displayWord += letter.Letter;
                    displayWord += " ";
                }
                else
                {
                    displayWord += "_ ";
                }
            }
            lblWordInPlay.Text = displayWord;

            if (game.lettersLeftToGuess == 0)
            {
                ShowEndGameForm("You win! You guessed the word: " + displayWord.Replace(" ", ""));
            }

            if (game.incorrectGuessesLeft == 0)
            {
                ShowEndGameForm("You ran out of guesses! The correct word is: " + word);
            }
        }

        private void ShowEndGameForm(string message)
        {
            EndGame endGameForm = new EndGame(this);

            endGameForm.SetMessage(message);

            endGameForm.ShowDialog(); 
        }
    }
}
