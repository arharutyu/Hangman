using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;


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
        public string definition;
        public string synonyms;
        public string word;
        public bool awaitingApi = false;
        private int apiCalls = 0;
        public static string difficulty = "Normal";

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

        public void GetWord()
        {
            //int length = words.Length;
            //Random random = new Random();
            //int randomIndex = random.Next(0, length - 1);
            //string word = words[randomIndex];
            awaitingApi = true;
            CallApi();
            //return word;
        }

        public string SetWord(string word)
        {
            string trimmed = word.Replace(" ", "").ToLower();
            lettersLeftToGuess = trimmed.Length;
            return trimmed;
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

        public class ApiResponse
        {
            public string Word { get; set; }
            public List<Result> Results { get; set; }
        }
        public class Result
        {
            public string Definition { get; set; }
            public List<string> Synonyms { get; set; }
        }

        public async Task CallApi()
        {
            definition = null;
            synonyms = null;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wordsapiv1.p.rapidapi.com/words/?random=true&letterPattern=%5E%5Ba-zA-Z%5D%2B%24&lettersMax=10&frequencymin=7.00"),
                Headers =
        {
            { "X-RapidAPI-Key", "2c1f575146mshda04e3a60712bd3p1daa4fjsne96090694fc2" },
            { "X-RapidAPI-Host", "wordsapiv1.p.rapidapi.com" },
        },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(body);
                word = apiResponse.Word;
                lettersLeftToGuess = word.Length;
                Console.WriteLine(word);
                if (apiResponse.Results != null && apiResponse.Results.Count > 0)
                {
                    string apiDefinition = apiResponse.Results[0].Definition;
                    if (!string.IsNullOrEmpty(apiDefinition))
                    {
                        definition = apiDefinition;
                    }

                    List<string> apiSynonyms = apiResponse.Results[0].Synonyms;

                    if (apiSynonyms != null && apiSynonyms.Count > 0)
                    {
                        string synonymsString = string.Join(", ", apiSynonyms);
                        synonyms = synonymsString;
                    }
                }
                apiCalls++;
                if (apiCalls > 3 || (definition != null && synonyms != null)) {
                    awaitingApi = false;
                } 
                else
                {
                    CallApi();
                }
            }
        }

    }
}
