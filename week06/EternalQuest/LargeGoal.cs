// LargeGoal - A goal where the player progresses toward a large objective, like running a marathon
public class LargeGoal : Goal
{
    private int _currentProgress;
    private int _targetProgress;

    public LargeGoal(string name, string description, int points, int targetProgress) 
        : base(name, description, points)
    {
        _currentProgress = 0;
        _targetProgress = targetProgress;
    }

    // Constructor used when loading from file
    public LargeGoal(string savedData) : base("", "", 0)
    {
        string[] parts = savedData.Split('|');
        SetShortName(parts[0]);
        SetDescription(parts[1]);
        SetPoints(int.Parse(parts[2]));
        _targetProgress = int.Parse(parts[3]);
        _currentProgress = int.Parse(parts[4]);
    }

    public override void RecordEvent()
    {
        if (_currentProgress < _targetProgress)
        {
            _currentProgress++;
            Console.WriteLine($"Goal progress: {_currentProgress}/{_targetProgress}. You earned {GetPoints()} points for this progress.");

            if (_currentProgress == _targetProgress)
            {
                Console.WriteLine($"Congratulations! You've completed the large goal! You earned an additional {GetPoints()} points.");
            }
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _currentProgress >= _targetProgress;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetShortName()}: {GetDescription()} - Progress: {_currentProgress}/{_targetProgress} (Earn {GetPoints()} points per progress)";
    }

    public override string GetStringRepresentation()
    {
        return $"LargeGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}|{_targetProgress}|{_currentProgress}";
    }

    public override int GetPoints()
    {
        return _currentProgress * base.GetPoints();
    }
}