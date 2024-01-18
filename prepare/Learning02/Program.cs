using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();
        Job job1 = new Job();
        Job job2 = new Job();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._name = "Irina Groza";
        

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engeneer";
        job1._startYear = 2023;
        job1._endYear = 2024;

        
        job2._company = "Yandex";
        job2._jobTitle = "Engeneer";
        job2._startYear = 2022;
        job2._endYear = 2023;  
        
        resume.DisplayResume();
    }   
}   
