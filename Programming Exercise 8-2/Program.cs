using System;
using System.Collections.Generic;
using System.Linq;

class Flights
{
    static List<(int, string, string)> list = new List<(int, string, string)>(
        new[] { (633, "HOU", "Houston  Scheduled at: 1140"),
        (510, "DFW" ,"Dallas Fort Worth  Scheduled at: 0915")});
    static void Main()
    {
        var s = Console.ReadLine();
        int i = 0;
        if (int.TryParse(s, out i))
        {
            GetFlightInfo(i, new int[] { }, new string[] { }, new string[] { }, new string[] { });
        }
        else
            GetFlightInfo(s, new int[] { }, new string[] { }, new string[] { }, new string[] { });
    }

    public static string GetFlightInfo(int flight, int[] flightNumbers, string[] codes, string[] names, string[] times)
    {
        var i = list.FirstOrDefault(t => t.Item1 == flight);
        var s = $"Flight #{i.Item1} {i.Item2} {i.Item3}";
        Console.WriteLine(s);
        return s;
    }
    public static string GetFlightInfo(string code, int[] flightNumbers, string[] codes, string[] names, string[] times)
    {
        var i = list.FirstOrDefault(t => t.Item2 == code);
        var s = $"Flight #{i.Item1} {i.Item2} {i.Item3}";
        Console.WriteLine(s);
        return s;
    }

}