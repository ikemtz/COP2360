using System;
using static System.Console;
class DailyTemps
{
    static void Main()
    {
        int count = 0;
        double tempTemp;
        double totalTemp = 0;
        while (999 != (tempTemp = double.Parse(Console.ReadLine())))
            if (tempTemp > -20 && tempTemp < 130)
            {
                totalTemp += tempTemp; count++;
            }
            else
                WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
        WriteLine($"{count} {totalTemp / count}");
    }
}
