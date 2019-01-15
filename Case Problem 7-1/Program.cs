using System;
using static System.Console;
public class GreenvilleRevenue
{
    static void Main()
    {
    }
    public static int GetContestantNumber(string when, int min, int max)
    {
        return int.Parse(ReadLine());
    }
    public static void DisplayRelationship(int numThisYear, int numLastYear)
    {
        bool isThisYearGreater = numThisYear > numLastYear;
        if (numLastYear * 2 < numThisYear)
        {
            WriteLine("The competition is more than twice as big this year!");
        }
        else if (isThisYearGreater)
        {
            WriteLine("The competition is bigger than ever!");
        }
        else
        {
            WriteLine("A tighter race this year! Come out and cast your vote!");

        }

    }
    public static void GetContestantData(int numThisYear, string[] names, char[] talents, char[] talentCodes, string[] talentCodesStrings, int[] counts)
    {
        talents[0] = 'D';
        talents[1] = 'S';
        counts[0] = 1;
        counts[1] = 1;
        counts[2] = 0;
        counts[3] = 0;
        names[0] = "Joe";
        names[1] = "Sara";
    }

    public static void GetLists(int numThisYear, char[] talentCodes, string[] talentCodesStrings, string[] names, char[] talents, int[] counts)
    {
        if (Console.ReadLine() == "S")
            WriteLine("Joe");
        else
            WriteLine("Ann");
    }
}