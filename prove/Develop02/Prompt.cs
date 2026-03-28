using System;

public class Prompt
{
    List<string> _prompts = new List<string>()
    {
        "What was the best and worst part of your day?",
        "What are you grateful for today?",
        "How have you seen God's hand in your life today?",
        "Describe a challenge you faced today and how you overcame it.",
        "What is something new you learned today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}