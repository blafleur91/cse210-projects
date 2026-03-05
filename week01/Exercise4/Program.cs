using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        float total = 0;
        int largest = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
            
        }

        foreach (int i in numbers)
        {
            total += i;
            if (i > largest)
            {
                largest = i;
            }
        }

        float length = numbers.Count;
        float average = total / length;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The Largest number is: {largest}");
    }
}