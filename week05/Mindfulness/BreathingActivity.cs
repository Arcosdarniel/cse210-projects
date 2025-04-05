public class BreathingActivity : Base
{
    public BreathingActivity()
    {
        _activityName = "Breathing";
        _activityDescription = "Breathing is a great way to reduce stress and anxiety. It can be done anywhere,anytime, and is easy to do.Breathing can be done in a quiet place, or in a noisy environment, and can be done for as long as you like.";
    }
    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Bucle(6);
        int totalTime = _duration;
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(totalTime);
        if (totalTime % 6 != 0)
        {
            totalTime += 6 - (totalTime % 6);
        }
        while (DateTime.Now < end)
        {

            Console.Write($"\nBreathe...");
            for (int i = 3; i > 0 ; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write($"\nNow breathe out...");
            for (int i = 3; i > 0 ; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine(" ");
        }
    }
}