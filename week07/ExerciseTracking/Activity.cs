public abstract class Activity
{   private string _date;
    private double _duration;

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }
    public double GetDuration()
    {
        return _duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public void GetSumarry()
    {
        Console.WriteLine($"Date: {_date} {this.GetType().Name} ({_duration}min)- Distance {GetDistance()} Km, Speed {GetSpeed()} Km/h, Pace {GetPace()} min/km");
    }
}