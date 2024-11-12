using System;

class Program
{
    static void Main(string[] args)
    {
        Job  Job1 = new Job();
        Job1._company = "Microsoft";
        Job1._jobTitle = "Software Engineer";
        Job1._startYear = 2015;
        Job1._endYear = 2019;

        Job1.DisplayJobDetails();
    
        Job  Job2 = new Job();
        Job2._company = "Apple";
        Job2._jobTitle = "Manager";
        Job2._startYear = 2019;
        Job2._endYear = 2024;

        Job2.DisplayJobDetails();
    }
}