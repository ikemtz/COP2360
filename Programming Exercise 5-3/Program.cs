using System;
using System.Linq;
using static System.Console;
class EnterUppercaseLetters
{
    static void Main()
    {
        char c;
        while ('!' != (c = Console.ReadLine().First()))
            if (!Char.IsUpper(c))
                WriteLine("Sorry - that was not an uppercase letter");
           else
                WriteLine("OK");
    }
}