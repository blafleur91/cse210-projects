

using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{

    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = IsComplete();
        return _points;
    }   

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        if (_isComplete == false)
        {
            return base.GetDetailsString();
        }
        else
        {
            return $". [X] {_shortName} ({_description})";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}