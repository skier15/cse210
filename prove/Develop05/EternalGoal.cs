public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {}

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You earned {base._points}!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal_{base._shortName}_{base._description}_{base._points}_{IsComplete()}";
    }
}