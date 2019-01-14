using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming_Exercise_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<char, double>();
            char c;
            while ('z' != (c = Console.ReadLine().ToLower().First()))
            {
                var temp = double.Parse(Console.ReadLine());
                if (dic.ContainsKey(c))
                {
                    dic[c] += temp;
                }
                else
                    dic.Add(c, temp);
            }

            foreach (var d in dic.OrderBy(t => t.Key))
            {
                Console.WriteLine($"{d.Value.ToString("C")}");
            }

            Console.WriteLine($"{dic.Sum(t => t.Value).ToString("C")}");
            Console.WriteLine($"{dic.Max(t => t.Value).ToString("C")}");

        }
    }
}
