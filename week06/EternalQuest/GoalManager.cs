public class GoalManager
{
    private List<Goal> _goals;
    private int score = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void Start()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine($"\nYou have {score} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Your Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
    Console.WriteLine("The types of goals are:");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");
    Console.WriteLine("  4. Large Goal");  // Added new goal type
    Console.WriteLine("  5. Negative Goal"); // Added new goal type
    Console.Write("Which type of goal would you like to create? ");
    string goalType = Console.ReadLine();

    Console.Write("Enter the goal name: ");
    string name = Console.ReadLine();

    Console.Write("Enter a short description: ");
    string description = Console.ReadLine();

    Console.Write("Enter the points associated: ");
    int points = int.Parse(Console.ReadLine());

    if (goalType == "1")
    {
        _goals.Add(new SimpleGoal(name, description, points));
    }
    else if (goalType == "2")
    {
        _goals.Add(new EternalGoal(name, description, points));
    }
    else if (goalType == "3")
    {
        Console.Write("Enter the target number of times to complete: ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("Enter the bonus points: ");
        int bonus = int.Parse(Console.ReadLine());

        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
    }
    else if (goalType == "4")  // Large Goal
    {
        Console.Write("Enter the target progress (e.g., total miles for marathon): ");
        int targetProgress = int.Parse(Console.ReadLine());

        _goals.Add(new LargeGoal(name, description, points, targetProgress));
    }
    else if (goalType == "5")  // Negative Goal
    {
        _goals.Add(new NegativeGoal(name, description, points));
    }
    else
    {
        Console.WriteLine("Invalid goal type.");
    }
    }


    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the number of the goal: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            Goal selectedGoal = _goals[choice];
            selectedGoal.RecordEvent();

            score += selectedGoal.GetPoints();
            Console.WriteLine($"Event recorded! You earned {selectedGoal.GetPoints()} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter a file name to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the file name to load from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        score = int.Parse(lines[0]);

        _goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            string goalType = parts[0];

            Goal goal = null;

            if (goalType == "SimpleGoal")
            {
                goal = new SimpleGoal(lines[i]);
            }
            else if (goalType == "EternalGoal")
            {
                goal = new EternalGoal(lines[i]);
            }
            else if (goalType == "ChecklistGoal")
            {
                goal = new ChecklistGoal(lines[i]);
            }

            if (goal != null)
            {
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}
