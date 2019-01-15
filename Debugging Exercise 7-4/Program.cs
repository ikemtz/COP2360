// Program calls a method that finds and returns
// the median value in an array
// The median value is the middle value from largest to smallest
// If there are an even number of values, the
// median is the mean of the two middle values
using System;
using static System.Console;
class DebugSeven4
{
    static void Main()
    {
        int[] firstArray = { 10, 9, 2, 3, 5, 6 };
        int[] secondArray = { 112, 456, 782 };
        int[] thirdArray = { 9, 12, 45, 82, 84, 67, 2, 6 };
        WriteLine("The median value of the first array is {0}",
           FindMedian(firstArray));
        WriteLine("The median value of the second array is {0}",
           FindMedian(secondArray));
        WriteLine("The median value of the third array is {0}",
           FindMedian(thirdArray));
    }
    private static double FindMedian(int[] array)
    {
        double median;
        int middle = array.Length / 2;
        Array.Sort(array);
        if (array.Length % 2 == 0)
            median = (double)(array[middle - 1] + array[middle]) / 2;
        else
            median = array[middle];
        return median;
    }
}