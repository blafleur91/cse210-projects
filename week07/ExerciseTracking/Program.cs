using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        Cycling cycling = new Cycling("14 Apr 2026", 30, 8);
        // distance should be 4 and pace should be 7.5

        Running running = new Running("14 Apr 2026", 30, 3);
        // distance should be 3, speed should be 6, and pace should be 10

        Swimming swimming = new Swimming("14 Apr 2026", 30, 100);
        // distance should be 3.1, speed should be 6.2, pace should be 9.7

        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        foreach (Activity a in activities)
        {
            a.GetSummary();
        }
    }
}