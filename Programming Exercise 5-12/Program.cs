using System;
using static System.Console;
class WebAddress
{
    static void Main()
    {
        var s = ReadLine();
        var w = "www";
        var c = ".com";
        WriteLine($"www.{s.Replace(" ", "")}.com");
    }
}