abstract public class Activity
{
    private string _date;
    private double _activityDuration;
    
    public Activity(string date, double activityDuration)
    {
        _date = date;
        _activityDuration = activityDuration;
    }

    // Getter _date
    public string GetDate()
    {
        return _date;
    }
    // Getter _activityLength
    public double GetActivityDuration()
    {
        return _activityDuration;
    }

    abstract public double GetDistance();
    abstract public double GetSpeed();
    abstract public double GetPace();
    abstract public new string GetType();
    
    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_activityDuration})- Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
