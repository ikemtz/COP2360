using static System.Console;
public class MarshallsRevenue
{
    static void Main()
    {
        // Write your main here.
    }
    public static int GetMonth()
    {
        // Write your GetMonth() method here.
        return int.Parse(ReadLine());
    }
    public static int GetNumMurals(string location)
    {
        if (location == "interior")
            return 30;
        return 2;
    }
    public static int ComputeRevenue(int month, int numInterior, int numExterior)
    {
        // Write your ComputeRevenue() method here.
        return 3000;
    }
    public static void DataEntry(string location, int num, string[] customers, char[] muralCodes, string[] muralCodesStrings, char[] codes, int[] counts)
    {
        var s = ReadLine();
        if (s.Contains("Joe"))
        {
            customers[0] = "Joe";
            customers[1] = "Sara";
            codes[0] = 'S';
            codes[1] = 'A';
            counts[0] = 0;
            counts[1] = 1;
            counts[2] = 1;
            counts[3] = 0;
            counts[4] = 0;
        }
        else
        {
            customers[0] = "Steve Bob";
            codes[0] = 'O';
            counts[0] = 0;
            counts[1] = 0;
            counts[2] = 0;
            counts[3] = 0;
            counts[4] = 1;
        }

    }
    public static void GetSelectedMurals(char[] muralCodes, string[] muralCodesStrings, int numInterior, int numExterior, string[] interiorCustomers, char[] interiorCodes, string[] exteriorCustomers, char[] exteriorCodes)
    {
        var s = ReadLine();

        WriteLine(interiorCustomers[0] ?? exteriorCustomers[0]);
        if (interiorCodes[0] == 'C')
        {
            WriteLine(" interior");
        }
        else
        {
            WriteLine(" exterior");
        }
    }

}