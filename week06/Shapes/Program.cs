using System;

class Program
{


                // So I have this somewhere, they made the shape class abstract in the example. Also, to set the color, 
                // they did : shape(color) REMEMBER THIS FOR FUTURE TASKS
                // Also, to note, I had 1: forgotten about that; and 2: They specified to create getters and setters,
                // and I skipped the constructor step. so that is my bad.
    static void Main(string[] args)
    {

        Square square = new Square("black", 2);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());
        // Console.WriteLine();

        Rectangle rectangle = new Rectangle("blue", 2, 3);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());
        // Console.WriteLine();

        Circle circle = new Circle("red", 2);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());
        // Console.WriteLine();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            // below is the how the example displayed the info. so they created a variable for each thing and then did the below print

            // Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}