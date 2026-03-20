using System;

class Program
{
    static void Main(string[] args)
    {

        //  I enhanced my code by adding a minimum word count. That way the user will have the chance to write more then a few words about their day.

        Console.WriteLine("Welcome to the Journal Program!");
        int choice = 0;
        // previously I had the line of code below inside of the loop. After asking chatgpt why I couldn't get the entries to show
        // I learned that I was creating a new list every single loop. So remember to have some stuff outside of the loop!
        Journal journal = new Journal();
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();

            // The below line of code basically works like this. you have the int.TryParse. it takes in one variable and will try to output
            //  another.
            // the first variable is the one you want to be parsed if possible. the out means it is outputting whatever comes next. 
            // Therefore, I am
            // outputting an integer variable named choice, if possible. However, I need it in the if statement, so it will be in there.
            
            if (int.TryParse(input, out choice) && choice == 1 )
            {
                PromptGenerator generator = new PromptGenerator();
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);

                int number = generator.GetRandomNumber();
                Console.WriteLine($"You should try to write {number} words."); 

                Console.Write(">");
                string newEntry = Console.ReadLine();
                Entry entry = new Entry();
                string today = DateTime.Today.ToLongDateString();

                entry._date = today;
                entry._prompText = prompt;
                entry._entryText = newEntry;

                journal.AddEntry(entry);
            } 
            else if (int.TryParse(input, out choice) && choice == 2 )
            {
                journal.DisplayAll();
            }
            else if (int.TryParse(input, out choice) && choice == 3 )
            {
                Console.WriteLine("What is the filename?");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (int.TryParse(input, out choice) && choice == 4 )
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (int.TryParse(input, out choice) && choice == 5 )
            {
                Console.WriteLine("Thank you for using the Journal Program!");
            }
            else
            {
                Console.WriteLine("Please input a valid number from the list.");
            }
        }
        
    }
}