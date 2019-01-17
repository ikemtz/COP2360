class DemoJobs
{
    static void Main()
    {
        // Write your main here.
    }
}

public class Job
{
    public string Description { get; set; }
    public double Time { get; set; }
    public double Hourly { get; set; }
    public double TotalFee => Time * Hourly;

    public static Job operator +(Job a, Job b)
    {
        return new Job
        {
            Description = $"{a.Description} and {b.Description}",
            Time = a.Time + b.Time,
            Hourly = a.Hourly + b.Hourly,
        };
    }
}