public class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming(
        string date, 
        double activityDuration, 
        double numberOfLaps
    ) : base(date, activityDuration)
    {
        _numberOfLaps = numberOfLaps;
    }


    // Get distance (km)
    override public double GetDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    // Speed (kph)
    override public double GetSpeed()
    {
        return (GetDistance() / base.GetActivityDuration()) * 60;
    }

    override public double GetPace()
    {
        return base.GetActivityDuration() / GetDistance();
    }

    override public string GetType()
    {
        return "Swimming";
    }
}