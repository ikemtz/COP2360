using System;
using static System.Console;
class SumInts
{
    static void Main()
    {
        var n = 0;
        var i = 0;
        // Write your main here
        while (i != 999)
        {
            n += i = int.Parse(Console.ReadLine());
        }
        WriteLine($"{n-999 }");
    }
}