using System;
using System.Collections.Generic;
using System.Linq;

class TypingGrades
{
    static void Main()
    {
        // Write your main here

        var list = new List<(int min, int max, char grade)>() {
            {(00, 15, 'F')},
            {(16, 30, 'D')},
            {(31, 50, 'C')},
            {(51, 75, 'B')},
            {(76, int.MaxValue, 'A')}};

        var speed = int.Parse(Console.ReadLine());
        var grade = list.First(t => t.min <= speed && t.max >= speed).grade;
        Console.WriteLine($"Typing {speed} words per minute: Grade {grade}.");
    }
}