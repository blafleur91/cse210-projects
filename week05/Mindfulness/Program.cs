using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        string input;
        input = "";

        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                // input whichever code and function is needed here.
                breathingActivity.DisplayEndingMessage();
            }
            else if (input == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplayStartingMessage();
                // input needed code to make it work.
                reflectingActivity.DisplayEndingMessage();
            }
            else if (input == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartingMessage();
                // input needed code here
                listingActivity.DisplayEndingMessage();
            }
            else if (input == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("You have input an invalid value. Please enter one of the four numbers.");
            }
        }
    }
}