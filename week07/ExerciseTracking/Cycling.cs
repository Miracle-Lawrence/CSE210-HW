public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    
    public override double GetDistance()
    {
        return _speed * GetLength();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return GetLength()/GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min)-Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {Math.Round(GetPace(),2)} min per km";
    }

}