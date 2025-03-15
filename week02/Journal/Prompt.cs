using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace MyApp;

public class Prompt
{        
        public string _answerPrompt;
        public string _prompt;
        public string _dateText;
        List<string> prompt = new List<string>
        {
            "What was the best thing that happened to you today?",
            "List three things you are grateful for today.",
            "Describe a moment when you felt happy today.",
            "If you could relive one moment from today, what would it be and why?",
            "Did you learn something new today? Explain briefly.",
            "Describe someone who made your day better and how they did it.",
            "If you had to give your day a title, what would it be?",
            "How did you feel most of the day? Explain why.",
            "Write a short letter to your 'future self' about your day.",
            "What would you do differently if you could redo today?"
        };
    
    public static int RandomNumber()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 9);
        return number;
    }

    int number = RandomNumber();
    public string PrintPrompt()
    {
        
        string dailyPrompt = prompt[number];
        return dailyPrompt;
    }
    public string Rememebr()
    {
        DateTime date = DateTime.Now;
        string dateText = date.ToString("MM/dd/yyyy");
        return dateText;
    }
}