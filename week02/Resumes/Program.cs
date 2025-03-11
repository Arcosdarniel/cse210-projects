using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._jobTitle = "Software Engineer";
        Job1._company = "Microsoft";
        Job1._startYear = 2025;
        Job1._endYear = 2026;

        Job Job2 = new Job();
        Job2._jobTitle = "Manager";
        Job2._company = "Apple";
        Job2._startYear = 2025;
        Job2._endYear =2026;

        Resume Resume1 = new Resume();
        Resume1._name = "Marcos Arcos";

        Resume1.jobs.Add(Job1);
        Resume1.jobs.Add(Job2);

        Resume1.Display();
    }
}