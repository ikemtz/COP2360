using System.Collections.Generic;
using static System.Console;
class ChatAWhile
{
    static void Main()
    {
        var dic = new Dictionary<string, double>() {
            {"262", 0.07},
            {"414", 0.10},
            {"608", 0.05},
            {"715", 0.16},
            {"815", 0.24},
            {"920", 0.14 }};

        var code = ReadLine();
        if (dic.ContainsKey(code))
        {
            var mins = int.Parse(ReadLine());
            WriteLine($"Your phone call to area {code} costs {dic[code].ToString("C")} per minute. For {mins} minutes the total is {(mins * dic[code]).ToString()}");
        }
        else
            WriteLine($"Sorry - no calls allowed to area {code}");
    }
}