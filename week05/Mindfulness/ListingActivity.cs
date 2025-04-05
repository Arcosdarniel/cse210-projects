public class ListingActivity : Base
{
    List<string> _prompts = new List<string>() {" What are some of your personal heroes?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are people that you appreciate?"};
    List<string> _answers = new List<string>();
    
    public ListingActivity()
    {
        _activityName = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Bucle(6);
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count);
        string prompt = _prompts[randomNumber];
        Console.WriteLine($"Liat as many responses you can to the following prompt:\n--- {prompt} ---\n");
        Console.Write("you may begin in: ");
        for (int i = 5; i >= 1; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine(" ");
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            _answers.Add(Console.ReadLine());
            
        }
        Console.WriteLine($"You listed {_answers.Count} items.");
    }
}