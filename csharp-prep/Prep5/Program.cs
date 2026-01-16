using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(UserNumber);
        int BirthYear;
        PromptUserBirthYear(out BirthYear);
        DisplayResult(UserName, SquaredNumber, BirthYear);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();
        return Name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int Number = int.Parse(Console.ReadLine());
        return Number;
    }
    
    static void PromptUserBirthYear(out int BirthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        BirthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int Number)
    {
        int Square = Number * Number;
        return Square;
    }

    static void DisplayResult(string Name, int Square, int BirthYear)
    {
        Console.WriteLine($"{Name}, the square of your favorite number is {Square}.");
        Console.WriteLine($"{Name}, you will turn {2026 - BirthYear} years old this year.");
    }
}