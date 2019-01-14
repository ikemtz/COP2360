using System.Collections.Generic;
using static System.Console;

class DeliveryCharges
{
    static void Main()
    {
        string[] zips = {"12789", "54012", "54481", "54982", "60007",
         "60103", "60187", "60188", "71244", "90210"};
        double[] prices = {2.40, 3.00, 3.50, 4.00, 4.50, 5.00,
         5.25, 5.75, 6.10, 10.00};
        // Write your main here
        var dic = new Dictionary<string, double>();
        for (int i = 0; i < zips.Length; i++)
        {
            dic.Add(zips[i], prices[i]);
        }

        var zip = ReadLine();
        WriteLine(dic.ContainsKey(zip) ? $"Delivery to {zip} ok. Delivery charge is {dic[zip].ToString("C")}"
            : $"Sorry - no delivery to {zip}");
    }
}