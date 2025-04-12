using System;

class Program
{
    static void Main(string[] args)
    {
        
        GoalManager goalManager = new GoalManager();
        int choice = 0;
        while (choice != 6)
        {
            goalManager.DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:\n1. Create a goal\n2. List goals\n3. Save Goals\n4. Record an event\n5. Load goals\n6. Exit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (choice == 1)
            {
                goalManager.CreateGoal();
            }
            else if (choice == 2)
            {
                goalManager.ListGoalDetails();
            }
            else if (choice == 3)
            {
                goalManager.SaveGoals();
            }
            else if (choice == 4)
            {
                goalManager.RecordEvent();
            }
            else if (choice == 5)
            {
                goalManager.LoadGoals();
            }
            else if (choice > 7)
            {
                Console.WriteLine("Please enter a valid option");
            }   
        }
    }
}