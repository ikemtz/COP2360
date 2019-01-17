using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class JobDemo2
{
    static void Main()
    {
        var list = new List<Job>();
        for (int i = 0; i < 5; i++)
        {
            int x = int.Parse(ReadLine());
            while (list.Select(t => t.JobNumber).Contains(x))
            {
                WriteLine("Please reenter");
                x = int.Parse(ReadLine());
            }
            list.Add(new Job(
                x,
                ReadLine(),
                ReadLine(),
              int.Parse(ReadLine())
                ));
        }
        list.ForEach(Console.WriteLine);
    }
}

public class Job : IComparable
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

    public int CompareTo(object obj)
    {
        return JobNumber.CompareTo(((Job)obj).JobNumber);
    }

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