using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {   

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;
        int attempts = 0;


        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string think = Console.ReadLine();
            guess = int.Parse(think);

            attempts++;

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Congratulations! You have guessed it");
                Console.WriteLine($"You have used {attempts} guesses");
            }
        }
    }
}