using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 500);
        string respond = ("");
        int guess = (-1);
        int count = 0;
        string tryAgain = ("yes");
        do 
        {

                if (tryAgain == ("yes"))
                {
                        do
                        {   
                            count++;
                            Console.WriteLine("What is your guess? ");
                            guess = int.Parse(Console.ReadLine());
                                if (number > guess)
                                {
                                    respond = ("Higher");
                                }
                                else if (guess > number)
                                {
                                    respond = ("Lower");
                                }
                                else if(guess == number)
                                {
                                    respond = ("Right");
                                }
                            Console.WriteLine($"{respond}");
                            
                        }
                        while (guess != number);
                    Console.WriteLine($"It only took you {count} tries");
                }

            Console.WriteLine("Do you wnat play again? ");
            tryAgain = Console.ReadLine();
            if (tryAgain == ("not"))
            {
                Console.WriteLine("Goodbye");
            }
        }
        while (tryAgain != ("not") );
    }
}