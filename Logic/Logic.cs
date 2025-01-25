using System;
using System.Collections.Generic;

public class Logic : ILogicLayer
{   
    private readonly IFrontendLayer frontendLayer;
    private readonly IDataLayer dataLayer;
    private List<Job> jobList = new List<Job>();

    public Logic(IFrontendLayer frontendLayer, IDataLayer dataLayer)
    {
        this.frontendLayer = frontendLayer;
        this.dataLayer = dataLayer;
    }

    public void SaveJobs(List<Job> jobList)
    {
        dataLayer.SaveToFile(jobList);
    }

    public void UpdateJobs()
    {
        jobList = dataLayer.LoadFromFile();
    }

    public void AddJob(Job job)
    {
        jobList.Add(job);
    }
}