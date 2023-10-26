using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.AddScripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");
        library.AddScripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        library.AddScripture("Genesis 1:1-2", "In the beginning, the Lord created the heaven and the earth. And the earth was without form, and void; and darkness was upon the face of the deep.");
        library.AddScripture("Isaiah 7:14", "Therefore, the Lord himself shall give you a sign—Behold, a virgin shall conceive, and shall bear a son, and shall call his name Immanuel.");

        Random random = new Random();
        Scripture selectedScripture = library.GetRandomScripture(random);

        ScriptureMemorizer memorizer = new ScriptureMemorizer(selectedScripture);

        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine($"Memorize: {memorizer.GetFullScripture()}");

        while (!memorizer.AllWordsHidden)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            memorizer.HideRandomWord(random);
            Console.Clear();
            Console.WriteLine($"Memorize: {memorizer.GetHiddenScripture()}");
        }

        Console.WriteLine("Congratulations! You've memorized the entire scripture.");
    }
}

