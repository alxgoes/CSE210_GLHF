using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Enginner";
        job1._company = "IBM";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Dell";
        job2._startYear = 2025;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Alex Goes";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}