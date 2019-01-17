// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using static System.Console;
class DebugNine2
{
    static void Main()
    {
        Breakfast special = new Breakfast("French toast", 4.99);
        //Display the info about breakfast
        WriteLine(Breakfast.INFO);
        // then display today's special
        WriteLine("Today we are having {0} for {1}",
           special.Name, special.Price.ToString("C2"));
    }
}
public class Breakfast
{
    public static string INFO =
       "Breakfast is the most important meal of the day.";
    // Breakfast constructor requires a
    // name, e.g "French toast", and a price
    public Breakfast(string name, double price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; set; }
    public double Price { get; set; }
}