using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int result = SquareNumber(userNumber);
        DisplayResult(userName,result);
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber (int number)
        {
            int multiplication = number * number;
            return multiplication;
            
        }
        static void DisplayResult (string name ,int multiplication)
        {
            Console.WriteLine($"{name}, the square of your number is {multiplication}");
        }
        
    }   
}