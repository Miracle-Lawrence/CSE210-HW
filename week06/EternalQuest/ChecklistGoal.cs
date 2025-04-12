public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    // Constructor used when loading from file
    public ChecklistGoal(string savedData) : base("", "", 0)
    {
        string[] parts = savedData.Split('|');
        SetShortName(parts[0]);
        SetDescription(parts[1]);
        SetPoints(int.Parse(parts[2]));
        _target = int.Parse(parts[3]);
        _bonus = int.Parse(parts[4]);
        _amountCompleted = int.Parse(parts[5]);
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Goal progress: {_amountCompleted}/{_target} completed. You earned {GetPoints()} points for this step.");

            
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You've completed the goal. You earned an additional {_bonus} points as a bonus!");
            }
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetShortName()}: {GetDescription()} - Progress: {_amountCompleted}/{_target} (Earn {GetPoints()} points per completion)";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }

    public override int GetPoints()
    {
        int totalPoints = _amountCompleted * base.GetPoints();
        if (IsComplete())
        {
            totalPoints += _bonus;
        }
        return totalPoints;
    }
}
