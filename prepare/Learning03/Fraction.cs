

public class Fraction
{
    private int _top;    // Private field for numerator
    private int _bottom; // Private field for denominator

    // Default constructor (1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter (e.g., top/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with two parameters (e.g., top/bottom)
    public Fraction(int top, int bottom)
    {
        if (bottom == 0) // Avoid division by zero
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for numerator
    public int GetNumerator()
    {
        return _top;
    }

    public void SetNumerator(int top)
    {
        _top = top;
    }

    // Getter and Setter for denominator
    public int GetDenominator()
    {
        return _bottom;
    }

    public void SetDenominator(int bottom)
    {
        if (bottom == 0) // Avoid division by zero
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _bottom = bottom;
    }

    // Method to get the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to get the fraction as a decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
