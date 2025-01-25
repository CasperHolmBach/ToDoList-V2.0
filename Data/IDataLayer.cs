using System.Collections.Generic;

public interface IDataLayer
{
    /// <summary>
    /// Saves current tasks in file
    /// </summary>
    void SaveToFile(List<Job> jobList);

    /// <summary>
    /// Get tasks from file
    /// </summary>
    List<Job> LoadFromFile();
}