using System;
using static System.Console;
class Admission
{
    static void Main()
    {
        Write("High school GPA >> ");
        var gpa = double.Parse(ReadLine());
        Write("Test score >> ");
        var score = double.Parse(ReadLine());
        var accepted = (gpa >= 3 && score >= 60) ||
            (gpa < 3 && score >= 80);
        WriteLine(accepted ? "Accept" : "Reject");
    }
}