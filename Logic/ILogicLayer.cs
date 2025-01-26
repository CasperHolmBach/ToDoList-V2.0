using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Metadata;

public interface ILogicLayer
{   
    /// <summary>
    /// Get tasks from jobList
    /// </summary>
    List<Job> GetJobs();

    /// <summary>
    /// Creates job with name and description sent from user
    /// </summary>
    void CreateJob(string name, string description);

    /// <summary>
    /// Saves current tasks
    /// </summary>
    void SaveJobs(List<Job> jobList);

    /// <summary>
    /// Updates tasks shown on frontend
    /// </summary>
    void UpdateJobs();
}