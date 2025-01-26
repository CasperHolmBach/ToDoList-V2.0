using System;
using System.Collections.Generic;

public class Logic : ILogicLayer
{   
    private readonly IDataLayer dataLayer;
    private List<Job> jobList = new List<Job>();

    public Logic(IDataLayer dataLayer)
    {
        this.dataLayer = dataLayer;
    }

    public List<Job> GetJobs()
    {
        return jobList;
    }

    public void CreateJob(string name, string description)
    {
        Job job = new Job(name, description);
        jobList.Add(job);

        Console.WriteLine("Current created Tasks: ");
        foreach(Job _job in jobList)
        {
            Console.WriteLine(_job.JobName);
        }
    }
    public void SaveJobs(List<Job> jobList)
    {
        dataLayer.SaveToFile(jobList);
    }

    public void UpdateJobs()
    {
        jobList = dataLayer.LoadFromFile();
    }

    
}