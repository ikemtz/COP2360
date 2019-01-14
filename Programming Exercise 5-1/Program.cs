using System;
using static System.Console;
class SumFiveints
{
    static void Main()
    {
        var n = 0;
        // Write your main here
        for (var i = 0; i < 5; i++)
            n += int.Parse(Console.ReadLine());
        WriteLine($"{n }");
    }
}
