using static System.Console;
class TipCalculation
{
    static void Main()
    {
        // Write your main here
    }

    public static void DisplayTipInfo(double price, double tipRate)
    {
        WriteLine($"Meal price: {price.ToString("C")}. Tip percent: {tipRate}");
        WriteLine($"Tip in dollars: {(price * tipRate).ToString("C")}.  Total bill {(price + price * tipRate).ToString("C")}");
    }
    public static void DisplayTipInfo(double price, int tipInDollars)
    {
        WriteLine($"Meal price: {price.ToString("C")}. Tip percent: {  (tipInDollars / price).ToString("0.##")}");
        WriteLine($"Tip in dollars: {tipInDollars.ToString("C")}.  Total bill { (price + tipInDollars).ToString("C")}");
    }

}