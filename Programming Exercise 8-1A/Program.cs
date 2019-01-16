using System.Collections.Generic;
using System.Linq;
using static System.Console;
class Reverse3
{
    static void Main()
    {
        var firstInt = 23;
        var middleInt = 45;
        var lastInt = 67;
        WriteLine($"{firstInt} {middleInt} {lastInt}");
        Reverse(ref firstInt, ref middleInt, ref lastInt);
    }

    public static void Reverse(ref int a, ref int b, ref int c)
    {
        var list = new []{ a, b, c };
        a = list.Max();
        c = list.Min();
        WriteLine($"{a} {b} {c}");
    }

}
