// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class DebugSix04
{
    public static void Main()
    {
        const int QUIT = 999;
        var numbers = new List<int>() { };
        int x = 20;
        int num;
        string inString;
        Console.Write("Please enter a number or " +
           QUIT + " to quit...");
        inString = ReadLine();
        num = Convert.ToInt32(inString);
        while ((x > numbers.Count) && num != QUIT)
        {
            numbers.Add(num);
            Write("Please enter a number or " +
               QUIT + " to quit...");
            inString = ReadLine();
            num = Convert.ToInt32(inString);
        }
        WriteLine("The numbers are:");
        numbers.ForEach(f=> 
            Console.Write("{0,6}", f));
        
        WriteLine();
        WriteLine("The average is {0}", numbers.Average());
    }
}