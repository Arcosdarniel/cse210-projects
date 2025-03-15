using MyApp;
namespace MyApp;
using System;
using System.Collections.Generic;
public class Menu
{   
    Prompt getPrompt = new Prompt();
    public string  Write()
    {
        getPrompt._prompt = getPrompt.PrintPrompt();
        Console.WriteLine(getPrompt._prompt);
        getPrompt._answerPrompt = Console.ReadLine();
        getPrompt._dateText = getPrompt.Rememebr();
        string dailyJournal = $"{getPrompt._dateText}-{getPrompt._prompt}-{getPrompt._answerPrompt}";
        return dailyJournal;
    }  
    
       public void PushAnswer(string dailyJournal)
    {
        Console.WriteLine("What is the file's name?");
        string nameJournal = Console.ReadLine();
        string fileName = ("Journal.txt");
        string directoryPath = @"C:\CSE 210\cse210-projects\week02\Journal";
        string filePath = Path.Combine(directoryPath,fileName);

        using (StreamWriter outputFile = new StreamWriter(filePath,true))
        {
            outputFile.WriteLine($"{nameJournal}-{dailyJournal}");
            Console.WriteLine("Your answer has been saved");
        };
    }

    public void LoadJournal(string nombre)
    {   
        
        string fileName = ("Journal.txt");
        string directoryPath = @"C:\CSE 210\cse210-projects\week02\Journal";
        string filePath = Path.Combine(directoryPath,fileName);
        string[] lines = System.IO.File.ReadAllLines(filePath);
        Console.WriteLine("What is the name of the memory you want to load?");
        foreach (string line in lines)
        {
            if (line.ToLower().Contains(nombre.ToLower()))
            {
                string title = line;
                Console.WriteLine(title);
            }
        }

    }
    public void DisplayJournal()
    {
        string fileName = ("Journal.txt");
        string directoryPath = @"C:\CSE 210\cse210-projects\week02\Journal";
        string filePath = Path.Combine(directoryPath,fileName);
        string[] lines = System.IO.File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split("-");
            string title = parts[0];
            string date = parts[1];
            string prompt = parts[2];
            string answer = parts[3];
            Console.WriteLine($"Title: {title}-{date}");
            Console.WriteLine($"Prompt: {prompt}");
            Console.WriteLine($"memory: {answer}");
            Console.WriteLine("");
        }
    }

    public int DisplaySelect()
    {
        Console.WriteLine("Welcome to the Journal App");
        Console.WriteLine("Please select one of the following choices");
        List<string> listMenu = new List<string> 
        {
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Quit"
        };
        foreach(string i in listMenu)
        {
            Console.WriteLine($"{i}");
            
        }
        Console.WriteLine("What do you like to do?");
        int select = int.Parse(Console.ReadLine());
        return select;
    }
}