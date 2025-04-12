// NegativeGoal - A goal where the player loses points for bad habits, like smoking
public class NegativeGoal : Goal
{
    private int _badHabitCount;

    public NegativeGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _badHabitCount = 0;
    }

    // Constructor used when loading from file
    public NegativeGoal(string savedData) : base("", "", 0)
    {
        string[] parts = savedData.Split('|');
        SetShortName(parts[0]);
        SetDescription(parts[1]);
        SetPoints(int.Parse(parts[2]));
        _badHabitCount = int.Parse(parts[3]);
    }

    public override void RecordEvent()
    {
        _badHabitCount++;
        Console.WriteLine($"You've lost {GetPoints()} points for the bad habit. Total bad habits: {_badHabitCount}");
    }

    public override bool IsComplete()
    {
        return false; // This goal doesn't "complete", but continues to accumulate bad habits.
    }

    public override string GetDetailsString()
    {
        return $"{GetShortName()}: {GetDescription()} - Bad habits count: {_badHabitCount} (Lose {GetPoints()} points for each bad habit)";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}|{_badHabitCount}";
    }

    public override int GetPoints()
    {
        return -_badHabitCount * base.GetPoints(); // Negative goal deducts points.
    }
}