using System;
using static System.Console;
class ConvertMilesToKilometers
{
    static void Main()
    {
        var x = int.Parse(ReadLine());
        // Write your main here.
        WriteLine($"{ConvertToKilometers(x)}");
    }
    public static double ConvertToKilometers(double miles)
    {
        return miles * 1.60934;
    }
}