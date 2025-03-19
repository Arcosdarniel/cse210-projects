using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        fraction1.Display();
        Fraction fraction2 = new Fraction(6);
        fraction2.SetTop(5);
        fraction2.Display();
        Fraction fraction3 = new Fraction(3, 4);
        fraction3.Display();
        fraction3.SetBoth(1,3);
        fraction3.Display();

    }
}  