

public class Shape
{
    private string _color;
    // To fix a mistake, I am adding a constructor since I was supposed to.

    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}