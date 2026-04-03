

using System.Diagnostics.CodeAnalysis;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        // I need to add to the constructor the lists being made.

        _prompts = new List<string>();
        _questions = new List<string>();
        // new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        // this needs to call a random prompt, wait for the user to press enter, and then begin to show the user various questions from 
        // the list.
        // it will end with well done and have a spinner.
        
        DisplayStartingMessage();
        DisplayPrompt();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            // Console.WriteLine("this is a test.");
            DisplayQuestions();
            ShowSpinner(10);
            Console.WriteLine();
        }
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int num = Random.Shared.Next(0, _prompts.Count());
        string ranIndex = _prompts[num];
        return ranIndex;
    }

    public string GetRandomQuestion()
    {
        // the below code is my initial way of getting a random question for the project. However, for enhancement, I have different
        // code I am using. However, I am not understanding the way google is explaining it so I'm just gonna do it a simpler for my
        // brain way. I will keep the original code and then adda remove to remove the question from the list so it cannot be displayed
        // again. I will also have to add an if else statement so it doesn't break the program if it runs out of items.
        if (_questions.Count() > 1)
        {
            int num = Random.Shared.Next(0, _questions.Count());
            string ranIndex = _questions[num];
            _questions.Remove(ranIndex);
            return "> " + ranIndex + " ";
        }
        else if (_questions.Count() == 1)
        {
            string lastIndex = _questions[0];
            _questions.Remove(lastIndex);
            return "> " + lastIndex + " ";
        }
        else
        {
            _questions.Add("Why was this experience meaningful to you?");
            _questions.Add("Have you ever done anything like this before?");
            _questions.Add("How did you get started?");
            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What made this time different than other times when you were not as successful?");
            _questions.Add("What is your favorite thing about this experience?");
            _questions.Add("What could you learn from this experience that applies to other situations?");
            _questions.Add("What did you learn about yourself through this experience?");
            _questions.Add("How can you keep this experience in mind in the future?");

            int num = Random.Shared.Next(0, _questions.Count());
            string ranIndex = _questions[num];
            _questions.Remove(ranIndex);
            return "> " + ranIndex + " ";
        }
        

        
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(" --- " + GetRandomPrompt() + " ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
    }

    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
    }
}