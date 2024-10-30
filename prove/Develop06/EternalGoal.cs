public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Since it's eternal, we don't set it as complete, but just grant points
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never fully complete
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} - [∞] {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_shortName}, Points per Event: {_points}";
    }
}
