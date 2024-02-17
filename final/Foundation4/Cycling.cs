public class Cycling : Activity
{
    private double _speed;

    public Cycling(
        string date, 
        double activityDuration,
        double speed
    ) : base(date, activityDuration)
    {
        _speed = speed;
    }

    // Distance = _speed * ActivityDuration
    override public double GetDistance()
    {
        return _speed * base.GetActivityDuration();
    }

    // _speed
    override public double GetSpeed()
    {
        return _speed;
    }

    // pace = activityDuration / distance
    override public double GetPace()
    {
        return base.GetActivityDuration()/GetDistance();
    }

    override public string GetType()
    {
        return "Cycling";
    }
}