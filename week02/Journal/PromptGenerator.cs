using System.Collections.Generic;

public class PromptGenerator
{
    List<string> _prompts = new List<string>();

    //  I don't really understand why it has to be the way it is, but if I create a new thing I.E. public void AddPrompt, it doesn't work.
    // However, the below code does work. I will try to look into that.
    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }
        
    Random ranIndex = new Random();
    

    public string GetRandomPrompt()
    {
        // during the beginning stages of writing the program, you can do this to return an empty sting
        int index = ranIndex.Next(_prompts.Count);

        string ranPrompt = _prompts[index];
        return ranPrompt;
    }

    public int GetRandomNumber()
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(5, 31);
        return magicNumber;
    }
}