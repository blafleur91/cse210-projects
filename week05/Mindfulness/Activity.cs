

using System.Security.Principal;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session to be? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready...");
        // need to add the spinner and timer functionality
    }

    public void DisplayEndingMessage()
    {
        // need to add timer functionality.
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        // need to add a line calling showspinner to have the spinner animation going.
    }

    public void ShowSpinner(int seconds)
    {
        
    }

    public void ShowCountDown(int seconds)
    {
        
    }
}