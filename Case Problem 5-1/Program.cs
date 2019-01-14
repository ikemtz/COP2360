
using System;
using static System.Console;
class GreenvilleRevenue
{
    static void Main()
    {
        var g = new Func<int>(() =>
        {
            int i = -1;
            while (i < 0 || i > 30)
            {
                i = Convert.ToInt32(ReadLine());
            }
            return i;
        });
        const int ENTRANCE_FEE = 25;
        int numThisYear;
        int numLastYear;
        int revenue;
        bool isThisYearGreater;
        Write("Enter number of contestants last year >> ");
        numLastYear = g();
        Write("Enter number of contestants this year >> ");
        numThisYear = g();
        revenue = numThisYear * ENTRANCE_FEE;
        isThisYearGreater = numThisYear > numLastYear;
        WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants",
           numLastYear, numThisYear);
        WriteLine("Revenue expected this year is {0}", revenue.ToString("C"));
        WriteLine("It is {0} that this year's competition is bigger than last year's.", isThisYearGreater);
        if (numLastYear * 2 < numThisYear)
        {
            WriteLine("The competition is more than twice as big this year!");
        }
        else if (isThisYearGreater)
        {
            WriteLine("The competition is bigger than ever!");
        }
        else
        {
            WriteLine("A tighter race this year! Come out and cast your vote!");

        }
        WriteLine("30");
    }
}