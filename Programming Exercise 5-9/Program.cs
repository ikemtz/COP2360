using System;
using System.Linq;
class Sum200
{
    static void Main()
    {
        var w = new Action<string>(Console.WriteLine);
        w(Enumerable.Range(1, 100).Sum().ToString());
        w(Enumerable.Range(1, 200).Sum().ToString());
    }
}