using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Program Menu:");
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunBreathingActivity();
                    break;
                case "2":
                    RunReflectionActivity();
                    break;
                case "3":
                    RunListingActivity();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void RunBreathingActivity()
    {
        BreathingActivity breathing = new BreathingActivity();
        breathing.StartActivity();
    }

    static void RunReflectionActivity()
    {
        ReflectionActivity reflection = new ReflectionActivity();
        reflection.StartActivity();
    }

    static void RunListingActivity()
    {
        ListingActivity listing = new ListingActivity();
        listing.StartActivity();
    }
}
