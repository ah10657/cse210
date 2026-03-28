using System;

class Activity
{
    private string _title;
    private string _description;
    private int _duration;
    private string _animation;

    public Activity(string title, string description)
    {
        _title = title;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        Console.Write("How many seconds would you like to do this activity?");
        int seconds = int.Parse(Console.ReadLine());
        _duration = seconds;
    }

    public void Animate(string animation)
    {
        _animation = animation;
        
        Console.Write("\\");
        Console.Write("\b");
        Console.Write("|");
        Console.Write("\b");
        Console.Write("/");
        Console.Write("\b");
        Console.Write("-");
        Console.Write("\b");
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Starting {_title} for {_duration} seconds.");
        Console.WriteLine(_description);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Finished {_title}.");
    }
}