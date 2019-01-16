using static System.Console;
public class GreenvilleRevenue
{
    public static void Main()
    {
        const int ENTRANCE_FEE = 25;
        const int MIN_CONTESTANTS = 0;
        const int MAX_CONTESTANTS = 30;
        int numThisYear;
        int numLastYear;
        int revenue;
        string[] names = new string[MAX_CONTESTANTS];
        char[] talents = new char[MAX_CONTESTANTS];
        char[] talentCodes = { 'S', 'D', 'M', 'O' };
        string[] talentCodesStrings = { "Singing", "Dancing", "Musical instrument", "Other" };
        int[] counts = { 0, 0, 0, 0 }; ;
        numLastYear = getContestantNumber("last", MIN_CONTESTANTS, MAX_CONTESTANTS);
        numThisYear = getContestantNumber("this", MIN_CONTESTANTS, MAX_CONTESTANTS);
        revenue = numThisYear * ENTRANCE_FEE;
        WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants",
           numLastYear, numThisYear);
        WriteLine("Revenue expected this year is {0}", revenue.ToString("C"));
        DisplayRelationship(numThisYear, numLastYear);
        getContestantData(numThisYear, names, talents, talentCodes, talentCodesStrings, counts);
        getLists(numThisYear, talentCodes, talentCodesStrings, names, talents, counts);
    }
    public static int getContestantNumber(string when, int min, int max)
    {
        int num;
        Write("Enter number of contestants {0} year >> ", when);

        num = parseInt();
        while (num < min || num > max)
        {
            WriteLine("Number must be between {0} and {1}", min, max);
            Write("Enter number of contestants {0} year >> ", when);

            num = parseInt();
        }
        return num;
    }
    public static void DisplayRelationship(int numThisYear, int numLastYear)
    {
        if (numThisYear > 2 * numLastYear)
            WriteLine("The competition is more than twice as big this year!");
        else
           if (numThisYear > numLastYear)
            WriteLine("The competition is bigger than ever!");
        else
              if (numThisYear < numLastYear)
            WriteLine("A tighter race this year! Come out and cast your vote!");
    }
    public static void getContestantData(int numThisYear, string[] names, char[] talents, char[] talentCodes, string[] talentCodesStrings, int[] counts)
    {
        int x = 0;
        bool isValid;
        while (x < numThisYear)
        {
            Write("Enter contestant name >> ");
            names[x] = ReadLine();
            WriteLine("Talent codes are:");
            for (int y = 0; y < talentCodes.Length; ++y)
                WriteLine("  {0}   {1}", talentCodes[y], talentCodesStrings[y]);
            Write("       Enter talent code >> ");
            talents[x] = parseChar();
            isValid = false;
            while (!isValid)
            {
                for (int z = 0; z < talentCodes.Length; ++z)
                {
                    if (talents[x] == talentCodes[z])
                    {
                        isValid = true;
                        ++counts[z];
                    }
                }
                if (!isValid)
                {
                    WriteLine("{0} is not a valid code", talents[x]);
                    Write("       Enter talent code >> ");
                    talents[x] = parseChar();
                }
            }
            ++x;
        }
    }
    public static void getLists(int numThisYear, char[] talentCodes, string[] talentCodesStrings, string[] names, char[] talents, int[] counts)
    {
        int x;
        char QUIT = 'Z';
        char option;
        bool isValid;
        int pos = 0;
        bool found;
        WriteLine("\nThe types of talent are:");
        for (x = 0; x < counts.Length; ++x)
            WriteLine("{0, -20}  {1, 5}", talentCodesStrings[x], counts[x]);
        Write("\nEnter a talent type or {0} to quit >> ", QUIT);
        option = parseChar();
        while (option != QUIT)
        {
            isValid = false;
            for (int z = 0; z < talentCodes.Length; ++z)
            {
                if (option == talentCodes[z])
                {
                    isValid = true;
                    pos = z;
                }
            }
            if (!isValid)
                WriteLine("{0} is not a valid code", option);
            else
            {
                WriteLine("\nContestants with talent {0} are:", talentCodesStrings[pos]);
                found = false;
                for (x = 0; x < numThisYear; ++x)
                {
                    if (talents[x] == option)
                    {
                        WriteLine(names[x]);
                        found = true;
                    }
                }
                if (!found)
                    WriteLine("No contestants had talent {0}", talentCodesStrings[pos]);
            }

            Write("\nEnter a talent type or {0} to quit >> ", QUIT);
            option = parseChar();
        }
    }
    public static int parseInt()
    {
        int i = 0;
        if (!int.TryParse(ReadLine(), out i))
        {
            WriteLine("Invalid");
            return parseInt();
        }
        return i;
    }

    public static char parseChar()
    {
        char i = ' ';
        if (!char.TryParse(ReadLine(), out i))
        {
            WriteLine("Invalid");
            return parseChar();
        }
        return i;
    }

}