public class Base
{
    protected string _activityName = "";
    protected string _activityDescription = "";
    protected int _duration = 0;

    public Base()
    {
        _activityName = "Undefined";
        _activityDescription = "Undefined";
        _duration = 0;
    }
    public void Duration()
    {
        Console.WriteLine("How long, in seconds would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
    }
    public void Bucle(int seconds)
    {
        List<string> list = new List<string>() {"|", "/", "-", "\\","|","/","-","\\","|","/","-","\\"};
        int i = 0;
        while (i < seconds)
        {
            Console.Write(list[i]);
            i++;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    public void GetDisplayInfo()
    {   Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity!\n");
        Console.WriteLine($"{_activityDescription}\n");
    }
    public void GetEndActivityInfo()
    {
        Console.WriteLine("\nWell done!");
        Bucle(6);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName} Activity.");
        Bucle(6);
    }
}