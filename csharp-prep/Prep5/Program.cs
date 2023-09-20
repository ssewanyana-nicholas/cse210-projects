using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   // calls the main function
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaNumber);

        static void DisplayWelcome() // function that displays the welcome message
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName() // function that asks the user the name and returns the name as string
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber() // function that asks the user the favourite number and returns the number as integer
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number) // function tha calculates the square and returns the number as interger
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square) // function that displays the results
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}