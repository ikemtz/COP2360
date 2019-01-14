using System.Linq;
using static System.Console;
class CheckZips
{
    static void Main()
    {
        string[] zips = {"12789", "54012", "54481", "54982", "60007",
         "60103", "60187", "60188", "71244", "90210"};
        // Write your main here
        var zip = ReadLine();
        WriteLine(zips.Contains(zip) ? $"Delivery to {zip} ok" : $"Sorry - no delivery to {zip}");
    }
}