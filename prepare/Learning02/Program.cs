using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Teacher";
        job1._company = "Shasta High School";
        job1._startYear = 2015;
        job1._endYear = 2017;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Netflix";
        job2._startYear = 2017;
        job2._endYear = 2024;

        Resume resume1 = new Resume();
        resume1._name = "Grant Skoy";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}