using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity\n2. Start Reflection Activity\n3. Start Listing Activity\n4. Quit");
            choice = Console.ReadLine();
            if (choice == "1")
            {
            BreathingActivity breathing = new BreathingActivity();
            breathing.GetDisplayInfo();
            breathing.Duration();
            breathing.RunActivity();
            breathing.GetEndActivityInfo();

            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.GetDisplayInfo();
                reflecting.Duration();  
                reflecting.RunActivity();
                reflecting.GetEndActivityInfo();
            }
            if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.GetDisplayInfo();
                listing.Duration();
                listing.RunActivity();
                listing.GetEndActivityInfo();
            
            }
            if (choice == "4")
            {
                Console.WriteLine("Thank you for using Mindfulness!");
                Console.ReadLine();
            }
        }
    }  
}