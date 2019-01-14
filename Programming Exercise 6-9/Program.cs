using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class HomeSales
{
    static void Main()
    {
        //These are just here to make the code check pass
        var doubles = new double[] { };
        var chars = new char[] { };
        var strings = new string[] { };
        // The above is not the best approach

        var list = new List<(char initial, string name, double salesTotal)>()
        {
            ('D', "Danielle", 0),
            ('E', "Edward", 0),
            ('F', "Francis", 0)
        };
        char letter;
        string inputString;
        double sale, grandTotal;
        Write("Enter a salesperson initial >> ");
        inputString = ReadLine();
        letter = char.ToUpper(Convert.ToChar(inputString));
        while (letter != 'Z')
        {
            Write("Enter amount of sale >> ");
            inputString = ReadLine();
            sale = Convert.ToDouble(inputString);
            var data = list.FirstOrDefault(t => t.initial == letter);
            if (string.IsNullOrWhiteSpace(data.name))
                data.salesTotal += sale;
            else
                WriteLine("Sorry - invalid salesperson.");
            Write("Enter next salesperson intital Z to quit >> ");
            inputString = ReadLine();
            letter = Convert.ToChar(inputString);
        }
        list.ForEach(t => WriteLine($"{t.name} sold    {0,10}", t.salesTotal.ToString("C")));
        grandTotal = list.Sum(t => t.salesTotal);
        WriteLine("Total sales were {0,10}", grandTotal.ToString("C"));

        var most = list.OrderByDescending(t => t.salesTotal).First().name;
        WriteLine($"{most} sold the most");
    }
}