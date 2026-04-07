

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        // below is the setter for color. screwed up during initial making of the shape class by not creating a constructor
        // so I had to use setters initially.
        // SetColor(color);
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}