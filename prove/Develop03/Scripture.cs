using System;
using System.Collections.Generic;


namespace SciptureMemorizer
{
    class Scripture
    {
        public Reference Reference { get; set; }
        private List<Word> words = new List<Word>();

        public Scripture(string referenceText, string scriptureText)
        {
            Reference = new Reference(referenceText);
            string[] wordsText = scriptureText.Split(' ');

            foreach (string wordText in wordsText)
            {
                words.Add(new Word(wordText, false));
            }
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine(Reference.Text);
            foreach (Word word in words)
            {
                if (word.IsHidden)
                {
                    Console.Write(new string('_', word.Text.Length) + " ");
                }
                else
                {
                    Console.Write(word.Text + " ");
                }
            }
            Console.WriteLine();
        }

        public void HideWordsRandomly(List<string> hiddenWords)
        {
            Random rand = new Random();

            foreach (Word word in words)
            {
                if (!word.IsHidden && !hiddenWords.Contains(word.Text))
                {
                    int probability = rand.Next(0, 2); // 50% of probability for hidding this word.
                    if (probability == 1)
                    {
                        hiddenWords.Add(word.Text);
                        word.IsHidden = true;
                    }
                }
            }
        }
    }
}
