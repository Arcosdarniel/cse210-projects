public class Running : Activity
{
    private double _k;
    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _k = distance;
    }

    public override double GetDistance()
    {
        return _k;
    }
    public override double GetSpeed()
    {
        return _k / (GetDuration() / 60.0);
    }
    public override double GetPace()
    {
        return GetDuration() / _k;
    }
}