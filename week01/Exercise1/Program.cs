using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine makes the next thing appear on a new line. using just write makes the next thing appear on the same line.
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}