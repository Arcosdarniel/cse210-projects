using System.Security.Cryptography.X509Certificates;
using System.IO;

public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYour score is {_score}");
    }
    public void ListGoalNames()
    {   
        int i = 1;
        foreach (Goal goal in _goals)
        {
            string goalinfo = goal.GetStringRepresentation();
            string[] nameTypegoal = goalinfo.Split(':');
            string[] nameGoal = nameTypegoal[1].Split(',');
            Console.WriteLine($"{i}. {nameGoal[0]}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
           Console.WriteLine($"{i}. {goal.GetDetailsString()}");
           i++;
        }
    }

    public string[] TextCreateGoal()
    {
        string[] goalInfo = new string[3];
        Console.Write("What is the name of the goal? ");
        goalInfo[0] = Console.ReadLine();
        Console.Write("What is the short description for it? ");
        goalInfo[1] = Console.ReadLine();
        Console.Write("What is the amont of points assosiated with this goal? ");
        goalInfo[2] = Console.ReadLine();
        return goalInfo;
    }
    public void CreateGoal()
    {
        Console.WriteLine("the type of Goals are:");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Which type of goal would you like to create: ");
        string choice = Console.ReadLine();
        
        if (choice == "1")
        {   
            string[] goalInfo = TextCreateGoal();
            _goals.Add(new SimpleGoal(goalInfo[0],goalInfo[1],goalInfo[2]));
            

        }
        else if (choice == "2")
        {
            string[] goalInfo = TextCreateGoal();
            _goals.Add(new EternalGoal(goalInfo[0],goalInfo[1],goalInfo[2]));
            
        
        }
        else if (choice == "3")
        {
            string[] goalInfo = TextCreateGoal();
            Console.Write("How many time does this goal need to be accomplished for the bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new CheckListGoal(goalInfo[0],goalInfo[1],goalInfo[2],bonus,target));
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish?");
        string choice = Console.ReadLine();
        int goalNumber = int.Parse(choice);
        string goalArray = _goals[goalNumber - 1].GetStringRepresentation();
        string[] goalInfo = goalArray.Split(':');
        string type = goalInfo[0];
        string[] parts = goalInfo[1].Split(',');

        int points = int.Parse(parts[2]);
        _score += points;

        if (type == "CheckListGoal")
        {
            int bonus = int.Parse(parts[3]);
            int target = int.Parse(parts[4]);
            int amountCompleted = int.Parse(parts[5]);

            if (amountCompleted == target-1)
            {
                Console.WriteLine($"Bonus achieved! You earned an extra {bonus} points.");
                _score += bonus;
            }
        }

        Console.WriteLine($"Congratulations! You have earned {points} points!\n");
        _goals[goalNumber - 1].RecordEvent();
    }
    public void SaveGoals()
    {   Console.WriteLine("What is the name of the file?");
        string fileName = (Console.ReadLine());
        string directoryPath = @"C:/CSE 210/cse210-projects/week06/EternalQuest";
        string filePath = Path.Combine(directoryPath,fileName);
        
        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            _goals.Clear();
            _score = 0;
        }
        _goals.Clear();
    }
    public void LoadGoals()
    {   Console.WriteLine("What is the name of the file?");
        string fileName = (Console.ReadLine());
        string directoryPath = @"C:/CSE 210/cse210-projects/week06/EternalQuest";
        string filePath = Path.Combine(directoryPath,fileName);
        string[] lines = System.IO.File.ReadAllLines(filePath);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            if (string.IsNullOrWhiteSpace(line)) continue;
            string[] parts = line.Split(':');
            string type = parts[0];
            if (type == "SimpleGoal")
            {
                string[] goalsParts = parts[1].Split(',');
                string name = goalsParts[0];
                string description = goalsParts[1];
                string points = goalsParts[2];
                bool isComplete = bool.Parse(goalsParts[3]);
                if (isComplete == true)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(name,description,points);
                    simpleGoal.RecordEvent();
                    _goals.Add(simpleGoal);
                }
                else
                {
                    SimpleGoal simpleGoal = new SimpleGoal(name,description,points);
                    _goals.Add(simpleGoal);
                }   
            }
            else if (type == "EternalGoal")
            {
                string[] nameDescriptionPoints = parts[1].Split(',');
                string name = nameDescriptionPoints[0];
                string description = nameDescriptionPoints[1];
                string points = nameDescriptionPoints[2];
                EternalGoal eternalGoal = new EternalGoal(name,description,points);
                _goals.Add(eternalGoal);
            }
            else if (type == "CheckListGoal")
            {
                string[] partsgoals = parts[1].Split(',');
                string name = partsgoals[0];
                string description = partsgoals[1];
                string points = partsgoals[2];
                int target = int.Parse(partsgoals[3]);
                int bonus = int.Parse(partsgoals[4]);
                int amountCompleted = int.Parse(partsgoals[5]);
                
                CheckListGoal checkListGoal = new CheckListGoal(name,description,points,target,bonus);
                for (int j = 0; j < amountCompleted; j++)
                {
                    checkListGoal.RecordEvent();
                }
                
                if (amountCompleted == target)
                {
                    checkListGoal.IsComplete();
                }
                _goals.Add(checkListGoal);
            }
        }
    }
}