using System;
using System.Linq;
class DisplayMultiplicationTable
{
    static void Main()
    {
        var i = int.Parse(Console.ReadLine());
        var x = Enumerable.Range(1, 10).ToList();
        var w = new Action<string>(Console.WriteLine);
        x.ForEach(o => w($"{o} x {i} = {o*i}"));
    }
}
