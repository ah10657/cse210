class Checklist : Goal
{
    private int _maxTimes;
    private int _timesDone;
    private int _bonusPoints;

    public override void RecordEvent()
    {
        if (_timesDone < _maxTimes)
        {
            _timesDone++;
            Console.WriteLine($"Congratulations! You have earned points! ({_timesDone}/{_maxTimes})");
            if (_timesDone == _maxTimes)
            {
                Console.WriteLine($"You have completed the checklist and earned a bonus of {_bonusPoints} points!");
            }
        }
        else
        {
            Console.WriteLine("You have already completed this checklist.");
        }
    }

    public void Display()
    {
        string status = _timesDone >= _maxTimes ? "[X]" : "[ ]";
        Console.WriteLine($"{status} Checklist ({_timesDone}/{_maxTimes}) - Bonus: {_bonusPoints} points");
    }
}