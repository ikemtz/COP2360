using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class ResortPrices
{
    static void Main()
    {
        var list = new List<(int min, int max, int rate)>() {
            {(1, 2, 200)},
            {(3, 4, 180)},
            {(5, 7, 160)},
            {(8, int.MaxValue, 145)}};

        var nights = int.Parse(Console.ReadLine());
        var rate = list.First(t => t.min <= nights && t.max >= nights).rate;

        WriteLine($"Price per night is {rate.ToString("C")}");
        WriteLine($"Total for {nights} night(s) is {(rate * nights).ToString("C")}");
    }
}