public class Running : Activity
{
    private double _distance;

    public Running(
        string date, 
        double activityDuration, 
        double distance
        ) : base(date, activityDuration)
    {
        _distance = distance;
    }

    override public double GetDistance()
    {
        return _distance;
    }

    // Speed (kph)
    override public double GetSpeed()
    {
        return (_distance / base.GetActivityDuration()) * 60;
    }

    override public double GetPace()
    {
        return base.GetActivityDuration()/_distance;
    }

    override public string GetType()
    {
        return "Running";
    }
}