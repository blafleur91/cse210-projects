using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        string input;
        input = "";

        // The way that I have improved this program is by making sure that there are no repeat questions on the reflecting activity
        // until it has gone through all the questions.

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

            BreathingActivity breathingActivity = new BreathingActivity();
            ReflectingActivity reflectingActivity = new ReflectingActivity();
            ListingActivity listingActivity = new ListingActivity();

            if (input == "1")
            {
                breathingActivity.Run();
            }

            else if (input == "2")
            {
                reflectingActivity.Run();
            }

            else if (input == "3")
            {
                listingActivity.Run();
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