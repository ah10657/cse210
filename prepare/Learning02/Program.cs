using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Lee's Marketplace";
        job1._jobTitle = "Cashier";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Intermountain Healthcare";
        job2._jobTitle = "Medical Assistant - Dermatology";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Job job3 = new Job();
        job3._company = "Intermountain Healthcare";
        job3._jobTitle = "Limited X-ray Tech";
        job3._startYear = 2023;
        job3._endYear = 2024;

        Resume resume = new Resume();

        resume._name = "Austin Hicken";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs.Add(job3);

        resume.Display();
    }
}