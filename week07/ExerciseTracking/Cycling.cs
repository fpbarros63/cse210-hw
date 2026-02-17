public class Cycling : Activity
{
    private double _speed; // mph

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        // distance = (speed / 60) * minutes
        return (GetSpeed() / 60.0) * GetMinutes();
    }

    public override double GetPace()
    {
        // pace = 60 / speed
        return 60.0 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetMinutes()} min)- " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}
