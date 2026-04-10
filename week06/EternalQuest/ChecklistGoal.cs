

public class ChecklistGoal : Goal
{
     private int _bonus;
    private int _target;
    private int _amountCompleted;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted ++;
        if (_amountCompleted != _target)
        {
            return _points;
        }
        else if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        else
        {
            return 8675309;
        }
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        if (_amountCompleted != _target)
        {
            return $". [ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $". [X] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}