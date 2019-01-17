class CookieDemo2
{
    static void Main()
    {
        // Your code here
    }
}

public class CookieOrder
{
    public string OrderNum { get; set; }
    public string Name { get; set; }
    public string CookieType { get; set; }
    public int Dozens { get; set; }
}

public class SpecialCookieOrder: CookieOrder
{
    public string SpecialDescription { get; set; }

}