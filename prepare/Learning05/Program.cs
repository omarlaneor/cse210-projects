using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Red", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("blue", 6);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.Write($"The {color} {shape} has an area of {area} m2.");
        }
    }
}
