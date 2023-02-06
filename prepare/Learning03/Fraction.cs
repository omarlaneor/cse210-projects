using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction() // Constructor with no parameters.
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int number) // Constructor with one parameter for _top.
    {
        _top = number;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) // Constructor for two parameters for top and bottom.
    {
        _top = top;
        _bottom = bottom;
    }

    public String GetFractionString()
    {
        String texto = $"{_top}/{_bottom}";
        return texto;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}