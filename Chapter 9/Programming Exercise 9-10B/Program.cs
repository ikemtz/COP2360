using System.Collections.Generic;
using static System.Console;
class SalesTaxDemo
{
    static void Main()
    {
        var list = new List<Sale>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(new Sale
            {
                InventoryNumber = ReadLine(),
                Amount = double.Parse(ReadLine())
            });
        }
        for (int i = 0; i < 10; i++)
        {
            WriteLine($"Sale # {i + 1} Amount: {list[i].InventoryNumber} Sale {list[i].Amount.ToString("C")}");
            list[i].CalculateTax();
        }
    }
}
public class Sale
{
    public string InventoryNumber { get; set; }

    public double Amount { get; set; }

    public double Tax => Amount <= 100 ? Amount * .08 : (Amount - 100) * 0.06 + 8;


    // Write your Sale class here.
    public void CalculateTax()
    {
        // Write your CalculateTax method here.

        WriteLine($"Tax is {Tax.ToString("C")}");
    }
}
