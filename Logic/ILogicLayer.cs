using System.Collections.Generic;

public interface ILogicLayer
{
    /// <summary>
    /// Saves current tasks
    /// </summary>
    void SaveJobs(List<Job> jobList);

    /// <summary>
    /// Updates tasks shown on frontend
    /// </summary>
    void UpdateJobs();
}