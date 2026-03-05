using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userNumber = magicNumber + 1;
        while (userNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }
    }
}