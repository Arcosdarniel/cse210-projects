using System.Collections.Generic;

class Program

{
    static void Main(string[] args)
    {   Console.WriteLine(" Enter a list of numbers, type 0 when finished. ");
        int number = (0);
        int sum = (0);
        float average = (0);
        List<int> negativeNumbers = new List<int>();
        List<int> positiveNumbers = new List<int>();
        List<int> numbers = new List<int>();
            do 
            {
                Console.Write("Enter number ");
                number = int.Parse(Console.ReadLine());
                if (number != 0 && number > 0)
                {
                   positiveNumbers.Add(number);
                   numbers.Add(number);
                }
                else if (number != 0 && number < 0)
                {
                    negativeNumbers.Add(number);
                    numbers.Add(number);
                }
                
            }
            while(number != 0);
            numbers.Sort();
            positiveNumbers.Sort();
            negativeNumbers.Sort();
        foreach (int eachNumber in positiveNumbers )
        {
            
            sum = sum + eachNumber;
            
        }
        foreach (int eachNumber in negativeNumbers )
        {  
            sum = sum + eachNumber;
        }
        average = sum/positiveNumbers.Count;
        Console.WriteLine($"The average is: {average.ToString("F2")}");
        Console.WriteLine($"The largest number is: {positiveNumbers[positiveNumbers.Count-1]}");
        Console.WriteLine($"The smaller positive number is: {positiveNumbers[0]}");
        Console.WriteLine("The sorted list is:");
        foreach (int eachNumber in numbers)
        {
            Console.WriteLine(eachNumber);
        }
        
    }
}