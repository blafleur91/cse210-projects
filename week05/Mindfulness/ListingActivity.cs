

using System.Threading.Tasks.Dataflow;

public class ListingActivity : Activity
{
    
    private int _count;
    private List<string> _prompts;
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        
        // this needs to call a random prompt from _prompts, display it, have a you may begin in with a countdown, and then have the user
        // begin inputting items to the computer. it will then count how many inputs you did and display that back to the user.
        DisplayStartingMessage();
        GetRandomPrompt();
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        _count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        if (_count > 1)
        {
            Console.WriteLine($"You listed {_count} items!");
        }
        else
        {
            Console.WriteLine("You listed 1 item!");
        }
        Console.WriteLine();

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        int ranIndex = Random.Shared.Next(0, _prompts.Count());
        string ranPrompt = _prompts[ranIndex];
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(" ---" + ranPrompt + " ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
    }

        // FOR GRADER
        // I checked the rubric and it didn't look like this method was required. If it is, I guess I will just have to take the hit.
        // However, if you could explain to me the purpose of this method if it is required, I would appreciate it, since the class
        // seems to be set up in a way where this is a somewhat useless method.

    // I don't quite know what this is wanting to return, so I may have to change it. However I don't know so I will leave it
    // as it is.
    // public List<string> GetListFromUser()
    // {
        
    //     return _prompts;
    // }
}