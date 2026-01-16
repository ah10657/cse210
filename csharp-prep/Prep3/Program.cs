using System;
using System.Security.Cryptography;

class Program
{


    static void Main(string[] args)
    {
        Random RandomNumber = new Random();
        int Number = RandomNumber.Next(1, 100);
        int Guess = 0;
        int GuessAmount = 0;
        string Again = "yes";

        Console.WriteLine("Welcome to the Magic Number Game!");
        while (Again == "yes")
        {
            while (Guess != Number)
            {
                Console.Write("What is your guess? ");
                string GuessNumber = Console.ReadLine();
                int NewGuess = int.Parse(GuessNumber); 
                if (NewGuess > Number)
                {
                    if (NewGuess > Number + 15)
                    {
                        Console.WriteLine("Whoa! That's WAY too high!");
                    }
                    else if (NewGuess > Number)
                    {
                        Console.WriteLine("Too high!");
                    }
                }
                else if (NewGuess < Number)
                {
                    if (NewGuess < Number - 15)
                    {
                        Console.WriteLine("Whoa! That's WAY too low!");
                    }
                    else if (NewGuess < Number)
                    {
                        Console.WriteLine("Too low!");
                    }
                }
                GuessAmount += 1;
                if (NewGuess == Number || GuessAmount > 20)
                {
                    Guess = NewGuess;
                    break;
                }
            }
            if (Guess == Number)
            {
                Console.WriteLine($"You got it! The number was {Number}! It took you {GuessAmount} guesses!");
            }
            else if (GuessAmount > 20)
            {
                Console.WriteLine("I'm gonna have to cut you off at 20 guesses. You are terrible at this game.");
            }
        Console.Write("Would you like to play again? [YES/NO] ");
        Again = Console.ReadLine().ToLower();
            if (Again == "yes")
            {
                Guess = 0;
                GuessAmount = 0;
                Number = RandomNumber.Next(1, 100);
            }
        }
        Console.Write("Thank you for playing!");
    }
}