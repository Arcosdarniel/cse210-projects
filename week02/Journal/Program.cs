using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using MyApp;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {   
        
        Menu menu = new Menu();
        int select;
        do 
        {   
            select = menu.DisplaySelect();

            while (select < 1 || select > 4)
            {
                Console.WriteLine("Invalid selection. Please choose a valid option (1, 2, 3, or 4).");
                select = menu.DisplaySelect();
            }
            if (select == 1)
            {
                string dailyJournal = menu.Write();
                string saveOrNot;
                do
                {   
                    Console.WriteLine("Do you want to save your memory? yes/not");
                    saveOrNot= Console.ReadLine();
                    if (saveOrNot.ToLower() == "yes")
                    {
                        menu.PushAnswer(dailyJournal);
                    }
                    else if (saveOrNot.ToLower() == "not")
                    {
                        Console.WriteLine("Your memory has not been saved");
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection");
                    }
                }
                while (saveOrNot.ToLower() != "not" && saveOrNot.ToLower() != "yes");
            }
            else if (select == 2)
            {
                menu.DisplayJournal();
            }
            else if (select == 3)
            {
                Console.WriteLine("What is the name of the memory you want to load?");
                string name = Console.ReadLine();
                menu.LoadJournal(name);
            }
            else if (select == 4)
            {
                Console.WriteLine("Goodbye");
            }      
        }
        while (select != 4);
    }
}