using System;

class Program
{
    static void Main(string[] args)
    {   

        Console.Write("Enter grade percentage: ");
        string answer = Console.ReadLine();
        int score = int.Parse(answer);

        string letter = "";


        if (score >= 90)
        {
            letter = "A";
        }

        else if (score >= 80)
        {
            letter = "B";
        }

        else if (score >= 70)
        {
            letter = "C";
        }

        else if (score >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }


        if (score >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course."); 
        }

        else
        {
            Console.WriteLine("Thank you for partipating! Try again next time");
        }

        // stretch challenge

        int lastNumber = score % 10; // checks the reminder
        string sign = "";
        if (lastNumber >= 7)
        {
            sign = "+";
        }

        else if (lastNumber < 3)
        {
            sign = "-";
        }

        if (letter =="A" && (sign == "+" || sign == "-" )) // handles letter exceptions
        {
            sign = "";
        }

        else if (letter =="F" && (sign =="+" || sign == "-"))
        {
            sign = "";
        }

        Console.WriteLine($"Your final grade is {letter}{sign}");
    }
}