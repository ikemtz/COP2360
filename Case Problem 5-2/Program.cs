using System;
using System.Linq;
using static System.Console;
class MarshallsRevenue
{
    static void Main()
    {

        var filter = new Func<int, int, int>((min, max) =>
        {
            var i = min - 5;
            while (i < min || i > max)
            {
                i = Convert.ToInt32(ReadLine());
                if (i < min || i > max)
                {
                    WriteLine("Invalid");
                }
            }
            return i;
        });

        const int _EXTERIOR_PRICE = 750;
        int INTERIOR_PRICE = 500;
        int EXTERIOR_PRICE = 750;
        int numInterior;
        int numExterior;
        int revenueInterior;
        int revenueExterior;
        int total;
        bool isInteriorGreater;
        int month = filter(1, 12);
        Write("Enter number of interior murals scheduled >> ");
        numInterior = filter(0, 30);
        Write("Enter number of exterior murals scheduled >> ");
        numExterior = filter(0, 30);
        if (new[] { 12,  2 }.Contains(month))
        {
            WriteLine("0 exterior murals are scheduled for a total of $0.00");
        }
        else
        {
            if (new[] { 4, 5, 9, 10 }.Contains(month))
            {
                EXTERIOR_PRICE = 699;
            }
            if (new[] { 7, 8 }.Contains(month))
            {
                INTERIOR_PRICE = 450;
            }
            revenueInterior = numInterior * INTERIOR_PRICE;
            revenueExterior = numExterior * EXTERIOR_PRICE;
            total = revenueInterior + revenueExterior;
            isInteriorGreater = numInterior > numExterior;
            WriteLine("{0} interior murals are scheduled at {1} for a total of {2}",
               numInterior, INTERIOR_PRICE.ToString("C"), revenueInterior.ToString("C"));
            WriteLine("{0} exterior murals are scheduled at {3} for a total of {2}",
               numExterior, EXTERIOR_PRICE.ToString("C"), revenueExterior.ToString("C"), _EXTERIOR_PRICE);
            WriteLine("Total revenue expected is {0}", total.ToString("C"));
            WriteLine("It is {0} that there are more interior murals scheduled than exterior ones.", isInteriorGreater);
        }
    }
}