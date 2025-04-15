public abstract class Activity
{
    private double _length;
    private string _date;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }
    
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min)-Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {Math.Round(GetPace(),2)} min per km";
    }

    
    

}