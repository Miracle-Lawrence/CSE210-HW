public class Goal
{
    private string _shortName;
    private string _description;
    private int _points; 

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Getter methods
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual int GetPoints() 
    {
        return _points;
    }

    // Setter methods
    protected void SetShortName(string name)
    {
        _shortName = name;
    }

    protected void SetDescription(string description)
    {
        _description = description;
    }

    protected void SetPoints(int points) 
    {
        _points = points;
    }

    // Virtual methods for derived classes to override
    public virtual void RecordEvent()
    {
        
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}
