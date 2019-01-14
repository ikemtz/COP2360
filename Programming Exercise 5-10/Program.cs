using System;
using System.Linq;
class Perfect
{
    static void Main()
    {
        var l = new Action<int>(Console.WriteLine);
        var pn = new Func<int, bool>(i => i == Enumerable.Range(1, i - 1).Where(w => i % w == 0).Sum());
        Enumerable.Range(1, 10000).Where(pn).ToList().ForEach(l);
    }
}