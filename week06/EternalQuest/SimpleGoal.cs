public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Constructor used when loading from file
    public SimpleGoal(string savedData) : base("", "", 0)
    {
        string[] parts = savedData.Split('|');
        SetShortName(parts[0]);
        SetDescription(parts[1]);
        SetPoints(int.Parse(parts[2]));
        _isComplete = bool.Parse(parts[3]);
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points for completing the goal: {GetShortName()}.");
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {GetShortName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }

    public override int GetPoints()
    {
        return _isComplete ? base.GetPoints() : 0;  
    }
}
