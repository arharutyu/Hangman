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
        public Play game;
        string displayWord = "";
        Play.WordInPlay[] wordArray;
        string word;
        bool onePlayerGame;

        public Play1P(bool onePlayer)
        {
            InitializeComponent();
            game = new Play();
            onePlayerGame = onePlayer;
            StartNewGame(onePlayer);
            keyboardUC1.KeyPressed += KeyboardUC_KeyPressed;
            hangmanPictureUC1.IncorrectGuessesChanged += HangmanPictureUC_IncorrectGuessesChanged;
            if (Play.difficulty == "Hard")
            {
                definitionButton.Visible = false;
                synonymsButton.Visible = false;
            }
        }

        private void StartNewGame(bool onePlayer)
        {
            if (onePlayer)
            {
                // Get a random word from the Play class
                game.GetWord();
                while (game.awaitingApi)
                {
                    Application.DoEvents();
                }
                word = game.word;
                Console.WriteLine(word);
            }
            else
            {
                // show form to enter word
                using (PvPEnterWord enterWordForm = new PvPEnterWord())
                {
                    // Show the PvPEnterWord form
                    enterWordForm.ShowDialog();

                    // Retrieve the entered word after the form is closed
                    string enteredWord = enterWordForm.EnteredWord;
                    string definition = enterWordForm.Definition;
                    string synonyms = enterWordForm.Synonyms;

                    if (!string.IsNullOrEmpty(enteredWord))
                    {
                        word = game.SetWord(enteredWord);
                    }
                    if (!string.IsNullOrEmpty(definition))
                    {
                        game.definition = definition;
                    }
                    if (!string.IsNullOrEmpty (synonyms))
                    {
                        game.synonyms = synonyms;
                    }
                }
            }

            wordArray = game.GetWordInPlayArray(word);

            for (int i = 0; i < word.Length; i++)
            {
                displayWord += "_ ";
            }
            lblGuessesLeft.Text = game.incorrectGuessesLeft.ToString();

            lblWordInPlay.Text = displayWord;

            if (game.definition == null)
            {
                definitionButton.Enabled = false;
            }
            if (game.synonyms ==  null)
            {
                synonymsButton.Enabled = false;
            }
        }

        private void KeyboardUC_KeyPressed(object sender, string letter)
        {
            int letterGuessed = 0;

            foreach (Play.WordInPlay letterInWordInPlay in wordArray)
            {
                if (letterInWordInPlay.Letter == letter[0])
                {
                    letterInWordInPlay.Guessed = true;
                    game.lettersLeftToGuess -= 1;
                    letterGuessed += 1;
                    Console.WriteLine(game.lettersLeftToGuess);
                }
            }

            if (letterGuessed == 0)
            {
                game.incorrectGuessesLeft -= 1;
                lblGuessesLeft.Text = game.incorrectGuessesLeft.ToString();
                // Raise the event to notify the HangmanPictureUC
                hangmanPictureUC1.OnIncorrectGuessesChanged();
            }
            RefreshDisplayWord();
        }
        private void HangmanPictureUC_IncorrectGuessesChanged(object sender, EventArgs e)
        {
            // Handle the event by updating the image viewer
            int incorrectGuessesLeft = game.incorrectGuessesLeft;
            switch (incorrectGuessesLeft)
            {
                case 9:
                    hangmanPictureUC1.HangmanImage = Properties.Resources._9;
                    break;
                case 8:
                    hangmanPictureUC1.HangmanImage = Properties.Resources._8;
                    break;
                case 7:
                    hangmanPictureUC1.HangmanImage = Properties.Resources._7;
                    break;
                case 6:
                    hangmanPictureUC1.HangmanImage = Properties.Resources._6;
                    break;
                case 5:
                    hangmanPictureUC1.HangmanImage = Properties.Resources._5;
                    break;
                case 4:
                    hangmanPictureUC1.HangmanImage = Properties.Resources._4;
                    break;
                case 3:
                    hangmanPictureUC1.HangmanImage = Properties.Resources._3;
                    break;
                case 2:
                    hangmanPictureUC1.HangmanImage = Properties.Resources._2;
                    break;
                case 1:
                    hangmanPictureUC1.HangmanImage = Properties.Resources._1;
                    break;
                case 0:
                    hangmanPictureUC1.HangmanImage = Properties.Resources._0;
                    break;
            }
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
            EndGame endGameForm = new EndGame(this, onePlayerGame);

            endGameForm.SetMessage(message);

            endGameForm.ShowDialog(); 
        }

        private void definitionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Definition: " + game.definition);
        }

        private void synonymsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Synonyms: " + game.synonyms);
        }
    }
}
