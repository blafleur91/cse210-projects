

using System.Dynamic;

public class Fractions
{
    private int _top;
    private int _bottom;

    public void Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public void Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public void Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        Console.WriteLine(_top);
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        // this is only supposed to give the first thing since the decimal value can give the other values.
        // if (_bottom > 1)
        // {
        //     return _top + "/" + _bottom;
        // }
        // else if (_bottom == 1)
        // {
        //     return $"{_top}";
        // }
        // else
        // {
        //     return "there is no number for the denominator.";
        // }
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        // NOTE MAKE SURE IF YOU WANT A DECIMAL TO CONVERT AT LEAST ONE INT INTO EITHER A FLOAT OR A DOUBLE
        double value = _top;
        return value/_bottom;
    }
}