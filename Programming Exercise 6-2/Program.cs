using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class TestScoreList
{
    static void Main()
    {
        var list = new List<int>();
        for (int i = 0; i < 8; i++)
        { 
                list.Add(int.Parse(ReadLine()));
        
        }
        var avg = list.Average();
        for (int i = 0; i < 8; i++)
        {
            WriteLine($"Test # {i}: {list[i]} From average: {list[i] - avg} ");
        }

    }
}