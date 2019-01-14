// Program asks user to enter three integers
// Program displays a message indicating whether the numbers
// are in sequential order,
// in reverse order
// or in neither order
using System;
using static System.Console;
class DebugFour2
{
    static void Main()
    {
        int num1, num2, num3;
        string snum1, snum2, snum3;
        Write("Enter first number ");
        snum1 = ReadLine();
        num1 = Convert.ToInt32(snum1);
        Write("Enter second number ");
        snum2 = ReadLine();
        num2 = Convert.ToInt32(snum2);
        Write("Enter third number ");
        snum3 = ReadLine();
        num3 = Convert.ToInt32(snum3);
        if (num1 < num2 && num2 < num3)
            WriteLine("Numbers are in sequential order");
        else
           if (num1 > num2 && num2 > num3)
            WriteLine("Numbers are in reverse order");
        else
            WriteLine("Numbers are in neither sequential nor reverse order");
    }
}
