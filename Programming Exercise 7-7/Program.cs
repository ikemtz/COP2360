using System;
using static System.Console;
class Hurricane
{
    static void Main()
    {
        Write("Enter speed >> ");
        var speed = int.Parse(ReadLine()); 
        if (speed < 74)
        {
            WriteLine("This is not a hurricane");
            return;
        }
        
        WriteLine($"This is a category {GetCategory(speed)} hurricane");
    }
    public static int GetCategory(int wind)
    {
        int cat = 0;
        if (wind < 96)
            cat = 1;
        else if (wind < 111)
            cat = 2;
        else if (wind < 130)
            cat = 3;
        else if (wind < 157)
            cat = 4;
        else
            cat = 5;
        return cat;
    }
}