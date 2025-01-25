public class Job
{
    public string JobName { get; set; }
    public string JobDescription { get; set; }
    public bool JobDone { get; set; }

    public Job(string jobName, string jobDescription)
    {
        JobName = jobName;
        JobDescription = jobDescription;
        JobDone = false;
    }
}