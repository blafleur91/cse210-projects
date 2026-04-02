

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        // I need to add to the constructor the lists being made.
    }

    public void Run()
    {
        // this needs to call a random prompt, wait for the user to press enter, and then begin to show the user various questions from 
        // the list.
        // it will end with well done and have a spinner.
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {
        
    }

    public void DisplayQuestions()
    {
        
    }
}