

using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{

    private bool _iscomplete;

    public SimpleGoal(string name, string description, string points) : base (name, description, points)
    {
        _iscomplete = false;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}