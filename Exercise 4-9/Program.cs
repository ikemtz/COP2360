using System;
using static System.Console;
class CheckMonth
{
    static void Main()
    {
        int i = int.Parse(Console.ReadLine());
        if (i < 1 || i > 12)
        {
            WriteLine("Invalid month");
        }
        else
            WriteLine($"{i} is a valid month");
    }
}