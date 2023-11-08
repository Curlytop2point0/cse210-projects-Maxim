using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a series of numbers to make a list. Enter 0 to quit.");

        do
        {
            input = Convert.ToInt32(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max: {max}");
    }
}
