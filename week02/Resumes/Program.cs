using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2010;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Yahoo";
        job2._startYear = 1999;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

        
    }
}