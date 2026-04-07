

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base (color)
    {
        // check rectangle for why below code is commented out.
        // SetColor(color);
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}