using System;
using System.Collections.Generic;

namespace SciptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Scripture scripture1 = new Scripture("Mosiah 3:8", "And he shall be called Jesus Christ, the Son of God, the Father of heaven and earth, the Creator of all things from the beginning; and his mother shall be called Mary.");
            Scripture scripture2 = new Scripture("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
            Scripture scripture3 = new Scripture("Alma 7:11-12", "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.\n And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.");

            scripture1.Show();
            Console.WriteLine("Press Enter to hide more words or write 'next' to continue with another scripture.");
            string input = Console.ReadLine();

            List<string> hiddenWords = new List<string>();

            while (input != "next")
            {
                scripture1.HideWordsRandomly(hiddenWords);
                scripture1.Show();
                Console.WriteLine("Press Enter to hide more words or write 'next' to continue with another scripture.");
                input = Console.ReadLine();
            }

            scripture2.Show();
            Console.WriteLine("Press Enter to hide more words or write 'next' to continue with another scripture.");
            input = Console.ReadLine();

            hiddenWords = new List<string>();

            while (input != "next")
            {
                scripture2.HideWordsRandomly(hiddenWords);
                scripture2.Show();
                Console.WriteLine("Press Enter to hide more words or write 'next' to continue with another scripture.");
                input = Console.ReadLine();
            }

            scripture3.Show();
            Console.WriteLine("Press Enter to hide more words or write 'next' to continue with another scripture.");
            input = Console.ReadLine();

            hiddenWords = new List<string>();

            while (input != "next")
            {
                scripture3.HideWordsRandomly(hiddenWords);
                scripture3.Show();
                Console.WriteLine("Press Enter to hide more words or write 'next' to continue with another scripture.");
                input = Console.ReadLine();
            }
        }
    }
}