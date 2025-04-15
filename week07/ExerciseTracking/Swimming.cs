public class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming(string date, double length, double NumberOfLaps) : base(date,length)
    {
        _numberOfLaps = NumberOfLaps;
    }

    public void SetLaps(int NumberOfLaps)
    {
        _numberOfLaps = NumberOfLaps;
    }

    public double GetLaps()
    {
        return _numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return GetLength()/GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min)-Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {Math.Round(GetPace(),2)} min per km";
    }

    
}