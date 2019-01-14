// Program takes a hot dog order
// And determines price
using System;
using static System.Console;
class DebugFour1
{
    static void Main()
    {
        const double BASIC_DOG_PRICE = 2.00;
        const double CHILI_PRICE = 0.69;
        const double CHEESE_PRICE = 0.49;
        String wantChilli, wantCheese;
        double price;
        Write("Do you want chili on your dog? ");
        wantChilli = ReadLine();
        Write("Do you want cheese on your dog? ");
        wantCheese = ReadLine();
        if (wantChilli == "Y")
            if (wantCheese == "Y")
                price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
            else
                price = BASIC_DOG_PRICE + CHILI_PRICE;
        else
           if (wantCheese == "Y")
            price = BASIC_DOG_PRICE + CHEESE_PRICE;
        else
            price = BASIC_DOG_PRICE;
        WriteLine("Your total is {0}", price.ToString("C"));
    }
}
