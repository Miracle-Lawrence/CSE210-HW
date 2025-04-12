//To exceed requirements, i did the following;
// Added a "LargeGoal" class to track progress towards a large goal like running a marathon, earning points as progress is made.
// Added a "NegativeGoal" class that deducts points for bad habits or undesirable actions, allowing for penalty-based goal tracking.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}