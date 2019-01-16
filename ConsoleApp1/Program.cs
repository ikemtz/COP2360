using System;
using static System.Console;
public class InputMethodDemo2
{
    public static void Main()
    {
        int first, second;
        InputMethod(out first, out second);
        WriteLine("After InputMethod first is {0}", first);
        WriteLine("and second is {0}", second);
    }
    private static void InputMethod(out int one, out int two)
    {
        one = DataEntry("first");
        two = DataEntry("second");
    }

    public static int DataEntry(string whichOne)
    {
        Write($"Enter {whichOne} integer ");
        return Convert.ToInt32(ReadLine());
    }

}