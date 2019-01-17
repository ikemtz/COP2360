using System.Linq;
using static System.Console;
class ShirtDemo
{
    static void Main()
    {
        // Write your main here
    }
    public static void Display(params Shirt[] shirts)
    {
        shirts.ToList()
            .ForEach(t => WriteLine($"{t.Material} {t.Color} {t.Size}"));
    }
}

public class Shirt
{
    public string Material { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
}