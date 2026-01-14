using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2020";
        job1._endYear = "2025";

    
        Job job2 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Administrator";
        job1._startYear = "2018";
        job1._endYear = "2023";

        Resume myResume = new Resume();
        myResume._name = "Logan Davis";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}