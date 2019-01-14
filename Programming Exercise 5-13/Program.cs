using System;
using System.Linq;
using static System.Console;
class CountVowels
{
    static void Main()
    {
        var s = ReadLine();
        var v = new[] { 'a', 'e', 'i', 'o', 'u' };
        WriteLine(s.ToLower().Count(c => v.Contains(c)));
    }
}