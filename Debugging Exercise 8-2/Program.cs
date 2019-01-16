// Overloaded method gives bonus points
// whether grade is a number or letter
using static System.Console;
public class DebugEight2
{
    public static void Main()
    {
        int numericScore = 82;
        string letterScore = "B";
        Write("Score was {0}. ", numericScore);
        GiveBonus(ref numericScore);
        WriteLine("Now it is {0}.", numericScore);
        Write("Grade was {0}. ", letterScore);
        GiveBonus(ref letterScore);
        WriteLine("Now it is {0}.", letterScore);
    }
    public static void GiveBonus(ref int testScore)
    {
        const int BONUS = 5;
        testScore += BONUS;
    }
    public static void GiveBonus(ref string letterScore)
    {
        const string BONUS = "+";
        letterScore += BONUS;
    }
}