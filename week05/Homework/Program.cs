using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssigment student1 = new MathAssigment("Ryan Sedgwick", "Fraction", "Section 8.6", "Problem 1-6");
        Console.WriteLine(student1.GetInfo());
        Console.WriteLine(student1.GetHomeworkList());
        
        WritingAssigment student2 = new WritingAssigment("Kayth Bundy", "Poetry", "The Poet's Voice");
        Console.WriteLine(student2.GetInfo());
        Console.WriteLine(student2.GetHomeworkList());
    }
}