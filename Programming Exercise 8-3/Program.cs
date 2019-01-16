using static System.Console;
public class Auction
{
    static void Main()
    {
        // Write your main here
    }

    public static void AcceptBid(int bid, int min)
    {
        WriteLine(bid > min ? "Bid accepted" : "Bid not high enough");
    }
    public static void AcceptBid(double bid, int min)
    {
        WriteLine(bid > min ? "Bid accepted" : "Bid not high enough");
    }
    public static void AcceptBid(string bid, int min)
    {
        double d = 0;
        if (double.TryParse(bid.Replace("dollars", "").Replace("$", ""), out d))
            WriteLine(d >= min ? "Bid accepted" : "Bid not high enough");
        else
            WriteLine("Bid was not in correct format.");
    }

}