
using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {  
        Scripture scripture = new Scripture();
        scripture.HideRandomWord();
        string displayText = scripture.GetDisplayText();
        string answer = "";

        while (answer != "quit")
        {
            Console.WriteLine(displayText);
            Console.WriteLine("Enter or type 'quit' to quit");
            answer = Console.ReadLine();
            Console.Clear();
                scripture.HideRandomWord();
                displayText = scripture.GetDisplayText();
        }

    }
}