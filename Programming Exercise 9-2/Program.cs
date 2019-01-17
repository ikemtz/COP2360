using static System.Console;

public class TestClassifiedAd
{
    public static void Main()
    {
        var a = new ClassifiedAd
        {
            Category = "Used Cars",
            Words = 100,
        };
        var b = new ClassifiedAd
        {
            Category = "Help Wanted",
            Words = 60,
        };
        WriteLine(a);
        WriteLine(b); 
    }
}
public class ClassifiedAd
{
    public string Category { get; set; }

    public int Words { get; set; }
    public double Price => Words * .09;

    public override string ToString()
    {
        return $"The classified ad with {Words} words in category {Category} costs { Price.ToString("C")}";
    }
}