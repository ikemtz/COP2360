using System.Collections.Generic;
using System.Linq;
using static System.Console;

class AutomobileDemo
{
    static void Main()
    {
        var list = new List<Automobile>();
        for (int i = 0; i < 8; i++)
        {
            int x = int.Parse(ReadLine());
            while (list.Select(t => t.IdNumber).Contains(x))
            {
                WriteLine("Please reenter");
                x = int.Parse(ReadLine());
            }
            list.Add(new Automobile
            {
                IdNumber = x,
                Make = ReadLine(),
                Year = int.Parse(ReadLine()),
                Price = double.Parse(ReadLine())
            });
        }

        list.OrderBy(t => t.IdNumber).ToList().ForEach(WriteLine);
        WriteLine($"Total for all Automobiles is {list.Sum(t=> t.Price).ToString("C")}");
    }
}
public class Automobile
{
    public int IdNumber { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public override string ToString()
    {
        return $"Automobile {IdNumber} {Year} {Make} Price is {Price.ToString("C")}";
    }
}