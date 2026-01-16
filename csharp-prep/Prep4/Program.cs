using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<float> Numbers;
        Numbers = new List<float>();
                
        Console.WriteLine("Enter a list of positive or negative numbers. Type 0 when you are done.");
        while (true)
        {
            Console.Write("Enter a number: ");
            string Input = Console.ReadLine();
            float Number = float.Parse(Input);
            Numbers.Add(Number);
            if (Number == 0)
            {
                Numbers.Remove(Number);
                break;
            }
        }
        
        float Sum = 0;
        float Max = Numbers[0];
        float Min = Numbers[0];
        Numbers.Sort();

        foreach (float Number in Numbers)
        {
            Sum += Number;
            if (Number > Max)
            {
                Max = Number;
            }
            else if (Number < Min)
            {
                Min = Number;
            }
        }

        float Average = ((float)Sum) / Numbers.Count;

        Console.WriteLine($"The sum of your numbers is: {Sum}");
        Console.WriteLine($"The average of your numbers is: {Average}");
        Console.WriteLine($"The largest number in your list is: {Max}");
        Console.WriteLine($"The smallest number in your list is : {Min}");
        Console.WriteLine("Your numbers sorted from smallest to largest:");
        foreach (float Number in Numbers)
        {
            Console.WriteLine(Number);
        }
    }
}