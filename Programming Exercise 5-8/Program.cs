using System;
using System.Linq;
class OddNums
{
    static void Main()
    {
        var w = new Action<string>(Console.WriteLine);
        Enumerable.Range(1, 100).Where(t => t % 2 == 1).ToList().ForEach(t => w($"{t}"));
    }

}