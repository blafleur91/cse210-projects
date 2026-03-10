public class Resume
{
    public string _name;

    // Ok, so below is confusing. I am pretty sure the thing most confusing to me is list, but using some brain power
    // I believe it is just using the little arrows to show what goes in the list. In this instance, it is saying the 
    // the Job class will go into the list. The equal sign with new means that the List is initialized, meaning it will work
    // since everything has to be initialized in C#
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        // below is a iterative for loop. foreach makes it function like pythons for loop. the first thing is says what type
        // of variable. The rest of it is like a for loop in python in place and function.
        foreach (Job j in _jobs)
        {
            // without the (j.), it would not be able to pull the needed index number to have the Job.cs display method work properly.
            // This means that it doesn't pull the index number for the name. Funnily enough, what happens without it is that it works
            // like redstone torches powering eachother. It keeps calling the display method from this file until it burns out.
            j.Display();
        }
    }
}