using System;
using System.Collections.Generic;

// Job class
public class Job
{
    // Member variables
    private string _company;
    private string _jobTitle;
    private int _startYear;
    private int _endYear;

    // Constructor
    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Method to display job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

// Resume class
public class Resume
{
    // Member variables
    private string _personName;
    private List<Job> _jobs;

    // Constructor
    public Resume(string personName)
    {
        _personName = personName;
        _jobs = new List<Job>();
    }

    // Method to add a job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Method to display resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create job instances
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        // Display job details
        Console.WriteLine("Sample Output");
        job1.Display();
        job2.Display();

        // Create resume instance
        Resume myResume = new Resume("Allison Rose");

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display resume details
        myResume.Display();
    }
}
