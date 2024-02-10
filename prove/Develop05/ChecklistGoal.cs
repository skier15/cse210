public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(
        string name, 
        string description, 
        int points, 
        int target, 
        int bonus) : base (name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

    public ChecklistGoal(
        string name, 
        string description, 
        int points,
        int amountCompleted, 
        int target, 
        int bonus) : base (name, description, points)
        {
            _amountCompleted = amountCompleted;
            _target = target;
            _bonus = bonus;
        }
    
    public override void RecordEvent()
    {
        _amountCompleted++;

        Console.WriteLine($"Congratulations! You earned {base._points}!");
        if (IsComplete())
        {
            base._points += _bonus;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted>=_target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist_{base._shortName}_{base._description}_{base._points}_{_amountCompleted}_{_target}_{_bonus}";
    }
}