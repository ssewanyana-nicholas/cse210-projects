using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2021;


        job job2 = new job();
        job2._jobTitle = "Sales Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;


        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}