using System.Linq;
using static System.Console;
public class FlexibleArrayMethod
{
    static void Main()
    {
        DisplayAndSum(new[] { 5, 6 });


        DisplayAndSum(new[] { 0, 1, 2, 3, });
        DisplayAndSum(new[] { 7, 8, 9 });
    }
    public static void DisplayAndSum(int[] arr)
    {
        //  Write your DisplayAndSum method here.
        arr.ToList().ForEach(WriteLine);
        WriteLine(arr.Sum());
    }
}