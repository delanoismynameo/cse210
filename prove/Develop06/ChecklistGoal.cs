public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    public int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} - [{_amountCompleted}/{_target}] {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: {_shortName}, Progress: {_amountCompleted}/{_target}, Points: {_points}, Bonus: {_bonus}";
    }
}
