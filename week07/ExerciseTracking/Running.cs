


public class Running : Activity
{
    private double _distance;

    
    public Running(string date, int length, int distance) : base(date, length)
    {
        _distance = distance;

    }



    public override double GetDistance()
    {
        // _distance = 0;
        return _distance;
    }

    public override double GetSpeed()
    {
        
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public override string GetActivityName()
    {
        return "Running";
    }
}