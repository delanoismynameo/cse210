public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} - {(_isComplete ? "[X]" : "[ ]")} {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_shortName}, Points: {_points}, Completed: {_isComplete}";
    }
}
