public class Job
{
    // I don't completely understand what is going on here so I'm gonna try to explain it so I'm not as confused
    // public class Job is like a big box. I can access this box because I have made the class type public.
    // the class is just specifying that this is basically a function. I can use this to create data to be
    // stored, so in the Program.cs file, I can call Job, and give a new thing, i.e. job1, and input values.
    // As much as I hate using the box analogy, I will use it here. By calling the Job class, and initializing it
    // Job job1 = new Job(); (that is the line of code that calls it and initializes it) I create a new box
    // called job1, which can have the four values below ascribed to it. That is what this currently does.

    // the four things below are called attributes. they are also called member variables. As in they are variables
    // for the class to work with. USE _underscoreCamelCase on member variables.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // below is the behaviors, also called methods. USE TitleCase on methods.

    // On another note, it took me a bit to figure this out. Basically, I was trying to label it a string, when this is
    // basically a function. After I figured that out, I was able to get it put together fairly easily.
    // to get called in another file, you use the same method with period, i.e. job1.Display()

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}