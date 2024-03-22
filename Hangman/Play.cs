using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Play
    {
        public string[] words = {
            "computer",
            "programming",
            "hangman",
            "developer",
            "keyboard",
            "algorithm",
            "debugging",
            "variable",
            "software",
            "coding"
        };

        public int incorrectGuessesLeft = 10;
        public int lettersLeftToGuess;

        public class WordInPlay
        {
            public char Letter { get; set; }
            public bool Guessed { get; set; }

            public WordInPlay(char letter, bool guessed)
            {
                Letter = letter;
                Guessed = guessed;
            }
        }

        public string GetWord()
        {
            int length = words.Length;
            Random random = new Random();
            int randomIndex = random.Next(0, length - 1);
            string word = words[randomIndex];
            lettersLeftToGuess = word.Length;

            return word;
        }

        public WordInPlay[] GetWordInPlayArray(string word)
        {
            WordInPlay[] wordArray = new WordInPlay[word.Length];
            for (int i=0; i<word.Length; i++)
            {
                wordArray[i] = new WordInPlay(word[i], false);
            }

            return wordArray;
        }

    }
}
