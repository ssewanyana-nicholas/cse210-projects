using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to a CSV file");
            Console.WriteLine("4. Load journal from a CSV file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GeneratePrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry(DateTime.Now, prompt, response);
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter a filename to save the journal as a CSV file: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToCsvFile(saveFilename);
                    break;

                case "4":
                    Console.Write("Enter a filename to load the journal from a CSV file: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromCsvFile(loadFilename);
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } //Added the process of saving and loading to save as a .csv file that could be opened in Excel
    }//exceeds the requirements
}