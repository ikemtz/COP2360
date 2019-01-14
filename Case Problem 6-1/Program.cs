using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class GreenvilleRevenue
{
    static void Main()
    {
        ReadLine();
        var i = int.Parse(ReadLine());
        var talents = new Dictionary<string, string> {
            { "S", "Singing" },
            { "D","Dancing" },
            { "M","Musical instrument" },
            { "O", "Other" }};
        var dic = new Dictionary<string, List<string>>();
        talents.Keys.ToList().ForEach(t => dic.Add(t, new List<string>()));
        Func<string> getTalent = () =>
        {
            var val = "";
            var uval = "";
            while (!talents.Keys.Contains(val) && val != "Z")
            {
                val = ReadLine();
                uval = val.ToUpper();
                if (!talents.Keys.Contains(uval) && uval != "Z")
                {
                    WriteLine($"{val} is not a valid code");
                }
            }
            return uval;
        };
        for (var c = 0; c < i; c++)
        {
            var name = ReadLine();
            var tal = getTalent();
            dic[tal].Add(name);
        }

        WriteLine("The types of talent are:");

        dic.ToList().ForEach(t =>

        WriteLine($"{talents[t.Key]}\t\t {t.Value.Count}")
        );

        var talent = "";
        while (true)
        {
            talent = getTalent();
            if (talent == "Z")
                break;
            WriteLine($"Contestants with talent {talents[talent]} are:");
            WriteLine($"{string.Join(" ", dic[talent])}");
        }
    }
}