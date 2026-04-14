


public class Swimming : Activity
{
    private int _lapCount;

    public Swimming(string date, int length, int lapCount) : base(date, length)
    {
        _lapCount = lapCount;
    }

    public override double GetDistance()
    {
        
        return _lapCount * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        
        return GetDistance() / _length * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

    public override string GetActivityName()
    {
        return "Swimming";
    }
}