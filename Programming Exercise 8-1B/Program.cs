using System.Linq;
using static System.Console;
class Reverse4
{
    static void Main()
    {
        var a = 23;
        var b = 45;
        var c = 55;
        var d = 67;
        WriteLine($"{a} {b} {c} {d}");
        Reverse(ref a, ref b, ref c, ref d);
    }

    public static void Reverse(ref int a, ref int b,
       ref int c, ref int d)
    {
        var list = (new[] { a, b, c, d }).OrderByDescending(t => t).ToArray();
        a = list[0];
        b = list[1];
        c = list[2];
        d = list[3];
        WriteLine(string.Join(" ", list));
    }

}