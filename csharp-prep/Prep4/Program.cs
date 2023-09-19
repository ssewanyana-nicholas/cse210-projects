using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter the number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0) // this will not put zero in the list
            {
                numbers.Add(input);
            }

        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }


        Console.WriteLine($"The sum is {sum}");

        double average = numbers.Average(); // calculates the average automatically

        Console.WriteLine($"The average is: {average}");

        int positiveNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > 0 && number < positiveNumber) // it calculates the positive number
            {
                positiveNumber = number;
            }
        }

        Console.WriteLine($"The smallest positive is {positiveNumber}");

        int max = numbers.Max(); // calculates the maxumium

        Console.WriteLine($"The maximum number is {max}");

        numbers.Sort(); // it sortes the number in the ascending

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}