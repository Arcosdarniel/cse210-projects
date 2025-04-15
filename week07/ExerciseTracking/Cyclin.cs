public class Cycling : Activity
{
    private double _speedK;

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speedK = speed;
    }

    public override double GetDistance()
    {
        return Math.Round(_speedK * GetDuration() / 60.0, 2);
    }

    public override double GetSpeed()
    {
        return _speedK;
    }

    public override double GetPace()
    {
        return 60.0 / _speedK;
    }
}
