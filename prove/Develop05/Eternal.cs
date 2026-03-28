class Eternal : Goal
{
    public override void RecordEvent()
    {
        _isComplete = false;
        Console.WriteLine("Congratulations! You have earned points!");
    }
}