


public class Cycling : Activity
{
    private double _speed;
    
    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;

    }


    public override double GetDistance()
    {
        return _speed * _length / 60;
    }

    public override double GetSpeed()
    {
        // _speed = (_distance / _length) * 60;
        return _speed;
    }

    public override double GetPace()
    {
        // _pace = _length / _distance;
        return 60 / _speed;
    }

    public override string GetActivityName()
    {
        return "Cycling";
    }
}