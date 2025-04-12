public class EternalGoal : Goal
{
    private int _currentStreak;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _currentStreak = 0;
    }

    // Constructor used when loading from file
    public EternalGoal(string savedData) : base("", "", 0)
    {
        string[] parts = savedData.Split('|');
        SetShortName(parts[0]);
        SetDescription(parts[1]);
        SetPoints(int.Parse(parts[2]));
        _currentStreak = int.Parse(parts[3]);
    }

    public override void RecordEvent()
    {
        _currentStreak++;
        Console.WriteLine($"You've earned {GetPoints()} points for this streak. Current streak: {_currentStreak}");
    }

    public override bool IsComplete()
    {
        return false; 
    }

    public override string GetDetailsString()
    {
        return $"{GetShortName()}: {GetDescription()} - Streak: {_currentStreak} (Earn {GetPoints()} points each time)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}|{_currentStreak}";
    }

    public override int GetPoints()
    {
        return _currentStreak * base.GetPoints(); 
    }
}
