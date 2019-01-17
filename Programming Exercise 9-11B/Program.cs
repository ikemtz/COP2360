using System;
using static System.Console;
class RelativesList
{
    static void Main()
    {
        // Write your main here
    }
}

public class Relative: IComparable
{
    public string Name { get; set; }
    public string Relationship { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
    public int Year { get; set; }

    public int CompareTo(object obj)
    {
        return Name.CompareTo(((Relative)obj).Name);

    }
}