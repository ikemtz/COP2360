using System;
using System.Linq;
using static System.Console;
class MarshallsRevenue
{
    static void Main()
    {
        const int MAX_MURALS = 30;
        int month;
        int numInterior;
        int numExterior;
        int total;
        string[] interiorCustomers = new string[MAX_MURALS];
        string[] exteriorCustomers = new string[MAX_MURALS];
        char[] muralCodes = { 'L', 'S', 'A', 'C', 'O' };
        string[] muralCodesStrings = {"Landscape", "Seascape",
         "Abstract", "Children's", "Other"};
        char[] interiorCodes = new char[MAX_MURALS];
        char[] exteriorCodes = new char[MAX_MURALS];
        int x;
        bool isInteriorGreater = false;
        int[] interiorCounts = { 0, 0, 0, 0, 0 };
        int[] exteriorCounts = { 0, 0, 0, 0, 0 };

        month = getMonth();
        numInterior = getNumMurals("interior");
        numExterior = getNumMurals("exterior");
        total = computeRevenue(month, numInterior, numExterior);
        WriteLine("Total revenue expected is {0}", (total -1).ToString("C"));
        if (numInterior > numExterior)
            isInteriorGreater = true;
        WriteLine("It is {0} that there are more interior murals scheduled than exterior ones.", isInteriorGreater);
        dataEntry("interior", numInterior, interiorCustomers, muralCodes, muralCodesStrings, interiorCodes, interiorCounts);
        dataEntry("exterior", numExterior, exteriorCustomers, muralCodes, muralCodesStrings, exteriorCodes, exteriorCounts);
        WriteLine("\nThe interior murals scheduled are:");
        for (x = 0; x < interiorCounts.Length; ++x)
            WriteLine("{0, -20}  {1, 5}", muralCodesStrings[x], interiorCounts[x]);
        WriteLine("\nThe exterior murals scheduled are:");
        for (x = 0; x < exteriorCounts.Length; ++x)
            WriteLine("{0, -20}  {1, 5}", muralCodesStrings[x], exteriorCounts[x]);
        getSelectedMurals(muralCodes, muralCodesStrings, numInterior, numExterior, interiorCustomers, interiorCodes, exteriorCustomers, exteriorCodes);

    }
    private static int getMonth()
    {
        int month = 0;
        string entryString;
        bool isValid = false;
        Write("Enter the month >> ");
        entryString = ReadLine();
        while (!isValid)
        {
            if (int.TryParse(entryString, out month))
                if (month < 1 || month > 12)
                {
                    Write("Invalid month. Enter the month >> ");
                    entryString = ReadLine();
                }
                else
                    isValid = true;
            else
            {
                Write("Wrong format. Enter the month >> ");
                entryString = ReadLine();
            }
        }
        return month;
    }
    private static int getNumMurals(string location)
    {
        int num = 0;
        string entryString;
        bool isValid = false;
        const int MIN_MURALS = 0;
        const int MAX_MURALS = 30;
        Write("Enter number of {0} murals scheduled >> ", location);
        entryString = ReadLine();
        while (!isValid)
        {
            if (int.TryParse(entryString, out num))
                if (num < MIN_MURALS || num > MAX_MURALS)
                {
                    WriteLine("Number must be between {0} and {1} inclusive", MIN_MURALS, MAX_MURALS);
                    Write("Enter number of {0} murals scheduled >> ", location);
                    entryString = ReadLine();
                }
                else
                    isValid = true;
            else
            {
                WriteLine("Wrong format");
                Write("Enter number of {0} murals scheduled >> ", location);
                entryString = ReadLine();
            }
        }
        return num;
    }
    private static int computeRevenue(int month, int numInterior, int numExterior)
    {
        int revenueInterior;
        int revenueExterior;
        int total;
        const int INTERIOR_PRICE = 500;
        const int EXTERIOR_PRICE = 750;
        const int DISCOUNT_INTERIOR_PRICE = 450;
        const int DISCOUNT_EXTERIOR_PRICE = 699;
        if (month == 12 || month == 1 || month == 2)
            numExterior = 0;
        if (month == 4 || month == 5 || month == 9 || month == 1)
            revenueInterior = numInterior *
            DISCOUNT_INTERIOR_PRICE;
        else
            revenueInterior = numInterior * INTERIOR_PRICE;
        if (month == 7 || month == 8)
            revenueExterior = numExterior *
            DISCOUNT_EXTERIOR_PRICE;
        else
            revenueExterior = numExterior * EXTERIOR_PRICE;
        total = revenueInterior + revenueExterior;
        WriteLine("{0} interior murals are scheuled at {1} each for a total of {2}",
           numInterior, INTERIOR_PRICE.ToString("C"), revenueInterior.ToString("C"));
        WriteLine("{0} exterior murals are scheuled at {1} each for a total of {2}",
           numExterior, EXTERIOR_PRICE.ToString("C"), revenueExterior.ToString("C"));
        return total;
    }
    private static void dataEntry(string location, int num, string[] customers, char[] muralCodes, string[] muralCodesStrings, char[] codes, int[] counts)
    {
        string entryString;
        bool isValid;
        int x;
        WriteLine("\n\nEntering {0} jobs:", location);
        x = 0;
        while (x < num)
        {
            Write("Enter customer name >> ");
            customers[x] = ReadLine();
            WriteLine("Mural options are:");
            for (int y = 0; y < muralCodes.Length; ++y)
                WriteLine("  {0}   {1}", muralCodes[y], muralCodesStrings[y]);
            Write("       Enter mural style code >> ");
            entryString = ReadLine();
            isValid = false;
            while (!isValid)
            {
                if (char.TryParse(entryString, out codes[x]))
                {
                    for (int z = 0; z < muralCodes.Length; ++z)
                    {
                        if (codes[x] == muralCodes[z])
                        {
                            isValid = true;
                            ++counts[z];
                        }
                    }
                    if (!isValid)
                    {
                        WriteLine("{0} is not a valid code", codes[x]);
                        Write("       Enter mural style code >> ");
                        entryString = ReadLine();
                    }
                }
                else
                {
                    WriteLine("Wrong format");
                    Write("       Enter mural style code >> ");
                    entryString = ReadLine();
                }
            }
            ++x;
        }
    }
    private static void getSelectedMurals(char[] muralCodes, string[] muralCodesStrings, int numInterior, int numExterior, string[] interiorCustomers, char[] interiorCodes, string[] exteriorCustomers, char[] exteriorCodes)
    {
        char option;
        const char QUIT = 'Z';
        bool isValid = false;
        bool found;
        int pos = 0;
        int x;
        string entryString;
        Write("\nEnter a mural type or {0} to quit >> ", QUIT);
        entryString = ReadLine();
        while (!isValid)
        {
            if (char.TryParse(entryString, out option))
            {
                if (option == QUIT)
                    isValid = true;
                else
                    for (int z = 0; z < muralCodes.Length; ++z)
                    {
                        if (option == muralCodes[z])
                        {
                            isValid = true;
                            pos = z;
                        }
                    }
                if (!isValid)
                {
                    WriteLine("{0} is not a valid code", option);
                    Write("\nEnter a mural type or {0} to quit >> ", QUIT);
                    entryString = ReadLine();
                }
            }
            else
            {
                WriteLine("Wrong format");
                Write("\nEnter a mural type or {0} to quit >> ", QUIT);
                entryString = ReadLine();
            }
            if (isValid && option != QUIT)
            {
                WriteLine("\nCustomers ordering {0} murals are:", muralCodesStrings[pos]);
                found = false;
                for (x = 0; x < numInterior; ++x)
                {
                    if (interiorCodes[x] == option)
                    {
                        WriteLine("{0} Interior", interiorCustomers[x]);
                        found = true;
                    }
                }
                for (x = 0; x < numExterior; ++x)
                {
                    if (exteriorCodes[x] == option)
                    {
                        WriteLine("{0} Exterior", exteriorCustomers[x]);
                        found = true;
                    }
                }
                if (!found)
                    WriteLine("No customers ordered {0} murals", muralCodesStrings[pos]);
                Write("\nEnter a mural type or {0} to quit >> ", QUIT);
                entryString = ReadLine();
                isValid = false;
            }
        }
    }
}

public class Mural
{
    public readonly static char[] muralCodes = { 'L', 'S', 'A', 'C', 'O' };
    public readonly static string[] muralTypes =
    {"Landscape", "Seascape",
         "Abstract", "Children's", "Other"};
    public string Name { get; set; }
    public string MuralType { get; set; }
    char code;
    public char Code
    {
        get
        {
            return code;
        }
        set
        {
            if (muralCodes.Contains(value))
            {
                code = value;
                MuralType = muralTypes[Array.IndexOf(muralCodes, value)];

            }
            else code = 'I';
        }
    }
}