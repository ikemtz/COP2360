using System;
using static System.Console;
public class MarshallsRevenue
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

        month = GetMonth();
        numInterior = GetNumMurals("interior");
        numExterior = GetNumMurals("exterior");
        total = ComputeRevenue(month, numInterior, numExterior);
        WriteLine("Total revenue expected is {0}", total.ToString("C"));
        if (numInterior > numExterior)
            isInteriorGreater = true;
        WriteLine("It is {0} that there are more interior murals scheduled than exterior ones.", isInteriorGreater);
        DataEntry("interior", numInterior, interiorCustomers, muralCodes, muralCodesStrings, interiorCodes, interiorCounts);
        DataEntry("exterior", numExterior, exteriorCustomers, muralCodes, muralCodesStrings, exteriorCodes, exteriorCounts);
        WriteLine("\nThe interior murals scheduled are:");
        for (x = 0; x < interiorCounts.Length; ++x)
            WriteLine("{0, -20}  {1, 5}", muralCodesStrings[x], interiorCounts[x]);
        WriteLine("\nThe exterior murals scheduled are:");
        for (x = 0; x < exteriorCounts.Length; ++x)
            WriteLine("{0, -20}  {1, 5}", muralCodesStrings[x], exteriorCounts[x]);
        GetSelectedMurals(muralCodes, muralCodesStrings, numInterior, numExterior, interiorCustomers, interiorCodes, exteriorCustomers, exteriorCodes);

    }
    public static int GetMonth()
    {
        int month;
        string entryString;
        Write("Enter the month >> "); 
        month = parseInt();
        while (month < 1 || month > 12)
        {
            Write("Invalid month. Enter the month >> "); 
            month = parseInt();
        }
        return month;
    }
    public static int GetNumMurals(string location)
    {
        int num;
        string entryString;
        const int MIN_MURALS = 0;
        const int MAX_MURALS = 30;
        Write("Enter number of {0} murals scheduled >> ", location); 
        num = parseInt();
        while (num < MIN_MURALS || num > MAX_MURALS)
        {
            WriteLine("Number must be between {0} and {1} inclusive", MIN_MURALS, MAX_MURALS);
            Write("Enter number of {0} murals scheduled >> ", location); 
            num = parseInt();
        }
        return num;
    }
    public static int ComputeRevenue(int month, int numInterior, int numExterior)
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
        if (month == 4 || month == 5 || month == 9 || month == 10)
            revenueExterior = numExterior *
            DISCOUNT_EXTERIOR_PRICE;
        else
            revenueExterior = numExterior * EXTERIOR_PRICE;
        if (month == 7 || month == 8)
            revenueInterior = numInterior *
            DISCOUNT_INTERIOR_PRICE;
        else
            revenueInterior = numInterior * INTERIOR_PRICE;
        total = revenueInterior + revenueExterior;
        WriteLine("{0} interior murals are scheduled at {1} each for a total of {2}",
           numInterior, INTERIOR_PRICE.ToString("C"), revenueInterior.ToString("C"));
        WriteLine("{0} exterior murals are scheduled at {1} each for a total of {2}",
           numExterior, EXTERIOR_PRICE.ToString("C"), revenueExterior.ToString("C"));
        return total;
    }
    public static void DataEntry(string location, int num, string[] customers, char[] muralCodes, string[] muralCodesStrings, char[] codes, int[] counts)
    {
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
            codes[x] = parseChar();
            isValid = false;
            while (!isValid)
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
                    codes[x] = parseChar();
                }
            }
            ++x;
        }
    }
    public static void GetSelectedMurals(char[] muralCodes, string[] muralCodesStrings, int numInterior, int numExterior, string[] interiorCustomers, char[] interiorCodes, string[] exteriorCustomers, char[] exteriorCodes)
    {
        char option;
        const char QUIT = 'Z';
        bool isValid;
        bool found;
        int pos = 0;
        int x;
        Write("\nEnter a mural type or {0} to quit >> ", QUIT);
        option = parseChar();
        while (option != QUIT)
        {
            isValid = false;
            for (int z = 0; z < muralCodes.Length; ++z)
            {
                if (option == muralCodes[z])
                {
                    isValid = true;
                    pos = z;
                }
            }
            if (!isValid)
                WriteLine("{0} is not a valid code", option);
            else
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
            }

            Write("\nEnter a mural type or {0} to quit >> ", QUIT);
            option = Convert.ToChar(ReadLine());
        }
    }

    public static int parseInt()
    {
        int i = 0;
        if (!int.TryParse(ReadLine(), out i))
        {
            WriteLine("Wrong format");
            return parseInt();
        }
        return i;
    }

    public static char parseChar()
    {
        char i = ' ';
        if (!char.TryParse(ReadLine(), out i))
        {
            WriteLine("Wrong format");
            return parseChar();
        }
        return i;
    }

}