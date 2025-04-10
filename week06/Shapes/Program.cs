using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle("Red", 5));
        shapes.Add(new Rectangle("Blue", 5, 5));
        shapes.Add(new Square("Green", 5));
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}