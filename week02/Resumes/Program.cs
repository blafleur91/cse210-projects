using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project.");
        // the below code makes a new box called job1 using the class Job. it then assigns a value to each of the 4 boxes
        // that are in the class. effectively giving me something of a dictionary to work with, but with the key being
        // the name of the box I just made.

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2016;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Apple";
        job2._startYear = 2019;
        job2._endYear = 2022;

        // this is from the second and third steps, but I want it here so I can have backtracing of things I did.
        // Console.WriteLine($"{job1._company}");
        // Console.WriteLine($"{job2._company}");

        // this will pull each of the "boxes" and have them call the Display method from the Job class. That means
        // it will show all the information put into them. by step 8 it is also outdated.
        // job1.Display();
        // job2.Display();

        Resume person1 = new Resume();
        person1._name = "Allison Rose";
        person1._jobs.Add(job1);
        person1._jobs.Add(job2);


        // this is just test code to make sure the above code was working right.
        // Console.WriteLine(person1._jobs[0]._jobTitle);
        // Console.WriteLine(person1._jobs[1]._jobTitle);

        // To pull the display method from the Resume class it needs the identifier of the box that was made. It cannot
        // be called on its own.
        person1.Display();
        
        
    }
}