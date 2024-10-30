using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Placeholder for startup logic
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public int GoalCount()
    {
        return _goals.Count;
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            
            // Add points for the event
            _score += goal._points;
            
            // Add bonus if checklist goal is completed
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal._bonus;
            }
        }
    }

    public void SaveGoals()
    {
        // Placeholder for save functionality
    }

    public void LoadGoals()
    {
        // Placeholder for load functionality
    }
}
