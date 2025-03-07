using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string textGrade = Console.ReadLine();
        int gradePorcentage = int.Parse(textGrade);

        string letter = "";

        if (gradePorcentage >= 90)
        {
             letter = "A";
        }
        else if (gradePorcentage >= 80)
        {
             letter = "B";
        }
        else if (gradePorcentage >= 70)
        {
             letter = "C";
        }
        else if (gradePorcentage >= 60)
        {
             letter = "D";
        }
        else if (gradePorcentage < 60)
        {
             letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");
    }   
}