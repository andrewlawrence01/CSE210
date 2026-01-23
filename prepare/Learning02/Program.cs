using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Delivery Driver";
        job1._company = "Domino's Pizza";
        job1._startYear = 2025;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Front End Developer";
        job2._company = "Epic";
        job2._startYear = 2026;
        job2._endYear = 2066;

        Resume myResume = new Resume();
        myResume._name = "Andrew Lawrence";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}