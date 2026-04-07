

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        // check rectangle for why below line is commented out.
        // SetColor(color);
        _radius = radius;
    }

    public override double GetArea()
    {
        // NOTE can use Math.PI without importing. So use that from now on instead.
        return 3.14 * (_radius*_radius);
    }
}