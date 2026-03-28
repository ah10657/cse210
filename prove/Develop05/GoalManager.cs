class GoalManager
{
    protected List<Goal> _goals = new List<Goal>();
    protected int _totalPoints = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
}