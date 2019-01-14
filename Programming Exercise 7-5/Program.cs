using System;
using static System.Console;
public class FineForOverdueBooks
{
    public static void Main()
    {
        var x = int.Parse(ReadLine());
        var y = int.Parse(ReadLine());
        DisplayFine(x, y);
        // Write your main here.
    }
    public static void DisplayFine(int books, int days)
    {
        double fines = Math.Min(7, days) * .10;
        if (days > 7)
        {
            fines += (days - 7) * .2;
        }
        fines *= books;
        WriteLine($"The fine for {books} book(s) for {days} day(s) is {fines.ToString("C")}");
    }
}