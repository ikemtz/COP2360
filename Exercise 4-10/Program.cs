using System;
using static System.Console;
class CheckMonth2
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        try
        {
            var date = new DateTime(2016, m, d);
            WriteLine($"{m}/{d} is a valid birthday");
        }
        catch (Exception)
        {
            WriteLine("Invalid date");
        }
    }
}
