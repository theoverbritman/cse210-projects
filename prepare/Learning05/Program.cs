using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sh1 = new Square("Red", 3);
        shapes.Add(sh1);

        Rectangle sh2 = new Rectangle("Blue", 4, 5);
        shapes.Add(sh2);

        Circle sh3 = new Circle("Green", 6);
        shapes.Add(sh3);

        foreach (Shape sh in shapes)
        {
            string color = sh.GetColor();

            double area = sh.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}