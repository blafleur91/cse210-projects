

public abstract class Activity
{
    // protected double _pace;
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;

        // to get the pace, you need to divide 60 by the miles. that gives you insert minutes per mile.
        // for distance, divide the run time by the pace.
    }



    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {GetActivityName()} ({_length}): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract string GetActivityName();
}