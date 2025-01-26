using System.Collections.Generic;

public interface IFrontendLayer
{
    /// <summary>
    /// Show current saved tasks
    /// </summary>
    List<Job> ShowTasks();

    /// <summary>
    /// Sends task name and description strings
    /// </summary>
    void ReceiveTaskProperties(string name, string description);
}
