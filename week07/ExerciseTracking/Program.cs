using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("15 April 2025", 50, 10);
        run.GetSumarry();
        Cycling cycle = new Cycling("15 April 2025", 40, 20);
        cycle.GetSumarry();
        Swimming swim = new Swimming("15 April 2025", 10, 10);
        swim.GetSumarry();
    }
}