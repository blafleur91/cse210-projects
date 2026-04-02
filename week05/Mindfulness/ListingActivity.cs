

public class ListingActivity : Activity
{
    
    private int _count;
    private List<string> _prompts;
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";


    }

    public void Run()
    {
        
        // this needs to call a random prompt from _prompts, display it, have a you may begin in with a countdown, and then have the user
        // begin inputting items to the computer. it will then count how many inputs you did and display that back to the user.
    }

    public void GetRandomPrompt()
    {
        
    }

    public List<string> GetListFromUser()
    {
        // I don't quite know what this is wanting to return, so I may have to change it. However I don't know so I will leave it
        // as it is.
        return _prompts;
    }
}