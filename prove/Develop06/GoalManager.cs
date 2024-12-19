class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            var goal = _goals[goalIndex];
            goal.RecordEvent();

            if (goal.IsComplete())
            {
                _score += goal.Points;
                CelebrateCompletion(goal);
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    private void CelebrateCompletion(Goal goal)
    {
        Console.WriteLine("\n🎉 Congratulations! 🎉");
        Console.WriteLine($"You completed the goal: {goal.GetDetailsString()}");
        Console.WriteLine($"Total Score: {_score}\n");
    }

    public void ListGoals()
    {
        Console.WriteLine("==== Goals ====");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine($"\nTotal Score: {_score}\n");
    }
}
