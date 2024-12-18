public class Square : Shape
{
    private double _sides = 0;

    public Square(string color, double sides) : base (color)
    {
        _sides = sides;
    }

    public override double GetArea()
    {
        return _sides * _sides;

    }
}