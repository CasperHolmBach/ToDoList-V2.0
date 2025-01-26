using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;

public class Frontend : IFrontendLayer
{
    private readonly ILogicLayer logicLayer;

    public Frontend(ILogicLayer logicLayer)
    {
        this.logicLayer = logicLayer;
    }

    public void ReceiveTaskProperties(string taskName, string taskDescription)
    {
        //Check for null or empty before having logiclayer create job
        if(string.IsNullOrEmpty(taskName))
            throw new ArgumentException("Task name cannot be empty");

        logicLayer.CreateJob(taskName, taskDescription);
    }

    public List<Job> ShowTasks()
    {
        List<Job> currentJobs = logicLayer.GetJobs();
        return currentJobs;
    }
}