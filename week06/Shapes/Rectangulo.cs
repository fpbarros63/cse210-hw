public class Rectangulo : Shape
{
    private double _width;
    private double _lenght;

    public Rectangulo(string color, double width, double lenght) : base(color)
    {
        _width = width;
        _lenght = lenght;
    }

    public override double GetArea()
    {
        return _width * _lenght;
    }
}