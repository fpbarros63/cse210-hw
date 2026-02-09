using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangulo s2 = new Rectangulo("Blue", 5, 4);
        shapes.Add(s2);

        Circle s3 = new Circle("Yellow", 3);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }
    }
}