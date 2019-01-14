using System.Collections.Generic;
using System.Linq;
using static System.Console;
class TemperaturesComparison
{
    static void Main()
    {
        var list = new List<int>();
        while (list.Count < 5)
        {
            var t = int.Parse(ReadLine());
            if (t < -30 && t > 130)
                continue;
            else if (list.Count == 3)
            {
                if (t > list.Max())
                    WriteLine("Getting warmer");
                else if (t < list.Min())
                    WriteLine("Getting cooler");
                else
                    WriteLine("It's a mixed bag");
            }
            list.Add(t);
        }

        WriteLine(string.Join(" ", list));
        WriteLine(list.Average());
    }
}