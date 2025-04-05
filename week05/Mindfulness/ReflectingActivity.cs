public class ReflectingActivity : Base
{
    List<string> _prompts = new List<string>() {"What is one thing you are grateful for?","What is one thing you are sad about?","What is one thing you are proud of?","What is one thing you are afraid of?"};
    List<string> _questions = new List<string>() {"Why was this experience meaningful to you?","Have you ever done anything like this   before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    public ReflectingActivity()
    {
        _activityName = "Reflection";
        _activityDescription = "Reflection is a great way to reduce stress and anxiety. It can be done anywhere,anytime, and is easy to do.Reflection can be done in a quiet place, or in a noisy environment, and can be done for as long as you like.";
    }
    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Bucle(6);
        Random random = new Random();
        int randomPrompt = random.Next(0,_prompts.Count);    
        Console.WriteLine($"Consider the following prompt:\n\n---{_prompts[randomPrompt]}---\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to your experience.");
        Console.Write("you may begin in: ");
        for (int i = 4; i >= 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        int totalTime = _duration;
        int midletime = (int)Math.Round(totalTime / 2.0);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(midletime * 2);
        int randomQuestion1 = random.Next(_questions.Count);
        string firstQuestion = _questions[randomQuestion1];
        Console.WriteLine(end);
        while (DateTime.Now < end)
        {
            Console.Clear();
            Console.Write($"{firstQuestion} ");
            Bucle(midletime);
            int randomQuestion2;
            do
            {
                randomQuestion2 = random.Next(_questions.Count);
            } while (randomQuestion2 == randomQuestion1);

            string secondQuestion = _questions[randomQuestion2];

            Console.Write($"\n{secondQuestion} ");
            Bucle(midletime);
            Console.WriteLine(" ");
        }
        
    }
}