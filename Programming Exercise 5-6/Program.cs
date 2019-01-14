using System;
using System.Collections.Generic;
using System.Linq;
class DisplayMultiplicationTable
{
    static void Main()
    {
        var x = Enumerable.Range(1, 10).ToList();
        var p = new Func<int, string>(f => f.ToString().PadLeft(3));
        var j = new Func<char, IEnumerable<string>, string>(string.Join);
        var w = new Action<string>(Console.WriteLine);
        w($"\t{j('\t', x.Select(t => p(t)))}");
        w(new string('-', 85));
        x.ForEach(o => w($"{p(o)}\t{j('\t', x.Select(t => p(t * o)))}"));
    }
}