using System;
using static System.Console;

namespace Exercise_2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(ReadLine());
            Console.WriteLine($"{(Month)m}");
        }
    }

    public enum Month
    {
        JANUARY = 1,
        FEBRUARY = 2,
        MARCH = 3,
        APRIL = 4,
        MAY = 5,
        JUNE = 6,
        JULY = 7,
        AUGUST = 8,
        SEPTEMBER = 9,
        OCTOBER = 10,
        NOVEMBER = 11,
        DECEMBER = 12
    }
}
