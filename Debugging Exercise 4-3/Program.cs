// Program decides tuition based on several criteria:
// 1 - 12 credit hours @ $150 per credit hour
// 13 - 18 credit hours, flat fee $1900
// over 18 hours, $1900 plus $100 per credit hour over 18
// If year in school is 4, there is a 15% discount
using System;
using static System.Console;
class DebugFour3
{
    static void Main()
    {
        int credits, year;
        string inputString;
        double tuition;
        const int LOWCREDITS = 12;
        const int HIGHCREDITS = 18;
        const double HOURFEE = 150;
        const double DISCOUNT = 0.15;
        const double FLAT = 1900.00;
        const double RATE = 100.00;
        const int SENIORYEAR = 4;
        WriteLine("How many credits? ");
        inputString = ReadLine();
        credits = Convert.ToInt32(inputString);
        WriteLine("Year in school? ");
        inputString = ReadLine();
        year = Convert.ToInt32(inputString);
        if (credits <= LOWCREDITS)
            tuition = HOURFEE * credits;
        else
           if (credits < HIGHCREDITS)
            tuition = FLAT;
        else
            tuition = FLAT + (credits - HIGHCREDITS) * RATE;
        if (year == SENIORYEAR)
            tuition = tuition - (tuition * DISCOUNT);
        WriteLine("For year {0}, with {1} credits",
           year, credits);
        WriteLine("Tuition is {0}", tuition.ToString("C"));
    }
}
