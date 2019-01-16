using System.Linq;
using static System.Console;
public class Averages
{
    public static void Main()
    {
        // Write your main here
        Average(22.3, 44.5, 88.1);
    }

    public static void Average(params double[] nums)
    { 
        WriteLine($"{string.Join(" ", nums)}  -- Average is {nums.Average()}");
    }
}