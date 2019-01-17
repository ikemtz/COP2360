class JobDemo
{
    static void Main()
    {
        // Your code here
    }

}

public class Job
{
    public Job(int jobNumber, string customer, string description, int hours)
    {
        JobNumber = jobNumber;
        Customer = customer;
        Description = description;
        Hours = hours;
    }
    public int JobNumber { get; set; }
    public string Customer { get; set; }
    public string Description { get; set; }
    public int Hours { get; set; }
    public double Price => Hours * 45;
    public override bool Equals(object obj)
    {
        return JobNumber == ((Job)obj).JobNumber;
    }
    public override int GetHashCode()
    {
        return JobNumber;
    }
    public override string ToString()
    {
        return $"Job {JobNumber} {Customer} {Description} {Hours} hours @$45.00 per hour. Total price is {Price.ToString("C")}";
    }
}