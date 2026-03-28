class Goal : GoalManager
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    virtual public void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }

    public void Display()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_description}) - {_points} points");
    }

    private int AddPoints()
    {
        if (!_isComplete)
        {
            _totalPoints += _points;
        }
        return _totalPoints;
    }
}