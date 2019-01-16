using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

public class IntegerFacts
{
    public static List<int> arr = new List<int>();

    static void Main()
    {
        var arr2 = new int[10];
        FillArray(arr2);
        Statistics(arr.ToArray(), arr.Count, out int high, out int low, out int sum, out double avg);
        Console.WriteLine($"The array has {arr.Count()} values");
        Console.WriteLine($"The highest value is {high}");
        Console.WriteLine($"The lowest value is {low}");
        Console.WriteLine($"The sum of the values is {sum}");
        Console.WriteLine($"The average is {avg}");
    }

    public static int FillArray(int[] array)
    {
        int i = 0;
        while (i != 999 && arr.Count < 10)
        {
            try
            {
                i = int.Parse(ReadLine());
                if (i != 999)
                {
                    arr.Add(i);
                }
            }
            catch { }
        }
        for (int f = 0; f < arr.Count; f++)
        {
            array[f] = arr[f];
        }
        return arr.Count;
    }

    public static void Statistics(int[] array, int numElements, out int high, out int low, out int sum, out double avg)
    {
        var a = array.Take(numElements);
        high = a.Max();
        low = a.Min();
        sum = a.Sum();
        avg = a.Average();
    }
}