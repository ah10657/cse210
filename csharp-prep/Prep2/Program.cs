using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string ValueInText = Console.ReadLine();
        double Number = double.Parse(ValueInText);
        string Letter = "";
        string Sign = "";

        double Remainder = Number % 10;
        if (Remainder >= 7)
        {
            Sign = "+";
        }
        else if (Remainder < 3)
        {
            Sign = "-";
        }

        if (Number >= 90)
        {
            Letter = "A";
        }
        else if (Number >= 80)
        {
            Letter = "B";
        }
        else if (Number >= 70)
        {
            Letter = "C";
        }
        else if (Number >= 60)
        {
            Letter = "D";
        }
        else if (Number < 60)
        {
            Letter = "F";
        }

        if (Letter == "A" && Remainder >= 7)
        {
            Sign = "";
        }
        else if (Letter == "F")
        {
            Sign = "";
        }

        if (Number >= 70)
        {
            Console.Write($"Hooray! You passed with a {Letter}{Sign} at {Number}%!");
        }
        else if (Number <= 70)
        {
            Console.Write($"Sorry, you failed with a {Letter}{Sign} at {Number}%... Better luck next time!");
        }
    }
}